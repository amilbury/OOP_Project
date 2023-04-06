namespace Milbury_Pelletier_FinalProject
{
    partial class CheckoutForm_Milbury_Pelletier
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(CheckoutForm_Milbury_Pelletier));
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.label1 = new System.Windows.Forms.Label();
            this.btnPrint = new System.Windows.Forms.Button();
            this.btnRemoveItem = new System.Windows.Forms.Button();
            this.btnBack = new System.Windows.Forms.Button();
            this.lstCheckout = new System.Windows.Forms.ListBox();
            this.sfdReceipt = new System.Windows.Forms.SaveFileDialog();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // pictureBox1
            // 
            this.pictureBox1.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox1.Image")));
            this.pictureBox1.Location = new System.Drawing.Point(576, 8);
            this.pictureBox1.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(67, 68);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pictureBox1.TabIndex = 7;
            this.pictureBox1.TabStop = false;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(247, 26);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(127, 13);
            this.label1.TabIndex = 9;
            this.label1.Text = "Item\'s to be Checked Out";
            // 
            // btnPrint
            // 
            this.btnPrint.Location = new System.Drawing.Point(134, 338);
            this.btnPrint.Name = "btnPrint";
            this.btnPrint.Size = new System.Drawing.Size(95, 40);
            this.btnPrint.TabIndex = 10;
            this.btnPrint.Text = "Print Receipt";
            this.btnPrint.UseVisualStyleBackColor = true;
            this.btnPrint.Click += new System.EventHandler(this.btnPrint_Click);
            // 
            // btnRemoveItem
            // 
            this.btnRemoveItem.Location = new System.Drawing.Point(385, 338);
            this.btnRemoveItem.Name = "btnRemoveItem";
            this.btnRemoveItem.Size = new System.Drawing.Size(94, 40);
            this.btnRemoveItem.TabIndex = 11;
            this.btnRemoveItem.Text = "Remove Items";
            this.btnRemoveItem.UseVisualStyleBackColor = true;
            // 
            // btnBack
            // 
            this.btnBack.Location = new System.Drawing.Point(262, 338);
            this.btnBack.Name = "btnBack";
            this.btnBack.Size = new System.Drawing.Size(95, 40);
            this.btnBack.TabIndex = 12;
            this.btnBack.Text = "Back";
            this.btnBack.UseVisualStyleBackColor = true;
            // 
            // lstCheckout
            // 
            this.lstCheckout.FormattingEnabled = true;
            this.lstCheckout.Location = new System.Drawing.Point(79, 53);
            this.lstCheckout.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.lstCheckout.Name = "lstCheckout";
            this.lstCheckout.Size = new System.Drawing.Size(475, 264);
            this.lstCheckout.TabIndex = 13;
            // 
            // sfdReceipt
            // 
            this.sfdReceipt.DefaultExt = "txt";
            this.sfdReceipt.FileName = "Receipt";
            // 
            // CheckoutForm_Milbury_Pelletier
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.ClientSize = new System.Drawing.Size(651, 450);
            this.Controls.Add(this.lstCheckout);
            this.Controls.Add(this.btnBack);
            this.Controls.Add(this.btnRemoveItem);
            this.Controls.Add(this.btnPrint);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.pictureBox1);
            this.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.Name = "CheckoutForm_Milbury_Pelletier";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "CheckoutForm_Milbury_Pelletier";
            this.Load += new System.EventHandler(this.CheckoutForm_Milbury_Pelletier_Load);
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button btnPrint;
        private System.Windows.Forms.Button btnRemoveItem;
        private System.Windows.Forms.Button btnBack;
        private System.Windows.Forms.ListBox lstCheckout;
        private System.Windows.Forms.SaveFileDialog sfdReceipt;
    }
}