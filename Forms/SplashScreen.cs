using System.Runtime.InteropServices;

namespace Inventory_Management_App
{
    public partial class SplashScreen : Form
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
        public SplashScreen()
        {
            InitializeComponent();
            Region = System.Drawing.Region.FromHrgn(CreateRoundRectRgn(0, 0, Width, Height, 25, 25));

        }

        private void SplashScreen_Load(object sender, EventArgs e)
        {
            //panelSlide.Visible = false;
        }

        private void splashScreenTimer_Tick(object sender, EventArgs e)
        {
            panelSlide.Width += 3;
            if (panelSlide.Width >= 543)
            {
                splashScreenTimer.Stop();
                this.Hide();
                new WelcomeScreen().Show();
            }
        }
    }
}