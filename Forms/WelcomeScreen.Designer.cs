namespace Inventory_Management_App
{
    partial class WelcomeScreen
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
            label2 = new Label();
            pictureBox2 = new PictureBox();
            pictureBox1 = new PictureBox();
            getStartedBtn = new Button();
            signInBtn = new Button();
            ((System.ComponentModel.ISupportInitialize)pictureBox2).BeginInit();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).BeginInit();
            SuspendLayout();
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Font = new Font("Lato", 13.8749981F, FontStyle.Bold, GraphicsUnit.Point);
            label2.Location = new Point(369, 48);
            label2.Name = "label2";
            label2.Size = new Size(183, 45);
            label2.TabIndex = 9;
            label2.Text = "Productly";
            // 
            // pictureBox2
            // 
            pictureBox2.Image = Properties.Resources.inventory2;
            pictureBox2.Location = new Point(316, 46);
            pictureBox2.Name = "pictureBox2";
            pictureBox2.Size = new Size(50, 50);
            pictureBox2.SizeMode = PictureBoxSizeMode.Zoom;
            pictureBox2.TabIndex = 8;
            pictureBox2.TabStop = false;
            // 
            // pictureBox1
            // 
            pictureBox1.Image = Properties.Resources.Investor_presentation_amico;
            pictureBox1.Location = new Point(160, 132);
            pictureBox1.Name = "pictureBox1";
            pictureBox1.Size = new Size(543, 386);
            pictureBox1.SizeMode = PictureBoxSizeMode.Zoom;
            pictureBox1.TabIndex = 7;
            pictureBox1.TabStop = false;
            // 
            // getStartedBtn
            // 
            getStartedBtn.BackColor = Color.FromArgb(43, 119, 234);
            getStartedBtn.FlatAppearance.BorderSize = 0;
            getStartedBtn.FlatStyle = FlatStyle.Flat;
            getStartedBtn.Font = new Font("Lato", 10.124999F, FontStyle.Bold, GraphicsUnit.Point);
            getStartedBtn.ForeColor = Color.White;
            getStartedBtn.Location = new Point(160, 581);
            getStartedBtn.Name = "getStartedBtn";
            getStartedBtn.Size = new Size(543, 71);
            getStartedBtn.TabIndex = 10;
            getStartedBtn.Text = "Get Started";
            getStartedBtn.UseVisualStyleBackColor = false;
            getStartedBtn.Click += getStartedBtn_Click;
            // 
            // signInBtn
            // 
            signInBtn.BackColor = Color.White;
            signInBtn.FlatAppearance.BorderColor = Color.FromArgb(43, 119, 234);
            signInBtn.FlatStyle = FlatStyle.Flat;
            signInBtn.Font = new Font("Lato", 10.124999F, FontStyle.Bold, GraphicsUnit.Point);
            signInBtn.ForeColor = Color.FromArgb(43, 119, 234);
            signInBtn.Location = new Point(160, 687);
            signInBtn.Name = "signInBtn";
            signInBtn.Size = new Size(543, 71);
            signInBtn.TabIndex = 11;
            signInBtn.Text = "Sign In";
            signInBtn.UseVisualStyleBackColor = false;
            signInBtn.Click += signInBtn_Click;
            // 
            // WelcomeScreen
            // 
            AutoScaleDimensions = new SizeF(14F, 29F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.FromArgb(233, 239, 255);
            ClientSize = new Size(862, 833);
            Controls.Add(signInBtn);
            Controls.Add(getStartedBtn);
            Controls.Add(label2);
            Controls.Add(pictureBox2);
            Controls.Add(pictureBox1);
            Font = new Font("Lato", 9F, FontStyle.Regular, GraphicsUnit.Point);
            FormBorderStyle = FormBorderStyle.None;
            Name = "WelcomeScreen";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "WelcomeScreen";
            Load += WelcomeScreen_Load;
            ((System.ComponentModel.ISupportInitialize)pictureBox2).EndInit();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label label2;
        private PictureBox pictureBox2;
        private PictureBox pictureBox1;
        private Button button1;
        private Button button2;
        private Button getStartedBtn;
        private Button signInBtn;
    }
}