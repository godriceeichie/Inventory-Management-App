namespace Inventory_Management_App
{
    partial class SignIn
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
            Guna.UI2.WinForms.Suite.CustomizableEdges customizableEdges1 = new Guna.UI2.WinForms.Suite.CustomizableEdges();
            Guna.UI2.WinForms.Suite.CustomizableEdges customizableEdges2 = new Guna.UI2.WinForms.Suite.CustomizableEdges();
            Guna.UI2.WinForms.Suite.CustomizableEdges customizableEdges3 = new Guna.UI2.WinForms.Suite.CustomizableEdges();
            Guna.UI2.WinForms.Suite.CustomizableEdges customizableEdges4 = new Guna.UI2.WinForms.Suite.CustomizableEdges();
            Guna.UI2.WinForms.Suite.CustomizableEdges customizableEdges5 = new Guna.UI2.WinForms.Suite.CustomizableEdges();
            Guna.UI2.WinForms.Suite.CustomizableEdges customizableEdges6 = new Guna.UI2.WinForms.Suite.CustomizableEdges();
            Guna.UI2.WinForms.Suite.CustomizableEdges customizableEdges7 = new Guna.UI2.WinForms.Suite.CustomizableEdges();
            createAccountLink = new Label();
            label6 = new Label();
            signInBtn = new Guna.UI2.WinForms.Guna2Button();
            showPassword = new CheckBox();
            passwordInput = new Guna.UI2.WinForms.Guna2TextBox();
            label5 = new Label();
            emailInput = new Guna.UI2.WinForms.Guna2TextBox();
            label4 = new Label();
            label2 = new Label();
            label1 = new Label();
            closeBtn = new Guna.UI2.WinForms.Guna2ImageButton();
            SuspendLayout();
            // 
            // createAccountLink
            // 
            createAccountLink.AutoSize = true;
            createAccountLink.Cursor = Cursors.Hand;
            createAccountLink.Font = new Font("Lato", 9F, FontStyle.Underline, GraphicsUnit.Point);
            createAccountLink.ForeColor = Color.FromArgb(67, 70, 85);
            createAccountLink.Location = new Point(367, 648);
            createAccountLink.Name = "createAccountLink";
            createAccountLink.Size = new Size(136, 29);
            createAccountLink.TabIndex = 30;
            createAccountLink.Text = "Create One";
            createAccountLink.Click += createAccountLink_Click;
            // 
            // label6
            // 
            label6.ForeColor = Color.Gray;
            label6.Location = new Point(119, 648);
            label6.Name = "label6";
            label6.Size = new Size(267, 40);
            label6.TabIndex = 29;
            label6.Text = "Don't have an account? ";
            // 
            // signInBtn
            // 
            signInBtn.BackColor = Color.White;
            signInBtn.BorderRadius = 7;
            signInBtn.CustomizableEdges = customizableEdges1;
            signInBtn.DisabledState.BorderColor = Color.DarkGray;
            signInBtn.DisabledState.CustomBorderColor = Color.DarkGray;
            signInBtn.DisabledState.FillColor = Color.FromArgb(169, 169, 169);
            signInBtn.DisabledState.ForeColor = Color.FromArgb(141, 141, 141);
            signInBtn.FillColor = Color.FromArgb(43, 119, 234);
            signInBtn.Font = new Font("Lato", 10.124999F, FontStyle.Bold, GraphicsUnit.Point);
            signInBtn.ForeColor = Color.White;
            signInBtn.Location = new Point(61, 572);
            signInBtn.Name = "signInBtn";
            signInBtn.ShadowDecoration.CustomizableEdges = customizableEdges2;
            signInBtn.Size = new Size(515, 63);
            signInBtn.TabIndex = 28;
            signInBtn.Text = "Sign In";
            signInBtn.Click += signInBtn_Click_1;
            // 
            // showPassword
            // 
            showPassword.AutoSize = true;
            showPassword.ForeColor = Color.Gray;
            showPassword.Location = new Point(61, 484);
            showPassword.Name = "showPassword";
            showPassword.Size = new Size(207, 33);
            showPassword.TabIndex = 27;
            showPassword.Text = "Show Password";
            showPassword.UseVisualStyleBackColor = true;
            showPassword.CheckedChanged += showPassword_CheckedChanged;
            // 
            // passwordInput
            // 
            passwordInput.BorderColor = Color.Gray;
            passwordInput.BorderRadius = 5;
            passwordInput.CustomizableEdges = customizableEdges3;
            passwordInput.DefaultText = "";
            passwordInput.DisabledState.BorderColor = Color.FromArgb(208, 208, 208);
            passwordInput.DisabledState.FillColor = Color.FromArgb(226, 226, 226);
            passwordInput.DisabledState.ForeColor = Color.FromArgb(138, 138, 138);
            passwordInput.DisabledState.PlaceholderForeColor = Color.FromArgb(138, 138, 138);
            passwordInput.FocusedState.BorderColor = Color.FromArgb(94, 148, 255);
            passwordInput.Font = new Font("Segoe UI", 9F, FontStyle.Regular, GraphicsUnit.Point);
            passwordInput.HoverState.BorderColor = Color.FromArgb(94, 148, 255);
            passwordInput.Location = new Point(61, 404);
            passwordInput.Name = "passwordInput";
            passwordInput.PasswordChar = '\0';
            passwordInput.PlaceholderText = "";
            passwordInput.SelectedText = "";
            passwordInput.ShadowDecoration.CustomizableEdges = customizableEdges4;
            passwordInput.Size = new Size(516, 63);
            passwordInput.TabIndex = 26;
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.Font = new Font("Lato", 10.124999F, FontStyle.Regular, GraphicsUnit.Point);
            label5.ForeColor = Color.Gray;
            label5.Location = new Point(52, 353);
            label5.Name = "label5";
            label5.Size = new Size(131, 33);
            label5.TabIndex = 25;
            label5.Text = "Password";
            // 
            // emailInput
            // 
            emailInput.BorderColor = Color.Gray;
            emailInput.BorderRadius = 5;
            emailInput.CustomizableEdges = customizableEdges5;
            emailInput.DefaultText = "";
            emailInput.DisabledState.BorderColor = Color.FromArgb(208, 208, 208);
            emailInput.DisabledState.FillColor = Color.FromArgb(226, 226, 226);
            emailInput.DisabledState.ForeColor = Color.FromArgb(138, 138, 138);
            emailInput.DisabledState.PlaceholderForeColor = Color.FromArgb(138, 138, 138);
            emailInput.FocusedState.BorderColor = Color.FromArgb(94, 148, 255);
            emailInput.Font = new Font("Segoe UI", 9F, FontStyle.Regular, GraphicsUnit.Point);
            emailInput.HoverState.BorderColor = Color.FromArgb(94, 148, 255);
            emailInput.Location = new Point(60, 232);
            emailInput.Name = "emailInput";
            emailInput.PasswordChar = '\0';
            emailInput.PlaceholderText = "";
            emailInput.SelectedText = "";
            emailInput.ShadowDecoration.CustomizableEdges = customizableEdges6;
            emailInput.Size = new Size(516, 63);
            emailInput.TabIndex = 24;
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Font = new Font("Lato", 10.124999F, FontStyle.Regular, GraphicsUnit.Point);
            label4.ForeColor = Color.Gray;
            label4.Location = new Point(51, 181);
            label4.Name = "label4";
            label4.Size = new Size(81, 33);
            label4.TabIndex = 23;
            label4.Text = "Email";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Font = new Font("Lato", 10.124999F, FontStyle.Regular, GraphicsUnit.Point);
            label2.ForeColor = Color.Gray;
            label2.Location = new Point(51, 99);
            label2.Name = "label2";
            label2.Size = new Size(224, 33);
            label2.TabIndex = 20;
            label2.Text = "Let's get you back";
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Lato", 16F, FontStyle.Bold, GraphicsUnit.Point);
            label1.ForeColor = Color.FromArgb(0, 71, 176);
            label1.Location = new Point(48, 35);
            label1.Name = "label1";
            label1.Size = new Size(149, 51);
            label1.TabIndex = 19;
            label1.Text = "Sign In";
            // 
            // closeBtn
            // 
            closeBtn.CheckedState.ImageSize = new Size(64, 64);
            closeBtn.HoverState.ImageSize = new Size(64, 64);
            closeBtn.Image = Properties.Resources.remove__1_;
            closeBtn.ImageOffset = new Point(0, 0);
            closeBtn.ImageRotate = 0F;
            closeBtn.ImageSize = new Size(50, 50);
            closeBtn.Location = new Point(504, 17);
            closeBtn.Name = "closeBtn";
            closeBtn.PressedState.ImageSize = new Size(64, 64);
            closeBtn.ShadowDecoration.CustomizableEdges = customizableEdges7;
            closeBtn.Size = new Size(82, 72);
            closeBtn.TabIndex = 31;
            closeBtn.Click += closeBtn_Click;
            // 
            // SignIn
            // 
            AutoScaleDimensions = new SizeF(14F, 29F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.White;
            ClientSize = new Size(643, 744);
            Controls.Add(closeBtn);
            Controls.Add(createAccountLink);
            Controls.Add(label6);
            Controls.Add(signInBtn);
            Controls.Add(showPassword);
            Controls.Add(passwordInput);
            Controls.Add(label5);
            Controls.Add(emailInput);
            Controls.Add(label4);
            Controls.Add(label2);
            Controls.Add(label1);
            Font = new Font("Lato", 9F, FontStyle.Regular, GraphicsUnit.Point);
            FormBorderStyle = FormBorderStyle.None;
            Name = "SignIn";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "SignInForm";
            Load += SignInForm_Load;
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label label7;
        private Label label6;
        private Guna.UI2.WinForms.Guna2Button signInBtn;
        private CheckBox showPassword;
        private Guna.UI2.WinForms.Guna2TextBox passwordInput;
        private Label label5;
        private Guna.UI2.WinForms.Guna2TextBox emailInput;
        private Label label4;
        private Label label2;
        private Label label1;
        private Label createAccountLink;
        private Guna.UI2.WinForms.Guna2ImageButton closeBtn;
    }
}