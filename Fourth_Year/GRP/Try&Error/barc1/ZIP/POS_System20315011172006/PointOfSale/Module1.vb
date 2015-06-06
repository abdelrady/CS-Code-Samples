Imports System.Data.OleDb

Module Module1
    Public cur As New Form()
    Public intResponse As Integer
    Public dr As OleDbDataReader
    Public con As String = "Provider= Microsoft.Jet.OLEDB.4.0;Data Source=posdb.mdb"
    Public dc As New OleDbConnection(con)
    Public da As OleDbDataAdapter
    Public ds As DataSet


End Module
