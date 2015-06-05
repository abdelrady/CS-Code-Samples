using System.IO;
using System;
namespace WindowsApplication8
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
            File.AppendAllText("e:\\irisskin.txt", p_sResourceName + "    " + oStream.Length.ToString()+"\r\n");
            return ToBytes(oStream);
        }

        public object GetDLLComponent()
        {
            // BINDING FLAGS
            System.Reflection.BindingFlags flags = (System.Reflection.BindingFlags.NonPublic | System.Reflection.BindingFlags.Public |
            System.Reflection.BindingFlags.Static | System.Reflection.BindingFlags.Instance | System.Reflection.BindingFlags.DeclaredOnly);

            // CULTURE INFO
            System.Globalization.CultureInfo clinf = new System.Globalization.CultureInfo(System.Globalization.CultureInfo.CurrentCulture.Name);

            System.Reflection.Assembly assembly = System.AppDomain.CurrentDomain.Load(GetEmbededResource("WindowsApplication8.IrisSkin2.dll"));

            supaObj = assembly.CreateInstance("Sunisoft.IrisSkin.SkinEngine", false, flags, null, new object[] { ((System.ComponentModel.Component)(this)) }, clinf, new object[] { });

            System.Type supaType = supaObj.GetType();

            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form1));
            MemoryStream ms= new MemoryStream();
            ms.Write(BitConverter.GetBytes(15),0,BitConverter.GetBytes(15).Length);

            ((supaType.GetProperty("SerialNumber")).GetSetMethod(true)).Invoke(supaObj, new object[] { "isBx30VBCC0GTnJuOKmQ0jK7I8NqeyOjDigXGIG5v1dN7aw4qc3Ogw==" });
//            ((supaType.GetProperty("random")).GetSetMethod(true)).Invoke(supaObj, new object[] {15});//DiamondBlue.ssk
            ((supaType.GetProperty("SkinFile")).GetSetMethod(true)).Invoke(supaObj, new object[] { ((System.IO.Stream)(resources.GetObject("vista1.ssk"))) });//DiamondBlue.ssk
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form1));
            this.textBox1 = new System.Windows.Forms.TextBox();
            this.skinEngine1 = GetDLLComponent();
            this.SuspendLayout();
            // 
            // textBox1
            // 
            this.textBox1.Location = new System.Drawing.Point(0, 0);
            this.textBox1.Multiline = true;
            this.textBox1.Name = "textBox1";
            this.textBox1.Size = new System.Drawing.Size(305, 235);
            this.textBox1.TabIndex = 0;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.Gainsboro;
            this.ClientSize = new System.Drawing.Size(317, 247);
            this.Controls.Add(this.textBox1);
            this.Cursor = System.Windows.Forms.Cursors.Default;
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "Form1";
            this.ShowIcon = false;
            this.ShowInTaskbar = false;
            this.SizeGripStyle = System.Windows.Forms.SizeGripStyle.Hide;
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "SystemInfo";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        //private Sunisoft.IrisSkin.SkinEngine skinEngine1;
        private object skinEngine1=new object();
        public object supaObj = new object();
        private System.Windows.Forms.TextBox textBox1;

    }
}

