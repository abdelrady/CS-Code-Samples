namespace FRImages
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
            this.components = new System.ComponentModel.Container();
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.vLDemoDataSet = new FRImages.VLDemoDataSet();
            this.facesBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.facesTableAdapter = new FRImages.VLDemoDataSetTableAdapters.FacesTableAdapter();
            this.iDDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.featuresDataGridViewImageColumn = new System.Windows.Forms.DataGridViewImageColumn();
            this.faceIDDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.vLDemoDataSet)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.facesBindingSource)).BeginInit();
            this.SuspendLayout();
            // 
            // dataGridView1
            // 
            this.dataGridView1.AutoGenerateColumns = false;
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.iDDataGridViewTextBoxColumn,
            this.featuresDataGridViewImageColumn,
            this.faceIDDataGridViewTextBoxColumn});
            this.dataGridView1.DataSource = this.facesBindingSource;
            this.dataGridView1.Location = new System.Drawing.Point(0, 0);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.Size = new System.Drawing.Size(729, 377);
            this.dataGridView1.TabIndex = 0;
            // 
            // vLDemoDataSet
            // 
            this.vLDemoDataSet.DataSetName = "VLDemoDataSet";
            this.vLDemoDataSet.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // facesBindingSource
            // 
            this.facesBindingSource.DataMember = "Faces";
            this.facesBindingSource.DataSource = this.vLDemoDataSet;
            // 
            // facesTableAdapter
            // 
            this.facesTableAdapter.ClearBeforeFill = true;
            // 
            // iDDataGridViewTextBoxColumn
            // 
            this.iDDataGridViewTextBoxColumn.DataPropertyName = "ID";
            this.iDDataGridViewTextBoxColumn.HeaderText = "ID";
            this.iDDataGridViewTextBoxColumn.Name = "iDDataGridViewTextBoxColumn";
            // 
            // featuresDataGridViewImageColumn
            // 
            this.featuresDataGridViewImageColumn.DataPropertyName = "Features";
            this.featuresDataGridViewImageColumn.HeaderText = "Features";
            this.featuresDataGridViewImageColumn.Name = "featuresDataGridViewImageColumn";
            // 
            // faceIDDataGridViewTextBoxColumn
            // 
            this.faceIDDataGridViewTextBoxColumn.DataPropertyName = "FaceID";
            this.faceIDDataGridViewTextBoxColumn.HeaderText = "FaceID";
            this.faceIDDataGridViewTextBoxColumn.Name = "faceIDDataGridViewTextBoxColumn";
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(741, 389);
            this.Controls.Add(this.dataGridView1);
            this.Name = "Form1";
            this.Text = "Form1";
            this.Load += new System.EventHandler(this.Form1_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.vLDemoDataSet)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.facesBindingSource)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.DataGridView dataGridView1;
        private VLDemoDataSet vLDemoDataSet;
        private System.Windows.Forms.BindingSource facesBindingSource;
        private FRImages.VLDemoDataSetTableAdapters.FacesTableAdapter facesTableAdapter;
        private System.Windows.Forms.DataGridViewTextBoxColumn iDDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewImageColumn featuresDataGridViewImageColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn faceIDDataGridViewTextBoxColumn;
    }
}

