<%@ Page Language="VB" %>
<script runat="server">

    public DOB as string
    public usermail as string
    public password as string
    public avatarimg as string
    
    
    
    Sub register( obj As Object, e As EventArgs )
    dim strSQLQuery as string
    dim insertSQL as string
    
    
    
    DOB= txtdd.text & "/" & txtmm.text & "/"  & txtyy.text
    if txtavatar.text="" then
    avatarimg="imagenew/default.jpg"
    else
    avatarimg=txtavatar.text
    end if
    
                 call dbcon
              strSQLQuery = "select userID,Email from users where userID='" & txtuserID.Text & "' or email='" & txtemail.text & "'"
                Bcon.open
             bcmd = New SqlCommand(strSQLQuery, Bcon)
             objreader = bcmd.ExecuteReader
    
                If objreader.HasRows = true Then
    
                lblmessege.text="the user ID or email is already in use/please try another one."
                   lblmessege.visible=true
    
    
             ElseIf Not IsDate(DOB) then
                    lblerrdate.text="enter a valid date"
    
                    elseif  Len(txtPass1.Text)<6 then
                    lblpasserror.text="password should be minimum 6 characters"
                else
                    lblpasserror.text=""
                    lblerrdate.text=""
                    lblmessege.visible=false
    
                call dbcon
                    insertSQL="insert into users(userID,pass_word,f_name,l_name,Bday,gender,Email,country,zip,address,phone,sec_question,answer,priviladge,posts,joineddate,ImageURL)values(@userID,@pass_word,@fname,@lname,@bday,@gender,@email,@country,@zip,@address,@phone,@secques,@answer,@priviladge,@posts,@joineddate,@imageURL)"
    
                    tcmd=new sqlcommand(insertSQL,bcon)
    
                    TCmd.Parameters.Add(New sqlParameter("@UserID", sqlDbType.Varchar,50))
                    TCmd.Parameters.Add(New sqlParameter("@Pass_word", sqlDbType.Varchar,16))
                    TCmd.Parameters.Add(New sqlParameter("@fname", sqlDbType.Varchar,50))
                    TCmd.Parameters.Add(New sqlParameter("@lName", sqlDbType.Varchar,50))
                    TCmd.Parameters.Add(New sqlParameter("@Bday", sqlDbType.char,20))
                    TCmd.Parameters.Add(New sqlParameter("@Email", sqlDbType.Varchar,100))
                    TCmd.Parameters.Add(New sqlParameter("@Gender", sqlDbType.char,10))
                    TCmd.Parameters.Add(New sqlParameter("@country", sqlDbType.Varchar,100))
                    TCmd.Parameters.Add(New sqlParameter("@Zip", sqlDbType.char,10))
                    TCmd.Parameters.Add(New sqlParameter("@address", sqlDbType.Varchar,500))
                    TCmd.Parameters.Add(New sqlParameter("@Phone", sqlDbType.char,20))
                    TCmd.Parameters.Add(New sqlParameter("@secques", sqlDbType.Varchar,200))
                    TCmd.Parameters.Add(New sqlParameter("@answer", sqlDbType.Varchar,50))
                    TCmd.Parameters.Add(New sqlParameter("@priviladge", sqlDbType.Varchar,20))
                    TCmd.Parameters.Add(New sqlParameter("@posts", sqlDbType.int))
                    TCmd.Parameters.Add(New sqlParameter("@Joineddate", sqlDbType.char,20))
                  TCmd.Parameters.Add(New sqlParameter("@ImageURL", sqlDbType.Varchar,300))
    
    
    
                    TCmd.Parameters("@UserID").Value =cstr(txtuserid.text)
                    TCmd.Parameters("@Pass_word").Value = cstr(txtpass1.text)
                    TCmd.Parameters("@fname").Value = cstr(txtfname.text)
                    TCmd.Parameters("@lName").Value = cstr(txtlname.text)
                    TCmd.Parameters("@Bday").Value = cstr(DOB)
                    TCmd.Parameters("@Email").Value = cstr(txtemail.text)
                    TCmd.Parameters("@Gender").Value = cstr(cboGen.SelectedItem.Text)
                    TCmd.Parameters("@country").Value = cstr(cboCon.SelectedItem.Text)
                    TCmd.Parameters("@Zip").Value = cstr(txtZip.text)
                    TCmd.Parameters("@address").Value = cstr(txtADDr.text)
                    TCmd.Parameters("@Phone").Value = Cstr(txtPhone.text)
                    TCmd.Parameters("@secques").Value = Cstr(txtsec.text)
                    TCmd.Parameters("@answer").Value =Cstr(txtAnswer.text)
                    TCmd.Parameters("@priviladge").Value = "Member"
                    TCmd.Parameters("@posts").Value = 0
                    TCmd.Parameters("@Joineddate").Value =cstr(cdate(now))
                    TCmd.Parameters("@ImageURL").Value = cstr(avatarimg)
    
                    bcon.open
                    TCmd.ExecuteNonQuery
                    usermail=txtemail.text
                    session("userID")=txtUserID.text
                    session("valid")="yes"
                    session("email")=txtemail.text
                    password=txtpass1.text
                    session("secCOde")=cstr(getsecCode(1,546789))
                  Bcon.close
    
    
                    txtuserid.text=""
                    txtpass1.text=""
                    txtpass2.text=""
                    txtfname.text=""
                    txtlname.text=""
                    txtemail.text=""
                    txtZip.text=""
                    txtADDr.text=""
                    txtPhone.text=""
                    txtsec.text=""
                    txtAnswer.text=""
                    txtAvatar.text=""
                    txtDD.text=""
                    txtMM.text=""
                    txtYY.text=""
                        call emailusr
                    response.Redirect("welcome.aspx")
    
                end if
    
    
    end sub
    
    
    sub emailusr
    
      Dim EmailMessage As New System.Web.Mail.MailMessage
    
                    'Smtp object to send the message
                 Dim emailSMTP As System.Web.Mail.SmtpMail
    
                 'build the mailMessage
                 EmailMessage.From = "webmaster@azmil.com"
                 EmailMessage.To = usermail
    
                 EmailMessage.Subject = "Welcome to GSMLANKA	"
    EmailMessage.BodyFormat = Mail.MailFormat.Html
                 EmailMessage.Body = "Dear " & session("userID") & "," & "<BR><BR>" & "welcome to our site  now you can purchase your favorite phone online @ GSMLanka, and you can discuss about your favorite phones,rate them and much more.thank you for registering @ our site your user details are as follows:<BR>username:" & session("userid") & "<BR>"& "Password:  " & password & "<BR><BR>     thank you<BR><BR>Administration"
    
    
    
                 emailSMTP.SmtpServer = "localhost"
    
                      emailSMTP.Send(EmailMessage)
    
    end sub

</script>
<html>
<head>
</head>
<body>
</body>
</html>
