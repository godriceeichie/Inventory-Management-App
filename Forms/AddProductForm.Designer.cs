namespace Inventory_Management_App.Forms
{
    partial class AddProductForm
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(AddProductForm));
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
            label2 = new Label();
            productName = new Guna.UI2.WinForms.Guna2TextBox();
            productQty = new Guna.UI2.WinForms.Guna2TextBox();
            label3 = new Label();
            productPrice = new Guna.UI2.WinForms.Guna2TextBox();
            label4 = new Label();
            productDesc = new Guna.UI2.WinForms.Guna2TextBox();
            label5 = new Label();
            label6 = new Label();
            productCategory = new Guna.UI2.WinForms.Guna2ComboBox();
            addProductBtn = new Guna.UI2.WinForms.Guna2Button();
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
            panel1.TabIndex = 0;
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
            closeBtn.Click += quitBtn_Click;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Lato", 11.9999981F, FontStyle.Bold, GraphicsUnit.Point);
            label1.ForeColor = Color.White;
            label1.Location = new Point(33, 30);
            label1.Name = "label1";
            label1.Size = new Size(277, 39);
            label1.TabIndex = 0;
            label1.Text = "Add Product Form";
            label1.Click += label1_Click;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Font = new Font("Lato", 10.124999F, FontStyle.Regular, GraphicsUnit.Point);
            label2.ForeColor = Color.Gray;
            label2.Location = new Point(34, 133);
            label2.Name = "label2";
            label2.Size = new Size(193, 33);
            label2.TabIndex = 1;
            label2.Text = "Product Name:";
            label2.Click += label2_Click;
            // 
            // productName
            // 
            productName.BorderColor = Color.Gray;
            productName.BorderRadius = 7;
            productName.CustomizableEdges = customizableEdges2;
            productName.DefaultText = "";
            productName.DisabledState.BorderColor = Color.FromArgb(208, 208, 208);
            productName.DisabledState.FillColor = Color.FromArgb(226, 226, 226);
            productName.DisabledState.ForeColor = Color.FromArgb(138, 138, 138);
            productName.DisabledState.PlaceholderForeColor = Color.FromArgb(138, 138, 138);
            productName.FocusedState.BorderColor = Color.FromArgb(94, 148, 255);
            productName.Font = new Font("Segoe UI", 9F, FontStyle.Regular, GraphicsUnit.Point);
            productName.HoverState.BorderColor = Color.FromArgb(94, 148, 255);
            productName.Location = new Point(44, 180);
            productName.Name = "productName";
            productName.PasswordChar = '\0';
            productName.PlaceholderText = "";
            productName.SelectedText = "";
            productName.ShadowDecoration.CustomizableEdges = customizableEdges3;
            productName.Size = new Size(680, 63);
            productName.TabIndex = 2;
            productName.TextChanged += productName_TextChanged;
            // 
            // productQty
            // 
            productQty.BorderColor = Color.Gray;
            productQty.BorderRadius = 7;
            productQty.CustomizableEdges = customizableEdges4;
            productQty.DefaultText = "";
            productQty.DisabledState.BorderColor = Color.FromArgb(208, 208, 208);
            productQty.DisabledState.FillColor = Color.FromArgb(226, 226, 226);
            productQty.DisabledState.ForeColor = Color.FromArgb(138, 138, 138);
            productQty.DisabledState.PlaceholderForeColor = Color.FromArgb(138, 138, 138);
            productQty.FocusedState.BorderColor = Color.FromArgb(94, 148, 255);
            productQty.Font = new Font("Segoe UI", 9F, FontStyle.Regular, GraphicsUnit.Point);
            productQty.HoverState.BorderColor = Color.FromArgb(94, 148, 255);
            productQty.Location = new Point(46, 326);
            productQty.Name = "productQty";
            productQty.PasswordChar = '\0';
            productQty.PlaceholderText = "";
            productQty.SelectedText = "";
            productQty.ShadowDecoration.CustomizableEdges = customizableEdges5;
            productQty.Size = new Size(680, 63);
            productQty.TabIndex = 4;
            productQty.TextChanged += productQty_TextChanged;
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Font = new Font("Lato", 10.124999F, FontStyle.Regular, GraphicsUnit.Point);
            label3.ForeColor = Color.Gray;
            label3.Location = new Point(36, 279);
            label3.Name = "label3";
            label3.Size = new Size(129, 33);
            label3.TabIndex = 3;
            label3.Text = "Quantity:";
            label3.Click += label3_Click;
            // 
            // productPrice
            // 
            productPrice.BorderColor = Color.Gray;
            productPrice.BorderRadius = 7;
            productPrice.CustomizableEdges = customizableEdges6;
            productPrice.DefaultText = "";
            productPrice.DisabledState.BorderColor = Color.FromArgb(208, 208, 208);
            productPrice.DisabledState.FillColor = Color.FromArgb(226, 226, 226);
            productPrice.DisabledState.ForeColor = Color.FromArgb(138, 138, 138);
            productPrice.DisabledState.PlaceholderForeColor = Color.FromArgb(138, 138, 138);
            productPrice.FocusedState.BorderColor = Color.FromArgb(94, 148, 255);
            productPrice.Font = new Font("Segoe UI", 9F, FontStyle.Regular, GraphicsUnit.Point);
            productPrice.HoverState.BorderColor = Color.FromArgb(94, 148, 255);
            productPrice.Location = new Point(47, 467);
            productPrice.Name = "productPrice";
            productPrice.PasswordChar = '\0';
            productPrice.PlaceholderText = "";
            productPrice.SelectedText = "";
            productPrice.ShadowDecoration.CustomizableEdges = customizableEdges7;
            productPrice.Size = new Size(680, 63);
            productPrice.TabIndex = 6;
            productPrice.TextChanged += productPrice_TextChanged;
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Font = new Font("Lato", 10.124999F, FontStyle.Regular, GraphicsUnit.Point);
            label4.ForeColor = Color.Gray;
            label4.Location = new Point(37, 420);
            label4.Name = "label4";
            label4.Size = new Size(84, 33);
            label4.TabIndex = 5;
            label4.Text = "Price:";
            label4.Click += label4_Click;
            // 
            // productDesc
            // 
            productDesc.BorderColor = Color.Gray;
            productDesc.BorderRadius = 7;
            productDesc.CustomizableEdges = customizableEdges8;
            productDesc.DefaultText = "";
            productDesc.DisabledState.BorderColor = Color.FromArgb(208, 208, 208);
            productDesc.DisabledState.FillColor = Color.FromArgb(226, 226, 226);
            productDesc.DisabledState.ForeColor = Color.FromArgb(138, 138, 138);
            productDesc.DisabledState.PlaceholderForeColor = Color.FromArgb(138, 138, 138);
            productDesc.FocusedState.BorderColor = Color.FromArgb(94, 148, 255);
            productDesc.Font = new Font("Segoe UI", 9F, FontStyle.Regular, GraphicsUnit.Point);
            productDesc.HoverState.BorderColor = Color.FromArgb(94, 148, 255);
            productDesc.Location = new Point(47, 612);
            productDesc.Name = "productDesc";
            productDesc.PasswordChar = '\0';
            productDesc.PlaceholderText = "";
            productDesc.SelectedText = "";
            productDesc.ShadowDecoration.CustomizableEdges = customizableEdges9;
            productDesc.Size = new Size(680, 105);
            productDesc.TabIndex = 8;
            productDesc.TextChanged += productDesc_TextChanged;
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.Font = new Font("Lato", 10.124999F, FontStyle.Regular, GraphicsUnit.Point);
            label5.ForeColor = Color.Gray;
            label5.Location = new Point(37, 565);
            label5.Name = "label5";
            label5.Size = new Size(161, 33);
            label5.TabIndex = 7;
            label5.Text = "Description:";
            label5.Click += label5_Click;
            // 
            // label6
            // 
            label6.AutoSize = true;
            label6.Font = new Font("Lato", 10.124999F, FontStyle.Regular, GraphicsUnit.Point);
            label6.ForeColor = Color.Gray;
            label6.Location = new Point(37, 748);
            label6.Name = "label6";
            label6.Size = new Size(133, 33);
            label6.TabIndex = 9;
            label6.Text = "Category:";
            label6.Click += label6_Click;
            // 
            // productCategory
            // 
            productCategory.BackColor = Color.Transparent;
            productCategory.BorderColor = Color.Gray;
            productCategory.CustomizableEdges = customizableEdges10;
            productCategory.DrawMode = DrawMode.OwnerDrawFixed;
            productCategory.DropDownStyle = ComboBoxStyle.DropDownList;
            productCategory.FocusedColor = Color.FromArgb(94, 148, 255);
            productCategory.FocusedState.BorderColor = Color.FromArgb(94, 148, 255);
            productCategory.Font = new Font("Segoe UI", 10F, FontStyle.Regular, GraphicsUnit.Point);
            productCategory.ForeColor = Color.FromArgb(68, 88, 112);
            productCategory.IntegralHeight = false;
            productCategory.ItemHeight = 30;
            productCategory.Location = new Point(47, 794);
            productCategory.Name = "productCategory";
            productCategory.ShadowDecoration.CustomizableEdges = customizableEdges11;
            productCategory.Size = new Size(680, 36);
            productCategory.TabIndex = 11;
            productCategory.SelectedIndexChanged += productCategory_SelectedIndexChanged;
            // 
            // addProductBtn
            // 
            addProductBtn.BorderRadius = 7;
            addProductBtn.CustomizableEdges = customizableEdges12;
            addProductBtn.DisabledState.BorderColor = Color.DarkGray;
            addProductBtn.DisabledState.CustomBorderColor = Color.DarkGray;
            addProductBtn.DisabledState.FillColor = Color.FromArgb(169, 169, 169);
            addProductBtn.DisabledState.ForeColor = Color.FromArgb(141, 141, 141);
            addProductBtn.FillColor = Color.FromArgb(43, 119, 234);
            addProductBtn.Font = new Font("Lato", 10.124999F, FontStyle.Bold, GraphicsUnit.Point);
            addProductBtn.ForeColor = Color.White;
            addProductBtn.Location = new Point(47, 892);
            addProductBtn.Name = "addProductBtn";
            addProductBtn.ShadowDecoration.CustomizableEdges = customizableEdges13;
            addProductBtn.Size = new Size(680, 69);
            addProductBtn.TabIndex = 12;
            addProductBtn.Text = "Add Product";
            addProductBtn.Click += addProductBtn_Click;
            // 
            // AddProductForm
            // 
            AutoScaleDimensions = new SizeF(13F, 32F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.White;
            ClientSize = new Size(764, 1007);
            Controls.Add(addProductBtn);
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
            Controls.Add(panel1);
            FormBorderStyle = FormBorderStyle.None;
            Name = "AddProductForm";
            StartPosition = FormStartPosition.CenterParent;
            Text = "AddProductForm";
            Load += AddProductForm_Load;
            panel1.ResumeLayout(false);
            panel1.PerformLayout();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Panel panel1;
        private Label label1;
        private Label label2;
        private Guna.UI2.WinForms.Guna2TextBox productName;
        private Guna.UI2.WinForms.Guna2TextBox productQty;
        private Label label3;
        private Guna.UI2.WinForms.Guna2TextBox productPrice;
        private Label label4;
        private Guna.UI2.WinForms.Guna2TextBox productDesc;
        private Label label5;
        private Label label6;
        private Guna.UI2.WinForms.Guna2ComboBox productCategory;
        private Guna.UI2.WinForms.Guna2Button addProductBtn;
        private Guna.UI2.WinForms.Guna2ImageButton closeBtn;
    }
}