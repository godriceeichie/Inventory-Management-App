namespace Inventory_Management_App.Forms
{
    partial class Orders
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
            Guna.UI2.WinForms.Suite.CustomizableEdges customizableEdges1 = new Guna.UI2.WinForms.Suite.CustomizableEdges();
            guna2Panel1 = new Guna.UI2.WinForms.Guna2Panel();
            productSearchBox = new Guna.UI2.WinForms.Guna2TextBox();
            label1 = new Label();
            addOrderBtn = new Guna.UI2.WinForms.Guna2Button();
            ordersGrid = new Guna.UI2.WinForms.Guna2DataGridView();
            Column1 = new DataGridViewTextBoxColumn();
            Column2 = new DataGridViewTextBoxColumn();
            Column3 = new DataGridViewTextBoxColumn();
            Column4 = new DataGridViewTextBoxColumn();
            Column5 = new DataGridViewTextBoxColumn();
            Column6 = new DataGridViewTextBoxColumn();
            Column7 = new DataGridViewTextBoxColumn();
            Column10 = new DataGridViewTextBoxColumn();
            Column11 = new DataGridViewTextBoxColumn();
            Column8 = new DataGridViewImageColumn();
            Column9 = new DataGridViewImageColumn();
            productsPanel = new Panel();
            closeBtn = new Guna.UI2.WinForms.Guna2ImageButton();
            guna2Panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)ordersGrid).BeginInit();
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
            productSearchBox.PlaceholderText = "Search for an order";
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
            label1.Size = new Size(118, 39);
            label1.TabIndex = 0;
            label1.Text = "Orders";
            label1.Click += label1_Click;
            // 
            // addOrderBtn
            // 
            addOrderBtn.BorderRadius = 8;
            addOrderBtn.CustomizableEdges = customizableEdges6;
            addOrderBtn.DisabledState.BorderColor = Color.DarkGray;
            addOrderBtn.DisabledState.CustomBorderColor = Color.DarkGray;
            addOrderBtn.DisabledState.FillColor = Color.FromArgb(169, 169, 169);
            addOrderBtn.DisabledState.ForeColor = Color.FromArgb(141, 141, 141);
            addOrderBtn.FillColor = Color.FromArgb(43, 119, 234);
            addOrderBtn.Font = new Font("Lato", 9F, FontStyle.Bold, GraphicsUnit.Point);
            addOrderBtn.ForeColor = Color.White;
            addOrderBtn.Location = new Point(41, 145);
            addOrderBtn.Name = "addOrderBtn";
            addOrderBtn.ShadowDecoration.CustomizableEdges = customizableEdges7;
            addOrderBtn.Size = new Size(256, 65);
            addOrderBtn.TabIndex = 2;
            addOrderBtn.Text = "Add Order";
            addOrderBtn.Click += addOrderBtn_Click;
            // 
            // ordersGrid
            // 
            dataGridViewCellStyle1.BackColor = Color.White;
            ordersGrid.AlternatingRowsDefaultCellStyle = dataGridViewCellStyle1;
            dataGridViewCellStyle2.Alignment = DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle2.BackColor = Color.FromArgb(0, 71, 176);
            dataGridViewCellStyle2.Font = new Font("Lato", 9F, FontStyle.Regular, GraphicsUnit.Point);
            dataGridViewCellStyle2.ForeColor = Color.White;
            dataGridViewCellStyle2.SelectionBackColor = Color.FromArgb(43, 119, 234);
            dataGridViewCellStyle2.SelectionForeColor = SystemColors.HighlightText;
            dataGridViewCellStyle2.WrapMode = DataGridViewTriState.True;
            ordersGrid.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle2;
            ordersGrid.ColumnHeadersHeight = 70;
            ordersGrid.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.EnableResizing;
            ordersGrid.Columns.AddRange(new DataGridViewColumn[] { Column1, Column2, Column3, Column4, Column5, Column6, Column7, Column10, Column11, Column8, Column9 });
            dataGridViewCellStyle3.Alignment = DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle3.BackColor = Color.White;
            dataGridViewCellStyle3.Font = new Font("Lato", 9F, FontStyle.Regular, GraphicsUnit.Point);
            dataGridViewCellStyle3.ForeColor = Color.FromArgb(71, 69, 94);
            dataGridViewCellStyle3.SelectionBackColor = Color.FromArgb(231, 229, 255);
            dataGridViewCellStyle3.SelectionForeColor = Color.FromArgb(71, 69, 94);
            dataGridViewCellStyle3.WrapMode = DataGridViewTriState.False;
            ordersGrid.DefaultCellStyle = dataGridViewCellStyle3;
            ordersGrid.GridColor = Color.FromArgb(231, 229, 255);
            ordersGrid.Location = new Point(41, 252);
            ordersGrid.Name = "ordersGrid";
            ordersGrid.RowHeadersVisible = false;
            ordersGrid.RowHeadersWidth = 82;
            dataGridViewCellStyle4.Alignment = DataGridViewContentAlignment.MiddleCenter;
            dataGridViewCellStyle4.ForeColor = Color.Black;
            ordersGrid.RowsDefaultCellStyle = dataGridViewCellStyle4;
            ordersGrid.RowTemplate.DefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleCenter;
            ordersGrid.RowTemplate.Height = 55;
            ordersGrid.Size = new Size(1689, 724);
            ordersGrid.TabIndex = 3;
            ordersGrid.ThemeStyle.AlternatingRowsStyle.BackColor = Color.White;
            ordersGrid.ThemeStyle.AlternatingRowsStyle.Font = null;
            ordersGrid.ThemeStyle.AlternatingRowsStyle.ForeColor = Color.Empty;
            ordersGrid.ThemeStyle.AlternatingRowsStyle.SelectionBackColor = Color.Empty;
            ordersGrid.ThemeStyle.AlternatingRowsStyle.SelectionForeColor = Color.Empty;
            ordersGrid.ThemeStyle.BackColor = Color.White;
            ordersGrid.ThemeStyle.GridColor = Color.FromArgb(231, 229, 255);
            ordersGrid.ThemeStyle.HeaderStyle.BackColor = Color.FromArgb(100, 88, 255);
            ordersGrid.ThemeStyle.HeaderStyle.BorderStyle = DataGridViewHeaderBorderStyle.None;
            ordersGrid.ThemeStyle.HeaderStyle.Font = new Font("Lato", 9F, FontStyle.Regular, GraphicsUnit.Point);
            ordersGrid.ThemeStyle.HeaderStyle.ForeColor = Color.White;
            ordersGrid.ThemeStyle.HeaderStyle.HeaightSizeMode = DataGridViewColumnHeadersHeightSizeMode.EnableResizing;
            ordersGrid.ThemeStyle.HeaderStyle.Height = 70;
            ordersGrid.ThemeStyle.ReadOnly = false;
            ordersGrid.ThemeStyle.RowsStyle.BackColor = Color.White;
            ordersGrid.ThemeStyle.RowsStyle.BorderStyle = DataGridViewCellBorderStyle.SingleHorizontal;
            ordersGrid.ThemeStyle.RowsStyle.Font = new Font("Lato", 9F, FontStyle.Regular, GraphicsUnit.Point);
            ordersGrid.ThemeStyle.RowsStyle.ForeColor = Color.FromArgb(71, 69, 94);
            ordersGrid.ThemeStyle.RowsStyle.Height = 55;
            ordersGrid.ThemeStyle.RowsStyle.SelectionBackColor = Color.FromArgb(231, 229, 255);
            ordersGrid.ThemeStyle.RowsStyle.SelectionForeColor = Color.FromArgb(71, 69, 94);
            ordersGrid.CellClick += ordersGrid_CellClick;
            ordersGrid.CellContentClick += ordersGrid_CellContentClick;
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
            Column2.HeaderText = "Order Id";
            Column2.MinimumWidth = 10;
            Column2.Name = "Column2";
            // 
            // Column3
            // 
            Column3.AutoSizeMode = DataGridViewAutoSizeColumnMode.AllCells;
            Column3.HeaderText = "Order Date";
            Column3.MinimumWidth = 10;
            Column3.Name = "Column3";
            Column3.Width = 164;
            // 
            // Column4
            // 
            Column4.AutoSizeMode = DataGridViewAutoSizeColumnMode.AllCells;
            Column4.HeaderText = "Customer Id";
            Column4.MinimumWidth = 10;
            Column4.Name = "Column4";
            Column4.Width = 170;
            // 
            // Column5
            // 
            Column5.AutoSizeMode = DataGridViewAutoSizeColumnMode.AllCells;
            Column5.HeaderText = "Product Id";
            Column5.MinimumWidth = 10;
            Column5.Name = "Column5";
            Column5.Width = 152;
            // 
            // Column6
            // 
            Column6.AutoSizeMode = DataGridViewAutoSizeColumnMode.Fill;
            Column6.HeaderText = "Total Amount";
            Column6.MinimumWidth = 10;
            Column6.Name = "Column6";
            // 
            // Column7
            // 
            Column7.HeaderText = "Order Item Id";
            Column7.MinimumWidth = 10;
            Column7.Name = "Column7";
            // 
            // Column10
            // 
            Column10.HeaderText = "Unit Price";
            Column10.MinimumWidth = 10;
            Column10.Name = "Column10";
            // 
            // Column11
            // 
            Column11.HeaderText = "Quantity";
            Column11.MinimumWidth = 10;
            Column11.Name = "Column11";
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
            // productsPanel
            // 
            productsPanel.BackColor = Color.FromArgb(0, 0, 15, 255);
            productsPanel.Controls.Add(ordersGrid);
            productsPanel.Controls.Add(addOrderBtn);
            productsPanel.Controls.Add(guna2Panel1);
            productsPanel.Dock = DockStyle.Bottom;
            productsPanel.Location = new Point(0, 0);
            productsPanel.Name = "productsPanel";
            productsPanel.Size = new Size(1770, 1144);
            productsPanel.TabIndex = 6;
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
            closeBtn.Location = new Point(1648, 12);
            closeBtn.Name = "closeBtn";
            closeBtn.PressedState.ImageSize = new Size(64, 64);
            closeBtn.ShadowDecoration.CustomizableEdges = customizableEdges1;
            closeBtn.Size = new Size(82, 72);
            closeBtn.TabIndex = 32;
            closeBtn.Click += closeBtn_Click;
            // 
            // Orders
            // 
            AutoScaleDimensions = new SizeF(14F, 29F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.FromArgb(233, 239, 255);
            ClientSize = new Size(1770, 1144);
            Controls.Add(productsPanel);
            Font = new Font("Lato", 9F, FontStyle.Regular, GraphicsUnit.Point);
            FormBorderStyle = FormBorderStyle.None;
            Name = "Orders";
            Text = "Orders";
            guna2Panel1.ResumeLayout(false);
            guna2Panel1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)ordersGrid).EndInit();
            productsPanel.ResumeLayout(false);
            ResumeLayout(false);
        }

        #endregion

        private Guna.UI2.WinForms.Guna2Panel guna2Panel1;
        private Guna.UI2.WinForms.Guna2TextBox productSearchBox;
        private Label label1;
        private Guna.UI2.WinForms.Guna2Button addOrderBtn;
        private Guna.UI2.WinForms.Guna2DataGridView ordersGrid;
        private DataGridViewTextBoxColumn Column1;
        private DataGridViewTextBoxColumn Column2;
        private DataGridViewTextBoxColumn Column3;
        private DataGridViewTextBoxColumn Column4;
        private DataGridViewTextBoxColumn Column5;
        private DataGridViewTextBoxColumn Column6;
        private DataGridViewTextBoxColumn Column7;
        private DataGridViewTextBoxColumn Column10;
        private DataGridViewTextBoxColumn Column11;
        private DataGridViewImageColumn Column8;
        private DataGridViewImageColumn Column9;
        private Panel productsPanel;
        private Guna.UI2.WinForms.Guna2ImageButton closeBtn;
    }
}