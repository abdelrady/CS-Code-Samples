using System.CodeDom.Compiler;
using System.Configuration;
using System.Diagnostics;
using System.Runtime.CompilerServices;

namespace Students__House_Control.Properties
{

    [CompilerGenerated]
    [GeneratedCode("Microsoft.VisualStudio.Editors.SettingsDesigner.SettingsSingleFileGenerator", "8.0.0.0")]
    internal sealed class Settings : ApplicationSettingsBase
    {

        private static Settings defaultInstance;

        [DefaultSettingValue("False")]
        [DebuggerNonUserCode]
        [UserScopedSetting]
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

        [DefaultSettingValue("Provider=Microsoft.Jet.OLEDB.4.0;Data Source=|DataDirectory|\\Studenst.mdb")]
        [SpecialSetting(SpecialSetting.ConnectionString)]
        [ApplicationScopedSetting]
        [DebuggerNonUserCode]
        public string StudenstConnectionString
        {
            get
            {
                return (string)base["StudenstConnectionString"];
            }
        }

        [DebuggerNonUserCode]
        [ApplicationScopedSetting]
        [DefaultSettingValue("Provider=Microsoft.Jet.OLEDB.4.0;Data Source=|DataDirectory|\\Students.mdb")]
        [SpecialSetting(SpecialSetting.ConnectionString)]
        public string StudentsConnectionString
        {
            get
            {
                return (string)base["StudentsConnectionString"];
            }
        }

        public static Settings Default
        {
            get
            {
                return Settings.defaultInstance;
            }
        }

        public Settings()
        {
        }

        static Settings()
        {
            Settings.defaultInstance = (Settings)SettingsBase.Synchronized(new Settings());
        }

    } // class Settings

}

