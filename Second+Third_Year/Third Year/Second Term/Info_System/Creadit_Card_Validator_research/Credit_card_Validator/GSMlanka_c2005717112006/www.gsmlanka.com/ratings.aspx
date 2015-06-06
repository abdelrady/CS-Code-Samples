<%@ Page Language="VB" %>
<script runat="server">

    Public  phone_ID as string
      Sub disprating
      phone_Id= LTRIM(request.QueryString("phoneID"))
       Dim intApprovalWidth, intBlankWidth as Integer
       Dim strQuery as string
       Dim strCon As String
       call dbcon
    
       If Not IsPostback Then
    
        strQuery  = "SELECT SUM(rating) As RatingSum, COUNT(ratingID) As RatingCount "
        strQuery += "FROM ratings WHERE phoneid='"& LTRIM(request.QueryString("phoneID")) &"'"
        bcon.Open()
        bcmd=new sqlcommand(strquery,bcon)
        tempdr = Bcmd.ExecuteReader()
        tempdr.read
        If tempdr("ratingcount")<>0 Then
    
         lblRatingCount.Text = " / " & tempdr("RatingCount")
         intApprovalWidth = tempdr("RatingSum")/tempdr("RatingCount")*15
         intBlankWidth    = 75 - intApprovalWidth
         imgRatingApproval.Width = _
             System.web.ui.webcontrols.unit.pixel(intApprovalWidth)
         imgRatingBlank.Width = _
             System.web.ui.webcontrols.unit.pixel(intBlankWidth)
        Else
         lblRatingCount.Text = "/0"
         lblRating.Text = "Be the first to rate it!"
    
        End If
        tempdr.Close()
        bcon.Close()
       End If
    
      End Sub
    
    
    
    
    
    
    Sub btnRating_Click(sender As Object, e As System.Web.UI.ImageClickEventArgs)
       'Variable declarations...
      Dim intApprovalWidth, intBlankWidth as Integer
       Dim strSelectQuery, strInsertQuery as string
       Dim strCon As String
    
       Dim strRemoteAddress as String
       Dim intSelectedRating, intCount As Integer
       intSelectedRating=rblRating.SelectedValue
       'Get the user's ip address and cast its type to string...
       strRemoteAddress = ltrim(Cstr(request.ServerVariables("REMOTE_ADDR")))
       'Build the query string...
       strSelectQuery  = "SELECT COUNT(ratingID) As RatingCount FROM ratings WHERE PhoneID='"& LTRIM(phone_ID) & "'  AND ip = '" & strRemoteAddress &"'"
       call dbcon
      bcon.open
       mcmd=new sqlcommand(strSelectQuery,bcon)
       intcount=mcmd.executescalar
    
      If intCount = 0 Then
        bcon.Close()
        strInsertQuery  = "INSERT INTO ratings (rating, ip, phoneID)VALUES ('" & intSelectedRating & "','"& strRemoteAddress & "','"& ltrim(request.QueryString("phoneID")) &"') "
        tcmd=new sqlcommand(strinsertquery,bcon)
        bcon.open
        tcmd.ExecuteNonQuery()
            bcon.Close()
       lblrating.text=""
    
    
       Else
          lblRating.Text = "You've already rated this phone"
        bcon.close  'The user hasn't rated the article
       End If
    
       strSelectQuery  ="SELECT SUM(rating) As RatingSum, COUNT(ratingID) As RatingCount FROM ratings WHERE phoneID='"& ltrim(request.QueryString("phoneID")) &"'"
       bcon.Open()
        mcmd=new sqlcommand(strSelectQuery,bcon)
       tempdr= mcmd.ExecuteReader()
       tempdr.Read()
    
       lblRatingCount.Text = " / " & tempdr("RatingCount")
       intApprovalWidth = tempdr("RatingSum")/tempdr("RatingCount")*15
       tempdr.Close()
    
    
       bcon.Close()
       intBlankWidth = 75 - intApprovalWidth
       imgRatingApproval.Width = _
          System.web.ui.webcontrols.unit.pixel(intApprovalWidth)
       imgRatingBlank.Width = _
          System.web.ui.webcontrols.unit.pixel(intBlankWidth)
      End Sub

</script>
<html>
<head>
</head>
<body>
</body>
</html>
