Imports System.Configuration
Partial Class EncryptConnectionString
    Inherits System.Web.UI.Page
    Private Sub EncryptMyConnectionString()
        Dim config As Configuration = _
        System.Web.Configuration.WebConfigurationManager.OpenWebConfiguration(Request.ApplicationPath)
        Dim section As ConfigurationSection = config.Sections("connectionStrings")
        section.SectionInformation.ProtectSection("DataProtectionConfigurationProvider")
        config.Save()
    End Sub

    Private Sub DecryptMyConnectionString()
        Dim config As Configuration = _
        System.Web.Configuration.WebConfigurationManager.OpenWebConfiguration(Request.ApplicationPath)
        Dim section As ConfigurationSection = config.Sections("connectionStrings")
        section.SectionInformation.UnprotectSection()
        config.Save()
    End Sub
End Class
