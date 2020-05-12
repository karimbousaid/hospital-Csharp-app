namespace NewProjectHopital5
{
    partial class Statistique
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
            Microsoft.Reporting.WinForms.ReportDataSource reportDataSource1 = new Microsoft.Reporting.WinForms.ReportDataSource();
            this.reportViewer1 = new Microsoft.Reporting.WinForms.ReportViewer();
            this.EtatDePassmentBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.ImpressionRDV = new NewProjectHopital5.ImpressionRDV();
            this.EtatDePassmentTableAdapter = new NewProjectHopital5.ImpressionRDVTableAdapters.EtatDePassmentTableAdapter();
            this.label1 = new System.Windows.Forms.Label();
            this.textBox1 = new System.Windows.Forms.TextBox();
            this.button1 = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.EtatDePassmentBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.ImpressionRDV)).BeginInit();
            this.SuspendLayout();
            // 
            // reportViewer1
            // 
            reportDataSource1.Name = "DataSet1";
            reportDataSource1.Value = this.EtatDePassmentBindingSource;
            this.reportViewer1.LocalReport.DataSources.Add(reportDataSource1);
            this.reportViewer1.LocalReport.ReportEmbeddedResource = "NewProjectHopital5.Report2.rdlc";
            this.reportViewer1.Location = new System.Drawing.Point(1, 58);
            this.reportViewer1.Name = "reportViewer1";
            this.reportViewer1.Size = new System.Drawing.Size(757, 266);
            this.reportViewer1.TabIndex = 0;
            // 
            // EtatDePassmentBindingSource
            // 
            this.EtatDePassmentBindingSource.DataMember = "EtatDePassment";
            this.EtatDePassmentBindingSource.DataSource = this.ImpressionRDV;
            // 
            // ImpressionRDV
            // 
            this.ImpressionRDV.DataSetName = "ImpressionRDV";
            this.ImpressionRDV.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // EtatDePassmentTableAdapter
            // 
            this.EtatDePassmentTableAdapter.ClearBeforeFill = true;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(176, 21);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(99, 13);
            this.label1.TabIndex = 1;
            this.label1.Text = "Date Rendez_vous";
            // 
            // textBox1
            // 
            this.textBox1.Location = new System.Drawing.Point(293, 18);
            this.textBox1.Name = "textBox1";
            this.textBox1.Size = new System.Drawing.Size(179, 20);
            this.textBox1.TabIndex = 2;
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(508, 15);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(77, 24);
            this.button1.TabIndex = 3;
            this.button1.Text = "Affiche";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // Statistique
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(760, 322);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.textBox1);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.reportViewer1);
            this.Name = "Statistique";
            this.Text = "Statistique";
            this.Load += new System.EventHandler(this.Statistique_Load);
            ((System.ComponentModel.ISupportInitialize)(this.EtatDePassmentBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.ImpressionRDV)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private Microsoft.Reporting.WinForms.ReportViewer reportViewer1;
        private System.Windows.Forms.BindingSource EtatDePassmentBindingSource;
        private ImpressionRDV ImpressionRDV;
        private ImpressionRDVTableAdapters.EtatDePassmentTableAdapter EtatDePassmentTableAdapter;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox textBox1;
        private System.Windows.Forms.Button button1;
    }
}