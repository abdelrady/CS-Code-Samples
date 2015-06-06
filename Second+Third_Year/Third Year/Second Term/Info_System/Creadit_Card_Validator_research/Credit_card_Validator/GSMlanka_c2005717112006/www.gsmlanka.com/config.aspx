<%@ Page Language="VB" %>
<script runat="server">

    sub dbcon
    
    Bcon = New sqlConnection("data source=fcis;uid=sa;pwd=admin;initial catalog=gsmlanka")
    cartCon= New sqlConnection("data source=fcis;uid=sa;pwd=admin;initial catalog=gsmlanka")
    end sub
    public BCon As sqlConnection
    public cartCon as sqlconnection
    public BCmd As sqlCommand
    public Mcmd as sqlcommand
    public Tcmd as sqlcommand
    public pcmd as sqlcommand
    
    public objreader as SqlDataReader
    public dr as sqldatareader
    public cdr as sqldatareader
    public tempdr as sqldatareader
    Public intStart As Integer
    PUBLIC INSERTSQL AS string
    public updatesql as string

</script>
<html>
<head>
</head>
<body>
</body>
</html>
