using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Text;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using System.Web.UI.WebControls.WebParts;

namespace Translator_CS
{
    [DefaultProperty("Text")]
    public class Translator_CS :WebPart
    {
        private string pStrText = "";
        private TextBox txtStringToTranslate;
        private Label lblTranslatedString;
        public Translator_CS()
        {
            this.AllowClose = true;
        }
        [Personalizable(PersonalizationScope.User), WebBrowsable()]
        public string strToTranslate
        {
            get
            {
                return pStrText;
            }
            set
            {
                pStrText = value;
            }
        }

        protected override void CreateChildControls()
        {
            Controls.Clear();
            txtStringToTranslate = new TextBox();
            txtStringToTranslate.Text = this.strToTranslate;
            this.Controls.Add(txtStringToTranslate);

            Button btnTranslate = new Button();
            btnTranslate.Text = "Translate";
            btnTranslate.Click += new EventHandler(btnTranslate_Click);
            this.Controls.Add(btnTranslate);

            lblTranslatedString = new Label();
            lblTranslatedString.BackColor = System.Drawing.Color.Yellow;
            this.Controls.Add(lblTranslatedString);
            ChildControlsCreated = true;
        }
        private void btnTranslate_Click(Object sender, EventArgs e)
        {
            if (txtStringToTranslate.Text != String.Empty )
            {
            this.strToTranslate = txtStringToTranslate.Text;
            txtStringToTranslate.Text = String.Empty;

            
            //Dim ws As New TranslatorWebService.TranslateService
            LangaugeTranslator.TranslateService Trans = new global::Translator_CS.LangaugeTranslator.TranslateService();

            lblTranslatedString.Text = "<br/>" + this.strToTranslate + "-->" + 
                Trans.Translate(global::Translator_CS.LangaugeTranslator.Language.EnglishTOJapanese,this.strToTranslate);
            }
        }

    }
}
