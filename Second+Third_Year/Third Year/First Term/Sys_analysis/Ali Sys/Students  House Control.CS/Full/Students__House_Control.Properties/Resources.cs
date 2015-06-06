using System;
using System.CodeDom.Compiler;
using System.ComponentModel;
using System.Diagnostics;
using System.Drawing;
using System.Globalization;
using System.Resources;
using System.Runtime.CompilerServices;

namespace Students__House_Control.Properties
{

    [System.CodeDom.Compiler.GeneratedCode("System.Resources.Tools.StronglyTypedResourceBuilder", "2.0.0.0")]
    [System.Diagnostics.DebuggerNonUserCode]
    [System.Runtime.CompilerServices.CompilerGenerated]
    internal class Resources
    {

        private static System.Globalization.CultureInfo resourceCulture;
        private static System.Resources.ResourceManager resourceMan;

        internal static System.Drawing.Bitmap Adminstrative
        {
            get
            {
                object obj = Students__House_Control.Properties.Resources.ResourceManager.GetObject("Adminstrative", Students__House_Control.Properties.Resources.resourceCulture);
                return (System.Drawing.Bitmap)obj;
            }
        }

        [System.ComponentModel.EditorBrowsable(System.ComponentModel.EditorBrowsableState.Advanced)]
        internal static System.Globalization.CultureInfo Culture
        {
            get
            {
                return Students__House_Control.Properties.Resources.resourceCulture;
            }
            set
            {
                Students__House_Control.Properties.Resources.resourceCulture = value;
            }
        }

        [System.ComponentModel.EditorBrowsable(System.ComponentModel.EditorBrowsableState.Advanced)]
        internal static System.Resources.ResourceManager ResourceManager
        {
            get
            {
                bool flag = !System.Object.ReferenceEquals(Students__House_Control.Properties.Resources.resourceMan, null);
                if (!flag)
                {
                    System.Resources.ResourceManager resourceManager1 = new System.Resources.ResourceManager("Students__House_Control.Properties.Resources", typeof(Students__House_Control.Properties.Resources).Assembly);
                    Students__House_Control.Properties.Resources.resourceMan = resourceManager1;
                }
                return Students__House_Control.Properties.Resources.resourceMan;
            }
        }

        internal static System.Drawing.Bitmap wrong
        {
            get
            {
                object obj = Students__House_Control.Properties.Resources.ResourceManager.GetObject("wrong", Students__House_Control.Properties.Resources.resourceCulture);
                return (System.Drawing.Bitmap)obj;
            }
        }

        internal Resources()
        {
        }

    } // class Resources

}

