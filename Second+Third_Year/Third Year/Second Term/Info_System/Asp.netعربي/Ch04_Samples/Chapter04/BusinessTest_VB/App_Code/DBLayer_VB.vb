Imports Microsoft.VisualBasic
Imports System
Imports System.Data
Imports System.Data.SqlClient
Imports System.Configuration

Public Class DBLayer_VB
    Private Sub New()

    End Sub
    Private Shared Function GetConnectionString() As String
        Return ConfigurationManager.ConnectionStrings("pubsConnectionString").ConnectionString
    End Function
    Private Shared Function ExecuteProcedure(ByVal strCommandName As String, Optional ByVal Inputs As SqlParameter() = Nothing) As DataSet
        Dim con As New SqlConnection(GetConnectionString())
        Dim cmd As New SqlCommand
        cmd.CommandText = strCommandName
        cmd.CommandType = CommandType.StoredProcedure
        For Each tempParam As SqlParameter In Inputs
            cmd.Parameters.Add(tempParam)
        Next
        Dim adpt As New SqlDataAdapter(cmd)
        Dim ds As New DataSet
        adpt.Fill(ds)
        cmd.Dispose()
        adpt.Dispose()
        con.Close()
        Return ds
    End Function
    Public Shared Function GetAuthorInformation(ByVal strAuthorID As String) As DataSet
        Return ExecuteProcedure("spGetAuthors")
    End Function

    Public Shared Function GetAuthorInformationWithPremission(ByVal intPremission As Integer) As DataSet
        If intPremission = 1 Then
            Return ExecuteProcedure("spGetAuthors")
        Else
            Return ExecuteProcedure("spGetAuthorByIDWithPremission")
        End If
    End Function
End Class
