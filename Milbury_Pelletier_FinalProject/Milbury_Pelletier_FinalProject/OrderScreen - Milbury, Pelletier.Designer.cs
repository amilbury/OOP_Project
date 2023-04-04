namespace Milbury_Pelletier_FinalProject
{
    partial class OrderScreen_Milbury_Pelletier
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(OrderScreen_Milbury_Pelletier));
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.lstProducts = new System.Windows.Forms.ListBox();
            this.cboCarType = new System.Windows.Forms.ComboBox();
            this.lblCarType = new System.Windows.Forms.Label();
            this.lblProducts = new System.Windows.Forms.Label();
            this.btnCheckout = new System.Windows.Forms.Button();
            this.btnCart = new System.Windows.Forms.Button();
            this.listBox1 = new System.Windows.Forms.ListBox();
            this.label1 = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // pictureBox1
            // 
            this.pictureBox1.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox1.Image")));
            this.pictureBox1.Location = new System.Drawing.Point(556, 8);
            this.pictureBox1.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(67, 68);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pictureBox1.TabIndex = 7;
            this.pictureBox1.TabStop = false;
            // 
            // lstProducts
            // 
            this.lstProducts.FormattingEnabled = true;
            this.lstProducts.Location = new System.Drawing.Point(27, 168);
            this.lstProducts.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.lstProducts.Name = "lstProducts";
            this.lstProducts.Size = new System.Drawing.Size(238, 186);
            this.lstProducts.TabIndex = 8;
            // 
            // cboCarType
            // 
            this.cboCarType.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cboCarType.FormattingEnabled = true;
            this.cboCarType.Location = new System.Drawing.Point(27, 70);
            this.cboCarType.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.cboCarType.Name = "cboCarType";
            this.cboCarType.Size = new System.Drawing.Size(82, 21);
            this.cboCarType.TabIndex = 9;
            // 
            // lblCarType
            // 
            this.lblCarType.AllowDrop = true;
            this.lblCarType.AutoSize = true;
            this.lblCarType.Location = new System.Drawing.Point(25, 47);
            this.lblCarType.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.lblCarType.Name = "lblCarType";
            this.lblCarType.Size = new System.Drawing.Size(89, 13);
            this.lblCarType.TabIndex = 10;
            this.lblCarType.Text = "Choose Car Type";
            // 
            // lblProducts
            // 
            this.lblProducts.AutoSize = true;
            this.lblProducts.Location = new System.Drawing.Point(114, 145);
            this.lblProducts.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.lblProducts.Name = "lblProducts";
            this.lblProducts.Size = new System.Drawing.Size(49, 13);
            this.lblProducts.TabIndex = 11;
            this.lblProducts.Text = "Products";
            // 
            // btnCheckout
            // 
            this.btnCheckout.Location = new System.Drawing.Point(292, 331);
            this.btnCheckout.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.btnCheckout.Name = "btnCheckout";
            this.btnCheckout.Size = new System.Drawing.Size(68, 23);
            this.btnCheckout.TabIndex = 12;
            this.btnCheckout.Text = "Checkout";
            this.btnCheckout.UseVisualStyleBackColor = true;
            // 
            // btnCart
            // 
            this.btnCart.Location = new System.Drawing.Point(292, 168);
            this.btnCart.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.btnCart.Name = "btnCart";
            this.btnCart.Size = new System.Drawing.Size(68, 23);
            this.btnCart.TabIndex = 13;
            this.btnCart.Text = "Add to cart";
            this.btnCart.UseVisualStyleBackColor = true;
            // 
            // listBox1
            // 
            this.listBox1.FormattingEnabled = true;
            this.listBox1.Location = new System.Drawing.Point(385, 168);
            this.listBox1.Margin = new System.Windows.Forms.Padding(2);
            this.listBox1.Name = "listBox1";
            this.listBox1.Size = new System.Drawing.Size(238, 186);
            this.listBox1.TabIndex = 14;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(491, 145);
            this.label1.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(49, 13);
            this.label1.TabIndex = 15;
            this.label1.Text = "Products";
            // 
            // OrderScreen_Milbury_Pelletier
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.ClientSize = new System.Drawing.Size(631, 368);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.listBox1);
            this.Controls.Add(this.btnCart);
            this.Controls.Add(this.btnCheckout);
            this.Controls.Add(this.lblProducts);
            this.Controls.Add(this.lblCarType);
            this.Controls.Add(this.cboCarType);
            this.Controls.Add(this.lstProducts);
            this.Controls.Add(this.pictureBox1);
            this.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.Name = "OrderScreen_Milbury_Pelletier";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "OrderScreen_Milbury_Pelletier";
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.ListBox lstProducts;
        private System.Windows.Forms.ComboBox cboCarType;
        private System.Windows.Forms.Label lblCarType;
        private System.Windows.Forms.Label lblProducts;
        private System.Windows.Forms.Button btnCheckout;
        private System.Windows.Forms.Button btnCart;
        private System.Windows.Forms.ListBox listBox1;
        private System.Windows.Forms.Label label1;
    }
}