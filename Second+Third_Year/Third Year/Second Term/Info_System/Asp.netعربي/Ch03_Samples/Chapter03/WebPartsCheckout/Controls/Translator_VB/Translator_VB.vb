Imports System
Imports System.Collections.Generic
Imports System.ComponentModel
Imports System.Text
Imports System.Web
Imports System.Web.UI.WebControls.WebParts
Imports System.Web.UI
Imports System.Web.UI.WebControls


<DefaultProperty("Text")> _
Public Class Translator_VB
    Inherits WebPart

    Private pStrText As String = Nothing
    Private txtStringToTranslate As TextBox

    Private lblTranslatedString As Label

    Public Sub New()
        Me.AllowClose = True
    End Sub

    <Personalizable(PersonalizationScope.User), WebBrowsable()> _
    Public Property strToTranslate() As String
        Get
            Return pStrText
        End Get
        Set(ByVal value As String)
            pStrText = value
        End Set
    End Property

    Protected Overrides Sub CreateChildControls()
        Controls.Clear()

        '---display a textbox
        txtStringToTranslate = New TextBox()
        txtStringToTranslate.Text = Me.strToTranslate
        Me.Controls.Add(txtStringToTranslate)

        '---display a button
        Dim btnTranslate As New Button()
        btnTranslate.Text = "Translate"
        AddHandler btnTranslate.Click, AddressOf Me.btnTranslate_Click
        Me.Controls.Add(btnTranslate)

        '---display a label
        lblTranslatedString = New Label()
        lblTranslatedString.BackColor = _
          System.Drawing.Color.Yellow
        Me.Controls.Add(lblTranslatedString)
        ChildControlsCreated = True
    End Sub

    Private Sub btnTranslate_Click(ByVal sender As Object, _
                             ByVal e As EventArgs)
        '---display the translated sentence
        If txtStringToTranslate.Text <> String.Empty Then
            Me.strToTranslate = txtStringToTranslate.Text
            txtStringToTranslate.Text = String.Empty

            '---access the web service
            Dim ws As New TranslatorWebService.TranslateService
            lblTranslatedString.Text = "<br/>" & Me.strToTranslate & "-->" & _
            ws.Translate(TranslatorWebService.Language.EnglishTOJapanese, _
            Me.strToTranslate)
        End If
    End Sub

End Class
