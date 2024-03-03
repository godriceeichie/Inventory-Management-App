namespace Inventory_Management_App.Forms
{
    partial class Categories
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
            Guna.UI2.WinForms.Suite.CustomizableEdges customizableEdges4 = new Guna.UI2.WinForms.Suite.CustomizableEdges();
            Guna.UI2.WinForms.Suite.CustomizableEdges customizableEdges5 = new Guna.UI2.WinForms.Suite.CustomizableEdges();
            Guna.UI2.WinForms.Suite.CustomizableEdges customizableEdges2 = new Guna.UI2.WinForms.Suite.CustomizableEdges();
            Guna.UI2.WinForms.Suite.CustomizableEdges customizableEdges3 = new Guna.UI2.WinForms.Suite.CustomizableEdges();
            DataGridViewCellStyle dataGridViewCellStyle1 = new DataGridViewCellStyle();
            DataGridViewCellStyle dataGridViewCellStyle2 = new DataGridViewCellStyle();
            DataGridViewCellStyle dataGridViewCellStyle3 = new DataGridViewCellStyle();
            DataGridViewCellStyle dataGridViewCellStyle4 = new DataGridViewCellStyle();
            Guna.UI2.WinForms.Suite.CustomizableEdges customizableEdges6 = new Guna.UI2.WinForms.Suite.CustomizableEdges();
            Guna.UI2.WinForms.Suite.CustomizableEdges customizableEdges7 = new Guna.UI2.WinForms.Suite.CustomizableEdges();
            Guna.UI2.WinForms.Suite.CustomizableEdges customizableEdges1 = new Guna.UI2.WinForms.Suite.CustomizableEdges();
            label1 = new Label();
            guna2Panel1 = new Guna.UI2.WinForms.Guna2Panel();
            categorySearchBox = new Guna.UI2.WinForms.Guna2TextBox();
            categoriesGrid = new Guna.UI2.WinForms.Guna2DataGridView();
            Column1 = new DataGridViewTextBoxColumn();
            Column2 = new DataGridViewTextBoxColumn();
            Column7 = new DataGridViewTextBoxColumn();
            Column8 = new DataGridViewImageColumn();
            Column9 = new DataGridViewImageColumn();
            productsPanel = new Panel();
            addCategoryBtn = new Guna.UI2.WinForms.Guna2Button();
            closeBtn = new Guna.UI2.WinForms.Guna2ImageButton();
            guna2Panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)categoriesGrid).BeginInit();
            productsPanel.SuspendLayout();
            SuspendLayout();
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Lato", 11.9999981F, FontStyle.Bold, GraphicsUnit.Point);
            label1.ForeColor = Color.FromArgb(67, 70, 85);
            label1.Location = new Point(33, 27);
            label1.Name = "label1";
            label1.Size = new Size(172, 39);
            label1.TabIndex = 0;
            label1.Text = "Categories";
            // 
            // guna2Panel1
            // 
            guna2Panel1.Controls.Add(closeBtn);
            guna2Panel1.Controls.Add(categorySearchBox);
            guna2Panel1.Controls.Add(label1);
            guna2Panel1.CustomizableEdges = customizableEdges4;
            guna2Panel1.Dock = DockStyle.Top;
            guna2Panel1.FillColor = Color.White;
            guna2Panel1.Location = new Point(0, 0);
            guna2Panel1.Name = "guna2Panel1";
            guna2Panel1.ShadowDecoration.CustomizableEdges = customizableEdges5;
            guna2Panel1.Size = new Size(1770, 93);
            guna2Panel1.TabIndex = 1;
            // 
            // categorySearchBox
            // 
            categorySearchBox.BorderColor = Color.FromArgb(164, 165, 169);
            categorySearchBox.BorderRadius = 10;
            categorySearchBox.CustomizableEdges = customizableEdges2;
            categorySearchBox.DefaultText = "";
            categorySearchBox.DisabledState.BorderColor = Color.FromArgb(208, 208, 208);
            categorySearchBox.DisabledState.FillColor = Color.FromArgb(226, 226, 226);
            categorySearchBox.DisabledState.ForeColor = Color.FromArgb(138, 138, 138);
            categorySearchBox.DisabledState.PlaceholderForeColor = Color.FromArgb(138, 138, 138);
            categorySearchBox.FocusedState.BorderColor = Color.FromArgb(94, 148, 255);
            categorySearchBox.Font = new Font("Lato", 9F, FontStyle.Regular, GraphicsUnit.Point);
            categorySearchBox.HoverState.BorderColor = Color.FromArgb(94, 148, 255);
            categorySearchBox.IconLeft = Properties.Resources.search_interface_symbol1;
            categorySearchBox.IconLeftOffset = new Point(10, 0);
            categorySearchBox.IconRightOffset = new Point(10, 0);
            categorySearchBox.Location = new Point(528, 17);
            categorySearchBox.Name = "categorySearchBox";
            categorySearchBox.PasswordChar = '\0';
            categorySearchBox.PlaceholderForeColor = Color.FromArgb(125, 137, 149);
            categorySearchBox.PlaceholderText = "Search for category";
            categorySearchBox.SelectedText = "";
            categorySearchBox.ShadowDecoration.CustomizableEdges = customizableEdges3;
            categorySearchBox.Size = new Size(650, 60);
            categorySearchBox.TabIndex = 0;
            categorySearchBox.TextChanged += categorySearchBox_TextChanged;
            // 
            // categoriesGrid
            // 
            dataGridViewCellStyle1.BackColor = Color.White;
            categoriesGrid.AlternatingRowsDefaultCellStyle = dataGridViewCellStyle1;
            dataGridViewCellStyle2.Alignment = DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle2.BackColor = Color.FromArgb(0, 71, 176);
            dataGridViewCellStyle2.Font = new Font("Lato", 9F, FontStyle.Regular, GraphicsUnit.Point);
            dataGridViewCellStyle2.ForeColor = Color.White;
            dataGridViewCellStyle2.SelectionBackColor = Color.FromArgb(43, 119, 234);
            dataGridViewCellStyle2.SelectionForeColor = SystemColors.HighlightText;
            dataGridViewCellStyle2.WrapMode = DataGridViewTriState.True;
            categoriesGrid.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle2;
            categoriesGrid.ColumnHeadersHeight = 70;
            categoriesGrid.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.EnableResizing;
            categoriesGrid.Columns.AddRange(new DataGridViewColumn[] { Column1, Column2, Column7, Column8, Column9 });
            dataGridViewCellStyle3.Alignment = DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle3.BackColor = Color.White;
            dataGridViewCellStyle3.Font = new Font("Lato", 9F, FontStyle.Regular, GraphicsUnit.Point);
            dataGridViewCellStyle3.ForeColor = Color.FromArgb(71, 69, 94);
            dataGridViewCellStyle3.SelectionBackColor = Color.FromArgb(231, 229, 255);
            dataGridViewCellStyle3.SelectionForeColor = Color.FromArgb(71, 69, 94);
            dataGridViewCellStyle3.WrapMode = DataGridViewTriState.False;
            categoriesGrid.DefaultCellStyle = dataGridViewCellStyle3;
            categoriesGrid.GridColor = Color.FromArgb(231, 229, 255);
            categoriesGrid.Location = new Point(41, 252);
            categoriesGrid.Name = "categoriesGrid";
            categoriesGrid.RowHeadersVisible = false;
            categoriesGrid.RowHeadersWidth = 82;
            dataGridViewCellStyle4.Alignment = DataGridViewContentAlignment.MiddleCenter;
            dataGridViewCellStyle4.ForeColor = Color.Black;
            categoriesGrid.RowsDefaultCellStyle = dataGridViewCellStyle4;
            categoriesGrid.RowTemplate.DefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleCenter;
            categoriesGrid.RowTemplate.Height = 55;
            categoriesGrid.Size = new Size(1688, 724);
            categoriesGrid.TabIndex = 3;
            categoriesGrid.ThemeStyle.AlternatingRowsStyle.BackColor = Color.White;
            categoriesGrid.ThemeStyle.AlternatingRowsStyle.Font = null;
            categoriesGrid.ThemeStyle.AlternatingRowsStyle.ForeColor = Color.Empty;
            categoriesGrid.ThemeStyle.AlternatingRowsStyle.SelectionBackColor = Color.Empty;
            categoriesGrid.ThemeStyle.AlternatingRowsStyle.SelectionForeColor = Color.Empty;
            categoriesGrid.ThemeStyle.BackColor = Color.White;
            categoriesGrid.ThemeStyle.GridColor = Color.FromArgb(231, 229, 255);
            categoriesGrid.ThemeStyle.HeaderStyle.BackColor = Color.FromArgb(100, 88, 255);
            categoriesGrid.ThemeStyle.HeaderStyle.BorderStyle = DataGridViewHeaderBorderStyle.None;
            categoriesGrid.ThemeStyle.HeaderStyle.Font = new Font("Lato", 9F, FontStyle.Regular, GraphicsUnit.Point);
            categoriesGrid.ThemeStyle.HeaderStyle.ForeColor = Color.White;
            categoriesGrid.ThemeStyle.HeaderStyle.HeaightSizeMode = DataGridViewColumnHeadersHeightSizeMode.EnableResizing;
            categoriesGrid.ThemeStyle.HeaderStyle.Height = 70;
            categoriesGrid.ThemeStyle.ReadOnly = false;
            categoriesGrid.ThemeStyle.RowsStyle.BackColor = Color.White;
            categoriesGrid.ThemeStyle.RowsStyle.BorderStyle = DataGridViewCellBorderStyle.SingleHorizontal;
            categoriesGrid.ThemeStyle.RowsStyle.Font = new Font("Lato", 9F, FontStyle.Regular, GraphicsUnit.Point);
            categoriesGrid.ThemeStyle.RowsStyle.ForeColor = Color.FromArgb(71, 69, 94);
            categoriesGrid.ThemeStyle.RowsStyle.Height = 55;
            categoriesGrid.ThemeStyle.RowsStyle.SelectionBackColor = Color.FromArgb(231, 229, 255);
            categoriesGrid.ThemeStyle.RowsStyle.SelectionForeColor = Color.FromArgb(71, 69, 94);
            categoriesGrid.CellClick += categoriesGrid_CellClick_1;
            categoriesGrid.CellContentClick += categoriesGrid_CellContentClick;
            // 
            // Column1
            // 
            Column1.AutoSizeMode = DataGridViewAutoSizeColumnMode.AllCells;
            Column1.HeaderText = "No";
            Column1.MinimumWidth = 10;
            Column1.Name = "Column1";
            Column1.Width = 87;
            // 
            // Column2
            // 
            Column2.AutoSizeMode = DataGridViewAutoSizeColumnMode.Fill;
            Column2.HeaderText = "Category ID";
            Column2.MinimumWidth = 10;
            Column2.Name = "Column2";
            // 
            // Column7
            // 
            Column7.HeaderText = "Category Name";
            Column7.MinimumWidth = 10;
            Column7.Name = "Column7";
            // 
            // Column8
            // 
            Column8.HeaderText = "";
            Column8.Image = Properties.Resources.edit_text2;
            Column8.MinimumWidth = 10;
            Column8.Name = "Column8";
            // 
            // Column9
            // 
            Column9.HeaderText = "";
            Column9.Image = Properties.Resources.delete2;
            Column9.MinimumWidth = 10;
            Column9.Name = "Column9";
            // 
            // productsPanel
            // 
            productsPanel.BackColor = Color.FromArgb(0, 0, 15, 255);
            productsPanel.Controls.Add(addCategoryBtn);
            productsPanel.Controls.Add(categoriesGrid);
            productsPanel.Controls.Add(guna2Panel1);
            productsPanel.Dock = DockStyle.Bottom;
            productsPanel.Location = new Point(0, 0);
            productsPanel.Name = "productsPanel";
            productsPanel.Size = new Size(1770, 1144);
            productsPanel.TabIndex = 6;
            productsPanel.Paint += productsPanel_Paint;
            // 
            // addCategoryBtn
            // 
            addCategoryBtn.BorderRadius = 8;
            addCategoryBtn.CustomizableEdges = customizableEdges6;
            addCategoryBtn.DisabledState.BorderColor = Color.DarkGray;
            addCategoryBtn.DisabledState.CustomBorderColor = Color.DarkGray;
            addCategoryBtn.DisabledState.FillColor = Color.FromArgb(169, 169, 169);
            addCategoryBtn.DisabledState.ForeColor = Color.FromArgb(141, 141, 141);
            addCategoryBtn.FillColor = Color.FromArgb(43, 119, 234);
            addCategoryBtn.Font = new Font("Lato", 9F, FontStyle.Bold, GraphicsUnit.Point);
            addCategoryBtn.ForeColor = Color.White;
            addCategoryBtn.Location = new Point(41, 141);
            addCategoryBtn.Name = "addCategoryBtn";
            addCategoryBtn.ShadowDecoration.CustomizableEdges = customizableEdges7;
            addCategoryBtn.Size = new Size(256, 65);
            addCategoryBtn.TabIndex = 8;
            addCategoryBtn.Text = "Add Category";
            addCategoryBtn.Click += addCategoryBtn_Click;
            // 
            // closeBtn
            // 
            closeBtn.CheckedState.ImageSize = new Size(64, 64);
            closeBtn.HoverState.ImageSize = new Size(64, 64);
            closeBtn.Image = Properties.Resources.remove__1_;
            closeBtn.ImageOffset = new Point(0, 0);
            closeBtn.ImageRotate = 0F;
            closeBtn.ImageSize = new Size(50, 50);
            closeBtn.Location = new Point(1647, 12);
            closeBtn.Name = "closeBtn";
            closeBtn.PressedState.ImageSize = new Size(64, 64);
            closeBtn.ShadowDecoration.CustomizableEdges = customizableEdges1;
            closeBtn.Size = new Size(82, 72);
            closeBtn.TabIndex = 32;
            closeBtn.Click += closeBtn_Click;
            // 
            // Categories
            // 
            AutoScaleDimensions = new SizeF(14F, 29F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.FromArgb(233, 239, 255);
            ClientSize = new Size(1770, 1144);
            Controls.Add(productsPanel);
            Font = new Font("Lato", 9F, FontStyle.Regular, GraphicsUnit.Point);
            FormBorderStyle = FormBorderStyle.None;
            Name = "Categories";
            Text = "Categories";
            guna2Panel1.ResumeLayout(false);
            guna2Panel1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)categoriesGrid).EndInit();
            productsPanel.ResumeLayout(false);
            ResumeLayout(false);
        }

        #endregion

        private Label label1;
        private Guna.UI2.WinForms.Guna2Button addCategoryBtn;
        private Guna.UI2.WinForms.Guna2Panel guna2Panel1;
        private Guna.UI2.WinForms.Guna2TextBox categorySearchBox;
        private DataGridViewTextBoxColumn Column6;
        private DataGridViewTextBoxColumn Column5;
        private DataGridViewTextBoxColumn Column3;
        private Guna.UI2.WinForms.Guna2Button editBtn;
        private Guna.UI2.WinForms.Guna2Button deleteBtn;
        private Guna.UI2.WinForms.Guna2DataGridView categoriesGrid;
        private DataGridViewTextBoxColumn Column4;
        private Panel productsPanel;
        private DataGridViewTextBoxColumn Column1;
        private DataGridViewTextBoxColumn Column2;
        private DataGridViewTextBoxColumn Column7;
        private DataGridViewImageColumn Column8;
        private DataGridViewImageColumn Column9;
        private Guna.UI2.WinForms.Guna2ImageButton closeBtn;
    }
}