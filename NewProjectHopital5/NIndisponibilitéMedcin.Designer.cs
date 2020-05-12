namespace NewProjectHopital5
{
    partial class NIndisponibilitéMedcin
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
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.button1 = new System.Windows.Forms.Button();
            this.DateFtxt = new System.Windows.Forms.DateTimePicker();
            this.DateDtxt = new System.Windows.Forms.DateTimePicker();
            this.CodeMtxt = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.groupBox1.SuspendLayout();
            this.SuspendLayout();
            // 
            // groupBox1
            // 
            this.groupBox1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(128)))));
            this.groupBox1.Controls.Add(this.button1);
            this.groupBox1.Controls.Add(this.DateFtxt);
            this.groupBox1.Controls.Add(this.DateDtxt);
            this.groupBox1.Controls.Add(this.CodeMtxt);
            this.groupBox1.Controls.Add(this.label3);
            this.groupBox1.Controls.Add(this.label2);
            this.groupBox1.Controls.Add(this.label1);
            this.groupBox1.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.groupBox1.Location = new System.Drawing.Point(12, 12);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(494, 288);
            this.groupBox1.TabIndex = 0;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Metrre un Nouveau Indisponibilité";
            // 
            // button1
            // 
            this.button1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            this.button1.Location = new System.Drawing.Point(334, 230);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(111, 30);
            this.button1.TabIndex = 6;
            this.button1.Text = "Save";
            this.button1.UseVisualStyleBackColor = false;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // DateFtxt
            // 
            this.DateFtxt.Format = System.Windows.Forms.DateTimePickerFormat.Short;
            this.DateFtxt.Location = new System.Drawing.Point(221, 167);
            this.DateFtxt.Name = "DateFtxt";
            this.DateFtxt.Size = new System.Drawing.Size(224, 29);
            this.DateFtxt.TabIndex = 5;
            // 
            // DateDtxt
            // 
            this.DateDtxt.Format = System.Windows.Forms.DateTimePickerFormat.Short;
            this.DateDtxt.Location = new System.Drawing.Point(221, 101);
            this.DateDtxt.Name = "DateDtxt";
            this.DateDtxt.Size = new System.Drawing.Size(224, 29);
            this.DateDtxt.TabIndex = 4;
            // 
            // CodeMtxt
            // 
            this.CodeMtxt.Location = new System.Drawing.Point(221, 48);
            this.CodeMtxt.Name = "CodeMtxt";
            this.CodeMtxt.Size = new System.Drawing.Size(224, 29);
            this.CodeMtxt.TabIndex = 3;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(64, 167);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(78, 24);
            this.label3.TabIndex = 2;
            this.label3.Text = "date Fin";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(64, 101);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(101, 24);
            this.label2.TabIndex = 1;
            this.label2.Text = "date Début";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(64, 48);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(135, 24);
            this.label1.TabIndex = 0;
            this.label1.Text = "Code Medecin";
            // 
            // NIndisponibilitéMedcin
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.DarkSeaGreen;
            this.ClientSize = new System.Drawing.Size(518, 312);
            this.Controls.Add(this.groupBox1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.MaximizeBox = false;
            this.Name = "NIndisponibilitéMedcin";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "NIndisponibilitéMedcin";
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.DateTimePicker DateFtxt;
        private System.Windows.Forms.DateTimePicker DateDtxt;
        private System.Windows.Forms.TextBox CodeMtxt;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
    }
}