namespace Milbury_Pelletier_FinalProject
{
    partial class CreateUser
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
            this.txtUsername = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.txtPassword = new System.Windows.Forms.TextBox();
            this.btncreateUser = new System.Windows.Forms.Button();
            this.btncancelProcess = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // txtUsername
            // 
            this.txtUsername.Location = new System.Drawing.Point(192, 51);
            this.txtUsername.Name = "txtUsername";
            this.txtUsername.Size = new System.Drawing.Size(194, 20);
            this.txtUsername.TabIndex = 0;
            this.txtUsername.Tag = "Usertag";
            // 
            // label1
            // 
            this.label1.Location = new System.Drawing.Point(226, 25);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(131, 23);
            this.label1.TabIndex = 1;
            this.label1.Text = "Please Enter Your Name";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(189, 112);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(197, 13);
            this.label2.TabIndex = 2;
            this.label2.Text = "Pick A Password - Between 1 - 10 chars";
            // 
            // txtPassword
            // 
            this.txtPassword.Location = new System.Drawing.Point(192, 147);
            this.txtPassword.Name = "txtPassword";
            this.txtPassword.PasswordChar = '*';
            this.txtPassword.Size = new System.Drawing.Size(194, 20);
            this.txtPassword.TabIndex = 3;
            this.txtPassword.Tag = "Passtag";
            this.txtPassword.UseSystemPasswordChar = true;
            // 
            // btncreateUser
            // 
            this.btncreateUser.Location = new System.Drawing.Point(220, 198);
            this.btncreateUser.Name = "btncreateUser";
            this.btncreateUser.Size = new System.Drawing.Size(128, 34);
            this.btncreateUser.TabIndex = 4;
            this.btncreateUser.Text = "Create New User";
            this.btncreateUser.UseVisualStyleBackColor = true;
            this.btncreateUser.Click += new System.EventHandler(this.btncreateUser_Click);
            // 
            // btncancelProcess
            // 
            this.btncancelProcess.Location = new System.Drawing.Point(229, 238);
            this.btncancelProcess.Name = "btncancelProcess";
            this.btncancelProcess.Size = new System.Drawing.Size(110, 24);
            this.btncancelProcess.TabIndex = 5;
            this.btncancelProcess.Text = "Cancel Process";
            this.btncancelProcess.UseVisualStyleBackColor = true;
            this.btncancelProcess.Click += new System.EventHandler(this.btncancelProcess_Click);
            // 
            // CreateUser
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.ClientSize = new System.Drawing.Size(584, 311);
            this.Controls.Add(this.btncancelProcess);
            this.Controls.Add(this.btncreateUser);
            this.Controls.Add(this.txtPassword);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.txtUsername);
            this.Name = "CreateUser";
            this.Text = "CreateUser";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox txtUsername;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox txtPassword;
        private System.Windows.Forms.Button btncreateUser;
        private System.Windows.Forms.Button btncancelProcess;
    }
}