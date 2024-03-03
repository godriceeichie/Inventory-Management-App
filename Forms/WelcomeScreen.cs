using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Runtime.InteropServices;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Inventory_Management_App
{
    public partial class WelcomeScreen : Form
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
        public WelcomeScreen()
        {
            InitializeComponent();
            Region = System.Drawing.Region.FromHrgn(CreateRoundRectRgn(0, 0, Width, Height, 25, 25));
        }

        private void getStartedBtn_Click(object sender, EventArgs e)
        {
            this.Hide();
            new GetStarted().Show();
        }

        private void signInBtn_Click(object sender, EventArgs e)
        {
            new SignIn().Show();
            this.Hide();
        }

        private void WelcomeScreen_Load(object sender, EventArgs e)
        {

        }
    }
}
