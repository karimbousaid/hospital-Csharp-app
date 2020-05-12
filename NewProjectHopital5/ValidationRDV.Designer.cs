namespace NewProjectHopital5
{
    partial class ValidationRDV
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
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.HeureRDVtxt = new System.Windows.Forms.MaskedTextBox();
            this.label7 = new System.Windows.Forms.Label();
            this.DateRDV = new System.Windows.Forms.DateTimePicker();
            this.label6 = new System.Windows.Forms.Label();
            this.button2 = new System.Windows.Forms.Button();
            this.checkBoxValide = new System.Windows.Forms.CheckBox();
            this.groupBox3 = new System.Windows.Forms.GroupBox();
            this.button3 = new System.Windows.Forms.Button();
            this.CodePtxt = new System.Windows.Forms.TextBox();
            this.label8 = new System.Windows.Forms.Label();
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.Column1 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column2 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column3 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column4 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column5 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column6 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column7 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.groupBox2.SuspendLayout();
            this.groupBox3.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            this.SuspendLayout();
            // 
            // groupBox2
            // 
            this.groupBox2.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(128)))));
            this.groupBox2.Controls.Add(this.HeureRDVtxt);
            this.groupBox2.Controls.Add(this.label7);
            this.groupBox2.Controls.Add(this.DateRDV);
            this.groupBox2.Controls.Add(this.label6);
            this.groupBox2.Controls.Add(this.button2);
            this.groupBox2.Controls.Add(this.checkBoxValide);
            this.groupBox2.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.groupBox2.Location = new System.Drawing.Point(11, 258);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(953, 174);
            this.groupBox2.TabIndex = 3;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "Valider le Passement de Patient";
            // 
            // HeureRDVtxt
            // 
            this.HeureRDVtxt.Location = new System.Drawing.Point(373, 84);
            this.HeureRDVtxt.Mask = "00:00";
            this.HeureRDVtxt.Name = "HeureRDVtxt";
            this.HeureRDVtxt.Size = new System.Drawing.Size(271, 29);
            this.HeureRDVtxt.TabIndex = 20;
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(304, 35);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(48, 24);
            this.label7.TabIndex = 19;
            this.label7.Text = "Date";
            // 
            // DateRDV
            // 
            this.DateRDV.Format = System.Windows.Forms.DateTimePickerFormat.Short;
            this.DateRDV.Location = new System.Drawing.Point(373, 31);
            this.DateRDV.Name = "DateRDV";
            this.DateRDV.Size = new System.Drawing.Size(271, 29);
            this.DateRDV.TabIndex = 18;
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(304, 84);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(63, 24);
            this.label6.TabIndex = 16;
            this.label6.Text = "Heure";
            // 
            // button2
            // 
            this.button2.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            this.button2.Location = new System.Drawing.Point(742, 58);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(130, 34);
            this.button2.TabIndex = 15;
            this.button2.Text = "Enregestrer";
            this.button2.UseVisualStyleBackColor = false;
            this.button2.Click += new System.EventHandler(this.button2_Click);
            // 
            // checkBoxValide
            // 
            this.checkBoxValide.AutoSize = true;
            this.checkBoxValide.Location = new System.Drawing.Point(402, 128);
            this.checkBoxValide.Name = "checkBoxValide";
            this.checkBoxValide.Size = new System.Drawing.Size(82, 28);
            this.checkBoxValide.TabIndex = 0;
            this.checkBoxValide.Text = "Valide";
            this.checkBoxValide.UseVisualStyleBackColor = true;
            // 
            // groupBox3
            // 
            this.groupBox3.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(128)))));
            this.groupBox3.Controls.Add(this.button3);
            this.groupBox3.Controls.Add(this.CodePtxt);
            this.groupBox3.Controls.Add(this.label8);
            this.groupBox3.Controls.Add(this.dataGridView1);
            this.groupBox3.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.groupBox3.Location = new System.Drawing.Point(11, 12);
            this.groupBox3.Name = "groupBox3";
            this.groupBox3.Size = new System.Drawing.Size(959, 240);
            this.groupBox3.TabIndex = 4;
            this.groupBox3.TabStop = false;
            this.groupBox3.Text = "Rendez-vous par Patient";
            // 
            // button3
            // 
            this.button3.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            this.button3.Location = new System.Drawing.Point(585, 36);
            this.button3.Name = "button3";
            this.button3.Size = new System.Drawing.Size(120, 32);
            this.button3.TabIndex = 17;
            this.button3.Text = "Rechercher";
            this.button3.UseVisualStyleBackColor = false;
            this.button3.Click += new System.EventHandler(this.button3_Click);
            // 
            // CodePtxt
            // 
            this.CodePtxt.Location = new System.Drawing.Point(304, 37);
            this.CodePtxt.Name = "CodePtxt";
            this.CodePtxt.Size = new System.Drawing.Size(218, 24);
            this.CodePtxt.TabIndex = 16;
            this.CodePtxt.TextChanged += new System.EventHandler(this.textBox7_TextChanged);
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Location = new System.Drawing.Point(206, 40);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(44, 18);
            this.label8.TabIndex = 15;
            this.label8.Text = "Code";
            // 
            // dataGridView1
            // 
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.Column1,
            this.Column2,
            this.Column3,
            this.Column4,
            this.Column5,
            this.Column6,
            this.Column7});
            this.dataGridView1.Location = new System.Drawing.Point(17, 76);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.ReadOnly = true;
            this.dataGridView1.Size = new System.Drawing.Size(936, 158);
            this.dataGridView1.TabIndex = 0;
            // 
            // Column1
            // 
            this.Column1.HeaderText = "Nom Patient";
            this.Column1.Name = "Column1";
            this.Column1.ReadOnly = true;
            // 
            // Column2
            // 
            this.Column2.HeaderText = "PrénomP";
            this.Column2.Name = "Column2";
            this.Column2.ReadOnly = true;
            // 
            // Column3
            // 
            this.Column3.HeaderText = "NomM";
            this.Column3.Name = "Column3";
            this.Column3.ReadOnly = true;
            // 
            // Column4
            // 
            this.Column4.HeaderText = "prénomM";
            this.Column4.Name = "Column4";
            this.Column4.ReadOnly = true;
            // 
            // Column5
            // 
            this.Column5.HeaderText = "Spécialité";
            this.Column5.Name = "Column5";
            this.Column5.ReadOnly = true;
            // 
            // Column6
            // 
            this.Column6.HeaderText = "Date RDV";
            this.Column6.Name = "Column6";
            this.Column6.ReadOnly = true;
            // 
            // Column7
            // 
            this.Column7.HeaderText = "Heure RDV";
            this.Column7.Name = "Column7";
            this.Column7.ReadOnly = true;
            // 
            // ValidationRDV
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.DarkSeaGreen;
            this.ClientSize = new System.Drawing.Size(982, 437);
            this.Controls.Add(this.groupBox3);
            this.Controls.Add(this.groupBox2);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.MaximizeBox = false;
            this.Name = "ValidationRDV";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Validation de Rendez-Vous";
            this.groupBox2.ResumeLayout(false);
            this.groupBox2.PerformLayout();
            this.groupBox3.ResumeLayout(false);
            this.groupBox3.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.Button button2;
        private System.Windows.Forms.CheckBox checkBoxValide;
        private System.Windows.Forms.GroupBox groupBox3;
        private System.Windows.Forms.DataGridView dataGridView1;
        private System.Windows.Forms.Button button3;
        private System.Windows.Forms.TextBox CodePtxt;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.DateTimePicker DateRDV;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.MaskedTextBox HeureRDVtxt;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column1;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column2;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column3;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column4;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column5;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column6;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column7;
    }
}