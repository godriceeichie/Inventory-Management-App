namespace Inventory_Management_App
{
    partial class SplashScreen
    {
        /// <summary>
        ///  Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        ///  Clean up any resources being used.
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
        ///  Required method for Designer support - do not modify
        ///  the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            components = new System.ComponentModel.Container();
            pictureBox1 = new PictureBox();
            pictureBox2 = new PictureBox();
            label2 = new Label();
            panel1 = new Panel();
            panelSlide = new Panel();
            splashScreenTimer = new System.Windows.Forms.Timer(components);
            label1 = new Label();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).BeginInit();
            ((System.ComponentModel.ISupportInitialize)pictureBox2).BeginInit();
            SuspendLayout();
            // 
            // pictureBox1
            // 
            pictureBox1.Image = Properties.Resources.Investor_presentation_amico;
            pictureBox1.Location = new Point(161, 154);
            pictureBox1.Name = "pictureBox1";
            pictureBox1.Size = new Size(543, 386);
            pictureBox1.SizeMode = PictureBoxSizeMode.Zoom;
            pictureBox1.TabIndex = 0;
            pictureBox1.TabStop = false;
            // 
            // pictureBox2
            // 
            pictureBox2.Image = Properties.Resources.inventory2;
            pictureBox2.Location = new Point(323, 68);
            pictureBox2.Name = "pictureBox2";
            pictureBox2.Size = new Size(50, 50);
            pictureBox2.SizeMode = PictureBoxSizeMode.Zoom;
            pictureBox2.TabIndex = 1;
            pictureBox2.TabStop = false;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Font = new Font("Lato", 13.8749981F, FontStyle.Bold, GraphicsUnit.Point);
            label2.Location = new Point(376, 70);
            label2.Name = "label2";
            label2.Size = new Size(183, 45);
            label2.TabIndex = 3;
            label2.Text = "Productly";
            // 
            // panel1
            // 
            panel1.BackColor = Color.White;
            panel1.Location = new Point(161, 611);
            panel1.Name = "panel1";
            panel1.Size = new Size(543, 38);
            panel1.TabIndex = 4;
            // 
            // panelSlide
            // 
            panelSlide.BackColor = Color.FromArgb(43, 119, 234);
            panelSlide.Location = new Point(161, 611);
            panelSlide.Name = "panelSlide";
            panelSlide.Size = new Size(61, 38);
            panelSlide.TabIndex = 5;
            // 
            // splashScreenTimer
            // 
            splashScreenTimer.Enabled = true;
            splashScreenTimer.Interval = 15;
            splashScreenTimer.Tick += splashScreenTimer_Tick;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Lato", 10.124999F, FontStyle.Regular, GraphicsUnit.Point);
            label1.ForeColor = Color.Gray;
            label1.Location = new Point(383, 704);
            label1.Name = "label1";
            label1.Size = new Size(145, 33);
            label1.TabIndex = 6;
            label1.Text = "Loading......";
            // 
            // SplashScreen
            // 
            AutoScaleDimensions = new SizeF(14F, 29F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.FromArgb(233, 239, 255);
            ClientSize = new Size(862, 833);
            Controls.Add(label1);
            Controls.Add(panelSlide);
            Controls.Add(panel1);
            Controls.Add(label2);
            Controls.Add(pictureBox2);
            Controls.Add(pictureBox1);
            Font = new Font("Lato", 9F, FontStyle.Regular, GraphicsUnit.Point);
            FormBorderStyle = FormBorderStyle.None;
            Name = "SplashScreen";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "Form1";
            Load += SplashScreen_Load;
            ((System.ComponentModel.ISupportInitialize)pictureBox1).EndInit();
            ((System.ComponentModel.ISupportInitialize)pictureBox2).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private PictureBox pictureBox1;
        private PictureBox pictureBox2;
        private Label label2;
        private Panel panel1;
        private Panel panelSlide;
        private System.Windows.Forms.Timer splashScreenTimer;
        private Label label1;
    }
}