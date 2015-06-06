using System;
using System.Data;
using System.Configuration;
using System.Collections;
using System.Web;
using System.Web.Security;
using System.Web.UI;
using System.Web.UI.WebControls;
using System.Web.UI.WebControls.WebParts;
using System.Web.UI.HtmlControls;

public partial class Default_CS : System.Web.UI.Page
{
    protected void Page_Load(object sender, EventArgs e)
    {

    }
    protected void DropDownList1_SelectedIndexChanged(object sender, EventArgs e)
    {
        switch (int.Parse(ddl_ShowType.SelectedValue))
        {
            case 0:
                WebPartManager1.DisplayMode = WebPartManager.BrowseDisplayMode;
                break;
            case 1:
                WebPartManager1.DisplayMode = WebPartManager.DesignDisplayMode;
                break;
            case 2:
                WebPartManager1.DisplayMode = WebPartManager.CatalogDisplayMode;
                break;
            case 3:
                WebPartManager1.DisplayMode = WebPartManager.EditDisplayMode;
                break;
            default:
                WebPartManager1.DisplayMode = WebPartManager.BrowseDisplayMode;
                break;
        }
    }
}
