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

public partial class EncryptConnectionString : System.Web.UI.Page
{
    protected void Page_Load(object sender, EventArgs e)
    {
        EncryptMyConnectionString();
    }
    private void EncryptMyConnectionString()
    {
        Configuration config = 
            System.Web.Configuration.WebConfigurationManager.OpenWebConfiguration(Request.ApplicationPath);
        ConfigurationSection section = config.Sections["connectionStrings"];
        section.SectionInformation.ProtectSection("DataProtectionConfigurationProvider");
        config.Save();
    }
    private void DecryptMyConnectionString()
    {
        Configuration config =
            System.Web.Configuration.WebConfigurationManager.OpenWebConfiguration(Request.ApplicationPath);
        ConfigurationSection section = config.Sections["connectionStrings"];
        section.SectionInformation.UnprotectSection();
        config.Save();
    }
}
