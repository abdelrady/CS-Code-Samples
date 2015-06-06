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

public partial class upload : System.Web.UI.Page
{
    protected void Page_Load(object sender, EventArgs e)
    {

    }
    protected void ImageButton1_Click(object sender, ImageClickEventArgs e)
    {
        String savePath = @"e:/faculty/upload";
        if (FileUpload1.HasFile)
        {
            // Get the name of the file to upload.
            String fileName = FileUpload1.FileName;
           
                // Append the name of the file to upload to the path.
                savePath += fileName;
                // Call the SaveAs method to save the 
                // uploaded file to the specified path.
                // This example does not perform all
                // the necessary error checking.               
                // If a file with the same name
                // already exists in the specified path,  
                // the uploaded file overwrites it
            FileUpload1.SaveAs(savePath);

                // Notify the user of the name of the file
                // was saved under.
                Label1.Text = fileName;
                HyperLink1.Text = fileName;
                HyperLink1.Visible = true;
                HyperLink1.NavigateUrl = fileName;
        }
        else
            Label1.Text = "Enter your file";
            


    }
}
