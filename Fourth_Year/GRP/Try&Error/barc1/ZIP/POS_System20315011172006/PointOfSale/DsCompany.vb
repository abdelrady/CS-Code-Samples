﻿'------------------------------------------------------------------------------
' <autogenerated>
'     This code was generated by a tool.
'     Runtime Version: 1.0.3705.0
'
'     Changes to this file may cause incorrect behavior and will be lost if 
'     the code is regenerated.
' </autogenerated>
'------------------------------------------------------------------------------

Option Strict Off
Option Explicit On

Imports System
Imports System.Data
Imports System.Runtime.Serialization
Imports System.Xml


<Serializable(),  _
 System.ComponentModel.DesignerCategoryAttribute("code"),  _
 System.Diagnostics.DebuggerStepThrough(),  _
 System.ComponentModel.ToolboxItem(true)>  _
Public Class DsCompany
    Inherits DataSet
    
    Private tableCompany_Profile As Company_ProfileDataTable
    
    Private tableCompanyProfile As CompanyProfileDataTable
    
    Public Sub New()
        MyBase.New
        Me.InitClass
        Dim schemaChangedHandler As System.ComponentModel.CollectionChangeEventHandler = AddressOf Me.SchemaChanged
        AddHandler Me.Tables.CollectionChanged, schemaChangedHandler
        AddHandler Me.Relations.CollectionChanged, schemaChangedHandler
    End Sub
    
    Protected Sub New(ByVal info As SerializationInfo, ByVal context As StreamingContext)
        MyBase.New
        Dim strSchema As String = CType(info.GetValue("XmlSchema", GetType(System.String)),String)
        If (Not (strSchema) Is Nothing) Then
            Dim ds As DataSet = New DataSet
            ds.ReadXmlSchema(New XmlTextReader(New System.IO.StringReader(strSchema)))
            If (Not (ds.Tables("Company Profile")) Is Nothing) Then
                Me.Tables.Add(New Company_ProfileDataTable(ds.Tables("Company Profile")))
            End If
            If (Not (ds.Tables("CompanyProfile")) Is Nothing) Then
                Me.Tables.Add(New CompanyProfileDataTable(ds.Tables("CompanyProfile")))
            End If
            Me.DataSetName = ds.DataSetName
            Me.Prefix = ds.Prefix
            Me.Namespace = ds.Namespace
            Me.Locale = ds.Locale
            Me.CaseSensitive = ds.CaseSensitive
            Me.EnforceConstraints = ds.EnforceConstraints
            Me.Merge(ds, false, System.Data.MissingSchemaAction.Add)
            Me.InitVars
        Else
            Me.InitClass
        End If
        Me.GetSerializationData(info, context)
        Dim schemaChangedHandler As System.ComponentModel.CollectionChangeEventHandler = AddressOf Me.SchemaChanged
        AddHandler Me.Tables.CollectionChanged, schemaChangedHandler
        AddHandler Me.Relations.CollectionChanged, schemaChangedHandler
    End Sub
    
    <System.ComponentModel.Browsable(false),  _
     System.ComponentModel.DesignerSerializationVisibilityAttribute(System.ComponentModel.DesignerSerializationVisibility.Content)>  _
    Public ReadOnly Property Company_Profile As Company_ProfileDataTable
        Get
            Return Me.tableCompany_Profile
        End Get
    End Property
    
    <System.ComponentModel.Browsable(false),  _
     System.ComponentModel.DesignerSerializationVisibilityAttribute(System.ComponentModel.DesignerSerializationVisibility.Content)>  _
    Public ReadOnly Property CompanyProfile As CompanyProfileDataTable
        Get
            Return Me.tableCompanyProfile
        End Get
    End Property
    
    Public Overrides Function Clone() As DataSet
        Dim cln As DsCompany = CType(MyBase.Clone,DsCompany)
        cln.InitVars
        Return cln
    End Function
    
    Protected Overrides Function ShouldSerializeTables() As Boolean
        Return false
    End Function
    
    Protected Overrides Function ShouldSerializeRelations() As Boolean
        Return false
    End Function
    
    Protected Overrides Sub ReadXmlSerializable(ByVal reader As XmlReader)
        Me.Reset
        Dim ds As DataSet = New DataSet
        ds.ReadXml(reader)
        If (Not (ds.Tables("Company Profile")) Is Nothing) Then
            Me.Tables.Add(New Company_ProfileDataTable(ds.Tables("Company Profile")))
        End If
        If (Not (ds.Tables("CompanyProfile")) Is Nothing) Then
            Me.Tables.Add(New CompanyProfileDataTable(ds.Tables("CompanyProfile")))
        End If
        Me.DataSetName = ds.DataSetName
        Me.Prefix = ds.Prefix
        Me.Namespace = ds.Namespace
        Me.Locale = ds.Locale
        Me.CaseSensitive = ds.CaseSensitive
        Me.EnforceConstraints = ds.EnforceConstraints
        Me.Merge(ds, false, System.Data.MissingSchemaAction.Add)
        Me.InitVars
    End Sub
    
    Protected Overrides Function GetSchemaSerializable() As System.Xml.Schema.XmlSchema
        Dim stream As System.IO.MemoryStream = New System.IO.MemoryStream
        Me.WriteXmlSchema(New XmlTextWriter(stream, Nothing))
        stream.Position = 0
        Return System.Xml.Schema.XmlSchema.Read(New XmlTextReader(stream), Nothing)
    End Function
    
    Friend Sub InitVars()
        Me.tableCompany_Profile = CType(Me.Tables("Company Profile"),Company_ProfileDataTable)
        If (Not (Me.tableCompany_Profile) Is Nothing) Then
            Me.tableCompany_Profile.InitVars
        End If
        Me.tableCompanyProfile = CType(Me.Tables("CompanyProfile"),CompanyProfileDataTable)
        If (Not (Me.tableCompanyProfile) Is Nothing) Then
            Me.tableCompanyProfile.InitVars
        End If
    End Sub
    
    Private Sub InitClass()
        Me.DataSetName = "DsCompany"
        Me.Prefix = ""
        Me.Namespace = "http://www.tempuri.org/DsCompany.xsd"
        Me.Locale = New System.Globalization.CultureInfo("en-US")
        Me.CaseSensitive = false
        Me.EnforceConstraints = true
        Me.tableCompany_Profile = New Company_ProfileDataTable
        Me.Tables.Add(Me.tableCompany_Profile)
        Me.tableCompanyProfile = New CompanyProfileDataTable
        Me.Tables.Add(Me.tableCompanyProfile)
    End Sub
    
    Private Function ShouldSerializeCompany_Profile() As Boolean
        Return false
    End Function
    
    Private Function ShouldSerializeCompanyProfile() As Boolean
        Return false
    End Function
    
    Private Sub SchemaChanged(ByVal sender As Object, ByVal e As System.ComponentModel.CollectionChangeEventArgs)
        If (e.Action = System.ComponentModel.CollectionChangeAction.Remove) Then
            Me.InitVars
        End If
    End Sub
    
    Public Delegate Sub Company_ProfileRowChangeEventHandler(ByVal sender As Object, ByVal e As Company_ProfileRowChangeEvent)
    
    Public Delegate Sub CompanyProfileRowChangeEventHandler(ByVal sender As Object, ByVal e As CompanyProfileRowChangeEvent)
    
    <System.Diagnostics.DebuggerStepThrough()>  _
    Public Class Company_ProfileDataTable
        Inherits DataTable
        Implements System.Collections.IEnumerable
        
        Private columnAddress1 As DataColumn
        
        Private columnAddress2 As DataColumn
        
        Private columnCompany_Name As DataColumn
        
        Private columnEmail As DataColumn
        
        Private columnFax_No As DataColumn
        
        Private columnPhoneNo1 As DataColumn
        
        Private columnPhoneNo2 As DataColumn
        
        Private columnPostcode As DataColumn
        
        Friend Sub New()
            MyBase.New("Company Profile")
            Me.InitClass
        End Sub
        
        Friend Sub New(ByVal table As DataTable)
            MyBase.New(table.TableName)
            If (table.CaseSensitive <> table.DataSet.CaseSensitive) Then
                Me.CaseSensitive = table.CaseSensitive
            End If
            If (table.Locale.ToString <> table.DataSet.Locale.ToString) Then
                Me.Locale = table.Locale
            End If
            If (table.Namespace <> table.DataSet.Namespace) Then
                Me.Namespace = table.Namespace
            End If
            Me.Prefix = table.Prefix
            Me.MinimumCapacity = table.MinimumCapacity
            Me.DisplayExpression = table.DisplayExpression
        End Sub
        
        <System.ComponentModel.Browsable(false)>  _
        Public ReadOnly Property Count As Integer
            Get
                Return Me.Rows.Count
            End Get
        End Property
        
        Friend ReadOnly Property Address1Column As DataColumn
            Get
                Return Me.columnAddress1
            End Get
        End Property
        
        Friend ReadOnly Property Address2Column As DataColumn
            Get
                Return Me.columnAddress2
            End Get
        End Property
        
        Friend ReadOnly Property Company_NameColumn As DataColumn
            Get
                Return Me.columnCompany_Name
            End Get
        End Property
        
        Friend ReadOnly Property EmailColumn As DataColumn
            Get
                Return Me.columnEmail
            End Get
        End Property
        
        Friend ReadOnly Property Fax_NoColumn As DataColumn
            Get
                Return Me.columnFax_No
            End Get
        End Property
        
        Friend ReadOnly Property PhoneNo1Column As DataColumn
            Get
                Return Me.columnPhoneNo1
            End Get
        End Property
        
        Friend ReadOnly Property PhoneNo2Column As DataColumn
            Get
                Return Me.columnPhoneNo2
            End Get
        End Property
        
        Friend ReadOnly Property PostcodeColumn As DataColumn
            Get
                Return Me.columnPostcode
            End Get
        End Property
        
        Public Default ReadOnly Property Item(ByVal index As Integer) As Company_ProfileRow
            Get
                Return CType(Me.Rows(index),Company_ProfileRow)
            End Get
        End Property
        
        Public Event Company_ProfileRowChanged As Company_ProfileRowChangeEventHandler
        
        Public Event Company_ProfileRowChanging As Company_ProfileRowChangeEventHandler
        
        Public Event Company_ProfileRowDeleted As Company_ProfileRowChangeEventHandler
        
        Public Event Company_ProfileRowDeleting As Company_ProfileRowChangeEventHandler
        
        Public Overloads Sub AddCompany_ProfileRow(ByVal row As Company_ProfileRow)
            Me.Rows.Add(row)
        End Sub
        
        Public Overloads Function AddCompany_ProfileRow(ByVal Address1 As String, ByVal Address2 As String, ByVal Company_Name As String, ByVal Email As String, ByVal Fax_No As String, ByVal PhoneNo1 As String, ByVal PhoneNo2 As String, ByVal Postcode As String) As Company_ProfileRow
            Dim rowCompany_ProfileRow As Company_ProfileRow = CType(Me.NewRow,Company_ProfileRow)
            rowCompany_ProfileRow.ItemArray = New Object() {Address1, Address2, Company_Name, Email, Fax_No, PhoneNo1, PhoneNo2, Postcode}
            Me.Rows.Add(rowCompany_ProfileRow)
            Return rowCompany_ProfileRow
        End Function
        
        Public Function FindByCompany_Name(ByVal Company_Name As String) As Company_ProfileRow
            Return CType(Me.Rows.Find(New Object() {Company_Name}),Company_ProfileRow)
        End Function
        
        Public Function GetEnumerator() As System.Collections.IEnumerator Implements System.Collections.IEnumerable.GetEnumerator
            Return Me.Rows.GetEnumerator
        End Function
        
        Public Overrides Function Clone() As DataTable
            Dim cln As Company_ProfileDataTable = CType(MyBase.Clone,Company_ProfileDataTable)
            cln.InitVars
            Return cln
        End Function
        
        Protected Overrides Function CreateInstance() As DataTable
            Return New Company_ProfileDataTable
        End Function
        
        Friend Sub InitVars()
            Me.columnAddress1 = Me.Columns("Address1")
            Me.columnAddress2 = Me.Columns("Address2")
            Me.columnCompany_Name = Me.Columns("Company Name")
            Me.columnEmail = Me.Columns("Email")
            Me.columnFax_No = Me.Columns("Fax No")
            Me.columnPhoneNo1 = Me.Columns("PhoneNo1")
            Me.columnPhoneNo2 = Me.Columns("PhoneNo2")
            Me.columnPostcode = Me.Columns("Postcode")
        End Sub
        
        Private Sub InitClass()
            Me.columnAddress1 = New DataColumn("Address1", GetType(System.String), Nothing, System.Data.MappingType.Element)
            Me.Columns.Add(Me.columnAddress1)
            Me.columnAddress2 = New DataColumn("Address2", GetType(System.String), Nothing, System.Data.MappingType.Element)
            Me.Columns.Add(Me.columnAddress2)
            Me.columnCompany_Name = New DataColumn("Company Name", GetType(System.String), Nothing, System.Data.MappingType.Element)
            Me.Columns.Add(Me.columnCompany_Name)
            Me.columnEmail = New DataColumn("Email", GetType(System.String), Nothing, System.Data.MappingType.Element)
            Me.Columns.Add(Me.columnEmail)
            Me.columnFax_No = New DataColumn("Fax No", GetType(System.String), Nothing, System.Data.MappingType.Element)
            Me.Columns.Add(Me.columnFax_No)
            Me.columnPhoneNo1 = New DataColumn("PhoneNo1", GetType(System.String), Nothing, System.Data.MappingType.Element)
            Me.Columns.Add(Me.columnPhoneNo1)
            Me.columnPhoneNo2 = New DataColumn("PhoneNo2", GetType(System.String), Nothing, System.Data.MappingType.Element)
            Me.Columns.Add(Me.columnPhoneNo2)
            Me.columnPostcode = New DataColumn("Postcode", GetType(System.String), Nothing, System.Data.MappingType.Element)
            Me.Columns.Add(Me.columnPostcode)
            Me.Constraints.Add(New UniqueConstraint("Constraint1", New DataColumn() {Me.columnCompany_Name}, true))
            Me.columnCompany_Name.AllowDBNull = false
            Me.columnCompany_Name.Unique = true
        End Sub
        
        Public Function NewCompany_ProfileRow() As Company_ProfileRow
            Return CType(Me.NewRow,Company_ProfileRow)
        End Function
        
        Protected Overrides Function NewRowFromBuilder(ByVal builder As DataRowBuilder) As DataRow
            Return New Company_ProfileRow(builder)
        End Function
        
        Protected Overrides Function GetRowType() As System.Type
            Return GetType(Company_ProfileRow)
        End Function
        
        Protected Overrides Sub OnRowChanged(ByVal e As DataRowChangeEventArgs)
            MyBase.OnRowChanged(e)
            If (Not (Me.Company_ProfileRowChangedEvent) Is Nothing) Then
                RaiseEvent Company_ProfileRowChanged(Me, New Company_ProfileRowChangeEvent(CType(e.Row,Company_ProfileRow), e.Action))
            End If
        End Sub
        
        Protected Overrides Sub OnRowChanging(ByVal e As DataRowChangeEventArgs)
            MyBase.OnRowChanging(e)
            If (Not (Me.Company_ProfileRowChangingEvent) Is Nothing) Then
                RaiseEvent Company_ProfileRowChanging(Me, New Company_ProfileRowChangeEvent(CType(e.Row,Company_ProfileRow), e.Action))
            End If
        End Sub
        
        Protected Overrides Sub OnRowDeleted(ByVal e As DataRowChangeEventArgs)
            MyBase.OnRowDeleted(e)
            If (Not (Me.Company_ProfileRowDeletedEvent) Is Nothing) Then
                RaiseEvent Company_ProfileRowDeleted(Me, New Company_ProfileRowChangeEvent(CType(e.Row,Company_ProfileRow), e.Action))
            End If
        End Sub
        
        Protected Overrides Sub OnRowDeleting(ByVal e As DataRowChangeEventArgs)
            MyBase.OnRowDeleting(e)
            If (Not (Me.Company_ProfileRowDeletingEvent) Is Nothing) Then
                RaiseEvent Company_ProfileRowDeleting(Me, New Company_ProfileRowChangeEvent(CType(e.Row,Company_ProfileRow), e.Action))
            End If
        End Sub
        
        Public Sub RemoveCompany_ProfileRow(ByVal row As Company_ProfileRow)
            Me.Rows.Remove(row)
        End Sub
    End Class
    
    <System.Diagnostics.DebuggerStepThrough()>  _
    Public Class Company_ProfileRow
        Inherits DataRow
        
        Private tableCompany_Profile As Company_ProfileDataTable
        
        Friend Sub New(ByVal rb As DataRowBuilder)
            MyBase.New(rb)
            Me.tableCompany_Profile = CType(Me.Table,Company_ProfileDataTable)
        End Sub
        
        Public Property Address1 As String
            Get
                Try 
                    Return CType(Me(Me.tableCompany_Profile.Address1Column),String)
                Catch e As InvalidCastException
                    Throw New StrongTypingException("Cannot get value because it is DBNull.", e)
                End Try
            End Get
            Set
                Me(Me.tableCompany_Profile.Address1Column) = value
            End Set
        End Property
        
        Public Property Address2 As String
            Get
                Try 
                    Return CType(Me(Me.tableCompany_Profile.Address2Column),String)
                Catch e As InvalidCastException
                    Throw New StrongTypingException("Cannot get value because it is DBNull.", e)
                End Try
            End Get
            Set
                Me(Me.tableCompany_Profile.Address2Column) = value
            End Set
        End Property
        
        Public Property Company_Name As String
            Get
                Return CType(Me(Me.tableCompany_Profile.Company_NameColumn),String)
            End Get
            Set
                Me(Me.tableCompany_Profile.Company_NameColumn) = value
            End Set
        End Property
        
        Public Property Email As String
            Get
                Try 
                    Return CType(Me(Me.tableCompany_Profile.EmailColumn),String)
                Catch e As InvalidCastException
                    Throw New StrongTypingException("Cannot get value because it is DBNull.", e)
                End Try
            End Get
            Set
                Me(Me.tableCompany_Profile.EmailColumn) = value
            End Set
        End Property
        
        Public Property Fax_No As String
            Get
                Try 
                    Return CType(Me(Me.tableCompany_Profile.Fax_NoColumn),String)
                Catch e As InvalidCastException
                    Throw New StrongTypingException("Cannot get value because it is DBNull.", e)
                End Try
            End Get
            Set
                Me(Me.tableCompany_Profile.Fax_NoColumn) = value
            End Set
        End Property
        
        Public Property PhoneNo1 As String
            Get
                Try 
                    Return CType(Me(Me.tableCompany_Profile.PhoneNo1Column),String)
                Catch e As InvalidCastException
                    Throw New StrongTypingException("Cannot get value because it is DBNull.", e)
                End Try
            End Get
            Set
                Me(Me.tableCompany_Profile.PhoneNo1Column) = value
            End Set
        End Property
        
        Public Property PhoneNo2 As String
            Get
                Try 
                    Return CType(Me(Me.tableCompany_Profile.PhoneNo2Column),String)
                Catch e As InvalidCastException
                    Throw New StrongTypingException("Cannot get value because it is DBNull.", e)
                End Try
            End Get
            Set
                Me(Me.tableCompany_Profile.PhoneNo2Column) = value
            End Set
        End Property
        
        Public Property Postcode As String
            Get
                Try 
                    Return CType(Me(Me.tableCompany_Profile.PostcodeColumn),String)
                Catch e As InvalidCastException
                    Throw New StrongTypingException("Cannot get value because it is DBNull.", e)
                End Try
            End Get
            Set
                Me(Me.tableCompany_Profile.PostcodeColumn) = value
            End Set
        End Property
        
        Public Function IsAddress1Null() As Boolean
            Return Me.IsNull(Me.tableCompany_Profile.Address1Column)
        End Function
        
        Public Sub SetAddress1Null()
            Me(Me.tableCompany_Profile.Address1Column) = System.Convert.DBNull
        End Sub
        
        Public Function IsAddress2Null() As Boolean
            Return Me.IsNull(Me.tableCompany_Profile.Address2Column)
        End Function
        
        Public Sub SetAddress2Null()
            Me(Me.tableCompany_Profile.Address2Column) = System.Convert.DBNull
        End Sub
        
        Public Function IsEmailNull() As Boolean
            Return Me.IsNull(Me.tableCompany_Profile.EmailColumn)
        End Function
        
        Public Sub SetEmailNull()
            Me(Me.tableCompany_Profile.EmailColumn) = System.Convert.DBNull
        End Sub
        
        Public Function IsFax_NoNull() As Boolean
            Return Me.IsNull(Me.tableCompany_Profile.Fax_NoColumn)
        End Function
        
        Public Sub SetFax_NoNull()
            Me(Me.tableCompany_Profile.Fax_NoColumn) = System.Convert.DBNull
        End Sub
        
        Public Function IsPhoneNo1Null() As Boolean
            Return Me.IsNull(Me.tableCompany_Profile.PhoneNo1Column)
        End Function
        
        Public Sub SetPhoneNo1Null()
            Me(Me.tableCompany_Profile.PhoneNo1Column) = System.Convert.DBNull
        End Sub
        
        Public Function IsPhoneNo2Null() As Boolean
            Return Me.IsNull(Me.tableCompany_Profile.PhoneNo2Column)
        End Function
        
        Public Sub SetPhoneNo2Null()
            Me(Me.tableCompany_Profile.PhoneNo2Column) = System.Convert.DBNull
        End Sub
        
        Public Function IsPostcodeNull() As Boolean
            Return Me.IsNull(Me.tableCompany_Profile.PostcodeColumn)
        End Function
        
        Public Sub SetPostcodeNull()
            Me(Me.tableCompany_Profile.PostcodeColumn) = System.Convert.DBNull
        End Sub
    End Class
    
    <System.Diagnostics.DebuggerStepThrough()>  _
    Public Class Company_ProfileRowChangeEvent
        Inherits EventArgs
        
        Private eventRow As Company_ProfileRow
        
        Private eventAction As DataRowAction
        
        Public Sub New(ByVal row As Company_ProfileRow, ByVal action As DataRowAction)
            MyBase.New
            Me.eventRow = row
            Me.eventAction = action
        End Sub
        
        Public ReadOnly Property Row As Company_ProfileRow
            Get
                Return Me.eventRow
            End Get
        End Property
        
        Public ReadOnly Property Action As DataRowAction
            Get
                Return Me.eventAction
            End Get
        End Property
    End Class
    
    <System.Diagnostics.DebuggerStepThrough()>  _
    Public Class CompanyProfileDataTable
        Inherits DataTable
        Implements System.Collections.IEnumerable
        
        Private columnAddress1 As DataColumn
        
        Private columnAddress2 As DataColumn
        
        Private columnCompanyName As DataColumn
        
        Private columnEmail As DataColumn
        
        Private columnFaxNo As DataColumn
        
        Private columnPhoneNo1 As DataColumn
        
        Private columnPhoneNo2 As DataColumn
        
        Private columnPostcode As DataColumn
        
        Friend Sub New()
            MyBase.New("CompanyProfile")
            Me.InitClass
        End Sub
        
        Friend Sub New(ByVal table As DataTable)
            MyBase.New(table.TableName)
            If (table.CaseSensitive <> table.DataSet.CaseSensitive) Then
                Me.CaseSensitive = table.CaseSensitive
            End If
            If (table.Locale.ToString <> table.DataSet.Locale.ToString) Then
                Me.Locale = table.Locale
            End If
            If (table.Namespace <> table.DataSet.Namespace) Then
                Me.Namespace = table.Namespace
            End If
            Me.Prefix = table.Prefix
            Me.MinimumCapacity = table.MinimumCapacity
            Me.DisplayExpression = table.DisplayExpression
        End Sub
        
        <System.ComponentModel.Browsable(false)>  _
        Public ReadOnly Property Count As Integer
            Get
                Return Me.Rows.Count
            End Get
        End Property
        
        Friend ReadOnly Property Address1Column As DataColumn
            Get
                Return Me.columnAddress1
            End Get
        End Property
        
        Friend ReadOnly Property Address2Column As DataColumn
            Get
                Return Me.columnAddress2
            End Get
        End Property
        
        Friend ReadOnly Property CompanyNameColumn As DataColumn
            Get
                Return Me.columnCompanyName
            End Get
        End Property
        
        Friend ReadOnly Property EmailColumn As DataColumn
            Get
                Return Me.columnEmail
            End Get
        End Property
        
        Friend ReadOnly Property FaxNoColumn As DataColumn
            Get
                Return Me.columnFaxNo
            End Get
        End Property
        
        Friend ReadOnly Property PhoneNo1Column As DataColumn
            Get
                Return Me.columnPhoneNo1
            End Get
        End Property
        
        Friend ReadOnly Property PhoneNo2Column As DataColumn
            Get
                Return Me.columnPhoneNo2
            End Get
        End Property
        
        Friend ReadOnly Property PostcodeColumn As DataColumn
            Get
                Return Me.columnPostcode
            End Get
        End Property
        
        Public Default ReadOnly Property Item(ByVal index As Integer) As CompanyProfileRow
            Get
                Return CType(Me.Rows(index),CompanyProfileRow)
            End Get
        End Property
        
        Public Event CompanyProfileRowChanged As CompanyProfileRowChangeEventHandler
        
        Public Event CompanyProfileRowChanging As CompanyProfileRowChangeEventHandler
        
        Public Event CompanyProfileRowDeleted As CompanyProfileRowChangeEventHandler
        
        Public Event CompanyProfileRowDeleting As CompanyProfileRowChangeEventHandler
        
        Public Overloads Sub AddCompanyProfileRow(ByVal row As CompanyProfileRow)
            Me.Rows.Add(row)
        End Sub
        
        Public Overloads Function AddCompanyProfileRow(ByVal Address1 As String, ByVal Address2 As String, ByVal CompanyName As String, ByVal Email As String, ByVal FaxNo As String, ByVal PhoneNo1 As String, ByVal PhoneNo2 As String, ByVal Postcode As String) As CompanyProfileRow
            Dim rowCompanyProfileRow As CompanyProfileRow = CType(Me.NewRow,CompanyProfileRow)
            rowCompanyProfileRow.ItemArray = New Object() {Address1, Address2, CompanyName, Email, FaxNo, PhoneNo1, PhoneNo2, Postcode}
            Me.Rows.Add(rowCompanyProfileRow)
            Return rowCompanyProfileRow
        End Function
        
        Public Function FindByCompanyName(ByVal CompanyName As String) As CompanyProfileRow
            Return CType(Me.Rows.Find(New Object() {CompanyName}),CompanyProfileRow)
        End Function
        
        Public Function GetEnumerator() As System.Collections.IEnumerator Implements System.Collections.IEnumerable.GetEnumerator
            Return Me.Rows.GetEnumerator
        End Function
        
        Public Overrides Function Clone() As DataTable
            Dim cln As CompanyProfileDataTable = CType(MyBase.Clone,CompanyProfileDataTable)
            cln.InitVars
            Return cln
        End Function
        
        Protected Overrides Function CreateInstance() As DataTable
            Return New CompanyProfileDataTable
        End Function
        
        Friend Sub InitVars()
            Me.columnAddress1 = Me.Columns("Address1")
            Me.columnAddress2 = Me.Columns("Address2")
            Me.columnCompanyName = Me.Columns("CompanyName")
            Me.columnEmail = Me.Columns("Email")
            Me.columnFaxNo = Me.Columns("FaxNo")
            Me.columnPhoneNo1 = Me.Columns("PhoneNo1")
            Me.columnPhoneNo2 = Me.Columns("PhoneNo2")
            Me.columnPostcode = Me.Columns("Postcode")
        End Sub
        
        Private Sub InitClass()
            Me.columnAddress1 = New DataColumn("Address1", GetType(System.String), Nothing, System.Data.MappingType.Element)
            Me.Columns.Add(Me.columnAddress1)
            Me.columnAddress2 = New DataColumn("Address2", GetType(System.String), Nothing, System.Data.MappingType.Element)
            Me.Columns.Add(Me.columnAddress2)
            Me.columnCompanyName = New DataColumn("CompanyName", GetType(System.String), Nothing, System.Data.MappingType.Element)
            Me.Columns.Add(Me.columnCompanyName)
            Me.columnEmail = New DataColumn("Email", GetType(System.String), Nothing, System.Data.MappingType.Element)
            Me.Columns.Add(Me.columnEmail)
            Me.columnFaxNo = New DataColumn("FaxNo", GetType(System.String), Nothing, System.Data.MappingType.Element)
            Me.Columns.Add(Me.columnFaxNo)
            Me.columnPhoneNo1 = New DataColumn("PhoneNo1", GetType(System.String), Nothing, System.Data.MappingType.Element)
            Me.Columns.Add(Me.columnPhoneNo1)
            Me.columnPhoneNo2 = New DataColumn("PhoneNo2", GetType(System.String), Nothing, System.Data.MappingType.Element)
            Me.Columns.Add(Me.columnPhoneNo2)
            Me.columnPostcode = New DataColumn("Postcode", GetType(System.String), Nothing, System.Data.MappingType.Element)
            Me.Columns.Add(Me.columnPostcode)
            Me.Constraints.Add(New UniqueConstraint("Constraint1", New DataColumn() {Me.columnCompanyName}, true))
            Me.columnCompanyName.AllowDBNull = false
            Me.columnCompanyName.Unique = true
        End Sub
        
        Public Function NewCompanyProfileRow() As CompanyProfileRow
            Return CType(Me.NewRow,CompanyProfileRow)
        End Function
        
        Protected Overrides Function NewRowFromBuilder(ByVal builder As DataRowBuilder) As DataRow
            Return New CompanyProfileRow(builder)
        End Function
        
        Protected Overrides Function GetRowType() As System.Type
            Return GetType(CompanyProfileRow)
        End Function
        
        Protected Overrides Sub OnRowChanged(ByVal e As DataRowChangeEventArgs)
            MyBase.OnRowChanged(e)
            If (Not (Me.CompanyProfileRowChangedEvent) Is Nothing) Then
                RaiseEvent CompanyProfileRowChanged(Me, New CompanyProfileRowChangeEvent(CType(e.Row,CompanyProfileRow), e.Action))
            End If
        End Sub
        
        Protected Overrides Sub OnRowChanging(ByVal e As DataRowChangeEventArgs)
            MyBase.OnRowChanging(e)
            If (Not (Me.CompanyProfileRowChangingEvent) Is Nothing) Then
                RaiseEvent CompanyProfileRowChanging(Me, New CompanyProfileRowChangeEvent(CType(e.Row,CompanyProfileRow), e.Action))
            End If
        End Sub
        
        Protected Overrides Sub OnRowDeleted(ByVal e As DataRowChangeEventArgs)
            MyBase.OnRowDeleted(e)
            If (Not (Me.CompanyProfileRowDeletedEvent) Is Nothing) Then
                RaiseEvent CompanyProfileRowDeleted(Me, New CompanyProfileRowChangeEvent(CType(e.Row,CompanyProfileRow), e.Action))
            End If
        End Sub
        
        Protected Overrides Sub OnRowDeleting(ByVal e As DataRowChangeEventArgs)
            MyBase.OnRowDeleting(e)
            If (Not (Me.CompanyProfileRowDeletingEvent) Is Nothing) Then
                RaiseEvent CompanyProfileRowDeleting(Me, New CompanyProfileRowChangeEvent(CType(e.Row,CompanyProfileRow), e.Action))
            End If
        End Sub
        
        Public Sub RemoveCompanyProfileRow(ByVal row As CompanyProfileRow)
            Me.Rows.Remove(row)
        End Sub
    End Class
    
    <System.Diagnostics.DebuggerStepThrough()>  _
    Public Class CompanyProfileRow
        Inherits DataRow
        
        Private tableCompanyProfile As CompanyProfileDataTable
        
        Friend Sub New(ByVal rb As DataRowBuilder)
            MyBase.New(rb)
            Me.tableCompanyProfile = CType(Me.Table,CompanyProfileDataTable)
        End Sub
        
        Public Property Address1 As String
            Get
                Try 
                    Return CType(Me(Me.tableCompanyProfile.Address1Column),String)
                Catch e As InvalidCastException
                    Throw New StrongTypingException("Cannot get value because it is DBNull.", e)
                End Try
            End Get
            Set
                Me(Me.tableCompanyProfile.Address1Column) = value
            End Set
        End Property
        
        Public Property Address2 As String
            Get
                Try 
                    Return CType(Me(Me.tableCompanyProfile.Address2Column),String)
                Catch e As InvalidCastException
                    Throw New StrongTypingException("Cannot get value because it is DBNull.", e)
                End Try
            End Get
            Set
                Me(Me.tableCompanyProfile.Address2Column) = value
            End Set
        End Property
        
        Public Property CompanyName As String
            Get
                Return CType(Me(Me.tableCompanyProfile.CompanyNameColumn),String)
            End Get
            Set
                Me(Me.tableCompanyProfile.CompanyNameColumn) = value
            End Set
        End Property
        
        Public Property Email As String
            Get
                Try 
                    Return CType(Me(Me.tableCompanyProfile.EmailColumn),String)
                Catch e As InvalidCastException
                    Throw New StrongTypingException("Cannot get value because it is DBNull.", e)
                End Try
            End Get
            Set
                Me(Me.tableCompanyProfile.EmailColumn) = value
            End Set
        End Property
        
        Public Property FaxNo As String
            Get
                Try 
                    Return CType(Me(Me.tableCompanyProfile.FaxNoColumn),String)
                Catch e As InvalidCastException
                    Throw New StrongTypingException("Cannot get value because it is DBNull.", e)
                End Try
            End Get
            Set
                Me(Me.tableCompanyProfile.FaxNoColumn) = value
            End Set
        End Property
        
        Public Property PhoneNo1 As String
            Get
                Try 
                    Return CType(Me(Me.tableCompanyProfile.PhoneNo1Column),String)
                Catch e As InvalidCastException
                    Throw New StrongTypingException("Cannot get value because it is DBNull.", e)
                End Try
            End Get
            Set
                Me(Me.tableCompanyProfile.PhoneNo1Column) = value
            End Set
        End Property
        
        Public Property PhoneNo2 As String
            Get
                Try 
                    Return CType(Me(Me.tableCompanyProfile.PhoneNo2Column),String)
                Catch e As InvalidCastException
                    Throw New StrongTypingException("Cannot get value because it is DBNull.", e)
                End Try
            End Get
            Set
                Me(Me.tableCompanyProfile.PhoneNo2Column) = value
            End Set
        End Property
        
        Public Property Postcode As String
            Get
                Try 
                    Return CType(Me(Me.tableCompanyProfile.PostcodeColumn),String)
                Catch e As InvalidCastException
                    Throw New StrongTypingException("Cannot get value because it is DBNull.", e)
                End Try
            End Get
            Set
                Me(Me.tableCompanyProfile.PostcodeColumn) = value
            End Set
        End Property
        
        Public Function IsAddress1Null() As Boolean
            Return Me.IsNull(Me.tableCompanyProfile.Address1Column)
        End Function
        
        Public Sub SetAddress1Null()
            Me(Me.tableCompanyProfile.Address1Column) = System.Convert.DBNull
        End Sub
        
        Public Function IsAddress2Null() As Boolean
            Return Me.IsNull(Me.tableCompanyProfile.Address2Column)
        End Function
        
        Public Sub SetAddress2Null()
            Me(Me.tableCompanyProfile.Address2Column) = System.Convert.DBNull
        End Sub
        
        Public Function IsEmailNull() As Boolean
            Return Me.IsNull(Me.tableCompanyProfile.EmailColumn)
        End Function
        
        Public Sub SetEmailNull()
            Me(Me.tableCompanyProfile.EmailColumn) = System.Convert.DBNull
        End Sub
        
        Public Function IsFaxNoNull() As Boolean
            Return Me.IsNull(Me.tableCompanyProfile.FaxNoColumn)
        End Function
        
        Public Sub SetFaxNoNull()
            Me(Me.tableCompanyProfile.FaxNoColumn) = System.Convert.DBNull
        End Sub
        
        Public Function IsPhoneNo1Null() As Boolean
            Return Me.IsNull(Me.tableCompanyProfile.PhoneNo1Column)
        End Function
        
        Public Sub SetPhoneNo1Null()
            Me(Me.tableCompanyProfile.PhoneNo1Column) = System.Convert.DBNull
        End Sub
        
        Public Function IsPhoneNo2Null() As Boolean
            Return Me.IsNull(Me.tableCompanyProfile.PhoneNo2Column)
        End Function
        
        Public Sub SetPhoneNo2Null()
            Me(Me.tableCompanyProfile.PhoneNo2Column) = System.Convert.DBNull
        End Sub
        
        Public Function IsPostcodeNull() As Boolean
            Return Me.IsNull(Me.tableCompanyProfile.PostcodeColumn)
        End Function
        
        Public Sub SetPostcodeNull()
            Me(Me.tableCompanyProfile.PostcodeColumn) = System.Convert.DBNull
        End Sub
    End Class
    
    <System.Diagnostics.DebuggerStepThrough()>  _
    Public Class CompanyProfileRowChangeEvent
        Inherits EventArgs
        
        Private eventRow As CompanyProfileRow
        
        Private eventAction As DataRowAction
        
        Public Sub New(ByVal row As CompanyProfileRow, ByVal action As DataRowAction)
            MyBase.New
            Me.eventRow = row
            Me.eventAction = action
        End Sub
        
        Public ReadOnly Property Row As CompanyProfileRow
            Get
                Return Me.eventRow
            End Get
        End Property
        
        Public ReadOnly Property Action As DataRowAction
            Get
                Return Me.eventAction
            End Get
        End Property
    End Class
End Class
