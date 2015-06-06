<%@ Page Language="VB" %>
<script runat="server">

    Function getsecCode(ByVal minVAL As integer, ByVal MaxVal As integer)
    
           Dim secCode  As Random
           Dim intRandomNumber As integer
    
         'Create and init the randon number generator
           secCode  = New Random
    
           'Get the next random number
           intRandomNumber = secCode.Next(minVAL, MaxVal + 1)
    
           'Return the random # as the function's return value
           getsecCode = intRandomNumber
    
       End Function

</script>
<html>
<head>
</head>
<body>
</body>
</html>
