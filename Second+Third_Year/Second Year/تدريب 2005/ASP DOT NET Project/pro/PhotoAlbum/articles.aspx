<%@ page language="C#" %>

<script runat="server">

</script>

<html>
<head runat="server">
    <title>Articles</title>
</head>
<body>
    <form runat="server">
        <asp:datalist id="DataList1" runat="server" datasourceid="artdataveiw" width="256px">
            <itemtemplate>
                username:
                <asp:label text='<%#DataBinder.Eval(Container.DataItem,"username") %>' runat="server">
                </asp:label>
                </asp:label><br />
                name:
                <asp:label text='<%# Eval("name") %>' runat="server">
                </asp:label>
                </asp:label><br />
                date:
                <asp:label text='<%# Eval("date") %>' runat="server">
                </asp:label>
                </asp:label><br />
                description:
                <asp:label text='<%# Eval("description") %>' runat="server">
                </asp:label>
                </asp:label><br />
                articles:
                <asp:label text='<%# Eval("articles") %>' runat="server">
                </asp:label>
                </asp:label><br />
                <br />
            </itemtemplate>
        </asp:datalist>
        <asp:accessdatasource id="artdataveiw" runat="server" selectcommand="select * from article"
            datafile="../Data/articles.mdb">
        </asp:accessdatasource>

    </form>
</body>
</html>
