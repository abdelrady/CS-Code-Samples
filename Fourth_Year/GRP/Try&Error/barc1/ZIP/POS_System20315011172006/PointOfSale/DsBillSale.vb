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
Public Class DsBillSale
    Inherits DataSet
    
    Private tableAllSale As AllSaleDataTable
    
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
            If (Not (ds.Tables("AllSale")) Is Nothing) Then
                Me.Tables.Add(New AllSaleDataTable(ds.Tables("AllSale")))
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
    Public ReadOnly Property AllSale As AllSaleDataTable
        Get
            Return Me.tableAllSale
        End Get
    End Property
    
    Public Overrides Function Clone() As DataSet
        Dim cln As DsBillSale = CType(MyBase.Clone,DsBillSale)
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
        If (Not (ds.Tables("AllSale")) Is Nothing) Then
            Me.Tables.Add(New AllSaleDataTable(ds.Tables("AllSale")))
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
        Me.tableAllSale = CType(Me.Tables("AllSale"),AllSaleDataTable)
        If (Not (Me.tableAllSale) Is Nothing) Then
            Me.tableAllSale.InitVars
        End If
    End Sub
    
    Private Sub InitClass()
        Me.DataSetName = "DsBillSale"
        Me.Prefix = ""
        Me.Namespace = "http://www.tempuri.org/DsBillSale.xsd"
        Me.Locale = New System.Globalization.CultureInfo("ms-MY")
        Me.CaseSensitive = false
        Me.EnforceConstraints = true
        Me.tableAllSale = New AllSaleDataTable
        Me.Tables.Add(Me.tableAllSale)
    End Sub
    
    Private Function ShouldSerializeAllSale() As Boolean
        Return false
    End Function
    
    Private Sub SchemaChanged(ByVal sender As Object, ByVal e As System.ComponentModel.CollectionChangeEventArgs)
        If (e.Action = System.ComponentModel.CollectionChangeAction.Remove) Then
            Me.InitVars
        End If
    End Sub
    
    Public Delegate Sub AllSaleRowChangeEventHandler(ByVal sender As Object, ByVal e As AllSaleRowChangeEvent)
    
    <System.Diagnostics.DebuggerStepThrough()>  _
    Public Class AllSaleDataTable
        Inherits DataTable
        Implements System.Collections.IEnumerable
        
        Private columnBillNo As DataColumn
        
        Private columnDiscount As DataColumn
        
        Private columnGrandTotal As DataColumn
        
        Private columnSaleDate As DataColumn
        
        Private columnSaleTime As DataColumn
        
        Private columnSubTotal As DataColumn
        
        Private columnTax As DataColumn
        
        Friend Sub New()
            MyBase.New("AllSale")
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
        
        Public Default ReadOnly Property Item(ByVal index As Integer) As AllSaleRow
            Get
                Return CType(Me.Rows(index),AllSaleRow)
            End Get
        End Property
        
        Public Event AllSaleRowChanged As AllSaleRowChangeEventHandler
        
        Public Event AllSaleRowChanging As AllSaleRowChangeEventHandler
        
        Public Event AllSaleRowDeleted As AllSaleRowChangeEventHandler
        
        Public Event AllSaleRowDeleting As AllSaleRowChangeEventHandler
        
        Public Overloads Sub AddAllSaleRow(ByVal row As AllSaleRow)
            Me.Rows.Add(row)
        End Sub
        
        Public Overloads Function AddAllSaleRow(ByVal BillNo As String, ByVal Discount As Decimal, ByVal GrandTotal As Decimal, ByVal SaleDate As Date, ByVal SaleTime As Date, ByVal SubTotal As Decimal, ByVal Tax As Decimal) As AllSaleRow
            Dim rowAllSaleRow As AllSaleRow = CType(Me.NewRow,AllSaleRow)
            rowAllSaleRow.ItemArray = New Object() {BillNo, Discount, GrandTotal, SaleDate, SaleTime, SubTotal, Tax}
            Me.Rows.Add(rowAllSaleRow)
            Return rowAllSaleRow
        End Function
        
        Public Function GetEnumerator() As System.Collections.IEnumerator Implements System.Collections.IEnumerable.GetEnumerator
            Return Me.Rows.GetEnumerator
        End Function
        
        Public Overrides Function Clone() As DataTable
            Dim cln As AllSaleDataTable = CType(MyBase.Clone,AllSaleDataTable)
            cln.InitVars
            Return cln
        End Function
        
        Protected Overrides Function CreateInstance() As DataTable
            Return New AllSaleDataTable
        End Function
        
        Friend Sub InitVars()
            Me.columnBillNo = Me.Columns("BillNo")
            Me.columnDiscount = Me.Columns("Discount")
            Me.columnGrandTotal = Me.Columns("GrandTotal")
            Me.columnSaleDate = Me.Columns("SaleDate")
            Me.columnSaleTime = Me.Columns("SaleTime")
            Me.columnSubTotal = Me.Columns("SubTotal")
            Me.columnTax = Me.Columns("Tax")
        End Sub
        
        Private Sub InitClass()
            Me.columnBillNo = New DataColumn("BillNo", GetType(System.String), Nothing, System.Data.MappingType.Element)
            Me.Columns.Add(Me.columnBillNo)
            Me.columnDiscount = New DataColumn("Discount", GetType(System.Decimal), Nothing, System.Data.MappingType.Element)
            Me.Columns.Add(Me.columnDiscount)
            Me.columnGrandTotal = New DataColumn("GrandTotal", GetType(System.Decimal), Nothing, System.Data.MappingType.Element)
            Me.Columns.Add(Me.columnGrandTotal)
            Me.columnSaleDate = New DataColumn("SaleDate", GetType(System.DateTime), Nothing, System.Data.MappingType.Element)
            Me.Columns.Add(Me.columnSaleDate)
            Me.columnSaleTime = New DataColumn("SaleTime", GetType(System.DateTime), Nothing, System.Data.MappingType.Element)
            Me.Columns.Add(Me.columnSaleTime)
            Me.columnSubTotal = New DataColumn("SubTotal", GetType(System.Decimal), Nothing, System.Data.MappingType.Element)
            Me.Columns.Add(Me.columnSubTotal)
            Me.columnTax = New DataColumn("Tax", GetType(System.Decimal), Nothing, System.Data.MappingType.Element)
            Me.Columns.Add(Me.columnTax)
        End Sub
        
        Public Function NewAllSaleRow() As AllSaleRow
            Return CType(Me.NewRow,AllSaleRow)
        End Function
        
        Protected Overrides Function NewRowFromBuilder(ByVal builder As DataRowBuilder) As DataRow
            Return New AllSaleRow(builder)
        End Function
        
        Protected Overrides Function GetRowType() As System.Type
            Return GetType(AllSaleRow)
        End Function
        
        Protected Overrides Sub OnRowChanged(ByVal e As DataRowChangeEventArgs)
            MyBase.OnRowChanged(e)
            If (Not (Me.AllSaleRowChangedEvent) Is Nothing) Then
                RaiseEvent AllSaleRowChanged(Me, New AllSaleRowChangeEvent(CType(e.Row,AllSaleRow), e.Action))
            End If
        End Sub
        
        Protected Overrides Sub OnRowChanging(ByVal e As DataRowChangeEventArgs)
            MyBase.OnRowChanging(e)
            If (Not (Me.AllSaleRowChangingEvent) Is Nothing) Then
                RaiseEvent AllSaleRowChanging(Me, New AllSaleRowChangeEvent(CType(e.Row,AllSaleRow), e.Action))
            End If
        End Sub
        
        Protected Overrides Sub OnRowDeleted(ByVal e As DataRowChangeEventArgs)
            MyBase.OnRowDeleted(e)
            If (Not (Me.AllSaleRowDeletedEvent) Is Nothing) Then
                RaiseEvent AllSaleRowDeleted(Me, New AllSaleRowChangeEvent(CType(e.Row,AllSaleRow), e.Action))
            End If
        End Sub
        
        Protected Overrides Sub OnRowDeleting(ByVal e As DataRowChangeEventArgs)
            MyBase.OnRowDeleting(e)
            If (Not (Me.AllSaleRowDeletingEvent) Is Nothing) Then
                RaiseEvent AllSaleRowDeleting(Me, New AllSaleRowChangeEvent(CType(e.Row,AllSaleRow), e.Action))
            End If
        End Sub
        
        Public Sub RemoveAllSaleRow(ByVal row As AllSaleRow)
            Me.Rows.Remove(row)
        End Sub
    End Class
    
    <System.Diagnostics.DebuggerStepThrough()>  _
    Public Class AllSaleRow
        Inherits DataRow
        
        Private tableAllSale As AllSaleDataTable
        
        Friend Sub New(ByVal rb As DataRowBuilder)
            MyBase.New(rb)
            Me.tableAllSale = CType(Me.Table,AllSaleDataTable)
        End Sub
        
        Public Property BillNo As String
            Get
                Try 
                    Return CType(Me(Me.tableAllSale.BillNoColumn),String)
                Catch e As InvalidCastException
                    Throw New StrongTypingException("Cannot get value because it is DBNull.", e)
                End Try
            End Get
            Set
                Me(Me.tableAllSale.BillNoColumn) = value
            End Set
        End Property
        
        Public Property Discount As Decimal
            Get
                Try 
                    Return CType(Me(Me.tableAllSale.DiscountColumn),Decimal)
                Catch e As InvalidCastException
                    Throw New StrongTypingException("Cannot get value because it is DBNull.", e)
                End Try
            End Get
            Set
                Me(Me.tableAllSale.DiscountColumn) = value
            End Set
        End Property
        
        Public Property GrandTotal As Decimal
            Get
                Try 
                    Return CType(Me(Me.tableAllSale.GrandTotalColumn),Decimal)
                Catch e As InvalidCastException
                    Throw New StrongTypingException("Cannot get value because it is DBNull.", e)
                End Try
            End Get
            Set
                Me(Me.tableAllSale.GrandTotalColumn) = value
            End Set
        End Property
        
        Public Property SaleDate As Date
            Get
                Try 
                    Return CType(Me(Me.tableAllSale.SaleDateColumn),Date)
                Catch e As InvalidCastException
                    Throw New StrongTypingException("Cannot get value because it is DBNull.", e)
                End Try
            End Get
            Set
                Me(Me.tableAllSale.SaleDateColumn) = value
            End Set
        End Property
        
        Public Property SaleTime As Date
            Get
                Try 
                    Return CType(Me(Me.tableAllSale.SaleTimeColumn),Date)
                Catch e As InvalidCastException
                    Throw New StrongTypingException("Cannot get value because it is DBNull.", e)
                End Try
            End Get
            Set
                Me(Me.tableAllSale.SaleTimeColumn) = value
            End Set
        End Property
        
        Public Property SubTotal As Decimal
            Get
                Try 
                    Return CType(Me(Me.tableAllSale.SubTotalColumn),Decimal)
                Catch e As InvalidCastException
                    Throw New StrongTypingException("Cannot get value because it is DBNull.", e)
                End Try
            End Get
            Set
                Me(Me.tableAllSale.SubTotalColumn) = value
            End Set
        End Property
        
        Public Property Tax As Decimal
            Get
                Try 
                    Return CType(Me(Me.tableAllSale.TaxColumn),Decimal)
                Catch e As InvalidCastException
                    Throw New StrongTypingException("Cannot get value because it is DBNull.", e)
                End Try
            End Get
            Set
                Me(Me.tableAllSale.TaxColumn) = value
            End Set
        End Property
        
        Public Function IsBillNoNull() As Boolean
            Return Me.IsNull(Me.tableAllSale.BillNoColumn)
        End Function
        
        Public Sub SetBillNoNull()
            Me(Me.tableAllSale.BillNoColumn) = System.Convert.DBNull
        End Sub
        
        Public Function IsDiscountNull() As Boolean
            Return Me.IsNull(Me.tableAllSale.DiscountColumn)
        End Function
        
        Public Sub SetDiscountNull()
            Me(Me.tableAllSale.DiscountColumn) = System.Convert.DBNull
        End Sub
        
        Public Function IsGrandTotalNull() As Boolean
            Return Me.IsNull(Me.tableAllSale.GrandTotalColumn)
        End Function
        
        Public Sub SetGrandTotalNull()
            Me(Me.tableAllSale.GrandTotalColumn) = System.Convert.DBNull
        End Sub
        
        Public Function IsSaleDateNull() As Boolean
            Return Me.IsNull(Me.tableAllSale.SaleDateColumn)
        End Function
        
        Public Sub SetSaleDateNull()
            Me(Me.tableAllSale.SaleDateColumn) = System.Convert.DBNull
        End Sub
        
        Public Function IsSaleTimeNull() As Boolean
            Return Me.IsNull(Me.tableAllSale.SaleTimeColumn)
        End Function
        
        Public Sub SetSaleTimeNull()
            Me(Me.tableAllSale.SaleTimeColumn) = System.Convert.DBNull
        End Sub
        
        Public Function IsSubTotalNull() As Boolean
            Return Me.IsNull(Me.tableAllSale.SubTotalColumn)
        End Function
        
        Public Sub SetSubTotalNull()
            Me(Me.tableAllSale.SubTotalColumn) = System.Convert.DBNull
        End Sub
        
        Public Function IsTaxNull() As Boolean
            Return Me.IsNull(Me.tableAllSale.TaxColumn)
        End Function
        
        Public Sub SetTaxNull()
            Me(Me.tableAllSale.TaxColumn) = System.Convert.DBNull
        End Sub
    End Class
    
    <System.Diagnostics.DebuggerStepThrough()>  _
    Public Class AllSaleRowChangeEvent
        Inherits EventArgs
        
        Private eventRow As AllSaleRow
        
        Private eventAction As DataRowAction
        
        Public Sub New(ByVal row As AllSaleRow, ByVal action As DataRowAction)
            MyBase.New
            Me.eventRow = row
            Me.eventAction = action
        End Sub
        
        Public ReadOnly Property Row As AllSaleRow
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
