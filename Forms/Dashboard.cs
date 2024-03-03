using Guna.UI2.WinForms;
using Inventory_Management_App.Session;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.Linq;
using System.Reflection.Metadata.Ecma335;
using System.Runtime.InteropServices;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Drawing.Drawing2D;
using Inventory_Management_App.SqlDbConnection;

namespace Inventory_Management_App.Forms
{
    public partial class Dashboard : Form
    {
        [DllImport("Gdi32.dll", EntryPoint = "CreateRoundRectRgn")]

        private static extern IntPtr CreateRoundRectRgn
            (
            int nLeftRect,
            int nTopRect,
            int RightRect,
            int nBottomRect,
            int nWidthEllipse,
            int nHeightEllipse

            );
        public Dashboard()
        {
            InitializeComponent();
            Region = System.Drawing.Region.FromHrgn(CreateRoundRectRgn(0, 0, Width, Height, 25, 25));
            new UserManager();
            username.Text = UserManager.CurrentUser.Username;
            email.Text = UserManager.CurrentUser.Email;

            if (dashboardBtn.Tag == null)
            {
                dashboardBtn.Image = Properties.Resources.dashboardWhite;
                dashboardBtn.Tag = "dashboardWhite";
                dashboardBtn.FillColor = Color.FromArgb(43, 119, 234);
                dashboardBtn.ForeColor = Color.White;
            }

            this.panelFormLoader.Controls.Clear();
            DashboardHome dashboardHome = new DashboardHome() { Dock = DockStyle.Fill, TopLevel = false, TopMost = true };
            dashboardHome.FormBorderStyle = FormBorderStyle.None;
            this.panelFormLoader.Controls.Add(dashboardHome);
            dashboardHome.Show();

            LoadUserProfileImage();
        }

        private void LoadUserProfileImage()
        {
            try
            {
                using (SqlConnection conn = DbConnection.GetSqlConnection())
                {
                    conn.Open();

                    // Check if the user's image exists in the UserImage table
                    string checkQuery = "SELECT UserImg FROM UserImage WHERE UserID = @userID";
                    using (SqlCommand checkCommand = new SqlCommand(checkQuery, conn))
                    {
                        checkCommand.Parameters.AddWithValue("@userID", UserManager.CurrentUser.UserId);

                        // If the user's image exists, load it into the profile image
                        object result = checkCommand.ExecuteScalar();
                        if (result != null)
                        {
                            byte[] userImageBytes = (byte[])result;
                            MemoryStream ms = new MemoryStream(userImageBytes);
                            ms.Position = 0;
                            Image userImage = Image.FromStream(ms);
                            profileImg.Image = userImage;
                            GraphicsPath graphicsPath = new GraphicsPath();
                            graphicsPath.AddEllipse(0, 0, profileImg.Width, profileImg.Height);
                            Region rg = new Region(graphicsPath);
                            profileImg.Region = rg;
                        }
                    }

                    conn.Close();
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show($"Error: {ex.Message}", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        public void ResetButtons()
        {
            // Reset background color for all buttons
            this.Width = 2000;
            panelFormLoader.Width = 1568;

            //dashboard btn reset
            dashboardBtn.FillColor = Color.White;
            dashboardBtn.Image = Properties.Resources.dashboard;
            dashboardBtn.Tag = "dashboard";
            dashboardBtn.ForeColor = Color.FromArgb(67, 70, 85);

            //product btn reset
            productsBtn.FillColor = Color.White;
            productsBtn.Image = Properties.Resources.product;
            productsBtn.Tag = "products";
            productsBtn.ForeColor = Color.FromArgb(67, 70, 85);

            //categories btn reset
            categoriesBtn.FillColor = Color.White;
            categoriesBtn.Image = Properties.Resources.categorization;
            categoriesBtn.Tag = "categories";
            categoriesBtn.ForeColor = Color.FromArgb(67, 70, 85);

            //customers btn reset
            customersBtn.FillColor = Color.White;
            customersBtn.Image = Properties.Resources.customer;
            customersBtn.Tag = "customers";
            customersBtn.ForeColor = Color.FromArgb(67, 70, 85);

            //orders btn reset
            ordersBtn.FillColor = Color.White;
            ordersBtn.Image = Properties.Resources.check_out;
            ordersBtn.Tag = "orders";
            ordersBtn.ForeColor = Color.FromArgb(67, 70, 85);

        }

        private void Dashboard_Load(object sender, EventArgs e)
        {

        }

        private void dashboardBtn_Click(object sender, EventArgs e)
        {
            ResetButtons();
            if (dashboardBtn.Tag == null || dashboardBtn.Tag.ToString() == "dashboard")
            {
                dashboardBtn.Image = Properties.Resources.dashboardWhite;
                dashboardBtn.Tag = "dashboardWhite";
                dashboardBtn.FillColor = Color.FromArgb(43, 119, 234);
                dashboardBtn.ForeColor = Color.White;
            }


            this.panelFormLoader.Controls.Clear();
            DashboardHome dashboardHome = new DashboardHome() { Dock = DockStyle.Fill, TopLevel = false, TopMost = true };
            dashboardHome.FormBorderStyle = FormBorderStyle.None;
            this.panelFormLoader.Controls.Add(dashboardHome);
            dashboardHome.Show();

        }

        private void productsBtn_Click(object sender, EventArgs e)
        {
            ResetButtons();
            if (productsBtn.Tag == null || productsBtn.Tag.ToString() == "products")
            {
                productsBtn.Image = Properties.Resources.productWhite;
                productsBtn.Tag = "productWhite";
                productsBtn.FillColor = Color.FromArgb(43, 119, 234);
                productsBtn.ForeColor = Color.White;
            }


            this.panelFormLoader.Controls.Clear();
            Products products = new Products() { Dock = DockStyle.Fill, TopLevel = false, TopMost = true };
            products.FormBorderStyle = FormBorderStyle.None;
            this.panelFormLoader.Controls.Add(products);
            products.Show();
        }

        private void ordersBtn_Click(object sender, EventArgs e)
        {
            ResetButtons();
            if (ordersBtn.Tag == null || ordersBtn.Tag.ToString() == "orders")
            {
                ordersBtn.Image = Properties.Resources.check_out_white;
                ordersBtn.Tag = "ordersWhite";
                ordersBtn.FillColor = Color.FromArgb(43, 119, 234);
                ordersBtn.ForeColor = Color.White;
            }

            // Set minimum size to ensure width change is effective
            this.MinimumSize = new Size(2202, this.MinimumSize.Height);
            panelFormLoader.MinimumSize = new Size(1770, panelFormLoader.MinimumSize.Height);

            // Adjust the width
            this.Width = 2202;
            panelFormLoader.Width = 1770;

            this.panelFormLoader.Controls.Clear();
            Orders orders = new Orders() { Dock = DockStyle.Fill, TopLevel = false, TopMost = true };
            orders.FormBorderStyle = FormBorderStyle.None;
            this.panelFormLoader.Controls.Add(orders);
            orders.Show();
        }

        private void categoriesBtn_Click(object sender, EventArgs e)
        {
            ResetButtons();
            if (categoriesBtn.Tag == null || categoriesBtn.Tag.ToString() == "categories")
            {
                categoriesBtn.Image = Properties.Resources.categorizationWhite;
                categoriesBtn.Tag = "categoriesWhite";
                categoriesBtn.FillColor = Color.FromArgb(43, 119, 234);
                categoriesBtn.ForeColor = Color.White;
            }


            this.panelFormLoader.Controls.Clear();
            Categories categories = new Categories() { Dock = DockStyle.Fill, TopLevel = false, TopMost = true };
            categories.FormBorderStyle = FormBorderStyle.None;
            this.panelFormLoader.Controls.Add(categories);
            categories.Show();
        }

        private void logoutBtn_Click(object sender, EventArgs e)
        {
            DialogResult result = MessageBox.Show("Are you sure you want to logout", "Logout", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
            if (result == DialogResult.Yes)
            {
                new SignIn().Show();
                this.Hide();
            }
        }

        private void panelFormLoader_Paint(object sender, PaintEventArgs e)
        {

        }

        private void addProductBtn_Click(object sender, EventArgs e)
        {

        }

        private void customersBtn_Click(object sender, EventArgs e)
        {
            ResetButtons();
            if (customersBtn.Tag == null || customersBtn.Tag.ToString() == "customers")
            {
                customersBtn.Image = Properties.Resources.customerWhite;
                customersBtn.Tag = "customerWhite";
                customersBtn.FillColor = Color.FromArgb(43, 119, 234);
                customersBtn.ForeColor = Color.White;
            }


            this.panelFormLoader.Controls.Clear();
            Customers customers = new Customers() { Dock = DockStyle.Fill, TopLevel = false, TopMost = true };
            customers.FormBorderStyle = FormBorderStyle.None;
            this.panelFormLoader.Controls.Add(customers);
            customers.Show();
        }

        private void guna2Button2_Click(object sender, EventArgs e)
        {

        }

        private void logoutBtn_Click_1(object sender, EventArgs e)
        {
            DialogResult result = MessageBox.Show("Are you sure you want to logout", "Logout", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
            if (result == DialogResult.Yes)
            {
                new SignIn().Show();
                this.Close();
            }
        }

        private void guna2CustomGradientPanel1_Paint(object sender, PaintEventArgs e)
        {

        }

        private void productsBtn_Click_1(object sender, EventArgs e)
        {
            ResetButtons();
            if (productsBtn.Tag == null || productsBtn.Tag.ToString() == "products")
            {
                productsBtn.Image = Properties.Resources.productWhite;
                productsBtn.Tag = "productWhite";
                productsBtn.FillColor = Color.FromArgb(43, 119, 234);
                productsBtn.ForeColor = Color.White;
            }


            this.panelFormLoader.Controls.Clear();
            Products products = new Products() { Dock = DockStyle.Fill, TopLevel = false, TopMost = true };
            products.FormBorderStyle = FormBorderStyle.None;
            this.panelFormLoader.Controls.Add(products);
            products.Show();
        }

        private void profileImg_Click(object sender, EventArgs e)
        {
            OpenFileDialog opf = new OpenFileDialog();

            if (opf.ShowDialog() == DialogResult.OK)
            {
                try
                {
                    Image img = Image.FromFile(opf.FileName);
                    MemoryStream tmpStream = new MemoryStream();
                    img.Save(tmpStream, System.Drawing.Imaging.ImageFormat.Png); // change to other format
                    tmpStream.Seek(0, SeekOrigin.Begin);
                    byte[] imageData = new byte[img.Size.Height * img.Height];
                    tmpStream.Read(imageData, 0, img.Size.Height * img.Height);
                    int userId = UserManager.CurrentUser.UserId;

                    using (SqlConnection CN = DbConnection.GetSqlConnection())
                    {
                        CN.Open();

                        // Check if the user's image exists in the UserImage table
                        string checkQuery = "SELECT UserImg FROM UserImage WHERE UserID = @userID";
                        using (SqlCommand checkCommand = new SqlCommand(checkQuery, CN))
                        {
                            checkCommand.Parameters.AddWithValue("@userID", userId);

                            // If the user's image exists, update it
                            object result = checkCommand.ExecuteScalar();
                            if (result != null)
                            {
                                string updateQuery = "UPDATE UserImage SET UserImg = @image WHERE UserID = @id";
                                using (SqlCommand updateCommand = new SqlCommand(updateQuery, CN))
                                {
                                    updateCommand.Parameters.AddWithValue("@image", (object)imageData);
                                    updateCommand.Parameters.AddWithValue("@id", userId);
                                    updateCommand.ExecuteNonQuery();

                                    //byte[] userImageBytes = (byte[])result;
                                    //MemoryStream ms = new MemoryStream(userImageBytes);
                                    //ms.Position = 0;
                                    //Image userImage = Image.FromStream(ms);
                                    //profileImg.Image = userImage;
                                    MessageBox.Show("The image is updated!");
                                }
                            }
                            else
                            {
                                // If the user's image does not exist, insert a new record
                                string insertQuery = "INSERT INTO UserImage(UserImg, UserID) VALUES (@image, @id)";
                                using (SqlCommand insertCommand = new SqlCommand(insertQuery, CN))
                                {
                                    insertCommand.Parameters.AddWithValue("@image", (object)imageData);
                                    insertCommand.Parameters.AddWithValue("@id", userId);
                                    insertCommand.ExecuteNonQuery();
                                    //byte[] userImageBytes = (byte[])result;
                                    //MemoryStream ms = new MemoryStream(userImageBytes);
                                    //ms.Position = 0;
                                    //Image userImage = Image.FromStream(ms);
                                    //profileImg.Image = userImage;
                                    MessageBox.Show("The image is stored!");
                                }
                            }
                        }
                    }
                }
                catch (Exception ex)
                {
                    MessageBox.Show($"Error: {ex.Message}", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
        }


       
    }
}
