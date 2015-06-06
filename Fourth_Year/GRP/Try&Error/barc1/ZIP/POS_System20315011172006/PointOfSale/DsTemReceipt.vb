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
Public Class DsTemReceipt
    Inherits DataSet
    
    Private tableTemReceipt As TemReceiptDataTable
    
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
            If (Not (ds.Tables("TemReceipt")) Is Nothing) Then
                Me.Tables.Add(New TemReceiptDataTable(ds.Tables("TemReceipt")))
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
    Public ReadOnly Property TemReceipt As TemReceiptDataTable
        Get
            Return Me.tableTemReceipt
        End Get
    End Property
    
    Public Overrides Function Clone() As DataSet
        Dim cln As DsTemReceipt = CType(MyBase.Clone,DsTemReceipt)
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
        If (Not (ds.Tables("TemReceipt")) Is Nothing) Then
            Me.Tables.Add(New TemReceiptDataTable(ds.Tables("TemReceipt")))
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
        Me.tableTemReceipt = CType(Me.Tables("TemReceipt"),TemReceiptDataTable)
        If (Not (Me.tableTemReceipt) Is Nothing) Then
            Me.tableTemReceipt.InitVars
        End If
    End Sub
    
    Private Sub InitClass()
        Me.DataSetName = "DsTemReceipt"
        Me.Prefix = ""
        Me.Namespace = "http://www.tempuri.org/DsTemReceipt.xsd"
        Me.Locale = New System.Globalization.CultureInfo("ms-MY")
        Me.CaseSensitive = false
        Me.EnforceConstraints = true
        Me.tableTemReceipt = New TemReceiptDataTable
        Me.Tables.Add(Me.tableTemReceipt)
    End Sub
    
    Private Function ShouldSerializeTemReceipt() As Boolean
        Return false
    End Function
    
    Private Sub SchemaChanged(ByVal sender As Object, ByVal e As System.ComponentModel.CollectionChangeEventArgs)
        If (e.Action = System.ComponentModel.CollectionChangeAction.Remove) Then
            Me.InitVars
        End If
    End Sub
    
    Public Delegate Sub TemReceiptRowChangeEventHandler(ByVal sender As Object, ByVal e As TemReceiptRowChangeEvent)
    
    <System.Diagnostics.DebuggerStepThrough()>  _
    Public Class TemReceiptDataTable
        Inherits DataTable
        Implements System.Collections.IEnumerable
        
        Private columnBillNo As DataColumn
        
        Private columnDescription As DataColumn
        
        Private columnDiscount As DataColumn
        
        Private columnGrandTotal As DataColumn
        
        Private columnQty As DataColumn
        
        Private columnSaleDate As DataColumn
        
        Private columnSaleTime As DataColumn
        
        Private columnSubTotal As DataColumn
        
        Private columnTax As DataColumn
        
        Private columnTotal As DataColumn
        
        Friend Sub New()
            MyBase.New("TemReceipt")
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
        
        Friend ReadOnly Property BillNoColumn As DataColumn
            Get
                Return Me.columnBillNo
            End Get
        End Property
        
        Friend ReadOnly Property DescriptionColumn As DataColumn
            Get
                Return Me.columnDescription
            End Get
        End Property
        
        Friend ReadOnly Property DiscountColumn As DataColumn
            Get
                Return Me.columnDiscount
            End Get
        End Property
        
        Friend ReadOnly Property GrandTotalColumn As DataColumn
            Get
                Return Me.columnGrandTotal
            End Get
        End Property
        
        Friend ReadOnly Property QtyColumn As DataColumn
            Get
                Return Me.columnQty
            End Get
        End Property
        
        Friend ReadOnly Property SaleDateColumn As DataColumn
            Get
                Return Me.columnSaleDate
            End Get
        End Property
        
        Friend ReadOnly Property SaleTimeColumn As DataColumn
            Get
                Return Me.columnSaleTime
            End Get
        End Property
        
        Friend ReadOnly Property SubTotalColumn As DataColumn
            Get
                Return Me.columnSubTotal
            End Get
        End Property
        
        Friend ReadOnly Property TaxColumn As DataColumn
            Get
                Return Me.columnTax
            End Get
        End Property
        
        Friend ReadOnly Property TotalColumn As DataColumn
            Get
                Return Me.columnTotal
            End Get
        End Property
        
        Public Default ReadOnly Property Item(ByVal index As Integer) As TemReceiptRow
            Get
                Return CType(Me.Rows(index),TemReceiptRow)
            End Get
        End Property
        
        Public Event TemReceiptRowChanged As TemReceiptRowChangeEventHandler
        
        Public Event TemReceiptRowChanging As TemReceiptRowChangeEventHandler
        
        Public Event TemReceiptRowDeleted As TemReceiptRowChangeEventHandler
        
        Public Event TemReceiptRowDeleting As TemReceiptRowChangeEventHandler
        
        Public Overloads Sub AddTemReceiptRow(ByVal row As TemReceiptRow)
            Me.Rows.Add(row)
        End Sub
        
        Public Overloads Function AddTemReceiptRow(ByVal BillNo As String, ByVal Description As String, ByVal Discount As Decimal, ByVal GrandTotal As Decimal, ByVal Qty As String, ByVal SaleDate As Date, ByVal SaleTime As Date, ByVal SubTotal As Decimal, ByVal Tax As Decimal, ByVal Total As String) As TemReceiptRow
            Dim rowTemReceiptRow As TemReceiptRow = CType(Me.NewRow,TemReceiptRow)
            rowTemReceiptRow.ItemArray = New Object() {BillNo, Description, Discount, GrandTotal, Qty, SaleDate, SaleTime, SubTotal, Tax, Total}
            Me.Rows.Add(rowTemReceiptRow)
            Return rowTemReceiptRow
        End Function
        
        Public Function GetEnumerator() As System.Collections.IEnumerator Implements System.Collections.IEnumerable.GetEnumerator
            Return Me.Rows.GetEnumerator
        End Function
        
        Public Overrides Function Clone() As DataTable
            Dim cln As TemReceiptDataTable = CType(MyBase.Clone,TemReceiptDataTable)
            cln.InitVars
            Return cln
        End Function
        
        Protected Overrides Function CreateInstance() As DataTable
            Return New TemReceiptDataTable
        End Function
        
        Friend Sub InitVars()
            Me.columnBillNo = Me.Columns("BillNo")
            Me.columnDescription = Me.Columns("Description")
            Me.columnDiscount = Me.Columns("Discount")
            Me.columnGrandTotal = Me.Columns("GrandTotal")
            Me.columnQty = Me.Columns("Qty")
            Me.columnSaleDate = Me.Columns("SaleDate")
            Me.columnSaleTime = Me.Columns("SaleTime")
            Me.columnSubTotal = Me.Columns("SubTotal")
            Me.columnTax = Me.Columns("Tax")
            Me.columnTotal = Me.Columns("Total")
        End Sub
        
        Private Sub InitClass()
            Me.columnBillNo = New DataColumn("BillNo", GetType(System.String), Nothing, System.Data.MappingType.Element)
            Me.Columns.Add(Me.columnBillNo)
            Me.columnDescription = New DataColumn("Description", GetType(System.String), Nothing, System.Data.MappingType.Element)
            Me.Columns.Add(Me.columnDescription)
            Me.columnDiscount = New DataColumn("Discount", GetType(System.Decimal), Nothing, System.Data.MappingType.Element)
            Me.Columns.Add(Me.columnDiscount)
            Me.columnGrandTotal = New DataColumn("GrandTotal", GetType(System.Decimal), Nothing, System.Data.MappingType.Element)
            Me.Columns.Add(Me.columnGrandTotal)
            Me.columnQty = New DataColumn("Qty", GetType(System.String), Nothing, System.Data.MappingType.Element)
            Me.Columns.Add(Me.columnQty)
            Me.columnSaleDate = New DataColumn("SaleDate", GetType(System.DateTime), Nothing, System.Data.MappingType.Element)
            Me.Columns.Add(Me.columnSaleDate)
            Me.columnSaleTime = New DataColumn("SaleTime", GetType(System.DateTime), Nothing, System.Data.MappingType.Element)
            Me.Columns.Add(Me.columnSaleTime)
            Me.columnSubTotal = New DataColumn("SubTotal", GetType(System.Decimal), Nothing, System.Data.MappingType.Element)
            Me.Columns.Add(Me.columnSubTotal)
            Me.columnTax = New DataColumn("Tax", GetType(System.Decimal), Nothing, System.Data.MappingType.Element)
            Me.Columns.Add(Me.columnTax)
            Me.columnTotal = New DataColumn("Total", GetType(System.String), Nothing, System.Data.MappingType.Element)
            Me.Columns.Add(Me.columnTotal)
        End Sub
        
        Public Function NewTemReceiptRow() As TemReceiptRow
            Return CType(Me.NewRow,TemReceiptRow)
        End Function
        
        Protected Overrides Function NewRowFromBuilder(ByVal builder As DataRowBuilder) As DataRow
            Return New TemReceiptRow(builder)
        End Function
        
        Protected Overrides Function GetRowType() As System.Type
            Return GetType(TemReceiptRow)
        End Function
        
        Protected Overrides Sub OnRowChanged(ByVal e As DataRowChangeEventArgs)
            MyBase.OnRowChanged(e)
            If (Not (Me.TemReceiptRowChangedEvent) Is Nothing) Then
                RaiseEvent TemReceiptRowChanged(Me, New TemReceiptRowChangeEvent(CType(e.Row,TemReceiptRow), e.Action))
            End If
        End Sub
        
        Protected Overrides Sub OnRowChanging(ByVal e As DataRowChangeEventArgs)
            MyBase.OnRowChanging(e)
            If (Not (Me.TemReceiptRowChangingEvent) Is Nothing) Then
                RaiseEvent TemReceiptRowChanging(Me, New TemReceiptRowChangeEvent(CType(e.Row,TemReceiptRow), e.Action))
            End If
        End Sub
        
        Protected Overrides Sub OnRowDeleted(ByVal e As DataRowChangeEventArgs)
            MyBase.OnRowDeleted(e)
            If (Not (Me.TemReceiptRowDeletedEvent) Is Nothing) Then
                RaiseEvent TemReceiptRowDeleted(Me, New TemReceiptRowChangeEvent(CType(e.Row,TemReceiptRow), e.Action))
            End If
        End Sub
        
        Protected Overrides Sub OnRowDeleting(ByVal e As DataRowChangeEventArgs)
            MyBase.OnRowDeleting(e)
            If (Not (Me.TemReceiptRowDeletingEvent) Is Nothing) Then
                RaiseEvent TemReceiptRowDeleting(Me, New TemReceiptRowChangeEvent(CType(e.Row,TemReceiptRow), e.Action))
            End If
        End Sub
        
        Public Sub RemoveTemReceiptRow(ByVal row As TemReceiptRow)
            Me.Rows.Remove(row)
        End Sub
    End Class
    
    <System.Diagnostics.DebuggerStepThrough()>  _
    Public Class TemReceiptRow
        Inherits DataRow
        
        Private tableTemReceipt As TemReceiptDataTable
        
        Friend Sub New(ByVal rb As DataRowBuilder)
            MyBase.New(rb)
            Me.tableTemReceipt = CType(Me.Table,TemReceiptDataTable)
        End Sub
        
        Public Property BillNo As String
            Get
                Try 
                    Return CType(Me(Me.tableTemReceipt.BillNoColumn),String)
                Catch e As InvalidCastException
                    Throw New StrongTypingException("Cannot get value because it is DBNull.", e)
                End Try
            End Get
            Set
                Me(Me.tableTemReceipt.BillNoColumn) = value
            End Set
        End Property
        
        Public Property Description As String
            Get
                Try 
                    Return CType(Me(Me.tableTemReceipt.DescriptionColumn),String)
                Catch e As InvalidCastException
                    Throw New StrongTypingException("Cannot get value because it is DBNull.", e)
                End Try
            End Get
            Set
                Me(Me.tableTemReceipt.DescriptionColumn) = value
            End Set
        End Property
        
        Public Property Discount As Decimal
            Get
                Try 
                    Return CType(Me(Me.tableTemReceipt.DiscountColumn),Decimal)
                Catch e As InvalidCastException
                    Throw New StrongTypingException("Cannot get value because it is DBNull.", e)
                End Try
            End Get
            Set
                Me(Me.tableTemReceipt.DiscountColumn) = value
            End Set
        End Property
        
        Public Property GrandTotal As Decimal
            Get
                Try 
                    Return CType(Me(Me.tableTemReceipt.GrandTotalColumn),Decimal)
                Catch e As InvalidCastException
                    Throw New StrongTypingException("Cannot get value because it is DBNull.", e)
                End Try
            End Get
            Set
                Me(Me.tableTemReceipt.GrandTotalColumn) = value
            End Set
        End Property
        
        Public Property Qty As String
            Get
                Try 
                    Return CType(Me(Me.tableTemReceipt.QtyColumn),String)
                Catch e As InvalidCastException
                    Throw New StrongTypingException("Cannot get value because it is DBNull.", e)
                End Try
            End Get
            Set
                Me(Me.tableTemReceipt.QtyColumn) = value
            End Set
        End Property
        
        Public Property SaleDate As Date
            Get
                Try 
                    Return CType(Me(Me.tableTemReceipt.SaleDateColumn),Date)
                Catch e As InvalidCastException
                    Throw New StrongTypingException("Cannot get value because it is DBNull.", e)
                End Try
            End Get
            Set
                Me(Me.tableTemReceipt.SaleDateColumn) = value
            End Set
        End Property
        
        Public Property SaleTime As Date
            Get
                Try 
                    Return CType(Me(Me.tableTemReceipt.SaleTimeColumn),Date)
                Catch e As InvalidCastException
                    Throw New StrongTypingException("Cannot get value because it is DBNull.", e)
                End Try
            End Get
            Set
                Me(Me.tableTemReceipt.SaleTimeColumn) = value
            End Set
        End Property
        
        Public Property SubTotal As Decimal
            Get
                Try 
                    Return CType(Me(Me.tableTemReceipt.SubTotalColumn),Decimal)
                Catch e As InvalidCastException
                    Throw New StrongTypingException("Cannot get value because it is DBNull.", e)
                End Try
            End Get
            Set
                Me(Me.tableTemReceipt.SubTotalColumn) = value
            End Set
        End Property
        
        Public Property Tax As Decimal
            Get
                Try 
                    Return CType(Me(Me.tableTemReceipt.TaxColumn),Decimal)
                Catch e As InvalidCastException
                    Throw New StrongTypingException("Cannot get value because it is DBNull.", e)
                End Try
            End Get
            Set
                Me(Me.tableTemReceipt.TaxColumn) = value
            End Set
        End Property
        
        Public Property Total As String
            Get
                Try 
                    Return CType(Me(Me.tableTemReceipt.TotalColumn),String)
                Catch e As InvalidCastException
                    Throw New StrongTypingException("Cannot get value because it is DBNull.", e)
                End Try
            End Get
            Set
                Me(Me.tableTemReceipt.TotalColumn) = value
            End Set
        End Property
        
        Public Function IsBillNoNull() As Boolean
            Return Me.IsNull(Me.tableTemReceipt.BillNoColumn)
        End Function
        
        Public Sub SetBillNoNull()
            Me(Me.tableTemReceipt.BillNoColumn) = System.Convert.DBNull
        End Sub
        
        Public Function IsDescriptionNull() As Boolean
            Return Me.IsNull(Me.tableTemReceipt.DescriptionColumn)
        End Function
        
        Public Sub SetDescriptionNull()
            Me(Me.tableTemReceipt.DescriptionColumn) = System.Convert.DBNull
        End Sub
        
        Public Function IsDiscountNull() As Boolean
            Return Me.IsNull(Me.tableTemReceipt.DiscountColumn)
        End Function
        
        Public Sub SetDiscountNull()
            Me(Me.tableTemReceipt.DiscountColumn) = System.Convert.DBNull
        End Sub
        
        Public Function IsGrandTotalNull() As Boolean
            Return Me.IsNull(Me.tableTemReceipt.GrandTotalColumn)
        End Function
        
        Public Sub SetGrandTotalNull()
            Me(Me.tableTemReceipt.GrandTotalColumn) = System.Convert.DBNull
        End Sub
        
        Public Function IsQtyNull() As Boolean
            Return Me.IsNull(Me.tableTemReceipt.QtyColumn)
        End Function
        
        Public Sub SetQtyNull()
            Me(Me.tableTemReceipt.QtyColumn) = System.Convert.DBNull
        End Sub
        
        Public Function IsSaleDateNull() As Boolean
            Return Me.IsNull(Me.tableTemReceipt.SaleDateColumn)
        End Function
        
        Public Sub SetSaleDateNull()
            Me(Me.tableTemReceipt.SaleDateColumn) = System.Convert.DBNull
        End Sub
        
        Public Function IsSaleTimeNull() As Boolean
            Return Me.IsNull(Me.tableTemReceipt.SaleTimeColumn)
        End Function
        
        Public Sub SetSaleTimeNull()
            Me(Me.tableTemReceipt.SaleTimeColumn) = System.Convert.DBNull
        End Sub
        
        Public Function IsSubTotalNull() As Boolean
            Return Me.IsNull(Me.tableTemReceipt.SubTotalColumn)
        End Function
        
        Public Sub SetSubTotalNull()
            Me(Me.tableTemReceipt.SubTotalColumn) = System.Convert.DBNull
        End Sub
        
        Public Function IsTaxNull() As Boolean
            Return Me.IsNull(Me.tableTemReceipt.TaxColumn)
        End Function
        
        Public Sub SetTaxNull()
            Me(Me.tableTemReceipt.TaxColumn) = System.Convert.DBNull
        End Sub
        
        Public Function IsTotalNull() As Boolean
            Return Me.IsNull(Me.tableTemReceipt.TotalColumn)
        End Function
        
        Public Sub SetTotalNull()
            Me(Me.tableTemReceipt.TotalColumn) = System.Convert.DBNull
        End Sub
    End Class
    
    <System.Diagnostics.DebuggerStepThrough()>  _
    Public Class TemReceiptRowChangeEvent
        Inherits EventArgs
        
        Private eventRow As TemReceiptRow
        
        Private eventAction As DataRowAction
        
        Public Sub New(ByVal row As TemReceiptRow, ByVal action As DataRowAction)
            MyBase.New
            Me.eventRow = row
            Me.eventAction = action
        End Sub
        
        Public ReadOnly Property Row As TemReceiptRow
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
