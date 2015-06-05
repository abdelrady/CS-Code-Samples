using System;
using System.Web;
using System.Web.Services;
using System.Web.Services.Protocols;
//using System.Web.UI.WebControls;
using System.Runtime.InteropServices;
using FCIS;

[WebService(Namespace = "http://localhost:1063/CamWebService/Service.asmx")]
[WebServiceBinding(ConformsTo = WsiProfiles.BasicProfile1_1)]
public class Service : System.Web.Services.WebService
{
    public Service () {

        //Uncomment the following line if using designed components 
        //InitializeComponent(); 
    }

    [WebMethod]
    public string HelloWorld() {
        return "Hello World";
    }

    //[DllImport("CaptureScreen_Dll.dll")]
    //public static extern void captureScreen(long quality, out byte[] imageData);

    [WebMethod]
    public System.Drawing.Image GetImage()
    {
        return FCIS.DeskTop.GetDesktopImage();
    }
    
}
