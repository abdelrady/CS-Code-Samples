<%@ Page Language="C#" %>
<%@ Register TagPrefix="etier" Namespace="Etier" Assembly="CreditCardValidator" %>

<!DOCTYPE HTML PUBLIC "-//W3C//DTD HTML 4.01 Transitional//EN">
<html>
<head>
<title>CreditCardValidator Test Form</title>
<meta http-equiv="Content-Type" content="text/html; charset=iso-8859-1">
<style type="text/css">
<!--
.table {
	border: 1px dotted #99CC33;
}
.blackBottom {
	border-bottom-width: 3px;
	border-bottom-style: solid;
	border-top-color: #000000;
	border-right-color: #000000;
	border-bottom-color: #000000;
	border-left-color: #000000;
}
-->
</style>
<style type="text/css">
<!--
.Result {
	font-family: Verdana, Arial, Helvetica, sans-serif;
	font-size: 10px;
	font-weight: bold;
}
-->
</style>
</head>

<body>
<form runat="server">
<table width="600" border="0" align="center" cellpadding="0" cellspacing="0" class="table">
  <tr>
    <td><table width="600" border="0" align="center" cellpadding="0" cellspacing="0" bgcolor="#95C03F" class="blackBottom">
          <tr> 
            <td height="65"> <div align="center"><font color="#FFFFFF" size="5" face="Arial, Helvetica, sans-serif">CreditCardValidator 
                Test Form</font></div></td>
          </tr>
        </table>
	    <table width="100%" border="0" cellpadding="4" cellspacing="0" bgcolor="#F4F4F4">
          <tr> 
	    <td></td>
            <td><font size="1" face="Verdana, Arial, Helvetica, sans-serif">This 
              page demonstrates the CreditCardValidator validation control.</font></td>
          </tr>
          <tr valign="middle"> 
            <td width="22%"><div align="right"><font color="#000000"><strong><font size="1" face="Verdana, Arial, Helvetica, sans-serif">Card 
                Number:</font></strong></font></div></td>
            <td width="78%"><asp:textbox ID="CardNumber" runat="server" />
		<asp:RequiredFieldValidator
		  ControlToValidate="CardNumber"
		  ErrorMessage="Please enter a card number"
		  Display="none"
		  RunAt="server"
		  EnableClientScript="False"
		/>
		<asp:regularexpressionvalidator
			ControlToValidate="CardNumber"
			ValidationExpression="^\d+$"
			ErrorMessage="Please enter the card number without spaces or dashes."
			Display="None"
			RunAt="server"
			EnableClientScript="false"
		/>
		<etier:CreditCardValidator
		  Id="MyValidator"
		  ControlToValidate="CardNumber"
		  ErrorMessage="Please enter a valid credit card number"
		  Display="none"
		  RunAt="server"
		  EnableClientScript="False"
		  ValidateCardType="True"
		  AcceptedCardTypes="Amex"
		/>
	    </td>
          </tr>
          <tr valign="middle"> 
            <td><div align="right"><font color="#000000"><font size="1" face="Verdana, Arial, Helvetica, sans-serif">Valid 
                from:</font></font></div></td>
            <td> <asp:textbox ID="StartDate" runat="server" MaxLength="5" Columns="5"/> <strong><font size="1" face="Verdana, Arial, Helvetica, sans-serif"> 
              Valid To: 
              <asp:textbox ID="ExpiryDate" runat="server" MaxLength="5" Columns="5"/>
              (MM/YY) </font></strong>
		<asp:RequiredFieldValidator
		  ControlToValidate="ExpiryDate"
		  ErrorMessage="Please enter an expiry date"
		  Display="none"
		  RunAt="server"
		  EnableClientScript="False"
		/>
	    </td>
          </tr>
          <tr valign="middle"> 
            <td><div align="right"><font color="#000000">&nbsp;<font size="1" face="Verdana, Arial, Helvetica, sans-serif">Issue 
                Number:</font></font></div></td>
            <td><asp:textbox ID="Issue" runat="server" MaxLength="2" Columns="5"/></td>
          </tr>
          <tr valign="middle">
            <td><div align="right"><font size="1" face="Verdana, Arial, Helvetica, sans-serif"><strong>Amount:</strong></font></div></td>
            <td><asp:textbox ID="Amount" runat="server" MaxLength="12" Columns="12"/> <font size="1" face="Verdana, Arial, Helvetica, sans-serif"><strong>GBP
		</strong></font>
		<asp:RequiredFieldValidator
		  ControlToValidate="Amount"
		  ErrorMessage="Please enter an amount"
		  Display="none"
		  RunAt="server"
		  EnableClientScript="False"
		/>
	    </td>
          </tr>
          <tr> 
            <td>&nbsp;</td>
            <td><asp:button text="Submit" id="ChargeCard" runat="server" /></td>
          </tr>
          <tr valign="top"> 
            <td>
	<% if (IsPostBack) { %>
	    <div align="right"><font size="1" face="Verdana, Arial, Helvetica, sans-serif">Result:</font></div>
	<% } %>
	    </td>
            <td><asp:label ID="Result" runat="server" Text="" CssClass="Result"/>
    	<asp:ValidationSummary
		DisplayMode="BulletList"
		HeaderText="There were the following errors"
		RunAt="Server"
		CssClass="Result"
	    />
	    </td>
          </tr>
        </table>
	  </td>
  </tr>
</table>
</form>
</body>
</html>
<script language="C#" runat="server">
	void Page_Load (Object sender, EventArgs e)
	{
		if (!IsPostBack)
		{
			//MyValidator.CardTypes = Etier.CardType.VISA;
		}
	}
</script>