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
Public Class Dspos
    Inherits DataSet
    
    Private tableItem_Master As Item_MasterDataTable
    
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
            If (Not (ds.Tables("Item Master")) Is Nothing) Then
                Me.Tables.Add(New Item_MasterDataTable(ds.Tables("Item Master")))
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
    Public ReadOnly Property Item_Master As Item_MasterDataTable
        Get
            Return Me.tableItem_Master
        End Get
    End Property
    
    Public Overrides Function Clone() As DataSet
        Dim cln As Dspos = CType(MyBase.Clone,Dspos)
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
        If (Not (ds.Tables("Item Master")) Is Nothing) Then
            Me.Tables.Add(New Item_MasterDataTable(ds.Tables("Item Master")))
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
        Me.tableItem_Master = CType(Me.Tables("Item Master"),Item_MasterDataTable)
        If (Not (Me.tableItem_Master) Is Nothing) Then
            Me.tableItem_Master.InitVars
        End If
    End Sub
    
    Private Sub InitClass()
        Me.DataSetName = "Dspos"
        Me.Prefix = ""
        Me.Namespace = "http://www.tempuri.org/Dspos.xsd"
        Me.Locale = New System.Globalization.CultureInfo("en-US")
        Me.CaseSensitive = false
        Me.EnforceConstraints = true
        Me.tableItem_Master = New Item_MasterDataTable
        Me.Tables.Add(Me.tableItem_Master)
    End Sub
    
    Private Function ShouldSerializeItem_Master() As Boolean
        Return false
    End Function
    
    Private Sub SchemaChanged(ByVal sender As Object, ByVal e As System.ComponentModel.CollectionChangeEventArgs)
        If (e.Action = System.ComponentModel.CollectionChangeAction.Remove) Then
            Me.InitVars
        End If
    End Sub
    
    Public Delegate Sub Item_MasterRowChangeEventHandler(ByVal sender As Object, ByVal e As Item_MasterRowChangeEvent)
    
    <System.Diagnostics.DebuggerStepThrough()>  _
    Public Class Item_MasterDataTable
        Inherits DataTable
        Implements System.Collections.IEnumerable
        
        Private columnBarcode As DataColumn
        
        Private columnDescription As DataColumn
        
        Private columnItemCode As DataColumn
        
        Private columnMinSellingPrice As DataColumn
        
        Private columnRetailPrice As DataColumn
        
        Private columnStandardCost As DataColumn
        
        Private columnStockQty As DataColumn
        
        Private columnStockReorderLevel As DataColumn
        
        Friend Sub New()
            MyBase.New("Item Master")
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
        
        Friend ReadOnly Property StockReorderLevelColumn As DataColumn
            Get
                Return Me.columnStockReorderLevel
            End Get
        End Property
        
        Public Default ReadOnly Property Item(ByVal index As Integer) As Item_MasterRow
            Get
                Return CType(Me.Rows(index),Item_MasterRow)
            End Get
        End Property
        
        Public Event Item_MasterRowChanged As Item_MasterRowChangeEventHandler
        
        Public Event Item_MasterRowChanging As Item_MasterRowChangeEventHandler
        
        Public Event Item_MasterRowDeleted As Item_MasterRowChangeEventHandler
        
        Public Event Item_MasterRowDeleting As Item_MasterRowChangeEventHandler
        
        Public Overloads Sub AddItem_MasterRow(ByVal row As Item_MasterRow)
            Me.Rows.Add(row)
        End Sub
        
        Public Overloads Function AddItem_MasterRow(ByVal Barcode As String, ByVal Description As String, ByVal ItemCode As String, ByVal MinSellingPrice As Decimal, ByVal RetailPrice As Decimal, ByVal StandardCost As Decimal, ByVal StockQty As Integer, ByVal StockReorderLevel As Integer) As Item_MasterRow
            Dim rowItem_MasterRow As Item_MasterRow = CType(Me.NewRow,Item_MasterRow)
            rowItem_MasterRow.ItemArray = New Object() {Barcode, Description, ItemCode, MinSellingPrice, RetailPrice, StandardCost, StockQty, StockReorderLevel}
            Me.Rows.Add(rowItem_MasterRow)
            Return rowItem_MasterRow
        End Function
        
        Public Function FindByItemCode(ByVal ItemCode As String) As Item_MasterRow
            Return CType(Me.Rows.Find(New Object() {ItemCode}),Item_MasterRow)
        End Function
        
        Public Function GetEnumerator() As System.Collections.IEnumerator Implements System.Collections.IEnumerable.GetEnumerator
            Return Me.Rows.GetEnumerator
        End Function
        
        Public Overrides Function Clone() As DataTable
            Dim cln As Item_MasterDataTable = CType(MyBase.Clone,Item_MasterDataTable)
            cln.InitVars
            Return cln
        End Function
        
        Protected Overrides Function CreateInstance() As DataTable
            Return New Item_MasterDataTable
        End Function
        
        Friend Sub InitVars()
            Me.columnBarcode = Me.Columns("Barcode")
            Me.columnDescription = Me.Columns("Description")
            Me.columnItemCode = Me.Columns("ItemCode")
            Me.columnMinSellingPrice = Me.Columns("MinSellingPrice")
            Me.columnRetailPrice = Me.Columns("RetailPrice")
            Me.columnStandardCost = Me.Columns("StandardCost")
            Me.columnStockQty = Me.Columns("StockQty")
            Me.columnStockReorderLevel = Me.Columns("StockReorderLevel")
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
            Me.columnStockReorderLevel = New DataColumn("StockReorderLevel", GetType(System.Int32), Nothing, System.Data.MappingType.Element)
            Me.Columns.Add(Me.columnStockReorderLevel)
            Me.Constraints.Add(New UniqueConstraint("Constraint1", New DataColumn() {Me.columnItemCode}, true))
            Me.columnItemCode.AllowDBNull = false
            Me.columnItemCode.Unique = true
        End Sub
        
        Public Function NewItem_MasterRow() As Item_MasterRow
            Return CType(Me.NewRow,Item_MasterRow)
        End Function
        
        Protected Overrides Function NewRowFromBuilder(ByVal builder As DataRowBuilder) As DataRow
            Return New Item_MasterRow(builder)
        End Function
        
        Protected Overrides Function GetRowType() As System.Type
            Return GetType(Item_MasterRow)
        End Function
        
        Protected Overrides Sub OnRowChanged(ByVal e As DataRowChangeEventArgs)
            MyBase.OnRowChanged(e)
            If (Not (Me.Item_MasterRowChangedEvent) Is Nothing) Then
                RaiseEvent Item_MasterRowChanged(Me, New Item_MasterRowChangeEvent(CType(e.Row,Item_MasterRow), e.Action))
            End If
        End Sub
        
        Protected Overrides Sub OnRowChanging(ByVal e As DataRowChangeEventArgs)
            MyBase.OnRowChanging(e)
            If (Not (Me.Item_MasterRowChangingEvent) Is Nothing) Then
                RaiseEvent Item_MasterRowChanging(Me, New Item_MasterRowChangeEvent(CType(e.Row,Item_MasterRow), e.Action))
            End If
        End Sub
        
        Protected Overrides Sub OnRowDeleted(ByVal e As DataRowChangeEventArgs)
            MyBase.OnRowDeleted(e)
            If (Not (Me.Item_MasterRowDeletedEvent) Is Nothing) Then
                RaiseEvent Item_MasterRowDeleted(Me, New Item_MasterRowChangeEvent(CType(e.Row,Item_MasterRow), e.Action))
            End If
        End Sub
        
        Protected Overrides Sub OnRowDeleting(ByVal e As DataRowChangeEventArgs)
            MyBase.OnRowDeleting(e)
            If (Not (Me.Item_MasterRowDeletingEvent) Is Nothing) Then
                RaiseEvent Item_MasterRowDeleting(Me, New Item_MasterRowChangeEvent(CType(e.Row,Item_MasterRow), e.Action))
            End If
        End Sub
        
        Public Sub RemoveItem_MasterRow(ByVal row As Item_MasterRow)
            Me.Rows.Remove(row)
        End Sub
    End Class
    
    <System.Diagnostics.DebuggerStepThrough()>  _
    Public Class Item_MasterRow
        Inherits DataRow
        
        Private tableItem_Master As Item_MasterDataTable
        
        Friend Sub New(ByVal rb As DataRowBuilder)
            MyBase.New(rb)
            Me.tableItem_Master = CType(Me.Table,Item_MasterDataTable)
        End Sub
        
        Public Property Barcode As String
            Get
                Try 
                    Return CType(Me(Me.tableItem_Master.BarcodeColumn),String)
                Catch e As InvalidCastException
                    Throw New StrongTypingException("Cannot get value because it is DBNull.", e)
                End Try
            End Get
            Set
                Me(Me.tableItem_Master.BarcodeColumn) = value
            End Set
        End Property
        
        Public Property Description As String
            Get
                Try 
                    Return CType(Me(Me.tableItem_Master.DescriptionColumn),String)
                Catch e As InvalidCastException
                    Throw New StrongTypingException("Cannot get value because it is DBNull.", e)
                End Try
            End Get
            Set
                Me(Me.tableItem_Master.DescriptionColumn) = value
            End Set
        End Property
        
        Public Property ItemCode As String
            Get
                Return CType(Me(Me.tableItem_Master.ItemCodeColumn),String)
            End Get
            Set
                Me(Me.tableItem_Master.ItemCodeColumn) = value
            End Set
        End Property
        
        Public Property MinSellingPrice As Decimal
            Get
                Try 
                    Return CType(Me(Me.tableItem_Master.MinSellingPriceColumn),Decimal)
                Catch e As InvalidCastException
                    Throw New StrongTypingException("Cannot get value because it is DBNull.", e)
                End Try
            End Get
            Set
                Me(Me.tableItem_Master.MinSellingPriceColumn) = value
            End Set
        End Property
        
        Public Property RetailPrice As Decimal
            Get
                Try 
                    Return CType(Me(Me.tableItem_Master.RetailPriceColumn),Decimal)
                Catch e As InvalidCastException
                    Throw New StrongTypingException("Cannot get value because it is DBNull.", e)
                End Try
            End Get
            Set
                Me(Me.tableItem_Master.RetailPriceColumn) = value
            End Set
        End Property
        
        Public Property StandardCost As Decimal
            Get
                Try 
                    Return CType(Me(Me.tableItem_Master.StandardCostColumn),Decimal)
                Catch e As InvalidCastException
                    Throw New StrongTypingException("Cannot get value because it is DBNull.", e)
                End Try
            End Get
            Set
                Me(Me.tableItem_Master.StandardCostColumn) = value
            End Set
        End Property
        
        Public Property StockQty As Integer
            Get
                Try 
                    Return CType(Me(Me.tableItem_Master.StockQtyColumn),Integer)
                Catch e As InvalidCastException
                    Throw New StrongTypingException("Cannot get value because it is DBNull.", e)
                End Try
            End Get
            Set
                Me(Me.tableItem_Master.StockQtyColumn) = value
            End Set
        End Property
        
        Public Property StockReorderLevel As Integer
            Get
                Try 
                    Return CType(Me(Me.tableItem_Master.StockReorderLevelColumn),Integer)
                Catch e As InvalidCastException
                    Throw New StrongTypingException("Cannot get value because it is DBNull.", e)
                End Try
            End Get
            Set
                Me(Me.tableItem_Master.StockReorderLevelColumn) = value
            End Set
        End Property
        
        Public Function IsBarcodeNull() As Boolean
            Return Me.IsNull(Me.tableItem_Master.BarcodeColumn)
        End Function
        
        Public Sub SetBarcodeNull()
            Me(Me.tableItem_Master.BarcodeColumn) = System.Convert.DBNull
        End Sub
        
        Public Function IsDescriptionNull() As Boolean
            Return Me.IsNull(Me.tableItem_Master.DescriptionColumn)
        End Function
        
        Public Sub SetDescriptionNull()
            Me(Me.tableItem_Master.DescriptionColumn) = System.Convert.DBNull
        End Sub
        
        Public Function IsMinSellingPriceNull() As Boolean
            Return Me.IsNull(Me.tableItem_Master.MinSellingPriceColumn)
        End Function
        
        Public Sub SetMinSellingPriceNull()
            Me(Me.tableItem_Master.MinSellingPriceColumn) = System.Convert.DBNull
        End Sub
        
        Public Function IsRetailPriceNull() As Boolean
            Return Me.IsNull(Me.tableItem_Master.RetailPriceColumn)
        End Function
        
        Public Sub SetRetailPriceNull()
            Me(Me.tableItem_Master.RetailPriceColumn) = System.Convert.DBNull
        End Sub
        
        Public Function IsStandardCostNull() As Boolean
            Return Me.IsNull(Me.tableItem_Master.StandardCostColumn)
        End Function
        
        Public Sub SetStandardCostNull()
            Me(Me.tableItem_Master.StandardCostColumn) = System.Convert.DBNull
        End Sub
        
        Public Function IsStockQtyNull() As Boolean
            Return Me.IsNull(Me.tableItem_Master.StockQtyColumn)
        End Function
        
        Public Sub SetStockQtyNull()
            Me(Me.tableItem_Master.StockQtyColumn) = System.Convert.DBNull
        End Sub
        
        Public Function IsStockReorderLevelNull() As Boolean
            Return Me.IsNull(Me.tableItem_Master.StockReorderLevelColumn)
        End Function
        
        Public Sub SetStockReorderLevelNull()
            Me(Me.tableItem_Master.StockReorderLevelColumn) = System.Convert.DBNull
        End Sub
    End Class
    
    <System.Diagnostics.DebuggerStepThrough()>  _
    Public Class Item_MasterRowChangeEvent
        Inherits EventArgs
        
        Private eventRow As Item_MasterRow
        
        Private eventAction As DataRowAction
        
        Public Sub New(ByVal row As Item_MasterRow, ByVal action As DataRowAction)
            MyBase.New
            Me.eventRow = row
            Me.eventAction = action
        End Sub
        
        Public ReadOnly Property Row As Item_MasterRow
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
