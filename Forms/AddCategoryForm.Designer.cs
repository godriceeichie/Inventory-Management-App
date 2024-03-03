namespace Inventory_Management_App.Forms
{
    partial class AddCategoryForm
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(AddCategoryForm));
            Guna.UI2.WinForms.Suite.CustomizableEdges customizableEdges1 = new Guna.UI2.WinForms.Suite.CustomizableEdges();
            Guna.UI2.WinForms.Suite.CustomizableEdges customizableEdges2 = new Guna.UI2.WinForms.Suite.CustomizableEdges();
            Guna.UI2.WinForms.Suite.CustomizableEdges customizableEdges3 = new Guna.UI2.WinForms.Suite.CustomizableEdges();
            Guna.UI2.WinForms.Suite.CustomizableEdges customizableEdges4 = new Guna.UI2.WinForms.Suite.CustomizableEdges();
            Guna.UI2.WinForms.Suite.CustomizableEdges customizableEdges5 = new Guna.UI2.WinForms.Suite.CustomizableEdges();
            panel1 = new Panel();
            closeBtn = new Guna.UI2.WinForms.Guna2ImageButton();
            label1 = new Label();
            addCategoryBtn = new Guna.UI2.WinForms.Guna2Button();
            categoryName = new Guna.UI2.WinForms.Guna2TextBox();
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
            label1.Size = new Size(295, 39);
            label1.TabIndex = 0;
            label1.Text = "Add Category Form";
            // 
            // addCategoryBtn
            // 
            addCategoryBtn.BorderRadius = 7;
            addCategoryBtn.CustomizableEdges = customizableEdges2;
            addCategoryBtn.DisabledState.BorderColor = Color.DarkGray;
            addCategoryBtn.DisabledState.CustomBorderColor = Color.DarkGray;
            addCategoryBtn.DisabledState.FillColor = Color.FromArgb(169, 169, 169);
            addCategoryBtn.DisabledState.ForeColor = Color.FromArgb(141, 141, 141);
            addCategoryBtn.FillColor = Color.FromArgb(43, 119, 234);
            addCategoryBtn.Font = new Font("Lato", 10.124999F, FontStyle.Bold, GraphicsUnit.Point);
            addCategoryBtn.ForeColor = Color.White;
            addCategoryBtn.Location = new Point(44, 322);
            addCategoryBtn.Name = "addCategoryBtn";
            addCategoryBtn.ShadowDecoration.CustomizableEdges = customizableEdges3;
            addCategoryBtn.Size = new Size(680, 69);
            addCategoryBtn.TabIndex = 24;
            addCategoryBtn.Text = "Add Category";
            addCategoryBtn.Click += addCategoryBtn_Click;
            // 
            // categoryName
            // 
            categoryName.BorderColor = Color.Gray;
            categoryName.BorderRadius = 7;
            categoryName.CustomizableEdges = customizableEdges4;
            categoryName.DefaultText = "";
            categoryName.DisabledState.BorderColor = Color.FromArgb(208, 208, 208);
            categoryName.DisabledState.FillColor = Color.FromArgb(226, 226, 226);
            categoryName.DisabledState.ForeColor = Color.FromArgb(138, 138, 138);
            categoryName.DisabledState.PlaceholderForeColor = Color.FromArgb(138, 138, 138);
            categoryName.FocusedState.BorderColor = Color.FromArgb(94, 148, 255);
            categoryName.Font = new Font("Segoe UI", 9F, FontStyle.Regular, GraphicsUnit.Point);
            categoryName.HoverState.BorderColor = Color.FromArgb(94, 148, 255);
            categoryName.Location = new Point(44, 203);
            categoryName.Name = "categoryName";
            categoryName.PasswordChar = '\0';
            categoryName.PlaceholderText = "";
            categoryName.SelectedText = "";
            categoryName.ShadowDecoration.CustomizableEdges = customizableEdges5;
            categoryName.Size = new Size(680, 63);
            categoryName.TabIndex = 15;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Font = new Font("Lato", 10.124999F, FontStyle.Regular, GraphicsUnit.Point);
            label2.ForeColor = Color.Gray;
            label2.Location = new Point(34, 156);
            label2.Name = "label2";
            label2.Size = new Size(208, 33);
            label2.TabIndex = 14;
            label2.Text = "Category Name:";
            // 
            // AddCategoryForm
            // 
            AutoScaleDimensions = new SizeF(14F, 29F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.White;
            ClientSize = new Size(764, 450);
            Controls.Add(panel1);
            Controls.Add(addCategoryBtn);
            Controls.Add(categoryName);
            Controls.Add(label2);
            Font = new Font("Lato", 9F, FontStyle.Regular, GraphicsUnit.Point);
            FormBorderStyle = FormBorderStyle.None;
            Name = "AddCategoryForm";
            StartPosition = FormStartPosition.CenterParent;
            Text = "AddCategoryForm";
            Load += AddCategoryForm_Load;
            panel1.ResumeLayout(false);
            panel1.PerformLayout();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Panel panel1;
        private Guna.UI2.WinForms.Guna2ImageButton closeBtn;
        private Label label1;
        private Guna.UI2.WinForms.Guna2Button addCategoryBtn;
        private Guna.UI2.WinForms.Guna2TextBox categoryName;
        private Label label2;
    }
}