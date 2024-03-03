using Guna.UI2.WinForms.Suite;
using Inventory_Management_App.SqlDbConnection;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Diagnostics;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Xml.Linq;

namespace Inventory_Management_App.Forms
{

    public partial class EditCategoryForm : Form
    {
        readonly int id;
        Categories categoriesForm;
        public EditCategoryForm(int id, Categories categoriesForm)
        {
            InitializeComponent();
            this.id = id;
            this.categoriesForm = categoriesForm;
        }

        private void updateCategoryBtn_Click(object sender, EventArgs e)
        {
            string name = categoryName.Text;
            using (SqlConnection conn = DbConnection.GetSqlConnection())
            {
                conn.Open();

                using (SqlCommand updateCommand = new SqlCommand(@"UPDATE Categories SET CategoryName = @CategoryName WHERE CategoryID = @CategoryID", conn))
                {

                    updateCommand.Parameters.AddWithValue("@CategoryName", name);
                    updateCommand.Parameters.AddWithValue("@CategoryID", id);

                    int rowsAffected = updateCommand.ExecuteNonQuery();

                    if (rowsAffected > 0)
                    {
                        MessageBox.Show("Category updated successfully.", "Success", MessageBoxButtons.OK, MessageBoxIcon.Information);
                        categoriesForm.LoadCategories();
                        this.Close(); // Close the form after successful update
                    }
                    else
                    {
                        MessageBox.Show("Failed to update category.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    }
                }
            }
        }

        private void closeBtn_Click(object sender, EventArgs e)
        {
            DialogResult result = MessageBox.Show("Are you sure you want to close this form", "Close", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
            if (result == DialogResult.Yes)
            {
                new Categories().LoadCategories();
                this.Close();
            }
        }

        private void EditCategoryForm_Load(object sender, EventArgs e)
        {

        }
    }
}
