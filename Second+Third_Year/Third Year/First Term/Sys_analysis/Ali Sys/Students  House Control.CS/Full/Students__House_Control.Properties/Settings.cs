using System.CodeDom.Compiler;
using System.Configuration;
using System.Diagnostics;
using System.Runtime.CompilerServices;

namespace Students__House_Control.Properties
{

    [System.Runtime.CompilerServices.CompilerGenerated]
    [System.CodeDom.Compiler.GeneratedCode("Microsoft.VisualStudio.Editors.SettingsDesigner.SettingsSingleFileGenerator", "8.0.0.0")]
    internal sealed class Settings : System.Configuration.ApplicationSettingsBase
    {

        private static Students__House_Control.Properties.Settings defaultInstance;

        [System.Configuration.DefaultSettingValue("False")]
        [System.Diagnostics.DebuggerNonUserCode]
        [System.Configuration.UserScopedSetting]
        public bool ali
        {
            get
            {
                return (bool)base["ali"];
            }
            set
            {
                base["ali"] = value;
            }
        }

        [System.Configuration.DefaultSettingValue("Provider=Microsoft.Jet.OLEDB.4.0;Data Source=|DataDirectory|\\Studenst.mdb")]
        [System.Configuration.SpecialSetting(System.Configuration.SpecialSetting.ConnectionString)]
        [System.Configuration.ApplicationScopedSetting]
        [System.Diagnostics.DebuggerNonUserCode]
        public string StudenstConnectionString
        {
            get
            {
                return (string)base["StudenstConnectionString"];
            }
        }

        [System.Diagnostics.DebuggerNonUserCode]
        [System.Configuration.ApplicationScopedSetting]
        [System.Configuration.DefaultSettingValue("Provider=Microsoft.Jet.OLEDB.4.0;Data Source=|DataDirectory|\\Students.mdb")]
        [System.Configuration.SpecialSetting(System.Configuration.SpecialSetting.ConnectionString)]
        public string StudentsConnectionString
        {
            get
            {
                return (string)base["StudentsConnectionString"];
            }
        }

        public static Students__House_Control.Properties.Settings Default
        {
            get
            {
                return Students__House_Control.Properties.Settings.defaultInstance;
            }
        }

        public Settings()
        {
        }

        static Settings()
        {
            Students__House_Control.Properties.Settings.defaultInstance = (Students__House_Control.Properties.Settings)System.Configuration.SettingsBase.Synchronized(new Students__House_Control.Properties.Settings());
        }

    } // class Settings

}

