namespace NewProjectHopital5
{
    partial class UpdatePassword2
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
            this.label3 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.Jobtxt = new System.Windows.Forms.ComboBox();
            this.Passwordtxt = new System.Windows.Forms.TextBox();
            this.Usertxt = new System.Windows.Forms.TextBox();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.label4 = new System.Windows.Forms.Label();
            this.EmailUser = new System.Windows.Forms.TextBox();
            this.groupBox1.SuspendLayout();
            this.groupBox2.SuspendLayout();
            this.SuspendLayout();
            // 
            // groupBox1
            // 
            this.groupBox1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(128)))));
            this.groupBox1.Controls.Add(this.button1);
            this.groupBox1.Controls.Add(this.label3);
            this.groupBox1.Controls.Add(this.label2);
            this.groupBox1.Controls.Add(this.label1);
            this.groupBox1.Controls.Add(this.Jobtxt);
            this.groupBox1.Controls.Add(this.Passwordtxt);
            this.groupBox1.Controls.Add(this.Usertxt);
            this.groupBox1.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.groupBox1.Location = new System.Drawing.Point(12, 73);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(506, 249);
            this.groupBox1.TabIndex = 0;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Modifier";
            // 
            // button1
            // 
            this.button1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            this.button1.Location = new System.Drawing.Point(374, 198);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(105, 33);
            this.button1.TabIndex = 6;
            this.button1.Text = "Save";
            this.button1.UseVisualStyleBackColor = false;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(101, 151);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(41, 24);
            this.label3.TabIndex = 5;
            this.label3.Text = "Job";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(92, 88);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(92, 24);
            this.label2.TabIndex = 4;
            this.label2.Text = "Password";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(117, 43);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(49, 24);
            this.label1.TabIndex = 3;
            this.label1.Text = "User";
            // 
            // Jobtxt
            // 
            this.Jobtxt.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.Jobtxt.FormattingEnabled = true;
            this.Jobtxt.Items.AddRange(new object[] {
            "Admin",
            "Emploiyée",
            "Medecin"});
            this.Jobtxt.Location = new System.Drawing.Point(199, 148);
            this.Jobtxt.Name = "Jobtxt";
            this.Jobtxt.Size = new System.Drawing.Size(280, 32);
            this.Jobtxt.TabIndex = 2;
            // 
            // Passwordtxt
            // 
            this.Passwordtxt.Location = new System.Drawing.Point(199, 88);
            this.Passwordtxt.Name = "Passwordtxt";
            this.Passwordtxt.Size = new System.Drawing.Size(280, 29);
            this.Passwordtxt.TabIndex = 1;
            // 
            // Usertxt
            // 
            this.Usertxt.Location = new System.Drawing.Point(199, 38);
            this.Usertxt.Name = "Usertxt";
            this.Usertxt.Size = new System.Drawing.Size(280, 29);
            this.Usertxt.TabIndex = 0;
            // 
            // groupBox2
            // 
            this.groupBox2.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(128)))));
            this.groupBox2.Controls.Add(this.label4);
            this.groupBox2.Controls.Add(this.EmailUser);
            this.groupBox2.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.groupBox2.Location = new System.Drawing.Point(12, 5);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(505, 62);
            this.groupBox2.TabIndex = 1;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "Confirmer l\'email une autre fois";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(131, 30);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(48, 20);
            this.label4.TabIndex = 8;
            this.label4.Text = "Email";
            // 
            // EmailUser
            // 
            this.EmailUser.Location = new System.Drawing.Point(199, 29);
            this.EmailUser.Multiline = true;
            this.EmailUser.Name = "EmailUser";
            this.EmailUser.Size = new System.Drawing.Size(275, 25);
            this.EmailUser.TabIndex = 7;
            // 
            // UpdatePassword2
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.DarkSeaGreen;
            this.ClientSize = new System.Drawing.Size(529, 334);
            this.Controls.Add(this.groupBox2);
            this.Controls.Add(this.groupBox1);
            this.Name = "UpdatePassword2";
            this.Text = "Modifier mode pass";
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.groupBox2.ResumeLayout(false);
            this.groupBox2.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.ComboBox Jobtxt;
        private System.Windows.Forms.TextBox Passwordtxt;
        private System.Windows.Forms.TextBox Usertxt;
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.TextBox EmailUser;
    }
}