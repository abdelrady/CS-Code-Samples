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

    [GeneratedCode("System.Resources.Tools.StronglyTypedResourceBuilder", "2.0.0.0")]
    [DebuggerNonUserCode]
    [CompilerGenerated]
    internal class Resources
    {

        private static CultureInfo resourceCulture;
        private static ResourceManager resourceMan;

        internal static Bitmap Adminstrative
        {
            get
            {
                object obj = Resources.ResourceManager.GetObject("Adminstrative", Resources.resourceCulture);
                return (Bitmap)obj;
            }
        }

        [EditorBrowsable(EditorBrowsableState.Advanced)]
        internal static CultureInfo Culture
        {
            get
            {
                return Resources.resourceCulture;
            }
            set
            {
                Resources.resourceCulture = value;
            }
        }

        [EditorBrowsable(EditorBrowsableState.Advanced)]
        internal static ResourceManager ResourceManager
        {
            get
            {
                bool flag = !Object.ReferenceEquals(Resources.resourceMan, null);
                if (!flag)
                {
                    ResourceManager resourceManager1 = new ResourceManager("Students__House_Control.Properties.Resources", typeof(Resources).Assembly);
                    Resources.resourceMan = resourceManager1;
                }
                return Resources.resourceMan;
            }
        }

        internal static Bitmap wrong
        {
            get
            {
                object obj = Resources.ResourceManager.GetObject("wrong", Resources.resourceCulture);
                return (Bitmap)obj;
            }
        }

        internal Resources()
        {
        }

    } // class Resources

}

