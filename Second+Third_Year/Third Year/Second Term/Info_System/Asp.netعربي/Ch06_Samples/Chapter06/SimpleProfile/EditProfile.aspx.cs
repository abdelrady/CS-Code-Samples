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

public partial class EditProfile : System.Web.UI.Page
{
    protected void Page_Load(object sender, EventArgs e)
    {
        if (Membership.GetUser() == null)
        {
            FormsAuthentication.RedirectToLoginPage();
        }
        else
        {
            if (!IsPostBack)
            {
                txtName.Text = Profile.UserInformation.Name;
                txtAddress.Text = Profile.Contacts.Address;
                txtCountry.Text = Profile.UserInformation.Country;
                txtDate.Text = Profile.UserInformation.BirthDate;
                txtMobile.Text = Profile.Contacts.Mobile;
                txtNationality.Text = Profile.UserInformation.Nationality;
                txtNotes.Text = Profile.UserInformation.Notes;
                txtPhone.Text = Profile.Contacts.Phone;
                ddlSystemColor.SelectedValue = Profile.UserInformation.color;                
            }
            updateColor();
        }
    }
    protected void btnSave_Click(object sender, EventArgs e)
    {
        Profile.UserInformation.Name = txtName.Text;
        Profile.Contacts.Address = txtAddress.Text;
        Profile.UserInformation.Country = txtCountry.Text;
        Profile.UserInformation.BirthDate = txtDate.Text;
        Profile.Contacts.Mobile = txtMobile.Text;
        Profile.UserInformation.Nationality = txtNationality.Text;
        Profile.UserInformation.Notes =  txtNotes.Text;
        Profile.Contacts.Phone = txtPhone.Text;
        Profile.UserInformation.color = ddlSystemColor.SelectedValue;
        Profile.Save();
        updateColor();
    }
    void updateColor()
    {
        switch (Profile.UserInformation.color)
        {
            case "0":
                lblColorTest.BackColor = System.Drawing.Color.Red;
                break;
            case "1":
                lblColorTest.BackColor = System.Drawing.Color.Green;
                break;
            case "2":
                lblColorTest.BackColor = System.Drawing.Color.Yellow;
                break;
            default:
                lblColorTest.BackColor = System.Drawing.Color.Wheat;
                break;
        }
    }
}
