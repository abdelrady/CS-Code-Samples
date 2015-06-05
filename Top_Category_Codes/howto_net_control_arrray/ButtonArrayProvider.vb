Imports System.ComponentModel

<ToolboxBitmap(GetType(ButtonArrayProvider), "control_array.bmp"), _
 ProvideProperty("ArrayIndex", GetType(Button)), _
 DefaultEvent("Click")> _
Public Class ButtonArrayProvider
    Inherits System.ComponentModel.Component
    Implements IExtenderProvider

#Region " Component Designer generated code "

    Public Sub New(ByVal Container As System.ComponentModel.IContainer)
        MyClass.New()

        'Required for Windows.Forms Class Composition Designer support
        Container.Add(Me)
    End Sub

    Public Sub New()
        MyBase.New()

        'This call is required by the Component Designer.
        InitializeComponent()

        'Add any initialization after the InitializeComponent() call

    End Sub

    'Component overrides dispose to clean up the component list.
    Protected Overloads Overrides Sub Dispose(ByVal disposing As Boolean)
        If disposing Then
            If Not (components Is Nothing) Then
                components.Dispose()
            End If
        End If
        MyBase.Dispose(disposing)
    End Sub

    'Required by the Component Designer
    Private components As System.ComponentModel.IContainer

    'NOTE: The following procedure is required by the Component Designer
    'It can be modified using the Component Designer.
    'Do not modify it using the code editor.
    <System.Diagnostics.DebuggerStepThrough()> Private Sub InitializeComponent()

    End Sub

#End Region

    ' When the user clicks one of the buttons
    ' in the control array, we raise this event.
    Public Event Click(ByVal Index As Integer)

    ' Information about a button.
    Private Class IndexInfo
        Public ClientControl As Button
        Public ArrayIndex As Integer

        ' Initialize ArrayIndex to the default value.
        Public Sub New(ByVal client_control As Button)
            ClientControl = client_control
            ArrayIndex = -1
        End Sub

        ' Return True if ArrayIndex is the default.
        Public Function IsDefault() As Boolean
            Return (ArrayIndex = -1)
        End Function
    End Class

    ' Information about our client controls.
    Private m_IndexInfo As New Hashtable

    ' We can only extend buttons.
    Public Function CanExtend(ByVal extendee As Object) As Boolean Implements System.ComponentModel.IExtenderProvider.CanExtend
        Return TypeOf extendee Is Button
    End Function

    ' Return this control's ArrayIndex.
    <Category("Data"), _
     DefaultValue("-1")> _
    Public Function GetArrayIndex(ByVal client_control As Button) As Integer
        ' Get the button's IndexInfo if it exists.
        Return GetIndexInfo(client_control).ArrayIndex
    End Function

    ' Set this control's ArrayIndex.
    <Category("Data"), _
     DefaultValue("-1")> _
    Public Sub SetArrayIndex(ByVal client_control As Button, ByVal array_index As Integer)
        ' Get this control's info.
        Dim index_info As IndexInfo = GetIndexInfo(client_control)

        ' Set the new minimum value.
        index_info.ArrayIndex = array_index

        ' Add or remove the IndexInfo if necessary.
        AddOrRemoveIfNecessary(client_control, index_info)
    End Sub

    ' Remove the control from the array.
    <Category("Data")> _
    Public Sub RemoveArrayIndex(ByVal client_control As Button)
        ' Set the control's index to the default -1.
        SetArrayIndex(client_control, -1)
    End Sub

    ' Handles client button Click events by raising our
    ' Click event, passing it the button's index.
    Private Sub Client_Click(ByVal sender As System.Object, ByVal e As System.EventArgs)
        ' Get the client and its IndexInfo.
        Dim client_button As Button = DirectCast(sender, Button)
        Dim index_info As IndexInfo = GetIndexInfo(client_button)
        RaiseEvent Click(index_info.ArrayIndex)
    End Sub

    ' Return this control's IndexInfo.
    Private Function GetIndexInfo(ByVal client_control As Button) As IndexInfo
        ' See if we have IndexInfo for this control.
        If m_IndexInfo.Contains(client_control) Then
            ' We have IndexInfo for this control. Return it.
            Return DirectCast(m_IndexInfo(client_control), IndexInfo)
        Else
            ' We do not have IndexInfo for this control.
            ' Return a new default IndexInfo.
            Return New IndexInfo(client_control)
        End If
    End Function

    ' Add or remove this IndexInfo if necessary.
    Private Sub AddOrRemoveIfNecessary(ByVal client_control As Button, ByVal index_info As IndexInfo)
        ' See if the IndexInfo should be present but is not,
        ' or should not be present but is.
        If index_info.IsDefault <> Not m_IndexInfo.Contains(client_control) Then
            If index_info.IsDefault Then
                ' The IndexInfo should not be present but is.
                m_IndexInfo.Remove(client_control)
                RemoveHandler client_control.Click, AddressOf Client_Click
            Else
                ' The IndexInfo should be present but is not.
                m_IndexInfo.Add(client_control, index_info)
                AddHandler client_control.Click, AddressOf Client_Click
            End If
        End If
    End Sub

    ' Return an Collection holding
    ' the controls in the array.
    Public Function Controls() As Collection
        ' Build the collection.
        Dim result As New Collection
        For Each index_info As IndexInfo In m_IndexInfo.Values
            result.Add(index_info.ClientControl)
        Next index_info

        ' Return the collection.
        Return result
    End Function
End Class
