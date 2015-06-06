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
Public Class DsTemItemMaster
    Inherits DataSet
    
    Private tableTemItemMaster As TemItemMasterDataTable
    
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
            If (Not (ds.Tables("TemItemMaster")) Is Nothing) Then
                Me.Tables.Add(New TemItemMasterDataTable(ds.Tables("TemItemMaster")))
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
    Public ReadOnly Property TemItemMaster As TemItemMasterDataTable
        Get
            Return Me.tableTemItemMaster
        End Get
    End Property
    
    Public Overrides Function Clone() As DataSet
        Dim cln As DsTemItemMaster = CType(MyBase.Clone,DsTemItemMaster)
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
        If (Not (ds.Tables("TemItemMaster")) Is Nothing) Then
            Me.Tables.Add(New TemItemMasterDataTable(ds.Tables("TemItemMaster")))
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
        Me.tableTemItemMaster = CType(Me.Tables("TemItemMaster"),TemItemMasterDataTable)
        If (Not (Me.tableTemItemMaster) Is Nothing) Then
            Me.tableTemItemMaster.InitVars
        End If
    End Sub
    
    Private Sub InitClass()
        Me.DataSetName = "DsTemItemMaster"
        Me.Prefix = ""
        Me.Namespace = "http://www.tempuri.org/DsTemItemMaster.xsd"
        Me.Locale = New System.Globalization.CultureInfo("ms-MY")
        Me.CaseSensitive = false
        Me.EnforceConstraints = true
        Me.tableTemItemMaster = New TemItemMasterDataTable
        Me.Tables.Add(Me.tableTemItemMaster)
    End Sub
    
    Private Function ShouldSerializeTemItemMaster() As Boolean
        Return false
    End Function
    
    Private Sub SchemaChanged(ByVal sender As Object, ByVal e As System.ComponentModel.CollectionChangeEventArgs)
        If (e.Action = System.ComponentModel.CollectionChangeAction.Remove) Then
            Me.InitVars
        End If
    End Sub
    
    Public Delegate Sub TemItemMasterRowChangeEventHandler(ByVal sender As Object, ByVal e As TemItemMasterRowChangeEvent)
    
    <System.Diagnostics.DebuggerStepThrough()>  _
    Public Class TemItemMasterDataTable
        Inherits DataTable
        Implements System.Collections.IEnumerable
        
        Private columnBarcode As DataColumn
        
        Private columnDescription As DataColumn
        
        Private columnItemCode As DataColumn
        
        Private columnMinSellingPrice As DataColumn
        
        Private columnRetailPrice As DataColumn
        
        Private columnStandardCost As DataColumn
        
        Private columnStockQty As DataColumn
        
        Friend Sub New()
            MyBase.New("TemItemMaster")
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
        
        Friend ReadOnly Property BarcodeColumn As DataColumn
            Get
                Return Me.columnBarcode
            End Get
        End Property
        
        Friend ReadOnly Property DescriptionColumn As DataColumn
            Get
                Return Me.columnDescription
            End Get
        End Property
        
        Friend ReadOnly Property ItemCodeColumn As DataColumn
            Get
                Return Me.columnItemCode
            End Get
        End Property
        
        Friend ReadOnly Property MinSellingPriceColumn As DataColumn
            Get
                Return Me.columnMinSellingPrice
            End Get
        End Property
        
        Friend ReadOnly Property RetailPriceColumn As DataColumn
            Get
                Return Me.columnRetailPrice
            End Get
        End Property
        
        Friend ReadOnly Property StandardCostColumn As DataColumn
            Get
                Return Me.columnStandardCost
            End Get
        End Property
        
        Friend ReadOnly Property StockQtyColumn As DataColumn
            Get
                Return Me.columnStockQty
            End Get
        End Property
        
        Public Default ReadOnly Property Item(ByVal index As Integer) As TemItemMasterRow
            Get
                Return CType(Me.Rows(index),TemItemMasterRow)
            End Get
        End Property
        
        Public Event TemItemMasterRowChanged As TemItemMasterRowChangeEventHandler
        
        Public Event TemItemMasterRowChanging As TemItemMasterRowChangeEventHandler
        
        Public Event TemItemMasterRowDeleted As TemItemMasterRowChangeEventHandler
        
        Public Event TemItemMasterRowDeleting As TemItemMasterRowChangeEventHandler
        
        Public Overloads Sub AddTemItemMasterRow(ByVal row As TemItemMasterRow)
            Me.Rows.Add(row)
        End Sub
        
        Public Overloads Function AddTemItemMasterRow(ByVal Barcode As String, ByVal Description As String, ByVal ItemCode As String, ByVal MinSellingPrice As Decimal, ByVal RetailPrice As Decimal, ByVal StandardCost As Decimal, ByVal StockQty As Integer) As TemItemMasterRow
            Dim rowTemItemMasterRow As TemItemMasterRow = CType(Me.NewRow,TemItemMasterRow)
            rowTemItemMasterRow.ItemArray = New Object() {Barcode, Description, ItemCode, MinSellingPrice, RetailPrice, StandardCost, StockQty}
            Me.Rows.Add(rowTemItemMasterRow)
            Return rowTemItemMasterRow
        End Function
        
        Public Function GetEnumerator() As System.Collections.IEnumerator Implements System.Collections.IEnumerable.GetEnumerator
            Return Me.Rows.GetEnumerator
        End Function
        
        Public Overrides Function Clone() As DataTable
            Dim cln As TemItemMasterDataTable = CType(MyBase.Clone,TemItemMasterDataTable)
            cln.InitVars
            Return cln
        End Function
        
        Protected Overrides Function CreateInstance() As DataTable
            Return New TemItemMasterDataTable
        End Function
        
        Friend Sub InitVars()
            Me.columnBarcode = Me.Columns("Barcode")
            Me.columnDescription = Me.Columns("Description")
            Me.columnItemCode = Me.Columns("ItemCode")
            Me.columnMinSellingPrice = Me.Columns("MinSellingPrice")
            Me.columnRetailPrice = Me.Columns("RetailPrice")
            Me.columnStandardCost = Me.Columns("StandardCost")
            Me.columnStockQty = Me.Columns("StockQty")
        End Sub
        
        Private Sub InitClass()
            Me.columnBarcode = New DataColumn("Barcode", GetType(System.String), Nothing, System.Data.MappingType.Element)
            Me.Columns.Add(Me.columnBarcode)
            Me.columnDescription = New DataColumn("Description", GetType(System.String), Nothing, System.Data.MappingType.Element)
            Me.Columns.Add(Me.columnDescription)
            Me.columnItemCode = New DataColumn("ItemCode", GetType(System.String), Nothing, System.Data.MappingType.Element)
            Me.Columns.Add(Me.columnItemCode)
            Me.columnMinSellingPrice = New DataColumn("MinSellingPrice", GetType(System.Decimal), Nothing, System.Data.MappingType.Element)
            Me.Columns.Add(Me.columnMinSellingPrice)
            Me.columnRetailPrice = New DataColumn("RetailPrice", GetType(System.Decimal), Nothing, System.Data.MappingType.Element)
            Me.Columns.Add(Me.columnRetailPrice)
            Me.columnStandardCost = New DataColumn("StandardCost", GetType(System.Decimal), Nothing, System.Data.MappingType.Element)
            Me.Columns.Add(Me.columnStandardCost)
            Me.columnStockQty = New DataColumn("StockQty", GetType(System.Int32), Nothing, System.Data.MappingType.Element)
            Me.Columns.Add(Me.columnStockQty)
        End Sub
        
        Public Function NewTemItemMasterRow() As TemItemMasterRow
            Return CType(Me.NewRow,TemItemMasterRow)
        End Function
        
        Protected Overrides Function NewRowFromBuilder(ByVal builder As DataRowBuilder) As DataRow
            Return New TemItemMasterRow(builder)
        End Function
        
        Protected Overrides Function GetRowType() As System.Type
            Return GetType(TemItemMasterRow)
        End Function
        
        Protected Overrides Sub OnRowChanged(ByVal e As DataRowChangeEventArgs)
            MyBase.OnRowChanged(e)
            If (Not (Me.TemItemMasterRowChangedEvent) Is Nothing) Then
                RaiseEvent TemItemMasterRowChanged(Me, New TemItemMasterRowChangeEvent(CType(e.Row,TemItemMasterRow), e.Action))
            End If
        End Sub
        
        Protected Overrides Sub OnRowChanging(ByVal e As DataRowChangeEventArgs)
            MyBase.OnRowChanging(e)
            If (Not (Me.TemItemMasterRowChangingEvent) Is Nothing) Then
                RaiseEvent TemItemMasterRowChanging(Me, New TemItemMasterRowChangeEvent(CType(e.Row,TemItemMasterRow), e.Action))
            End If
        End Sub
        
        Protected Overrides Sub OnRowDeleted(ByVal e As DataRowChangeEventArgs)
            MyBase.OnRowDeleted(e)
            If (Not (Me.TemItemMasterRowDeletedEvent) Is Nothing) Then
                RaiseEvent TemItemMasterRowDeleted(Me, New TemItemMasterRowChangeEvent(CType(e.Row,TemItemMasterRow), e.Action))
            End If
        End Sub
        
        Protected Overrides Sub OnRowDeleting(ByVal e As DataRowChangeEventArgs)
            MyBase.OnRowDeleting(e)
            If (Not (Me.TemItemMasterRowDeletingEvent) Is Nothing) Then
                RaiseEvent TemItemMasterRowDeleting(Me, New TemItemMasterRowChangeEvent(CType(e.Row,TemItemMasterRow), e.Action))
            End If
        End Sub
        
        Public Sub RemoveTemItemMasterRow(ByVal row As TemItemMasterRow)
            Me.Rows.Remove(row)
        End Sub
    End Class
    
    <System.Diagnostics.DebuggerStepThrough()>  _
    Public Class TemItemMasterRow
        Inherits DataRow
        
        Private tableTemItemMaster As TemItemMasterDataTable
        
        Friend Sub New(ByVal rb As DataRowBuilder)
            MyBase.New(rb)
            Me.tableTemItemMaster = CType(Me.Table,TemItemMasterDataTable)
        End Sub
        
        Public Property Barcode As String
            Get
                Try 
                    Return CType(Me(Me.tableTemItemMaster.BarcodeColumn),String)
                Catch e As InvalidCastException
                    Throw New StrongTypingException("Cannot get value because it is DBNull.", e)
                End Try
            End Get
            Set
                Me(Me.tableTemItemMaster.BarcodeColumn) = value
            End Set
        End Property
        
        Public Property Description As String
            Get
                Try 
                    Return CType(Me(Me.tableTemItemMaster.DescriptionColumn),String)
                Catch e As InvalidCastException
                    Throw New StrongTypingException("Cannot get value because it is DBNull.", e)
                End Try
            End Get
            Set
                Me(Me.tableTemItemMaster.DescriptionColumn) = value
            End Set
        End Property
        
        Public Property ItemCode As String
            Get
                Try 
                    Return CType(Me(Me.tableTemItemMaster.ItemCodeColumn),String)
                Catch e As InvalidCastException
                    Throw New StrongTypingException("Cannot get value because it is DBNull.", e)
                End Try
            End Get
            Set
                Me(Me.tableTemItemMaster.ItemCodeColumn) = value
            End Set
        End Property
        
        Public Property MinSellingPrice As Decimal
            Get
                Try 
                    Return CType(Me(Me.tableTemItemMaster.MinSellingPriceColumn),Decimal)
                Catch e As InvalidCastException
                    Throw New StrongTypingException("Cannot get value because it is DBNull.", e)
                End Try
            End Get
            Set
                Me(Me.tableTemItemMaster.MinSellingPriceColumn) = value
            End Set
        End Property
        
        Public Property RetailPrice As Decimal
            Get
                Try 
                    Return CType(Me(Me.tableTemItemMaster.RetailPriceColumn),Decimal)
                Catch e As InvalidCastException
                    Throw New StrongTypingException("Cannot get value because it is DBNull.", e)
                End Try
            End Get
            Set
                Me(Me.tableTemItemMaster.RetailPriceColumn) = value
            End Set
        End Property
        
        Public Property StandardCost As Decimal
            Get
                Try 
                    Return CType(Me(Me.tableTemItemMaster.StandardCostColumn),Decimal)
                Catch e As InvalidCastException
                    Throw New StrongTypingException("Cannot get value because it is DBNull.", e)
                End Try
            End Get
            Set
                Me(Me.tableTemItemMaster.StandardCostColumn) = value
            End Set
        End Property
        
        Public Property StockQty As Integer
            Get
                Try 
                    Return CType(Me(Me.tableTemItemMaster.StockQtyColumn),Integer)
                Catch e As InvalidCastException
                    Throw New StrongTypingException("Cannot get value because it is DBNull.", e)
                End Try
            End Get
            Set
                Me(Me.tableTemItemMaster.StockQtyColumn) = value
            End Set
        End Property
        
        Public Function IsBarcodeNull() As Boolean
            Return Me.IsNull(Me.tableTemItemMaster.BarcodeColumn)
        End Function
        
        Public Sub SetBarcodeNull()
            Me(Me.tableTemItemMaster.BarcodeColumn) = System.Convert.DBNull
        End Sub
        
        Public Function IsDescriptionNull() As Boolean
            Return Me.IsNull(Me.tableTemItemMaster.DescriptionColumn)
        End Function
        
        Public Sub SetDescriptionNull()
            Me(Me.tableTemItemMaster.DescriptionColumn) = System.Convert.DBNull
        End Sub
        
        Public Function IsItemCodeNull() As Boolean
            Return Me.IsNull(Me.tableTemItemMaster.ItemCodeColumn)
        End Function
        
        Public Sub SetItemCodeNull()
            Me(Me.tableTemItemMaster.ItemCodeColumn) = System.Convert.DBNull
        End Sub
        
        Public Function IsMinSellingPriceNull() As Boolean
            Return Me.IsNull(Me.tableTemItemMaster.MinSellingPriceColumn)
        End Function
        
        Public Sub SetMinSellingPriceNull()
            Me(Me.tableTemItemMaster.MinSellingPriceColumn) = System.Convert.DBNull
        End Sub
        
        Public Function IsRetailPriceNull() As Boolean
            Return Me.IsNull(Me.tableTemItemMaster.RetailPriceColumn)
        End Function
        
        Public Sub SetRetailPriceNull()
            Me(Me.tableTemItemMaster.RetailPriceColumn) = System.Convert.DBNull
        End Sub
        
        Public Function IsStandardCostNull() As Boolean
            Return Me.IsNull(Me.tableTemItemMaster.StandardCostColumn)
        End Function
        
        Public Sub SetStandardCostNull()
            Me(Me.tableTemItemMaster.StandardCostColumn) = System.Convert.DBNull
        End Sub
        
        Public Function IsStockQtyNull() As Boolean
            Return Me.IsNull(Me.tableTemItemMaster.StockQtyColumn)
        End Function
        
        Public Sub SetStockQtyNull()
            Me(Me.tableTemItemMaster.StockQtyColumn) = System.Convert.DBNull
        End Sub
    End Class
    
    <System.Diagnostics.DebuggerStepThrough()>  _
    Public Class TemItemMasterRowChangeEvent
        Inherits EventArgs
        
        Private eventRow As TemItemMasterRow
        
        Private eventAction As DataRowAction
        
        Public Sub New(ByVal row As TemItemMasterRow, ByVal action As DataRowAction)
            MyBase.New
            Me.eventRow = row
            Me.eventAction = action
        End Sub
        
        Public ReadOnly Property Row As TemItemMasterRow
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
