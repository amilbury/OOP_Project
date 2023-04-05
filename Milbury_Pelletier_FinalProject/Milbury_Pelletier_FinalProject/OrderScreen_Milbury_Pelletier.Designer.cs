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
            this.picLogo = new System.Windows.Forms.PictureBox();
            this.lstProducts = new System.Windows.Forms.ListBox();
            this.cboCarType = new System.Windows.Forms.ComboBox();
            this.lblCarType = new System.Windows.Forms.Label();
            this.lblProducts = new System.Windows.Forms.Label();
            this.btnCheckout = new System.Windows.Forms.Button();
            this.btnCart = new System.Windows.Forms.Button();
            this.grpAdminControls = new System.Windows.Forms.GroupBox();
            this.btnRemove = new System.Windows.Forms.Button();
            this.btnAdd = new System.Windows.Forms.Button();
            this.btnHide = new System.Windows.Forms.Button();
            this.lblRemove = new System.Windows.Forms.Label();
            this.lblAdd = new System.Windows.Forms.Label();
            this.lblHide = new System.Windows.Forms.Label();
            this.btnLogout = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.picLogo)).BeginInit();
            this.grpAdminControls.SuspendLayout();
            this.SuspendLayout();
            // 
            // picLogo
            // 
            this.picLogo.Image = ((System.Drawing.Image)(resources.GetObject("picLogo.Image")));
            this.picLogo.Location = new System.Drawing.Point(953, 11);
            this.picLogo.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.picLogo.Name = "picLogo";
            this.picLogo.Size = new System.Drawing.Size(89, 84);
            this.picLogo.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.picLogo.TabIndex = 7;
            this.picLogo.TabStop = false;
            // 
            // lstProducts
            // 
            this.lstProducts.FormattingEnabled = true;
            this.lstProducts.ItemHeight = 16;
            this.lstProducts.Location = new System.Drawing.Point(12, 209);
            this.lstProducts.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.lstProducts.Name = "lstProducts";
            this.lstProducts.Size = new System.Drawing.Size(516, 228);
            this.lstProducts.TabIndex = 8;
            this.lstProducts.SelectedIndexChanged += new System.EventHandler(this.lstProducts_SelectedIndexChanged);
            // 
            // cboCarType
            // 
            this.cboCarType.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cboCarType.FormattingEnabled = true;
            this.cboCarType.Location = new System.Drawing.Point(177, 100);
            this.cboCarType.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.cboCarType.Name = "cboCarType";
            this.cboCarType.Size = new System.Drawing.Size(159, 24);
            this.cboCarType.TabIndex = 9;
            this.cboCarType.SelectedIndexChanged += new System.EventHandler(this.cboCarType_SelectedIndexChanged);
            // 
            // lblCarType
            // 
            this.lblCarType.AllowDrop = true;
            this.lblCarType.AutoSize = true;
            this.lblCarType.Location = new System.Drawing.Point(199, 72);
            this.lblCarType.Name = "lblCarType";
            this.lblCarType.Size = new System.Drawing.Size(113, 16);
            this.lblCarType.TabIndex = 10;
            this.lblCarType.Text = "Choose Car Type";
            // 
            // lblProducts
            // 
            this.lblProducts.AutoSize = true;
            this.lblProducts.Location = new System.Drawing.Point(229, 191);
            this.lblProducts.Name = "lblProducts";
            this.lblProducts.Size = new System.Drawing.Size(60, 16);
            this.lblProducts.TabIndex = 11;
            this.lblProducts.Text = "Products";
            // 
            // btnCheckout
            // 
            this.btnCheckout.Location = new System.Drawing.Point(601, 408);
            this.btnCheckout.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.btnCheckout.Name = "btnCheckout";
            this.btnCheckout.Size = new System.Drawing.Size(91, 28);
            this.btnCheckout.TabIndex = 12;
            this.btnCheckout.Text = "&Checkout";
            this.btnCheckout.UseVisualStyleBackColor = true;
            this.btnCheckout.Click += new System.EventHandler(this.btnCheckout_Click);
            // 
            // btnCart
            // 
            this.btnCart.Location = new System.Drawing.Point(601, 208);
            this.btnCart.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.btnCart.Name = "btnCart";
            this.btnCart.Size = new System.Drawing.Size(91, 28);
            this.btnCart.TabIndex = 13;
            this.btnCart.Text = "Add to cart";
            this.btnCart.UseVisualStyleBackColor = true;
            this.btnCart.Click += new System.EventHandler(this.btnCart_Click);
            // 
            // grpAdminControls
            // 
            this.grpAdminControls.Controls.Add(this.btnRemove);
            this.grpAdminControls.Controls.Add(this.btnAdd);
            this.grpAdminControls.Controls.Add(this.btnHide);
            this.grpAdminControls.Controls.Add(this.lblRemove);
            this.grpAdminControls.Controls.Add(this.lblAdd);
            this.grpAdminControls.Controls.Add(this.lblHide);
            this.grpAdminControls.Location = new System.Drawing.Point(723, 208);
            this.grpAdminControls.Margin = new System.Windows.Forms.Padding(4);
            this.grpAdminControls.Name = "grpAdminControls";
            this.grpAdminControls.Padding = new System.Windows.Forms.Padding(4);
            this.grpAdminControls.Size = new System.Drawing.Size(297, 229);
            this.grpAdminControls.TabIndex = 16;
            this.grpAdminControls.TabStop = false;
            this.grpAdminControls.Text = "Admin Controls";
            this.grpAdminControls.Visible = false;
            // 
            // btnRemove
            // 
            this.btnRemove.Location = new System.Drawing.Point(11, 178);
            this.btnRemove.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.btnRemove.Name = "btnRemove";
            this.btnRemove.Size = new System.Drawing.Size(129, 28);
            this.btnRemove.TabIndex = 21;
            this.btnRemove.Text = "Remove Product";
            this.btnRemove.UseVisualStyleBackColor = true;
            // 
            // btnAdd
            // 
            this.btnAdd.Location = new System.Drawing.Point(11, 117);
            this.btnAdd.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.btnAdd.Name = "btnAdd";
            this.btnAdd.Size = new System.Drawing.Size(129, 28);
            this.btnAdd.TabIndex = 20;
            this.btnAdd.Text = "Add Product";
            this.btnAdd.UseVisualStyleBackColor = true;
            // 
            // btnHide
            // 
            this.btnHide.Location = new System.Drawing.Point(11, 49);
            this.btnHide.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.btnHide.Name = "btnHide";
            this.btnHide.Size = new System.Drawing.Size(129, 28);
            this.btnHide.TabIndex = 19;
            this.btnHide.Text = "Hide Product";
            this.btnHide.UseVisualStyleBackColor = true;
            // 
            // lblRemove
            // 
            this.lblRemove.AutoSize = true;
            this.lblRemove.Location = new System.Drawing.Point(7, 160);
            this.lblRemove.Name = "lblRemove";
            this.lblRemove.Size = new System.Drawing.Size(163, 16);
            this.lblRemove.TabIndex = 18;
            this.lblRemove.Text = "Remove from Product List:";
            // 
            // lblAdd
            // 
            this.lblAdd.AutoSize = true;
            this.lblAdd.Location = new System.Drawing.Point(7, 98);
            this.lblAdd.Name = "lblAdd";
            this.lblAdd.Size = new System.Drawing.Size(121, 16);
            this.lblAdd.TabIndex = 17;
            this.lblAdd.Text = "Add to Product List:";
            // 
            // lblHide
            // 
            this.lblHide.AutoSize = true;
            this.lblHide.Location = new System.Drawing.Point(7, 31);
            this.lblHide.Name = "lblHide";
            this.lblHide.Size = new System.Drawing.Size(145, 16);
            this.lblHide.TabIndex = 16;
            this.lblHide.Text = "Hide Product From List:";
            // 
            // btnLogout
            // 
            this.btnLogout.Location = new System.Drawing.Point(601, 300);
            this.btnLogout.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.btnLogout.Name = "btnLogout";
            this.btnLogout.Size = new System.Drawing.Size(91, 28);
            this.btnLogout.TabIndex = 18;
            this.btnLogout.Text = "&Logout";
            this.btnLogout.UseVisualStyleBackColor = true;
            this.btnLogout.Click += new System.EventHandler(this.btnLogout_Click);
            // 
            // OrderScreen_Milbury_Pelletier
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.ClientSize = new System.Drawing.Size(1074, 463);
            this.Controls.Add(this.btnLogout);
            this.Controls.Add(this.grpAdminControls);
            this.Controls.Add(this.btnCart);
            this.Controls.Add(this.btnCheckout);
            this.Controls.Add(this.lblProducts);
            this.Controls.Add(this.lblCarType);
            this.Controls.Add(this.cboCarType);
            this.Controls.Add(this.lstProducts);
            this.Controls.Add(this.picLogo);
            this.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.Name = "OrderScreen_Milbury_Pelletier";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "OrderScreen_Milbury_Pelletier";
            this.Load += new System.EventHandler(this.OrderScreen_Milbury_Pelletier_Load);
            ((System.ComponentModel.ISupportInitialize)(this.picLogo)).EndInit();
            this.grpAdminControls.ResumeLayout(false);
            this.grpAdminControls.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.PictureBox picLogo;
        private System.Windows.Forms.ListBox lstProducts;
        private System.Windows.Forms.ComboBox cboCarType;
        private System.Windows.Forms.Label lblCarType;
        private System.Windows.Forms.Label lblProducts;
        private System.Windows.Forms.Button btnCheckout;
        private System.Windows.Forms.Button btnCart;
        private System.Windows.Forms.GroupBox grpAdminControls;
        private System.Windows.Forms.Button btnRemove;
        private System.Windows.Forms.Button btnAdd;
        private System.Windows.Forms.Button btnHide;
        private System.Windows.Forms.Label lblRemove;
        private System.Windows.Forms.Label lblAdd;
        private System.Windows.Forms.Label lblHide;
        private System.Windows.Forms.Button btnLogout;
    }
}