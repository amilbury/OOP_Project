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
            this.lblAdmin = new System.Windows.Forms.Label();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.btnRemove = new System.Windows.Forms.Button();
            this.btnAdd = new System.Windows.Forms.Button();
            this.btnHide = new System.Windows.Forms.Button();
            this.label4 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.radControlPanel = new System.Windows.Forms.RadioButton();
            this.btnLogout = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.groupBox1.SuspendLayout();
            this.SuspendLayout();
            // 
            // pictureBox1
            // 
            this.pictureBox1.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox1.Image")));
            this.pictureBox1.Location = new System.Drawing.Point(886, 5);
            this.pictureBox1.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(89, 84);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pictureBox1.TabIndex = 7;
            this.pictureBox1.TabStop = false;
            // 
            // lstProducts
            // 
            this.lstProducts.FormattingEnabled = true;
            this.lstProducts.ItemHeight = 16;
            this.lstProducts.Location = new System.Drawing.Point(24, 218);
            this.lstProducts.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.lstProducts.Name = "lstProducts";
            this.lstProducts.Size = new System.Drawing.Size(442, 228);
            this.lstProducts.TabIndex = 8;
            // 
            // cboCarType
            // 
            this.cboCarType.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cboCarType.FormattingEnabled = true;
            this.cboCarType.Location = new System.Drawing.Point(149, 98);
            this.cboCarType.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.cboCarType.Name = "cboCarType";
            this.cboCarType.Size = new System.Drawing.Size(139, 24);
            this.cboCarType.TabIndex = 9;
            this.cboCarType.SelectedIndexChanged += new System.EventHandler(this.cboCarType_SelectedIndexChanged);
            // 
            // lblCarType
            // 
            this.lblCarType.AllowDrop = true;
            this.lblCarType.AutoSize = true;
            this.lblCarType.Location = new System.Drawing.Point(163, 70);
            this.lblCarType.Name = "lblCarType";
            this.lblCarType.Size = new System.Drawing.Size(113, 16);
            this.lblCarType.TabIndex = 10;
            this.lblCarType.Text = "Choose Car Type";
            // 
            // lblProducts
            // 
            this.lblProducts.AutoSize = true;
            this.lblProducts.Location = new System.Drawing.Point(196, 191);
            this.lblProducts.Name = "lblProducts";
            this.lblProducts.Size = new System.Drawing.Size(60, 16);
            this.lblProducts.TabIndex = 11;
            this.lblProducts.Text = "Products";
            // 
            // btnCheckout
            // 
            this.btnCheckout.Location = new System.Drawing.Point(534, 402);
            this.btnCheckout.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.btnCheckout.Name = "btnCheckout";
            this.btnCheckout.Size = new System.Drawing.Size(91, 28);
            this.btnCheckout.TabIndex = 12;
            this.btnCheckout.Text = "&Checkout";
            this.btnCheckout.UseVisualStyleBackColor = true;
            // 
            // btnCart
            // 
            this.btnCart.Location = new System.Drawing.Point(534, 202);
            this.btnCart.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.btnCart.Name = "btnCart";
            this.btnCart.Size = new System.Drawing.Size(91, 28);
            this.btnCart.TabIndex = 13;
            this.btnCart.Text = "Add to cart";
            this.btnCart.UseVisualStyleBackColor = true;
            // 
            // lblAdmin
            // 
            this.lblAdmin.AutoSize = true;
            this.lblAdmin.Location = new System.Drawing.Point(780, 173);
            this.lblAdmin.Name = "lblAdmin";
            this.lblAdmin.Size = new System.Drawing.Size(97, 16);
            this.lblAdmin.TabIndex = 15;
            this.lblAdmin.Text = "Admin Controls";
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.btnRemove);
            this.groupBox1.Controls.Add(this.btnAdd);
            this.groupBox1.Controls.Add(this.btnHide);
            this.groupBox1.Controls.Add(this.label4);
            this.groupBox1.Controls.Add(this.label3);
            this.groupBox1.Controls.Add(this.label2);
            this.groupBox1.Location = new System.Drawing.Point(656, 202);
            this.groupBox1.Margin = new System.Windows.Forms.Padding(4);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Padding = new System.Windows.Forms.Padding(4);
            this.groupBox1.Size = new System.Drawing.Size(297, 229);
            this.groupBox1.TabIndex = 16;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "grpAdminControls";
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
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(7, 160);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(163, 16);
            this.label4.TabIndex = 18;
            this.label4.Text = "Remove from Product List:";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(7, 98);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(121, 16);
            this.label3.TabIndex = 17;
            this.label3.Text = "Add to Product List:";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(7, 31);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(145, 16);
            this.label2.TabIndex = 16;
            this.label2.Text = "Hide Product From List:";
            // 
            // radControlPanel
            // 
            this.radControlPanel.AutoSize = true;
            this.radControlPanel.Location = new System.Drawing.Point(656, 167);
            this.radControlPanel.Margin = new System.Windows.Forms.Padding(4);
            this.radControlPanel.Name = "radControlPanel";
            this.radControlPanel.Size = new System.Drawing.Size(108, 20);
            this.radControlPanel.TabIndex = 17;
            this.radControlPanel.TabStop = true;
            this.radControlPanel.Text = "Control Panel";
            this.radControlPanel.UseVisualStyleBackColor = true;
            // 
            // btnLogout
            // 
            this.btnLogout.Location = new System.Drawing.Point(534, 294);
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
            this.ClientSize = new System.Drawing.Size(983, 463);
            this.Controls.Add(this.btnLogout);
            this.Controls.Add(this.radControlPanel);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.lblAdmin);
            this.Controls.Add(this.btnCart);
            this.Controls.Add(this.btnCheckout);
            this.Controls.Add(this.lblProducts);
            this.Controls.Add(this.lblCarType);
            this.Controls.Add(this.cboCarType);
            this.Controls.Add(this.lstProducts);
            this.Controls.Add(this.pictureBox1);
            this.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.Name = "OrderScreen_Milbury_Pelletier";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "OrderScreen_Milbury_Pelletier";
            this.Load += new System.EventHandler(this.OrderScreen_Milbury_Pelletier_Load);
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
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
        private System.Windows.Forms.Label lblAdmin;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.Button btnRemove;
        private System.Windows.Forms.Button btnAdd;
        private System.Windows.Forms.Button btnHide;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.RadioButton radControlPanel;
        private System.Windows.Forms.Button btnLogout;
    }
}