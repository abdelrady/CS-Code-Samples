<%@ Page Language="VB" ContentType="text/html" ResponseEncoding="iso-8859-1" %>
<script runat="server">

    Sub Page_Load( s As Object, e As EventArgs )
    
    session("AdminID")=""
    response.Redirect("adminlogin.aspx")
    
    
    
    
    End Sub

</script>
<html>
<head>
    <title>Signing out</title> 
    <meta http-equiv="Content-Type" content="text/html; charset=iso-8859-1" />
</head>
<body>
</body>
</html>
