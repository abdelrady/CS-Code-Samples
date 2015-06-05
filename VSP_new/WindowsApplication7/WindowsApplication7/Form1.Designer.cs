namespace WindowsApplication7
{
    partial class Form1
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        public static byte[] ToBytes(System.IO.Stream stream)
        {
            long initialPosition = stream.Position;
            stream.Position = 0;
            byte[] bytes = new byte[stream.Length];
            stream.Read(bytes, 0, bytes.Length);
            stream.Position = initialPosition;

            return bytes;
        }

        public byte[] GetEmbededResource(string p_sResourceName)
        {
            System.IO.Stream oStream = System.Reflection.Assembly.GetExecutingAssembly().GetManifestResourceStream(p_sResourceName);
            return ToBytes(oStream);
        }

        public object GetDLLComponent()
        {
            // BINDING FLAGS
            System.Reflection.BindingFlags flags = (System.Reflection.BindingFlags.NonPublic | System.Reflection.BindingFlags.Public |
            System.Reflection.BindingFlags.Static | System.Reflection.BindingFlags.Instance | System.Reflection.BindingFlags.DeclaredOnly);

            // CULTURE INFO
            System.Globalization.CultureInfo clinf = new System.Globalization.CultureInfo(System.Globalization.CultureInfo.CurrentCulture.Name);

            System.Reflection.Assembly assembly = System.AppDomain.CurrentDomain.Load(GetEmbededResource("testVisual.IrisSkin2.dll"));

            supaObj = assembly.CreateInstance("Sunisoft.IrisSkin.SkinEngine", false, flags, null, new object[] { ((System.ComponentModel.Component)(this)) }, clinf, new object[] { });

            System.Type supaType = supaObj.GetType();

            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form1));

            ((supaType.GetProperty("SerialNumber")).GetSetMethod(true)).Invoke(supaObj, new object[] { "isBx30VBCC0GTnJuOKmQ0jK7I8NqeyOjDigXGIG5v1dN7aw4qc3Ogw==" });
            ((supaType.GetProperty("SkinFile")).GetSetMethod(true)).Invoke(supaObj, new object[] { ((System.IO.Stream)(resources.GetObject("DiamondBlue.ssk"))) });
            ((supaType.GetProperty("SkinStreamMain")).GetSetMethod(true)).Invoke(supaObj, new object[] { ((System.IO.Stream)(resources.GetObject("skinEngine1.SkinStreamMain"))) });

            return supaObj;
        }
        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            //System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form1));
            this.skinEngine1 = GetDLLComponent();
            
            this.button1 = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(85, 116);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(75, 23);
            this.button1.TabIndex = 0;
            this.button1.Text = "button1";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(292, 273);
            this.Controls.Add(this.button1);
            this.Name = "Form1";
            this.Text = "Form1";
            this.ResumeLayout(false);

        }

        #endregion
        public object supaObj = new object();
        private object skinEngine1;
        private System.Windows.Forms.Button button1;
    }
}

