namespace Inventory_Management_App.Forms
{
    partial class Products
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
            Guna.UI2.WinForms.Suite.CustomizableEdges customizableEdges6 = new Guna.UI2.WinForms.Suite.CustomizableEdges();
            Guna.UI2.WinForms.Suite.CustomizableEdges customizableEdges7 = new Guna.UI2.WinForms.Suite.CustomizableEdges();
            DataGridViewCellStyle dataGridViewCellStyle1 = new DataGridViewCellStyle();
            DataGridViewCellStyle dataGridViewCellStyle2 = new DataGridViewCellStyle();
            DataGridViewCellStyle dataGridViewCellStyle3 = new DataGridViewCellStyle();
            DataGridViewCellStyle dataGridViewCellStyle4 = new DataGridViewCellStyle();
            Guna.UI2.WinForms.Suite.CustomizableEdges customizableEdges8 = new Guna.UI2.WinForms.Suite.CustomizableEdges();
            Guna.UI2.WinForms.Suite.CustomizableEdges customizableEdges9 = new Guna.UI2.WinForms.Suite.CustomizableEdges();
            Guna.UI2.WinForms.Suite.CustomizableEdges customizableEdges10 = new Guna.UI2.WinForms.Suite.CustomizableEdges();
            Guna.UI2.WinForms.Suite.CustomizableEdges customizableEdges11 = new Guna.UI2.WinForms.Suite.CustomizableEdges();
            Guna.UI2.WinForms.Suite.CustomizableEdges customizableEdges1 = new Guna.UI2.WinForms.Suite.CustomizableEdges();
            guna2Panel1 = new Guna.UI2.WinForms.Guna2Panel();
            productSearchBox = new Guna.UI2.WinForms.Guna2TextBox();
            label1 = new Label();
            addProductBtn = new Guna.UI2.WinForms.Guna2Button();
            productsGrid = new Guna.UI2.WinForms.Guna2DataGridView();
            Column1 = new DataGridViewTextBoxColumn();
            Column2 = new DataGridViewTextBoxColumn();
            Column3 = new DataGridViewTextBoxColumn();
            Column4 = new DataGridViewTextBoxColumn();
            Column5 = new DataGridViewTextBoxColumn();
            Column6 = new DataGridViewTextBoxColumn();
            Column7 = new DataGridViewTextBoxColumn();
            Column8 = new DataGridViewImageColumn();
            Column9 = new DataGridViewImageColumn();
            deleteBtn = new Guna.UI2.WinForms.Guna2Button();
            editBtn = new Guna.UI2.WinForms.Guna2Button();
            productsPanel = new Panel();
            closeBtn = new Guna.UI2.WinForms.Guna2ImageButton();
            guna2Panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)productsGrid).BeginInit();
            productsPanel.SuspendLayout();
            SuspendLayout();
            // 
            // guna2Panel1
            // 
            guna2Panel1.Controls.Add(closeBtn);
            guna2Panel1.Controls.Add(productSearchBox);
            guna2Panel1.Controls.Add(label1);
            guna2Panel1.CustomizableEdges = customizableEdges4;
            guna2Panel1.Dock = DockStyle.Top;
            guna2Panel1.FillColor = Color.White;
            guna2Panel1.Location = new Point(0, 0);
            guna2Panel1.Name = "guna2Panel1";
            guna2Panel1.ShadowDecoration.CustomizableEdges = customizableEdges5;
            guna2Panel1.Size = new Size(1770, 93);
            guna2Panel1.TabIndex = 1;
            guna2Panel1.Paint += guna2Panel1_Paint;
            // 
            // productSearchBox
            // 
            productSearchBox.BorderColor = Color.FromArgb(164, 165, 169);
            productSearchBox.BorderRadius = 10;
            productSearchBox.CustomizableEdges = customizableEdges2;
            productSearchBox.DefaultText = "";
            productSearchBox.DisabledState.BorderColor = Color.FromArgb(208, 208, 208);
            productSearchBox.DisabledState.FillColor = Color.FromArgb(226, 226, 226);
            productSearchBox.DisabledState.ForeColor = Color.FromArgb(138, 138, 138);
            productSearchBox.DisabledState.PlaceholderForeColor = Color.FromArgb(138, 138, 138);
            productSearchBox.FocusedState.BorderColor = Color.FromArgb(94, 148, 255);
            productSearchBox.Font = new Font("Lato", 9F, FontStyle.Regular, GraphicsUnit.Point);
            productSearchBox.HoverState.BorderColor = Color.FromArgb(94, 148, 255);
            productSearchBox.IconLeft = Properties.Resources.search_interface_symbol1;
            productSearchBox.IconLeftOffset = new Point(10, 0);
            productSearchBox.IconRightOffset = new Point(10, 0);
            productSearchBox.Location = new Point(528, 17);
            productSearchBox.Name = "productSearchBox";
            productSearchBox.PasswordChar = '\0';
            productSearchBox.PlaceholderForeColor = Color.FromArgb(125, 137, 149);
            productSearchBox.PlaceholderText = "Search for product";
            productSearchBox.SelectedText = "";
            productSearchBox.ShadowDecoration.CustomizableEdges = customizableEdges3;
            productSearchBox.Size = new Size(650, 60);
            productSearchBox.TabIndex = 0;
            productSearchBox.TextChanged += productSearchBox_TextChanged;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Lato", 11.9999981F, FontStyle.Bold, GraphicsUnit.Point);
            label1.ForeColor = Color.FromArgb(67, 70, 85);
            label1.Location = new Point(33, 27);
            label1.Name = "label1";
            label1.Size = new Size(145, 39);
            label1.TabIndex = 0;
            label1.Text = "Products";
            label1.Click += label1_Click;
            // 
            // addProductBtn
            // 
            addProductBtn.BorderRadius = 8;
            addProductBtn.CustomizableEdges = customizableEdges6;
            addProductBtn.DisabledState.BorderColor = Color.DarkGray;
            addProductBtn.DisabledState.CustomBorderColor = Color.DarkGray;
            addProductBtn.DisabledState.FillColor = Color.FromArgb(169, 169, 169);
            addProductBtn.DisabledState.ForeColor = Color.FromArgb(141, 141, 141);
            addProductBtn.FillColor = Color.FromArgb(43, 119, 234);
            addProductBtn.Font = new Font("Lato", 9F, FontStyle.Bold, GraphicsUnit.Point);
            addProductBtn.ForeColor = Color.White;
            addProductBtn.Location = new Point(41, 145);
            addProductBtn.Name = "addProductBtn";
            addProductBtn.ShadowDecoration.CustomizableEdges = customizableEdges7;
            addProductBtn.Size = new Size(256, 65);
            addProductBtn.TabIndex = 2;
            addProductBtn.Text = "Add Product";
            addProductBtn.Click += addProductBtn_Click;
            // 
            // productsGrid
            // 
            dataGridViewCellStyle1.BackColor = Color.White;
            productsGrid.AlternatingRowsDefaultCellStyle = dataGridViewCellStyle1;
            dataGridViewCellStyle2.Alignment = DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle2.BackColor = Color.FromArgb(0, 71, 176);
            dataGridViewCellStyle2.Font = new Font("Lato", 9F, FontStyle.Regular, GraphicsUnit.Point);
            dataGridViewCellStyle2.ForeColor = Color.White;
            dataGridViewCellStyle2.SelectionBackColor = Color.FromArgb(43, 119, 234);
            dataGridViewCellStyle2.SelectionForeColor = SystemColors.HighlightText;
            dataGridViewCellStyle2.WrapMode = DataGridViewTriState.True;
            productsGrid.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle2;
            productsGrid.ColumnHeadersHeight = 70;
            productsGrid.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.EnableResizing;
            productsGrid.Columns.AddRange(new DataGridViewColumn[] { Column1, Column2, Column3, Column4, Column5, Column6, Column7, Column8, Column9 });
            dataGridViewCellStyle3.Alignment = DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle3.BackColor = Color.White;
            dataGridViewCellStyle3.Font = new Font("Lato", 9F, FontStyle.Regular, GraphicsUnit.Point);
            dataGridViewCellStyle3.ForeColor = Color.FromArgb(71, 69, 94);
            dataGridViewCellStyle3.SelectionBackColor = Color.FromArgb(231, 229, 255);
            dataGridViewCellStyle3.SelectionForeColor = Color.FromArgb(71, 69, 94);
            dataGridViewCellStyle3.WrapMode = DataGridViewTriState.False;
            productsGrid.DefaultCellStyle = dataGridViewCellStyle3;
            productsGrid.GridColor = Color.FromArgb(231, 229, 255);
            productsGrid.Location = new Point(41, 252);
            productsGrid.Name = "productsGrid";
            productsGrid.RowHeadersVisible = false;
            productsGrid.RowHeadersWidth = 82;
            dataGridViewCellStyle4.Alignment = DataGridViewContentAlignment.MiddleCenter;
            dataGridViewCellStyle4.ForeColor = Color.Black;
            productsGrid.RowsDefaultCellStyle = dataGridViewCellStyle4;
            productsGrid.RowTemplate.DefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleLeft;
            productsGrid.RowTemplate.Height = 55;
            productsGrid.Size = new Size(1681, 724);
            productsGrid.TabIndex = 3;
            productsGrid.ThemeStyle.AlternatingRowsStyle.BackColor = Color.White;
            productsGrid.ThemeStyle.AlternatingRowsStyle.Font = null;
            productsGrid.ThemeStyle.AlternatingRowsStyle.ForeColor = Color.Empty;
            productsGrid.ThemeStyle.AlternatingRowsStyle.SelectionBackColor = Color.Empty;
            productsGrid.ThemeStyle.AlternatingRowsStyle.SelectionForeColor = Color.Empty;
            productsGrid.ThemeStyle.BackColor = Color.White;
            productsGrid.ThemeStyle.GridColor = Color.FromArgb(231, 229, 255);
            productsGrid.ThemeStyle.HeaderStyle.BackColor = Color.FromArgb(100, 88, 255);
            productsGrid.ThemeStyle.HeaderStyle.BorderStyle = DataGridViewHeaderBorderStyle.None;
            productsGrid.ThemeStyle.HeaderStyle.Font = new Font("Lato", 9F, FontStyle.Regular, GraphicsUnit.Point);
            productsGrid.ThemeStyle.HeaderStyle.ForeColor = Color.White;
            productsGrid.ThemeStyle.HeaderStyle.HeaightSizeMode = DataGridViewColumnHeadersHeightSizeMode.EnableResizing;
            productsGrid.ThemeStyle.HeaderStyle.Height = 70;
            productsGrid.ThemeStyle.ReadOnly = false;
            productsGrid.ThemeStyle.RowsStyle.BackColor = Color.White;
            productsGrid.ThemeStyle.RowsStyle.BorderStyle = DataGridViewCellBorderStyle.SingleHorizontal;
            productsGrid.ThemeStyle.RowsStyle.Font = new Font("Lato", 9F, FontStyle.Regular, GraphicsUnit.Point);
            productsGrid.ThemeStyle.RowsStyle.ForeColor = Color.FromArgb(71, 69, 94);
            productsGrid.ThemeStyle.RowsStyle.Height = 55;
            productsGrid.ThemeStyle.RowsStyle.SelectionBackColor = Color.FromArgb(231, 229, 255);
            productsGrid.ThemeStyle.RowsStyle.SelectionForeColor = Color.FromArgb(71, 69, 94);
            productsGrid.CellClick += productsGrid_CellClick;
            productsGrid.CellContentClick += productsGrid_CellContentClick;
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
            Column2.HeaderText = "Product Id";
            Column2.MinimumWidth = 10;
            Column2.Name = "Column2";
            // 
            // Column3
            // 
            Column3.HeaderText = "Name";
            Column3.MinimumWidth = 10;
            Column3.Name = "Column3";
            // 
            // Column4
            // 
            Column4.AutoSizeMode = DataGridViewAutoSizeColumnMode.AllCells;
            Column4.HeaderText = "Quantity";
            Column4.MinimumWidth = 10;
            Column4.Name = "Column4";
            Column4.Width = 149;
            // 
            // Column5
            // 
            Column5.AutoSizeMode = DataGridViewAutoSizeColumnMode.AllCells;
            Column5.HeaderText = "Price";
            Column5.MinimumWidth = 10;
            Column5.Name = "Column5";
            Column5.Width = 111;
            // 
            // Column6
            // 
            Column6.HeaderText = "Description";
            Column6.MinimumWidth = 10;
            Column6.Name = "Column6";
            // 
            // Column7
            // 
            Column7.AutoSizeMode = DataGridViewAutoSizeColumnMode.Fill;
            Column7.HeaderText = "Category";
            Column7.MinimumWidth = 10;
            Column7.Name = "Column7";
            // 
            // Column8
            // 
            Column8.AutoSizeMode = DataGridViewAutoSizeColumnMode.AllCells;
            Column8.HeaderText = "";
            Column8.Image = Properties.Resources.edit_text2;
            Column8.MinimumWidth = 10;
            Column8.Name = "Column8";
            Column8.Width = 32;
            // 
            // Column9
            // 
            Column9.AutoSizeMode = DataGridViewAutoSizeColumnMode.AllCells;
            Column9.HeaderText = "";
            Column9.Image = Properties.Resources.delete2;
            Column9.MinimumWidth = 10;
            Column9.Name = "Column9";
            Column9.Width = 32;
            // 
            // deleteBtn
            // 
            deleteBtn.BorderColor = Color.FromArgb(43, 119, 234);
            deleteBtn.BorderRadius = 7;
            deleteBtn.BorderThickness = 1;
            deleteBtn.CustomizableEdges = customizableEdges8;
            deleteBtn.DisabledState.BorderColor = Color.DarkGray;
            deleteBtn.DisabledState.CustomBorderColor = Color.DarkGray;
            deleteBtn.DisabledState.FillColor = Color.FromArgb(169, 169, 169);
            deleteBtn.DisabledState.ForeColor = Color.FromArgb(141, 141, 141);
            deleteBtn.FillColor = Color.White;
            deleteBtn.Font = new Font("Lato", 9F, FontStyle.Bold, GraphicsUnit.Point);
            deleteBtn.ForeColor = Color.FromArgb(43, 119, 234);
            deleteBtn.Location = new Point(1309, 1016);
            deleteBtn.Name = "deleteBtn";
            deleteBtn.ShadowDecoration.CustomizableEdges = customizableEdges9;
            deleteBtn.Size = new Size(224, 68);
            deleteBtn.TabIndex = 5;
            deleteBtn.Text = "Delete";
            deleteBtn.Click += deleteBtn_Click;
            // 
            // editBtn
            // 
            editBtn.BorderColor = Color.FromArgb(43, 119, 234);
            editBtn.BorderRadius = 7;
            editBtn.BorderThickness = 1;
            editBtn.CustomizableEdges = customizableEdges10;
            editBtn.DisabledState.BorderColor = Color.DarkGray;
            editBtn.DisabledState.CustomBorderColor = Color.DarkGray;
            editBtn.DisabledState.FillColor = Color.FromArgb(169, 169, 169);
            editBtn.DisabledState.ForeColor = Color.FromArgb(141, 141, 141);
            editBtn.FillColor = Color.White;
            editBtn.Font = new Font("Lato", 9F, FontStyle.Bold, GraphicsUnit.Point);
            editBtn.ForeColor = Color.FromArgb(43, 119, 234);
            editBtn.Location = new Point(1046, 1016);
            editBtn.Name = "editBtn";
            editBtn.ShadowDecoration.CustomizableEdges = customizableEdges11;
            editBtn.Size = new Size(224, 68);
            editBtn.TabIndex = 6;
            editBtn.Text = "Edit";
            editBtn.Click += editBtn_Click;
            // 
            // productsPanel
            // 
            productsPanel.BackColor = Color.FromArgb(0, 0, 15, 255);
            productsPanel.Controls.Add(editBtn);
            productsPanel.Controls.Add(deleteBtn);
            productsPanel.Controls.Add(productsGrid);
            productsPanel.Controls.Add(addProductBtn);
            productsPanel.Controls.Add(guna2Panel1);
            productsPanel.Dock = DockStyle.Bottom;
            productsPanel.Location = new Point(0, 0);
            productsPanel.Name = "productsPanel";
            productsPanel.Size = new Size(1770, 1144);
            productsPanel.TabIndex = 5;
            productsPanel.Paint += productsPanel_Paint;
            // 
            // closeBtn
            // 
            closeBtn.CheckedState.ImageSize = new Size(64, 64);
            closeBtn.HoverState.ImageSize = new Size(64, 64);
            closeBtn.Image = Properties.Resources.remove__1_;
            closeBtn.ImageOffset = new Point(0, 0);
            closeBtn.ImageRotate = 0F;
            closeBtn.ImageSize = new Size(50, 50);
            closeBtn.Location = new Point(1640, 5);
            closeBtn.Name = "closeBtn";
            closeBtn.PressedState.ImageSize = new Size(64, 64);
            closeBtn.ShadowDecoration.CustomizableEdges = customizableEdges1;
            closeBtn.Size = new Size(82, 72);
            closeBtn.TabIndex = 32;
            closeBtn.Click += closeBtn_Click;
            // 
            // Products
            // 
            AutoScaleDimensions = new SizeF(14F, 29F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.FromArgb(233, 239, 255);
            ClientSize = new Size(1770, 1144);
            Controls.Add(productsPanel);
            Font = new Font("Lato", 9F, FontStyle.Regular, GraphicsUnit.Point);
            FormBorderStyle = FormBorderStyle.None;
            Name = "Products";
            Text = "Products";
            guna2Panel1.ResumeLayout(false);
            guna2Panel1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)productsGrid).EndInit();
            productsPanel.ResumeLayout(false);
            ResumeLayout(false);
        }

        #endregion

        private Guna.UI2.WinForms.Guna2Panel guna2Panel1;
        private Guna.UI2.WinForms.Guna2TextBox productSearchBox;
        private Label label1;
        private Guna.UI2.WinForms.Guna2Button addProductBtn;
        private Guna.UI2.WinForms.Guna2DataGridView productsGrid;
        private DataGridViewTextBoxColumn Column1;
        private DataGridViewTextBoxColumn Column2;
        private DataGridViewTextBoxColumn Column3;
        private DataGridViewTextBoxColumn Column4;
        private DataGridViewTextBoxColumn Column5;
        private DataGridViewTextBoxColumn Column6;
        private DataGridViewTextBoxColumn Column7;
        private DataGridViewImageColumn Column8;
        private DataGridViewImageColumn Column9;
        private Guna.UI2.WinForms.Guna2Button deleteBtn;
        private Guna.UI2.WinForms.Guna2Button editBtn;
        private Panel productsPanel;
        private Guna.UI2.WinForms.Guna2ImageButton closeBtn;
    }
}