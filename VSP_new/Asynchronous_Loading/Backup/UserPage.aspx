<%@ Page Language="vb" AutoEventWireup="false" Codebehind="UserPage.aspx.vb" Inherits="Asynchronous_Loading.UserPage"%>
<!DOCTYPE HTML PUBLIC "-//W3C//DTD HTML 4.0 Transitional//EN">
<HTML>
	<HEAD>
		<script>
// '172.26.11.215' will be the IP address of the Server (In which System has our Database 'India')
var requestURL = 'http://172.26.11.215/Asynchronous_Loading/AJAX.aspx?';

var xmlhttp;
var whichtype;

function show_date(strname,strselected)
{
	whichtype=strselected;
	if(strname=='-')
	{
	// 'getElementById' -> Returns a reference to the first object with the specified value 'STATELIST' 
	document.getElementById('STATELIST').innerHTML='<select name="STA"><option value="-">--- Select State ---</option></select>';
	document.getElementById('DISTRICTLIST').innerHTML='<select name="DIS"><option value="-">--- Districts ---</option></select>';
	return;
	}

if (strselected=='STARTWITH')
{
	if (strname.length >0)
	{	
		// 'strname' - contains	the selected value from the Combo.
		// 'Type'    - contains the word 'STATES' or 'DISTRICTS', Which combo was selected.
		var url = requestURL + 'q=' + strname + '&Type=STATES';
		xmlhttp= getxmlhttpobject(statechangehandler);
		xmlhttp_get(xmlhttp,url);
	}
}
else if (strselected=='cboSTATES')
{
	if (strname.length >0)
		{			
			var url = requestURL + 'q=' + strname + '&Type=DISTRICTS';			
			xmlhttp= getxmlhttpobject(statechangehandler);
			xmlhttp_get(xmlhttp,url);
		}
}
}

function statechangehandler()
{
	if(xmlhttp.readyState==4 || xmlhttp.readyState=='complete')
	{
		var str = xmlhttp.responseText;
		if (whichtype=='STARTWITH')
		{
			document.getElementById('STATELIST').innerHTML=str;
			document.getElementById('DISTRICTLIST').innerHTML='<select name="DIS"><option value="-">--- Districts ---</option></select>';
								
		}
		else
		{
			document.getElementById('DISTRICTLIST').innerHTML=str;
		}
	}
}


function xmlhttp_get(xmlhttp,url)
{
	xmlhttp.open('GET',url,true);
	xmlhttp.send(null);
}

function getxmlhttpobject(handler)
{
	var objxmlhttp=null;
	objxmlhttp = new ActiveXObject('Microsoft.XMLHTTP');
	
	// 'onreadystatechange' is a Event Property, Fires the 'onreadystatechange' object's state has changed.
	// 'handler' has the State will be any one of 'uninitialized','loading','loaded','interactive','complete' 

	objxmlhttp.onreadystatechange=handler;
	
	return objxmlhttp;
}
		</script>
	</HEAD>
	<body MS_POSITIONING='GridLayout'>
		<form id='Form1' method='post' runat='server'>
			<center>
				<TABLE height='54' cellSpacing='0' cellPadding='0' width='50%' border='1' ms_2d_layout='TRUE' bordercolor='#ff9900' style='BORDER-TOP-WIDTH: 1px;'>
					<tr bgColor='#ff9900'>
						<!-- #ffffff #0797cd-->
						<td align='middle' style='WIDTH: 100%; HEIGHT: 22px; ' colSpan='2'><b><font face='Verdana' color='#ffffff' size='2'>Asynchronous</font></b></td>
					</tr>
					<TR vAlign='top'>
						<TD width='30%' align='right' style='BORDER-RIGHT: 1px; BORDER-BOTTOM: 1px'><font face='Arial' size='2'>Start 
								With :</font></TD>
						<td style='BORDER-BOTTOM: 1px'>
							<select name='STARTWITH' onchange='show_date(STARTWITH.value,STARTWITH.name)'>
								<%
								dim i
								for i=1 to 26%>
								<option value='<% = chr(i+64) %>' selected><% =chr(i+64) %></option>
								<% next	%>
							</select>
						</td>
					</TR>
					<TR vAlign='top'>
						<TD align='right' style='BORDER-RIGHT: 1px; BORDER-BOTTOM: 1px'><font face='Arial' size='2'>State 
								:</font></TD>
						<TD style='BORDER-BOTTOM: 1px'><div id='STATELIST'><select name='STA'><option value='-'>--- 
										Select State ---</option>
								</select></div>
						</TD>
					</TR>
					<TR vAlign='top'>
						<TD align='right' style='BORDER-RIGHT: 1px;'><font face='Arial' size='2'>Districts :</font></TD>
						<TD id='tdDistrict'><div id='DISTRICTLIST'><select name='DIS'><option value='-'>--- Districts 
										---</option>
								</select></div>
						</TD>
					</TR>
				</TABLE>
			</center>
		</form>
	</body>
</HTML>
