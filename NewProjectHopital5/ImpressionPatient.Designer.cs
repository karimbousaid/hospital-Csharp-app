namespace NewProjectHopital5
{
    partial class ImpressionPatient
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
            this.DataTable1BindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.ImpressionRDV = new NewProjectHopital5.ImpressionRDV();
            this.reportViewer1 = new Microsoft.Reporting.WinForms.ReportViewer();
            this.DataTable1TableAdapter = new NewProjectHopital5.ImpressionRDVTableAdapters.DataTable1TableAdapter();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.button2 = new System.Windows.Forms.Button();
            this.label3 = new System.Windows.Forms.Label();
            this.Spécialitétxt = new System.Windows.Forms.ComboBox();
            this.label2 = new System.Windows.Forms.Label();
            this.EtatRdvtxt = new System.Windows.Forms.ComboBox();
            this.label1 = new System.Windows.Forms.Label();
            this.DateRDVtxt = new System.Windows.Forms.DateTimePicker();
            this.button1 = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.DataTable1BindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.ImpressionRDV)).BeginInit();
            this.groupBox1.SuspendLayout();
            this.SuspendLayout();
            // 
            // DataTable1BindingSource
            // 
            this.DataTable1BindingSource.DataMember = "DataTable1";
            this.DataTable1BindingSource.DataSource = this.ImpressionRDV;
            // 
            // ImpressionRDV
            // 
            this.ImpressionRDV.DataSetName = "ImpressionRDV";
            this.ImpressionRDV.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // reportViewer1
            // 
            reportDataSource1.Name = "DataSet1";
            reportDataSource1.Value = this.DataTable1BindingSource;
            this.reportViewer1.LocalReport.DataSources.Add(reportDataSource1);
            this.reportViewer1.LocalReport.ReportEmbeddedResource = "NewProjectHopital5.Report1.rdlc";
            this.reportViewer1.Location = new System.Drawing.Point(12, 86);
            this.reportViewer1.Name = "reportViewer1";
            this.reportViewer1.Size = new System.Drawing.Size(1338, 629);
            this.reportViewer1.TabIndex = 0;
            // 
            // DataTable1TableAdapter
            // 
            this.DataTable1TableAdapter.ClearBeforeFill = true;
            // 
            // groupBox1
            // 
            this.groupBox1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(128)))));
            this.groupBox1.Controls.Add(this.button2);
            this.groupBox1.Controls.Add(this.label3);
            this.groupBox1.Controls.Add(this.Spécialitétxt);
            this.groupBox1.Controls.Add(this.label2);
            this.groupBox1.Controls.Add(this.EtatRdvtxt);
            this.groupBox1.Controls.Add(this.label1);
            this.groupBox1.Controls.Add(this.DateRDVtxt);
            this.groupBox1.Controls.Add(this.button1);
            this.groupBox1.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.groupBox1.Location = new System.Drawing.Point(12, 12);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(1330, 69);
            this.groupBox1.TabIndex = 1;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Imprimer Patient par";
            this.groupBox1.Enter += new System.EventHandler(this.groupBox1_Enter);
            // 
            // button2
            // 
            this.button2.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            this.button2.Location = new System.Drawing.Point(1209, 23);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(92, 35);
            this.button2.TabIndex = 7;
            this.button2.Text = "Close";
            this.button2.UseVisualStyleBackColor = false;
            this.button2.Click += new System.EventHandler(this.button2_Click);
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(746, 31);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(91, 24);
            this.label3.TabIndex = 6;
            this.label3.Text = "Spécialité";
            // 
            // Spécialitétxt
            // 
            this.Spécialitétxt.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            this.Spécialitétxt.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.Spécialitétxt.FormattingEnabled = true;
            this.Spécialitétxt.Location = new System.Drawing.Point(843, 27);
            this.Spécialitétxt.Name = "Spécialitétxt";
            this.Spécialitétxt.Size = new System.Drawing.Size(213, 32);
            this.Spécialitétxt.TabIndex = 5;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(386, 30);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(189, 24);
            this.label2.TabIndex = 4;
            this.label2.Text = "Etat de Rendez-Vous";
            // 
            // EtatRdvtxt
            // 
            this.EtatRdvtxt.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            this.EtatRdvtxt.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.EtatRdvtxt.FlatStyle = System.Windows.Forms.FlatStyle.System;
            this.EtatRdvtxt.FormattingEnabled = true;
            this.EtatRdvtxt.Items.AddRange(new object[] {
            "Valide",
            "No Valide"});
            this.EtatRdvtxt.Location = new System.Drawing.Point(581, 28);
            this.EtatRdvtxt.Name = "EtatRdvtxt";
            this.EtatRdvtxt.Size = new System.Drawing.Size(159, 32);
            this.EtatRdvtxt.TabIndex = 3;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(15, 30);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(169, 24);
            this.label1.TabIndex = 2;
            this.label1.Text = "Date Rendez-Vous";
            // 
            // DateRDVtxt
            // 
            this.DateRDVtxt.Format = System.Windows.Forms.DateTimePickerFormat.Short;
            this.DateRDVtxt.Location = new System.Drawing.Point(190, 28);
            this.DateRDVtxt.Name = "DateRDVtxt";
            this.DateRDVtxt.Size = new System.Drawing.Size(175, 29);
            this.DateRDVtxt.TabIndex = 1;
            // 
            // button1
            // 
            this.button1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            this.button1.Location = new System.Drawing.Point(1100, 24);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(103, 35);
            this.button1.TabIndex = 0;
            this.button1.Text = "Afficher";
            this.button1.UseVisualStyleBackColor = false;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // ImpressionPatient
            // 
            this.BackColor = System.Drawing.Color.DarkSeaGreen;
            this.ClientSize = new System.Drawing.Size(1354, 733);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.reportViewer1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedDialog;
            this.MaximizeBox = false;
            this.Name = "ImpressionPatient";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Imprimer les Rendez-Vous";
            this.Load += new System.EventHandler(this.ImpressionPatient_Load_1);
            ((System.ComponentModel.ISupportInitialize)(this.DataTable1BindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.ImpressionRDV)).EndInit();
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.ResumeLayout(false);

        }

        private Microsoft.Reporting.WinForms.ReportViewer reportViewer1;
        private System.Windows.Forms.BindingSource DataTable1BindingSource;
        private ImpressionRDV ImpressionRDV;
        private ImpressionRDVTableAdapters.DataTable1TableAdapter DataTable1TableAdapter;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.ComboBox Spécialitétxt;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.ComboBox EtatRdvtxt;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.DateTimePicker DateRDVtxt;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Button button2;


    }
        #endregion
}