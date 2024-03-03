namespace Inventory_Management_App.Forms
{
    partial class AddCustomerForm
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(AddCustomerForm));
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
            Guna.UI2.WinForms.Suite.CustomizableEdges customizableEdges14 = new Guna.UI2.WinForms.Suite.CustomizableEdges();
            Guna.UI2.WinForms.Suite.CustomizableEdges customizableEdges15 = new Guna.UI2.WinForms.Suite.CustomizableEdges();
            panel1 = new Panel();
            closeBtn = new Guna.UI2.WinForms.Guna2ImageButton();
            label1 = new Label();
            customerPhoneNumber = new Guna.UI2.WinForms.Guna2TextBox();
            label6 = new Label();
            customerLocation = new Guna.UI2.WinForms.Guna2TextBox();
            label7 = new Label();
            addCustomerBtn = new Guna.UI2.WinForms.Guna2Button();
            customerCountry = new Guna.UI2.WinForms.Guna2TextBox();
            label5 = new Label();
            customerCity = new Guna.UI2.WinForms.Guna2TextBox();
            label4 = new Label();
            customerLastName = new Guna.UI2.WinForms.Guna2TextBox();
            label3 = new Label();
            customerFirstName = new Guna.UI2.WinForms.Guna2TextBox();
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
            panel1.TabIndex = 41;
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
            label1.Size = new Size(303, 39);
            label1.TabIndex = 0;
            label1.Text = "Add Customer Form";
            // 
            // customerPhoneNumber
            // 
            customerPhoneNumber.BorderColor = Color.Gray;
            customerPhoneNumber.BorderRadius = 7;
            customerPhoneNumber.CustomizableEdges = customizableEdges2;
            customerPhoneNumber.DefaultText = "";
            customerPhoneNumber.DisabledState.BorderColor = Color.FromArgb(208, 208, 208);
            customerPhoneNumber.DisabledState.FillColor = Color.FromArgb(226, 226, 226);
            customerPhoneNumber.DisabledState.ForeColor = Color.FromArgb(138, 138, 138);
            customerPhoneNumber.DisabledState.PlaceholderForeColor = Color.FromArgb(138, 138, 138);
            customerPhoneNumber.FocusedState.BorderColor = Color.FromArgb(94, 148, 255);
            customerPhoneNumber.Font = new Font("Segoe UI", 9F, FontStyle.Regular, GraphicsUnit.Point);
            customerPhoneNumber.HoverState.BorderColor = Color.FromArgb(94, 148, 255);
            customerPhoneNumber.Location = new Point(47, 782);
            customerPhoneNumber.Name = "customerPhoneNumber";
            customerPhoneNumber.PasswordChar = '\0';
            customerPhoneNumber.PlaceholderText = "";
            customerPhoneNumber.SelectedText = "";
            customerPhoneNumber.ShadowDecoration.CustomizableEdges = customizableEdges3;
            customerPhoneNumber.Size = new Size(680, 69);
            customerPhoneNumber.TabIndex = 54;
            // 
            // label6
            // 
            label6.AutoSize = true;
            label6.Font = new Font("Lato", 10.124999F, FontStyle.Regular, GraphicsUnit.Point);
            label6.ForeColor = Color.Gray;
            label6.Location = new Point(37, 735);
            label6.Name = "label6";
            label6.Size = new Size(200, 33);
            label6.TabIndex = 53;
            label6.Text = "Phone Number:";
            // 
            // customerLocation
            // 
            customerLocation.BorderColor = Color.Gray;
            customerLocation.BorderRadius = 7;
            customerLocation.CustomizableEdges = customizableEdges4;
            customerLocation.DefaultText = "";
            customerLocation.DisabledState.BorderColor = Color.FromArgb(208, 208, 208);
            customerLocation.DisabledState.FillColor = Color.FromArgb(226, 226, 226);
            customerLocation.DisabledState.ForeColor = Color.FromArgb(138, 138, 138);
            customerLocation.DisabledState.PlaceholderForeColor = Color.FromArgb(138, 138, 138);
            customerLocation.FocusedState.BorderColor = Color.FromArgb(94, 148, 255);
            customerLocation.Font = new Font("Segoe UI", 9F, FontStyle.Regular, GraphicsUnit.Point);
            customerLocation.HoverState.BorderColor = Color.FromArgb(94, 148, 255);
            customerLocation.Location = new Point(47, 920);
            customerLocation.Name = "customerLocation";
            customerLocation.PasswordChar = '\0';
            customerLocation.PlaceholderText = "";
            customerLocation.SelectedText = "";
            customerLocation.ShadowDecoration.CustomizableEdges = customizableEdges5;
            customerLocation.Size = new Size(680, 69);
            customerLocation.TabIndex = 52;
            // 
            // label7
            // 
            label7.AutoSize = true;
            label7.Font = new Font("Lato", 10.124999F, FontStyle.Regular, GraphicsUnit.Point);
            label7.ForeColor = Color.Gray;
            label7.Location = new Point(37, 873);
            label7.Name = "label7";
            label7.Size = new Size(125, 33);
            label7.TabIndex = 51;
            label7.Text = "Location:";
            // 
            // addCustomerBtn
            // 
            addCustomerBtn.BorderRadius = 7;
            addCustomerBtn.CustomizableEdges = customizableEdges6;
            addCustomerBtn.DisabledState.BorderColor = Color.DarkGray;
            addCustomerBtn.DisabledState.CustomBorderColor = Color.DarkGray;
            addCustomerBtn.DisabledState.FillColor = Color.FromArgb(169, 169, 169);
            addCustomerBtn.DisabledState.ForeColor = Color.FromArgb(141, 141, 141);
            addCustomerBtn.FillColor = Color.FromArgb(43, 119, 234);
            addCustomerBtn.Font = new Font("Lato", 10.124999F, FontStyle.Bold, GraphicsUnit.Point);
            addCustomerBtn.ForeColor = Color.White;
            addCustomerBtn.Location = new Point(47, 1056);
            addCustomerBtn.Name = "addCustomerBtn";
            addCustomerBtn.ShadowDecoration.CustomizableEdges = customizableEdges7;
            addCustomerBtn.Size = new Size(680, 69);
            addCustomerBtn.TabIndex = 50;
            addCustomerBtn.Text = "Add Customer";
            addCustomerBtn.Click += addCustomerBtn_Click;
            // 
            // customerCountry
            // 
            customerCountry.BorderColor = Color.Gray;
            customerCountry.BorderRadius = 7;
            customerCountry.CustomizableEdges = customizableEdges8;
            customerCountry.DefaultText = "";
            customerCountry.DisabledState.BorderColor = Color.FromArgb(208, 208, 208);
            customerCountry.DisabledState.FillColor = Color.FromArgb(226, 226, 226);
            customerCountry.DisabledState.ForeColor = Color.FromArgb(138, 138, 138);
            customerCountry.DisabledState.PlaceholderForeColor = Color.FromArgb(138, 138, 138);
            customerCountry.FocusedState.BorderColor = Color.FromArgb(94, 148, 255);
            customerCountry.Font = new Font("Segoe UI", 9F, FontStyle.Regular, GraphicsUnit.Point);
            customerCountry.HoverState.BorderColor = Color.FromArgb(94, 148, 255);
            customerCountry.Location = new Point(43, 638);
            customerCountry.Name = "customerCountry";
            customerCountry.PasswordChar = '\0';
            customerCountry.PlaceholderText = "";
            customerCountry.SelectedText = "";
            customerCountry.ShadowDecoration.CustomizableEdges = customizableEdges9;
            customerCountry.Size = new Size(680, 69);
            customerCountry.TabIndex = 49;
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.Font = new Font("Lato", 10.124999F, FontStyle.Regular, GraphicsUnit.Point);
            label5.ForeColor = Color.Gray;
            label5.Location = new Point(33, 591);
            label5.Name = "label5";
            label5.Size = new Size(121, 33);
            label5.TabIndex = 48;
            label5.Text = "Country:";
            // 
            // customerCity
            // 
            customerCity.BorderColor = Color.Gray;
            customerCity.BorderRadius = 7;
            customerCity.CustomizableEdges = customizableEdges10;
            customerCity.DefaultText = "";
            customerCity.DisabledState.BorderColor = Color.FromArgb(208, 208, 208);
            customerCity.DisabledState.FillColor = Color.FromArgb(226, 226, 226);
            customerCity.DisabledState.ForeColor = Color.FromArgb(138, 138, 138);
            customerCity.DisabledState.PlaceholderForeColor = Color.FromArgb(138, 138, 138);
            customerCity.FocusedState.BorderColor = Color.FromArgb(94, 148, 255);
            customerCity.Font = new Font("Segoe UI", 9F, FontStyle.Regular, GraphicsUnit.Point);
            customerCity.HoverState.BorderColor = Color.FromArgb(94, 148, 255);
            customerCity.Location = new Point(43, 493);
            customerCity.Name = "customerCity";
            customerCity.PasswordChar = '\0';
            customerCity.PlaceholderText = "";
            customerCity.SelectedText = "";
            customerCity.ShadowDecoration.CustomizableEdges = customizableEdges11;
            customerCity.Size = new Size(680, 69);
            customerCity.TabIndex = 47;
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Font = new Font("Lato", 10.124999F, FontStyle.Regular, GraphicsUnit.Point);
            label4.ForeColor = Color.Gray;
            label4.Location = new Point(33, 446);
            label4.Name = "label4";
            label4.Size = new Size(72, 33);
            label4.TabIndex = 46;
            label4.Text = "City:";
            // 
            // customerLastName
            // 
            customerLastName.BorderColor = Color.Gray;
            customerLastName.BorderRadius = 7;
            customerLastName.CustomizableEdges = customizableEdges12;
            customerLastName.DefaultText = "";
            customerLastName.DisabledState.BorderColor = Color.FromArgb(208, 208, 208);
            customerLastName.DisabledState.FillColor = Color.FromArgb(226, 226, 226);
            customerLastName.DisabledState.ForeColor = Color.FromArgb(138, 138, 138);
            customerLastName.DisabledState.PlaceholderForeColor = Color.FromArgb(138, 138, 138);
            customerLastName.FocusedState.BorderColor = Color.FromArgb(94, 148, 255);
            customerLastName.Font = new Font("Segoe UI", 9F, FontStyle.Regular, GraphicsUnit.Point);
            customerLastName.HoverState.BorderColor = Color.FromArgb(94, 148, 255);
            customerLastName.Location = new Point(42, 352);
            customerLastName.Name = "customerLastName";
            customerLastName.PasswordChar = '\0';
            customerLastName.PlaceholderText = "";
            customerLastName.SelectedText = "";
            customerLastName.ShadowDecoration.CustomizableEdges = customizableEdges13;
            customerLastName.Size = new Size(680, 69);
            customerLastName.TabIndex = 45;
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Font = new Font("Lato", 10.124999F, FontStyle.Regular, GraphicsUnit.Point);
            label3.ForeColor = Color.Gray;
            label3.Location = new Point(32, 305);
            label3.Name = "label3";
            label3.Size = new Size(147, 33);
            label3.TabIndex = 44;
            label3.Text = "Last Name:";
            // 
            // customerFirstName
            // 
            customerFirstName.BorderColor = Color.Gray;
            customerFirstName.BorderRadius = 7;
            customerFirstName.CustomizableEdges = customizableEdges14;
            customerFirstName.DefaultText = "";
            customerFirstName.DisabledState.BorderColor = Color.FromArgb(208, 208, 208);
            customerFirstName.DisabledState.FillColor = Color.FromArgb(226, 226, 226);
            customerFirstName.DisabledState.ForeColor = Color.FromArgb(138, 138, 138);
            customerFirstName.DisabledState.PlaceholderForeColor = Color.FromArgb(138, 138, 138);
            customerFirstName.FocusedState.BorderColor = Color.FromArgb(94, 148, 255);
            customerFirstName.Font = new Font("Segoe UI", 9F, FontStyle.Regular, GraphicsUnit.Point);
            customerFirstName.HoverState.BorderColor = Color.FromArgb(94, 148, 255);
            customerFirstName.Location = new Point(40, 206);
            customerFirstName.Name = "customerFirstName";
            customerFirstName.PasswordChar = '\0';
            customerFirstName.PlaceholderText = "";
            customerFirstName.SelectedText = "";
            customerFirstName.ShadowDecoration.CustomizableEdges = customizableEdges15;
            customerFirstName.Size = new Size(680, 69);
            customerFirstName.TabIndex = 43;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Font = new Font("Lato", 10.124999F, FontStyle.Regular, GraphicsUnit.Point);
            label2.ForeColor = Color.Gray;
            label2.Location = new Point(30, 159);
            label2.Name = "label2";
            label2.Size = new Size(152, 33);
            label2.TabIndex = 42;
            label2.Text = "First Name:";
            // 
            // AddCustomerForm
            // 
            AutoScaleDimensions = new SizeF(14F, 29F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.White;
            ClientSize = new Size(764, 1168);
            Controls.Add(panel1);
            Controls.Add(customerPhoneNumber);
            Controls.Add(label6);
            Controls.Add(customerLocation);
            Controls.Add(label7);
            Controls.Add(addCustomerBtn);
            Controls.Add(customerCountry);
            Controls.Add(label5);
            Controls.Add(customerCity);
            Controls.Add(label4);
            Controls.Add(customerLastName);
            Controls.Add(label3);
            Controls.Add(customerFirstName);
            Controls.Add(label2);
            Font = new Font("Lato", 9F, FontStyle.Regular, GraphicsUnit.Point);
            FormBorderStyle = FormBorderStyle.None;
            Name = "AddCustomerForm";
            StartPosition = FormStartPosition.CenterParent;
            Text = "AddCustomerForm";
            Load += AddCustomerForm_Load;
            panel1.ResumeLayout(false);
            panel1.PerformLayout();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Panel panel1;
        private Guna.UI2.WinForms.Guna2ImageButton closeBtn;
        private Label label1;
        public Guna.UI2.WinForms.Guna2TextBox customerPhoneNumber;
        private Label label6;
        public Guna.UI2.WinForms.Guna2TextBox customerLocation;
        private Label label7;
        private Guna.UI2.WinForms.Guna2Button addCustomerBtn;
        public Guna.UI2.WinForms.Guna2TextBox customerCountry;
        private Label label5;
        public Guna.UI2.WinForms.Guna2TextBox customerCity;
        private Label label4;
        public Guna.UI2.WinForms.Guna2TextBox customerLastName;
        private Label label3;
        public Guna.UI2.WinForms.Guna2TextBox customerFirstName;
        private Label label2;
    }
}