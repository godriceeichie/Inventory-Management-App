namespace Inventory_Management_App.Forms
{
    partial class AddOrdersForm
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(AddOrdersForm));
            Guna.UI2.WinForms.Suite.CustomizableEdges customizableEdges12 = new Guna.UI2.WinForms.Suite.CustomizableEdges();
            Guna.UI2.WinForms.Suite.CustomizableEdges customizableEdges13 = new Guna.UI2.WinForms.Suite.CustomizableEdges();
            Guna.UI2.WinForms.Suite.CustomizableEdges customizableEdges14 = new Guna.UI2.WinForms.Suite.CustomizableEdges();
            Guna.UI2.WinForms.Suite.CustomizableEdges customizableEdges15 = new Guna.UI2.WinForms.Suite.CustomizableEdges();
            Guna.UI2.WinForms.Suite.CustomizableEdges customizableEdges16 = new Guna.UI2.WinForms.Suite.CustomizableEdges();
            Guna.UI2.WinForms.Suite.CustomizableEdges customizableEdges17 = new Guna.UI2.WinForms.Suite.CustomizableEdges();
            Guna.UI2.WinForms.Suite.CustomizableEdges customizableEdges18 = new Guna.UI2.WinForms.Suite.CustomizableEdges();
            Guna.UI2.WinForms.Suite.CustomizableEdges customizableEdges19 = new Guna.UI2.WinForms.Suite.CustomizableEdges();
            Guna.UI2.WinForms.Suite.CustomizableEdges customizableEdges20 = new Guna.UI2.WinForms.Suite.CustomizableEdges();
            Guna.UI2.WinForms.Suite.CustomizableEdges customizableEdges21 = new Guna.UI2.WinForms.Suite.CustomizableEdges();
            Guna.UI2.WinForms.Suite.CustomizableEdges customizableEdges22 = new Guna.UI2.WinForms.Suite.CustomizableEdges();
            panel1 = new Panel();
            closeBtn = new Guna.UI2.WinForms.Guna2ImageButton();
            label1 = new Label();
            orderQuantity = new Guna.UI2.WinForms.Guna2TextBox();
            label7 = new Label();
            addOrderBtn = new Guna.UI2.WinForms.Guna2Button();
            label4 = new Label();
            label3 = new Label();
            label2 = new Label();
            orderDate = new Guna.UI2.WinForms.Guna2DateTimePicker();
            customerId = new Guna.UI2.WinForms.Guna2ComboBox();
            productId = new Guna.UI2.WinForms.Guna2ComboBox();
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
            panel1.TabIndex = 55;
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
            closeBtn.ShadowDecoration.CustomizableEdges = customizableEdges12;
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
            label1.Size = new Size(250, 39);
            label1.TabIndex = 0;
            label1.Text = "Add Order Form";
            // 
            // orderQuantity
            // 
            orderQuantity.BorderColor = Color.Gray;
            orderQuantity.BorderRadius = 7;
            orderQuantity.CustomizableEdges = customizableEdges13;
            orderQuantity.DefaultText = "";
            orderQuantity.DisabledState.BorderColor = Color.FromArgb(208, 208, 208);
            orderQuantity.DisabledState.FillColor = Color.FromArgb(226, 226, 226);
            orderQuantity.DisabledState.ForeColor = Color.FromArgb(138, 138, 138);
            orderQuantity.DisabledState.PlaceholderForeColor = Color.FromArgb(138, 138, 138);
            orderQuantity.FocusedState.BorderColor = Color.FromArgb(94, 148, 255);
            orderQuantity.Font = new Font("Segoe UI", 9F, FontStyle.Regular, GraphicsUnit.Point);
            orderQuantity.HoverState.BorderColor = Color.FromArgb(94, 148, 255);
            orderQuantity.Location = new Point(46, 622);
            orderQuantity.Name = "orderQuantity";
            orderQuantity.PasswordChar = '\0';
            orderQuantity.PlaceholderText = "";
            orderQuantity.SelectedText = "";
            orderQuantity.ShadowDecoration.CustomizableEdges = customizableEdges14;
            orderQuantity.Size = new Size(680, 69);
            orderQuantity.TabIndex = 66;
            // 
            // label7
            // 
            label7.AutoSize = true;
            label7.Font = new Font("Lato", 10.124999F, FontStyle.Regular, GraphicsUnit.Point);
            label7.ForeColor = Color.Gray;
            label7.Location = new Point(39, 575);
            label7.Name = "label7";
            label7.Size = new Size(129, 33);
            label7.TabIndex = 65;
            label7.Text = "Quantity:";
            // 
            // addOrderBtn
            // 
            addOrderBtn.BorderRadius = 7;
            addOrderBtn.CustomizableEdges = customizableEdges15;
            addOrderBtn.DisabledState.BorderColor = Color.DarkGray;
            addOrderBtn.DisabledState.CustomBorderColor = Color.DarkGray;
            addOrderBtn.DisabledState.FillColor = Color.FromArgb(169, 169, 169);
            addOrderBtn.DisabledState.ForeColor = Color.FromArgb(141, 141, 141);
            addOrderBtn.FillColor = Color.FromArgb(43, 119, 234);
            addOrderBtn.Font = new Font("Lato", 10.124999F, FontStyle.Bold, GraphicsUnit.Point);
            addOrderBtn.ForeColor = Color.White;
            addOrderBtn.Location = new Point(44, 758);
            addOrderBtn.Name = "addOrderBtn";
            addOrderBtn.ShadowDecoration.CustomizableEdges = customizableEdges16;
            addOrderBtn.Size = new Size(680, 69);
            addOrderBtn.TabIndex = 64;
            addOrderBtn.Text = "Add Order";
            addOrderBtn.Click += addOrderBtn_Click;
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Font = new Font("Lato", 10.124999F, FontStyle.Regular, GraphicsUnit.Point);
            label4.ForeColor = Color.Gray;
            label4.Location = new Point(36, 432);
            label4.Name = "label4";
            label4.Size = new Size(146, 33);
            label4.TabIndex = 60;
            label4.Text = "Product Id:";
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Font = new Font("Lato", 10.124999F, FontStyle.Regular, GraphicsUnit.Point);
            label3.ForeColor = Color.Gray;
            label3.Location = new Point(35, 291);
            label3.Name = "label3";
            label3.Size = new Size(168, 33);
            label3.TabIndex = 58;
            label3.Text = "Customer Id:";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Font = new Font("Lato", 10.124999F, FontStyle.Regular, GraphicsUnit.Point);
            label2.ForeColor = Color.Gray;
            label2.Location = new Point(33, 145);
            label2.Name = "label2";
            label2.Size = new Size(158, 33);
            label2.TabIndex = 56;
            label2.Text = "Order Date:";
            // 
            // orderDate
            // 
            orderDate.BorderRadius = 7;
            orderDate.Checked = true;
            orderDate.CustomizableEdges = customizableEdges17;
            orderDate.FillColor = Color.FromArgb(233, 239, 255);
            orderDate.Font = new Font("Lato", 9F, FontStyle.Regular, GraphicsUnit.Point);
            orderDate.Format = DateTimePickerFormat.Long;
            orderDate.Location = new Point(43, 195);
            orderDate.MaxDate = new DateTime(9998, 12, 31, 0, 0, 0, 0);
            orderDate.MinDate = new DateTime(1753, 1, 1, 0, 0, 0, 0);
            orderDate.Name = "orderDate";
            orderDate.ShadowDecoration.CustomizableEdges = customizableEdges18;
            orderDate.Size = new Size(680, 72);
            orderDate.TabIndex = 69;
            orderDate.Value = new DateTime(2023, 12, 19, 17, 59, 19, 871);
            // 
            // customerId
            // 
            customerId.BackColor = Color.Transparent;
            customerId.BorderColor = Color.Gray;
            customerId.BorderRadius = 7;
            customerId.CustomizableEdges = customizableEdges19;
            customerId.DrawMode = DrawMode.OwnerDrawFixed;
            customerId.DropDownStyle = ComboBoxStyle.DropDownList;
            customerId.FocusedColor = Color.FromArgb(94, 148, 255);
            customerId.FocusedState.BorderColor = Color.FromArgb(94, 148, 255);
            customerId.Font = new Font("Segoe UI", 10F, FontStyle.Regular, GraphicsUnit.Point);
            customerId.ForeColor = Color.FromArgb(68, 88, 112);
            customerId.ItemHeight = 30;
            customerId.Location = new Point(43, 343);
            customerId.Name = "customerId";
            customerId.ShadowDecoration.CustomizableEdges = customizableEdges20;
            customerId.Size = new Size(680, 36);
            customerId.TabIndex = 70;
            // 
            // productId
            // 
            productId.BackColor = Color.Transparent;
            productId.BorderColor = Color.Gray;
            productId.BorderRadius = 7;
            productId.CustomizableEdges = customizableEdges21;
            productId.DrawMode = DrawMode.OwnerDrawFixed;
            productId.DropDownStyle = ComboBoxStyle.DropDownList;
            productId.FocusedColor = Color.FromArgb(94, 148, 255);
            productId.FocusedState.BorderColor = Color.FromArgb(94, 148, 255);
            productId.Font = new Font("Segoe UI", 10F, FontStyle.Regular, GraphicsUnit.Point);
            productId.ForeColor = Color.FromArgb(68, 88, 112);
            productId.ItemHeight = 30;
            productId.Location = new Point(43, 485);
            productId.Name = "productId";
            productId.ShadowDecoration.CustomizableEdges = customizableEdges22;
            productId.Size = new Size(680, 36);
            productId.TabIndex = 71;
            // 
            // AddOrdersForm
            // 
            AutoScaleDimensions = new SizeF(14F, 29F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.White;
            ClientSize = new Size(764, 890);
            Controls.Add(productId);
            Controls.Add(customerId);
            Controls.Add(orderDate);
            Controls.Add(panel1);
            Controls.Add(orderQuantity);
            Controls.Add(label7);
            Controls.Add(addOrderBtn);
            Controls.Add(label4);
            Controls.Add(label3);
            Controls.Add(label2);
            Font = new Font("Lato", 9F, FontStyle.Regular, GraphicsUnit.Point);
            FormBorderStyle = FormBorderStyle.None;
            Name = "AddOrdersForm";
            StartPosition = FormStartPosition.CenterParent;
            Text = "AddOrdersForm";
            Load += AddOrdersForm_Load;
            panel1.ResumeLayout(false);
            panel1.PerformLayout();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Panel panel1;
        private Guna.UI2.WinForms.Guna2ImageButton closeBtn;
        private Label label1;
        public Guna.UI2.WinForms.Guna2TextBox orderQuantity;
        private Label label7;
        private Guna.UI2.WinForms.Guna2Button addOrderBtn;
        private Label label4;
        private Label label3;
        private Label label2;
        private Guna.UI2.WinForms.Guna2DateTimePicker orderDate;
        private Guna.UI2.WinForms.Guna2ComboBox customerId;
        private Guna.UI2.WinForms.Guna2ComboBox productId;
    }
}