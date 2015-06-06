<%@ Page Language="VB" %>
<script runat="server">

    Function HtmlClean(ByVal SQLString as string) as string
    
        SQLString = Regex.Replace(SQLString, "'", "''")
            SQLString = Regex.Replace(SQLString, "<[^>]*>", "")
            SQLString = Regex.Replace(SQLString, Microsoft.VisualBasic.vbCrLf, "<br>")
            Return SQLString
    
    End Function
    
    
    Function smiley(byval postingmessage as string) as string
    
    dim smile,lol,sad,rose,wink,cool,conf,shocked as string
    
    'smile="<img src=""smileys/1.gif"" alt=""smile""/>"
    'lol="<img src=""smileys/21.gif"" alt=""lol""/>"
    'sad="<img src=""smileys/2.gif"" alt=""sad""/>"
    'rose="<img src=""smileys/53.gif"" alt=""rose""/>"
    'wink="<img src=""smileys/3.gif"" alt=""wink""/>"
    'cool="<img src=""smileys/16.gif"" alt=""cool""/>"
    'conf="<img src=""smileys/17.gif"" alt=""confused""/>"
    'shocked="<img src=""smileys/13.gif"" alt=""Shocked""/>"
    
    
            postingmessage=regex.replace(postingmessage,cstr("::smile"),"<img src=""smileys/1.gif"" alt=""smile""/>")
            postingmessage=regex.replace(postingmessage,cstr("::lol"),"<img src=""smileys/21.gif"" alt=""lol""/>" )
            postingmessage=regex.replace(postingmessage,cstr(":sad"),"<img src=""smileys/2.gif"" alt=""sad""/>")
            postingmessage=regex.replace(postingmessage,cstr("::rose"),"<img src=""smileys/53.gif"" alt=""rose""/>")
            postingmessage=regex.replace(postingmessage,cstr("::wink"),"<img src=""smileys/3.gif"" alt=""wink""/>")
            postingmessage=regex.replace(postingmessage,cstr("::cool"),"<img src=""smileys/16.gif"" alt=""cool""/>")
            postingmessage=regex.replace(postingmessage,cstr("::wacko"),"<img src=""smileys/17.gif"" alt=""confused""/>")
            postingmessage=regex.replace(postingmessage,cstr(":o"),"<img src=""smileys/13.gif"" alt=""Shocked""/>")
            postingmessage=regex.replace(postingmessage,cstr(":@"),"<img src=""smileys/14.gif"" alt=""angry""/>")
            postingmessage=regex.replace(postingmessage,cstr("::roll"),"<img src=""smileys/icon_rolleyes.gif"" alt=""Roll eyes""/>")
            postingmessage=regex.replace(postingmessage,cstr("::clap"),"<img src=""smileys/41.gif"" alt=""applause""/>")
            postingmessage=regex.replace(postingmessage,cstr("::dance"),"<img src=""smileys/dance.gif"" alt=""dance""/>")
    
    
    
    
    
            return postingmessage
    end function
    
       Function UBBCparse(ByVal input As String) As String
    
             If input Is Nothing Then
                 Return ""
                 Exit Function
             End If
    
             Dim Reg1 As New regex("\[b\]((.|\n)*?)\[/b\]") ' bold regex
             Dim Reg2 As New regex("\[i\]((.|\n)*?)\[/i\]") ' italic regex
             Dim Reg3 As New regex("\[u\]((.|\n)*?)\[/u\]") ' underline regex
             Dim Reg4 As New regex("\[s\]((.|\n)*?)\[/s\]") ' strike-through regex
             Dim Reg5 As New regex("\[sup\]((.|\n)*?)\[/sup\]") ' superscript regex
             Dim Reg6 As New regex("\[sub\]((.|\n)*?)\[/sub\]") ' subscript regex
             Dim Reg7 As New regex("\[url\]((.|\n)*?)\[/url\]") ' basic url regex
             Dim Reg8 As New regex("\[url=((.)*?)\]((.|\n)*?)\[/url\]") ' adv url regex
             Dim Reg9 As New regex("\[color=(#)*(([a-fA-F0-9])*?)\]((.|\n)*?)\[/color\]") ' HEX color regex
             Dim Reg10 As New regex("\[color=(([a-zA-Z])*?)\]((.|\n)*?)\[/color\]") ' named color regex
             Dim Reg11 As New regex("\[img\]((.|\n)*?)\[/img\]") ' image regex
             Dim Reg12 As New regex("\[mail\]((.|\n)*?)\[/mail\]") ' basic mail regex
             Dim Reg13 As New regex("\[mail=((.)+?)\]((.|\n)+?)\[/mail\]") ' adv mail regex
             Dim Reg14 As New regex("\[size=([1-7]){1}\]((.|\n)*?)\[/size\]") ' size regex
             Dim Reg15 As New regex("\[pre\]((.|\n)*?)\[/pre\]") ' preformatted regex
    
             input = Reg1.replace(input, "<b>$1</b>") ' bold replace
             input = Reg2.replace(input, "<i>$1</i>") ' italic replace
             input = Reg3.replace(input, "<u>$1</u>") ' underline replace
             input = Reg4.replace(input, "<span style='text-decoration:line-through;'>$1</span>") ' strike-through replace
             input = Reg5.replace(input, "<sup>$1</sup>") ' superscript replace
             input = Reg6.replace(input, "<sub>$1</sub>") ' subscript replace
             input = Reg7.replace(input, "<a href='$1' target='_blank'>$1</a>") ' basic url replace
             input = Reg8.replace(input, "<a href='$1' target='_blank'>$3</a>") ' adv url replace
             input = Reg9.replace(input, "<span style='color:#$2'>$4</span>") ' HEX color replace
             input = Reg10.replace(input, "<span style='color:$1'>$3</span>") ' named color replace
             input = Reg11.replace(input, "<img border='0' alt='$1' src='$1' />") ' named color replace
             input = Reg12.replace(input, "<a href='mailto:$1' target='_blank'>$1</a>") ' basic mail replace
             input = Reg13.replace(input, "<a href='mailto:$1' target='_blank'>$3</a>") ' adv mail replace
             input = Reg14.replace(input, "<font size='$1'>$2</font>") ' size replace
             input = Reg15.replace(input, "<pre>$1</pre>") ' preformatted replace
             input = input.Replace("[br]", "<br />") ' br replace
             Return input.Replace("[hr]", "<hr />") ' br replace
    
         End Function

</script>
<html>
<head>
</head>
<body>
</body>
</html>
