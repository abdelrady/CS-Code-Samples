namespace WindowsApplication9
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

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            //Sunisoft.IrisSkin.SkinEngine.random = 11;
            this.skinEngine1 = new Sunisoft.IrisSkin.SkinEngine(((System.ComponentModel.Component)(this)));
            System.Type supaType = skinEngine1.GetType();
            ((supaType.GetProperty("SerialNumber")).GetSetMethod(true)).Invoke(skinEngine1, new object[] { "isBx30VBCC0GTnJuOKmQ0jK7I8NqeyOjDigXGIG5v1dN7aw4qc3Ogw==" });
            //            ((supaType.GetProperty("random")).GetSetMethod(true)).Invoke(supaObj, new object[] {15});//DiamondBlue.ssk
            //((supaType.GetProperty("SkinFile")).GetSetMethod(true)).Invoke(skinEngine1, new object[] { ((System.IO.Stream)(resources.GetObject("vista1.ssk"))) });//DiamondBlue.ssk
            //((supaType.GetProperty("SkinStreamMain")).GetSetMethod(true)).Invoke(skinEngine1, new object[] { ((System.IO.Stream)(resources.GetObject("skinEngine1.SkinStreamMain"))) });
            this.SuspendLayout();
            // 
            // skinEngine1
            // 
            //this.skinEngine1.SerialNumber = "";
            this.skinEngine1.SkinFile = @"MacOS.ssk";
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(292, 273);
            this.Name = "Form1";
            this.Text = "Form1";
            this.ResumeLayout(false);

        }

        #endregion

        private Sunisoft.IrisSkin.SkinEngine skinEngine1;
    }
}

