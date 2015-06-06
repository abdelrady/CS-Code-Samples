using System;
using System.Data;
using System.Configuration;
using System.Web;
using System.IO;
using System.Web.Security;
using System.Web.UI;
using System.Web.UI.WebControls;
using System.Web.UI.WebControls.WebParts;
using System.Web.UI.HtmlControls;

public partial class _Default : System.Web.UI.Page 
{
    protected void Page_Load(object sender, EventArgs e)
    {
        TreeNode rotNode=new TreeNode();
        //AddToNode(rotNode, Request.PhysicalApplicationPath);
        //tv_DirectoryList.Nodes.Add(rotNode);
        string[] DirectoriesArray = Directory.GetDirectories(Request.PhysicalApplicationPath);
        foreach (string strDirectory in DirectoriesArray)
        {
            TreeNode tempNode = new TreeNode(strDirectory.Split('\\').ToString());
            tv_DirectoryList.Nodes.Add(tempNode);
        }
    }
    private void AddToNode(TreeNode node, string path)
    {
        string[] DirectoriesArray = Directory.GetDirectories(path);

        foreach (string strDirectory in DirectoriesArray)
        {
            TreeNode tempNode = new TreeNode(strDirectory);
            node.ChildNodes.Add(tempNode);
            AddToNode(node, strDirectory);
        }
    }
}
