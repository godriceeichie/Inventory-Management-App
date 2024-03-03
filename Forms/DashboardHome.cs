using Inventory_Management_App.Models;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Inventory_Management_App.Forms
{
    public partial class DashboardHome : Form
    {
        private DashboardModel model;

        public DashboardHome()
        {
            InitializeComponent();
            startDate.Value = DateTime.Today.AddDays(-7);
            endDate.Value = DateTime.Now;
            last7DaysBtn.Select();

            model = new DashboardModel();
            LoadData();
        }

        private void LoadData()
        {
            var refreshData = model.LoadData(startDate.Value, endDate.Value);
            if (refreshData)
            {
                ordersNum.Text = model.OrdersNum.ToString();
                totalRevenue.Text = $"${model.TotalRevenue.ToString()}";
                totalProfit.Text = $"${model.TotalProfit.ToString()}";

                grossRevenueChart.DataSource = model.GrossRevenueList;
                grossRevenueChart.Series[0].XValueMember = "Date";
                grossRevenueChart.Series[0].YValueMembers = "TotalAmount";
                grossRevenueChart.DataBind();

                topProductsChart.DataSource = model.TopProductsList;
                topProductsChart.Series[0].XValueMember = "Key";
                topProductsChart.Series[0].YValueMembers = "Value";
                topProductsChart.DataBind();

                Console.WriteLine("Loaded View :)");
            }
            else Console.WriteLine("View not loaded, same query");
        }

        private void panelFormLoader_Paint(object sender, PaintEventArgs e)
        {

        }

        private void DisableCustomDates()
        {
            startDate.Enabled = false;
            endDate.Enabled = false;
            okBtn.Visible = false;
        }

        private void todayBtn_Click(object sender, EventArgs e)
        {
            startDate.Value = DateTime.Today;
            endDate.Value = DateTime.Now;
            LoadData();
            DisableCustomDates();
        }

        private void last7DaysBtn_Click(object sender, EventArgs e)
        {
            startDate.Value = DateTime.Today.AddDays(-7);
            endDate.Value = DateTime.Now;
            LoadData();
            DisableCustomDates();

        }

        private void last30Days_Click(object sender, EventArgs e)
        {
            startDate.Value = DateTime.Today.AddDays(-30);
            endDate.Value = DateTime.Now;
            LoadData();
            DisableCustomDates();
        }

        private void customDateBtn_Click(object sender, EventArgs e)
        {
            startDate.Enabled = true;
            endDate.Enabled = true;
            okBtn.Visible = true;
        }

        private void okBtn_Click(object sender, EventArgs e)
        {
            LoadData();
        }

        private void closeBtn_Click(object sender, EventArgs e)
        {
            DialogResult result = MessageBox.Show("Are you sure you want to close the application", "Close", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
            if (result == DialogResult.Yes)
            {
                Application.Exit();
            }
        }
    }
}
