namespace Inventory_Management_App.Forms
{
    partial class EditProductsForm
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(EditProductsForm));
            Guna.UI2.WinForms.Suite.CustomizableEdges customizableEdges1 = new Guna.UI2.WinForms.Suite.CustomizableEdges();
            Guna.UI2.WinForms.Suite.CustomizableEdges customizableEdges2 = new Guna.UI2.WinForms.Suite.CustomizableEdges();
            Guna.UI2.WinForms.Suite.CustomizableEdges customizableEdges3 = new Guna.UI2.WinForms.Suite.CustomizableEdges();
            Guna.UI2.WinForms.Suite.CustomizableEdges customizableEdges4 = new Guna.UI2.WinForms.Suite.CustomizableEdges();
            Guna.UI2.WinForms.Suite.CustomizableEdges customizableEdges5 = new Guna.UI2.WinForms.Suite.CustomizableEdges();
            Guna.UI2.WinForms.Suite.CustomizableEdges customizableEdges6 = new Guna.UI2.WinForms.Suite.CustomizableEdges();
            Guna.UI2.WinForms.Suite.CustomizableEdges customizableEdges7 = new Guna.UI2.WinForms.Suite.CustomizableEdges();
            Guna.UI2.WinForms.Suite.CustomizableEdges customizableEdges8 = new Guna.UI2.WinForms.Suite.CustomizableEdges();
            Guna.UI2.WinForms.Suite.CustomizableEdges customizableEdges9 = new Guna.UI2.WinForms.Suite.CustomizableEdges();
            Guna.UI2.WinForms.Suite.CustomizableEdges customizableEdges10 = new Guna.UI2.WinForms.Suite.CustomizableEdges();
            Guna.UI2.WinForms.Suite.CustomizableEdges customizableEdges11 = new Guna.UI2.WinForms.Suite.CustomizableEdges();
            Guna.UI2.WinForms.Suite.CustomizableEdges customizableEdges12 = new Guna.UI2.WinForms.Suite.CustomizableEdges();
            Guna.UI2.WinForms.Suite.CustomizableEdges customizableEdges13 = new Guna.UI2.WinForms.Suite.CustomizableEdges();
            panel1 = new Panel();
            closeBtn = new Guna.UI2.WinForms.Guna2ImageButton();
            label1 = new Label();
            editProductBtn = new Guna.UI2.WinForms.Guna2Button();
            productCategory = new Guna.UI2.WinForms.Guna2ComboBox();
            label6 = new Label();
            productDesc = new Guna.UI2.WinForms.Guna2TextBox();
            label5 = new Label();
            productPrice = new Guna.UI2.WinForms.Guna2TextBox();
            label4 = new Label();
            productQty = new Guna.UI2.WinForms.Guna2TextBox();
            label3 = new Label();
            productName = new Guna.UI2.WinForms.Guna2TextBox();
            label2 = new Label();
            panel1.SuspendLayout();
            SuspendLayout();
            // 
            // panel1
            // 
            panel1.BackColor = Color.FromArgb(43, 119, 234);
            panel1.Controls.Add(closeBtn);
            panel1.Controls.Add(label1);
            panel1.Dock = DockStyle.Top;
            panel1.Location = new Point(0, 0);
            panel1.Name = "panel1";
            panel1.Size = new Size(764, 98);
            panel1.TabIndex = 13;
            panel1.Paint += panel1_Paint;
            // 
            // closeBtn
            // 
            closeBtn.CheckedState.ImageSize = new Size(64, 64);
            closeBtn.HoverState.ImageSize = new Size(64, 64);
            closeBtn.Image = (Image)resources.GetObject("closeBtn.Image");
            closeBtn.ImageOffset = new Point(0, 0);
            closeBtn.ImageRotate = 0F;
            closeBtn.ImageSize = new Size(50, 50);
            closeBtn.Location = new Point(658, 12);
            closeBtn.Name = "closeBtn";
            closeBtn.PressedState.ImageSize = new Size(64, 64);
            closeBtn.ShadowDecoration.CustomizableEdges = customizableEdges1;
            closeBtn.Size = new Size(82, 72);
            closeBtn.TabIndex = 1;
            closeBtn.Click += closeBtn_Click;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Lato", 11.9999981F, FontStyle.Bold, GraphicsUnit.Point);
            label1.ForeColor = Color.White;
            label1.Location = new Point(33, 30);
            label1.Name = "label1";
            label1.Size = new Size(275, 39);
            label1.TabIndex = 0;
            label1.Text = "Edit Product Form";
            label1.Click += label1_Click;
            // 
            // editProductBtn
            // 
            editProductBtn.BorderRadius = 7;
            editProductBtn.CustomizableEdges = customizableEdges2;
            editProductBtn.DisabledState.BorderColor = Color.DarkGray;
            editProductBtn.DisabledState.CustomBorderColor = Color.DarkGray;
            editProductBtn.DisabledState.FillColor = Color.FromArgb(169, 169, 169);
            editProductBtn.DisabledState.ForeColor = Color.FromArgb(141, 141, 141);
            editProductBtn.FillColor = Color.FromArgb(43, 119, 234);
            editProductBtn.Font = new Font("Lato", 10.124999F, FontStyle.Bold, GraphicsUnit.Point);
            editProductBtn.ForeColor = Color.White;
            editProductBtn.Location = new Point(47, 894);
            editProductBtn.Name = "editProductBtn";
            editProductBtn.ShadowDecoration.CustomizableEdges = customizableEdges3;
            editProductBtn.Size = new Size(680, 69);
            editProductBtn.TabIndex = 24;
            editProductBtn.Text = "Edit Product";
            editProductBtn.Click += editProductBtn_Click;
            // 
            // productCategory
            // 
            productCategory.BackColor = Color.Transparent;
            productCategory.BorderColor = Color.Gray;
            productCategory.CustomizableEdges = customizableEdges4;
            productCategory.DrawMode = DrawMode.OwnerDrawFixed;
            productCategory.DropDownStyle = ComboBoxStyle.DropDownList;
            productCategory.FocusedColor = Color.FromArgb(94, 148, 255);
            productCategory.FocusedState.BorderColor = Color.FromArgb(94, 148, 255);
            productCategory.Font = new Font("Segoe UI", 10F, FontStyle.Regular, GraphicsUnit.Point);
            productCategory.ForeColor = Color.FromArgb(68, 88, 112);
            productCategory.IntegralHeight = false;
            productCategory.ItemHeight = 30;
            productCategory.Location = new Point(47, 796);
            productCategory.Name = "productCategory";
            productCategory.ShadowDecoration.CustomizableEdges = customizableEdges5;
            productCategory.Size = new Size(680, 36);
            productCategory.TabIndex = 23;
            productCategory.SelectedIndexChanged += productCategory_SelectedIndexChanged;
            // 
            // label6
            // 
            label6.AutoSize = true;
            label6.Font = new Font("Lato", 10.124999F, FontStyle.Regular, GraphicsUnit.Point);
            label6.ForeColor = Color.Gray;
            label6.Location = new Point(37, 750);
            label6.Name = "label6";
            label6.Size = new Size(133, 33);
            label6.TabIndex = 22;
            label6.Text = "Category:";
            label6.Click += label6_Click;
            // 
            // productDesc
            // 
            productDesc.BorderColor = Color.Gray;
            productDesc.BorderRadius = 7;
            productDesc.CustomizableEdges = customizableEdges6;
            productDesc.DefaultText = "";
            productDesc.DisabledState.BorderColor = Color.FromArgb(208, 208, 208);
            productDesc.DisabledState.FillColor = Color.FromArgb(226, 226, 226);
            productDesc.DisabledState.ForeColor = Color.FromArgb(138, 138, 138);
            productDesc.DisabledState.PlaceholderForeColor = Color.FromArgb(138, 138, 138);
            productDesc.FocusedState.BorderColor = Color.FromArgb(94, 148, 255);
            productDesc.Font = new Font("Segoe UI", 9F, FontStyle.Regular, GraphicsUnit.Point);
            productDesc.HoverState.BorderColor = Color.FromArgb(94, 148, 255);
            productDesc.Location = new Point(47, 614);
            productDesc.Name = "productDesc";
            productDesc.PasswordChar = '\0';
            productDesc.PlaceholderText = "";
            productDesc.SelectedText = "";
            productDesc.ShadowDecoration.CustomizableEdges = customizableEdges7;
            productDesc.Size = new Size(680, 105);
            productDesc.TabIndex = 21;
            productDesc.TextChanged += productDesc_TextChanged;
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.Font = new Font("Lato", 10.124999F, FontStyle.Regular, GraphicsUnit.Point);
            label5.ForeColor = Color.Gray;
            label5.Location = new Point(37, 567);
            label5.Name = "label5";
            label5.Size = new Size(161, 33);
            label5.TabIndex = 20;
            label5.Text = "Description:";
            label5.Click += label5_Click;
            // 
            // productPrice
            // 
            productPrice.BorderColor = Color.Gray;
            productPrice.BorderRadius = 7;
            productPrice.CustomizableEdges = customizableEdges8;
            productPrice.DefaultText = "";
            productPrice.DisabledState.BorderColor = Color.FromArgb(208, 208, 208);
            productPrice.DisabledState.FillColor = Color.FromArgb(226, 226, 226);
            productPrice.DisabledState.ForeColor = Color.FromArgb(138, 138, 138);
            productPrice.DisabledState.PlaceholderForeColor = Color.FromArgb(138, 138, 138);
            productPrice.FocusedState.BorderColor = Color.FromArgb(94, 148, 255);
            productPrice.Font = new Font("Segoe UI", 9F, FontStyle.Regular, GraphicsUnit.Point);
            productPrice.HoverState.BorderColor = Color.FromArgb(94, 148, 255);
            productPrice.Location = new Point(47, 469);
            productPrice.Name = "productPrice";
            productPrice.PasswordChar = '\0';
            productPrice.PlaceholderText = "";
            productPrice.SelectedText = "";
            productPrice.ShadowDecoration.CustomizableEdges = customizableEdges9;
            productPrice.Size = new Size(680, 63);
            productPrice.TabIndex = 19;
            productPrice.TextChanged += productPrice_TextChanged;
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Font = new Font("Lato", 10.124999F, FontStyle.Regular, GraphicsUnit.Point);
            label4.ForeColor = Color.Gray;
            label4.Location = new Point(37, 422);
            label4.Name = "label4";
            label4.Size = new Size(84, 33);
            label4.TabIndex = 18;
            label4.Text = "Price:";
            label4.Click += label4_Click;
            // 
            // productQty
            // 
            productQty.BorderColor = Color.Gray;
            productQty.BorderRadius = 7;
            productQty.CustomizableEdges = customizableEdges10;
            productQty.DefaultText = "";
            productQty.DisabledState.BorderColor = Color.FromArgb(208, 208, 208);
            productQty.DisabledState.FillColor = Color.FromArgb(226, 226, 226);
            productQty.DisabledState.ForeColor = Color.FromArgb(138, 138, 138);
            productQty.DisabledState.PlaceholderForeColor = Color.FromArgb(138, 138, 138);
            productQty.FocusedState.BorderColor = Color.FromArgb(94, 148, 255);
            productQty.Font = new Font("Segoe UI", 9F, FontStyle.Regular, GraphicsUnit.Point);
            productQty.HoverState.BorderColor = Color.FromArgb(94, 148, 255);
            productQty.Location = new Point(46, 328);
            productQty.Name = "productQty";
            productQty.PasswordChar = '\0';
            productQty.PlaceholderText = "";
            productQty.SelectedText = "";
            productQty.ShadowDecoration.CustomizableEdges = customizableEdges11;
            productQty.Size = new Size(680, 63);
            productQty.TabIndex = 17;
            productQty.TextChanged += productQty_TextChanged;
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Font = new Font("Lato", 10.124999F, FontStyle.Regular, GraphicsUnit.Point);
            label3.ForeColor = Color.Gray;
            label3.Location = new Point(36, 281);
            label3.Name = "label3";
            label3.Size = new Size(129, 33);
            label3.TabIndex = 16;
            label3.Text = "Quantity:";
            label3.Click += label3_Click;
            // 
            // productName
            // 
            productName.BorderColor = Color.Gray;
            productName.BorderRadius = 7;
            productName.CustomizableEdges = customizableEdges12;
            productName.DefaultText = "";
            productName.DisabledState.BorderColor = Color.FromArgb(208, 208, 208);
            productName.DisabledState.FillColor = Color.FromArgb(226, 226, 226);
            productName.DisabledState.ForeColor = Color.FromArgb(138, 138, 138);
            productName.DisabledState.PlaceholderForeColor = Color.FromArgb(138, 138, 138);
            productName.FocusedState.BorderColor = Color.FromArgb(94, 148, 255);
            productName.Font = new Font("Segoe UI", 9F, FontStyle.Regular, GraphicsUnit.Point);
            productName.HoverState.BorderColor = Color.FromArgb(94, 148, 255);
            productName.Location = new Point(44, 182);
            productName.Name = "productName";
            productName.PasswordChar = '\0';
            productName.PlaceholderText = "";
            productName.SelectedText = "";
            productName.ShadowDecoration.CustomizableEdges = customizableEdges13;
            productName.Size = new Size(680, 63);
            productName.TabIndex = 15;
            productName.TextChanged += productName_TextChanged;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Font = new Font("Lato", 10.124999F, FontStyle.Regular, GraphicsUnit.Point);
            label2.ForeColor = Color.Gray;
            label2.Location = new Point(34, 135);
            label2.Name = "label2";
            label2.Size = new Size(193, 33);
            label2.TabIndex = 14;
            label2.Text = "Product Name:";
            label2.Click += label2_Click;
            // 
            // EditProductsForm
            // 
            AutoScaleDimensions = new SizeF(14F, 29F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.White;
            ClientSize = new Size(764, 1007);
            Controls.Add(panel1);
            Controls.Add(editProductBtn);
            Controls.Add(productCategory);
            Controls.Add(label6);
            Controls.Add(productDesc);
            Controls.Add(label5);
            Controls.Add(productPrice);
            Controls.Add(label4);
            Controls.Add(productQty);
            Controls.Add(label3);
            Controls.Add(productName);
            Controls.Add(label2);
            Font = new Font("Lato", 9F, FontStyle.Regular, GraphicsUnit.Point);
            FormBorderStyle = FormBorderStyle.None;
            Name = "EditProductsForm";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "EditProductsForm";
            Load += EditProductsForm_Load;
            panel1.ResumeLayout(false);
            panel1.PerformLayout();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Panel panel1;
        private Guna.UI2.WinForms.Guna2ImageButton closeBtn;
        private Label label1;
        private Guna.UI2.WinForms.Guna2Button editProductBtn;
        private Label label6;
        private Label label5;
        private Label label4;
        private Label label3;
        private Label label2;
        public Guna.UI2.WinForms.Guna2ComboBox productCategory;
        public Guna.UI2.WinForms.Guna2TextBox productDesc;
        public Guna.UI2.WinForms.Guna2TextBox productPrice;
        public Guna.UI2.WinForms.Guna2TextBox productQty;
        public Guna.UI2.WinForms.Guna2TextBox productName;
    }
}