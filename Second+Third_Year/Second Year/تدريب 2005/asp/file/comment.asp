<html>
	<head>
		<title></title>
	</head>
	<body bgcolor="#ccccff">


<% dim namelog
	namelog=request.form("namedr")

		<form action="feedback.asp" name="feedback" method="get">
			<table width="100%" height="100%">
				<tr>
					<td colspan="2" align="middle" height="5%" bgcolor="#66cc99">
						<font color="black" size="6">Comment Page </font>
					</td>
				</tr>
				<tr>
					<td height="5%" align="center">
						<h3>Your Name :</h3>
						<input type="text" maxlength="100" name="name1" id="name1" value=namedr >
					</td>
					<td height="5%" align="center">
						<h3>Your E-mail :</h3>
						<input type="text" maxlength="50" id="email" name="email">
					</td>
					</tr>
					<td colspan="2" height="5%" bgcolor="#66cc99">
						<h2 align="center">Enter Your Comment her</h2>
					</td>
				</tr>
				<tr>
					<td colspan="2" align="center">
						<textarea id="Comment" name="Comment" rows="10" cols="50">
						</textarea>
					</td>
				</tr>
				<tr>
					<td align="center" height="5%">
						<input type="submit" name="submit" id="submit" value="Send Comment">
					</td>
					<td align="center" height="5%">
						<input type="reset" name="reset" id="reset" value="clear Fields">
					</td>
				</tr>
			</table>
		</form>
	</body>
</html>
