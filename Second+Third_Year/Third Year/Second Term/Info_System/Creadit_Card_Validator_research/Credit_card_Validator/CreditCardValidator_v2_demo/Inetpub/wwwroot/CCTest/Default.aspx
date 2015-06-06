<%@ Register TagPrefix="etier" Namespace="Etier.CreditCard" Assembly="CreditCardValidator" %>
<%@ Page Language="C#" Debug="true" %>
<HTML>
	<body>
		<form runat="server">
			<asp:textbox ID="CardNumber" runat="server" />
			<etier:CreditCardValidator Id="MyValidator" ControlToValidate="CardNumber" ErrorMessage="Please enter a valid credit card number"
				Display="none" RunAt="server" CardTypesListBox="CardTypesListBox1" />
			<etier:CardTypesListBox id="CardTypesListBox1" runat="server" Width="198px" Height="80px" Rows="1">
				<asp:ListItem Value="CardTypes Here">CardTypes Here</asp:ListItem>
			</etier:CardTypesListBox>
			<p>
				<asp:button text="Submit" id="ChargeCard" runat="server" />
				<asp:ValidationSummary DisplayMode="BulletList" HeaderText="There were the following errors" RunAt="server"
					CssClass="Result" id="ValidationSummary1" />
		</form>
		</P>
	</body>
</HTML>
