namespace CalorieTracker_PL
{
    partial class FormOpening
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FormOpening));
            pictureBox1 = new PictureBox();
            lblApplicatonName = new Label();
            lblWelcome = new Label();
            lblApp = new Label();
            lblWhatWeProvide = new Label();
            lblFinal = new Label();
            btnLogin = new ReaLTaiizor.Controls.CyberButton();
            lblLogin = new Label();
            lblRegister = new Label();
            pbLeftPicture = new PictureBox();
            pbRightPicture = new PictureBox();
            btnRegister = new ReaLTaiizor.Controls.CyberButton();
            swcDarkMode = new ReaLTaiizor.Controls.CyberSwitch();
            label5 = new Label();
            btnMinimize = new ReaLTaiizor.Controls.ForeverMinimize();
            btnClose = new ReaLTaiizor.Controls.ForeverClose();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).BeginInit();
            ((System.ComponentModel.ISupportInitialize)pbLeftPicture).BeginInit();
            ((System.ComponentModel.ISupportInitialize)pbRightPicture).BeginInit();
            SuspendLayout();
            // 
            // pictureBox1
            // 
            pictureBox1.Anchor = AnchorStyles.Top | AnchorStyles.Bottom | AnchorStyles.Left | AnchorStyles.Right;
            pictureBox1.BackColor = Color.Transparent;
            pictureBox1.BackgroundImage = Properties.Resources.icon;
            pictureBox1.BackgroundImageLayout = ImageLayout.Zoom;
            pictureBox1.Location = new Point(340, 20);
            pictureBox1.Name = "pictureBox1";
            pictureBox1.Size = new Size(120, 120);
            pictureBox1.SizeMode = PictureBoxSizeMode.StretchImage;
            pictureBox1.TabIndex = 3;
            pictureBox1.TabStop = false;
            // 
            // lblApplicatonName
            // 
            lblApplicatonName.Anchor = AnchorStyles.Top | AnchorStyles.Bottom | AnchorStyles.Left | AnchorStyles.Right;
            lblApplicatonName.AutoSize = true;
            lblApplicatonName.BackColor = Color.Transparent;
            lblApplicatonName.Font = new Font("Segoe UI Semibold", 14.25F, FontStyle.Bold, GraphicsUnit.Point);
            lblApplicatonName.Location = new Point(331, 152);
            lblApplicatonName.Name = "lblApplicatonName";
            lblApplicatonName.Size = new Size(138, 25);
            lblApplicatonName.TabIndex = 4;
            lblApplicatonName.Text = "Calorie Tracker";
            lblApplicatonName.TextAlign = ContentAlignment.MiddleCenter;
            // 
            // lblWelcome
            // 
            lblWelcome.Anchor = AnchorStyles.Top | AnchorStyles.Bottom | AnchorStyles.Left | AnchorStyles.Right;
            lblWelcome.AutoSize = true;
            lblWelcome.BackColor = Color.Transparent;
            lblWelcome.Font = new Font("Segoe UI", 11.25F, FontStyle.Regular, GraphicsUnit.Point);
            lblWelcome.Location = new Point(361, 189);
            lblWelcome.Name = "lblWelcome";
            lblWelcome.Size = new Size(79, 20);
            lblWelcome.TabIndex = 5;
            lblWelcome.Text = "Welcome! ";
            // 
            // lblApp
            // 
            lblApp.Anchor = AnchorStyles.Top | AnchorStyles.Bottom | AnchorStyles.Left | AnchorStyles.Right;
            lblApp.AutoSize = true;
            lblApp.BackColor = Color.Transparent;
            lblApp.Font = new Font("Segoe UI", 11.25F, FontStyle.Regular, GraphicsUnit.Point);
            lblApp.Location = new Point(190, 219);
            lblApp.Name = "lblApp";
            lblApp.Size = new Size(421, 20);
            lblApp.TabIndex = 5;
            lblApp.Text = "We made the newest and the best calorie tracking application.";
            lblApp.TextAlign = ContentAlignment.MiddleCenter;
            // 
            // lblWhatWeProvide
            // 
            lblWhatWeProvide.Anchor = AnchorStyles.Top | AnchorStyles.Bottom | AnchorStyles.Left | AnchorStyles.Right;
            lblWhatWeProvide.BackColor = Color.Transparent;
            lblWhatWeProvide.Font = new Font("Segoe UI", 11.25F, FontStyle.Regular, GraphicsUnit.Point);
            lblWhatWeProvide.Location = new Point(190, 249);
            lblWhatWeProvide.Name = "lblWhatWeProvide";
            lblWhatWeProvide.Size = new Size(421, 67);
            lblWhatWeProvide.TabIndex = 5;
            lblWhatWeProvide.Text = "With this application, you can calculate your Body Mass Index, track your daily, weekly and monthly calorie, protein, carbonhyrate and fat intake. ";
            lblWhatWeProvide.TextAlign = ContentAlignment.MiddleCenter;
            // 
            // lblFinal
            // 
            lblFinal.Anchor = AnchorStyles.Top | AnchorStyles.Bottom | AnchorStyles.Left | AnchorStyles.Right;
            lblFinal.BackColor = Color.Transparent;
            lblFinal.Font = new Font("Segoe UI", 11.25F, FontStyle.Regular, GraphicsUnit.Point);
            lblFinal.Location = new Point(190, 319);
            lblFinal.Name = "lblFinal";
            lblFinal.Size = new Size(421, 26);
            lblFinal.TabIndex = 5;
            lblFinal.Text = "Also you can compare your data with other users.";
            lblFinal.TextAlign = ContentAlignment.MiddleCenter;
            // 
            // btnLogin
            // 
            btnLogin.Alpha = 20;
            btnLogin.Anchor = AnchorStyles.Bottom;
            btnLogin.AutoSize = true;
            btnLogin.BackColor = Color.Transparent;
            btnLogin.Background = true;
            btnLogin.Background_WidthPen = 4F;
            btnLogin.BackgroundImage = Properties.Resources.login;
            btnLogin.BackgroundImageLayout = ImageLayout.Stretch;
            btnLogin.BackgroundPen = false;
            btnLogin.ColorBackground = Color.Transparent;
            btnLogin.ColorBackground_1 = Color.FromArgb(37, 52, 68);
            btnLogin.ColorBackground_2 = Color.FromArgb(41, 63, 86);
            btnLogin.ColorBackground_Pen = Color.FromArgb(29, 200, 238);
            btnLogin.ColorLighting = Color.FromArgb(50, 215, 255);
            btnLogin.ColorPen_1 = Color.FromArgb(37, 52, 68);
            btnLogin.ColorPen_2 = Color.FromArgb(41, 63, 86);
            btnLogin.Cursor = Cursors.Hand;
            btnLogin.CyberButtonStyle = ReaLTaiizor.Enum.Cyber.StateStyle.Custom;
            btnLogin.Effect_1 = true;
            btnLogin.Effect_1_ColorBackground = Color.FromArgb(29, 200, 238);
            btnLogin.Effect_1_Transparency = 25;
            btnLogin.Effect_2 = true;
            btnLogin.Effect_2_ColorBackground = Color.White;
            btnLogin.Effect_2_Transparency = 20;
            btnLogin.Font = new Font("Segoe UI Semibold", 12F, FontStyle.Bold, GraphicsUnit.Point);
            btnLogin.ForeColor = Color.Black;
            btnLogin.Lighting = false;
            btnLogin.LinearGradient_Background = false;
            btnLogin.LinearGradientPen = false;
            btnLogin.Location = new Point(265, 374);
            btnLogin.Name = "btnLogin";
            btnLogin.PenWidth = 20;
            btnLogin.Rounding = true;
            btnLogin.RoundingInt = 90;
            btnLogin.Size = new Size(75, 75);
            btnLogin.SmoothingMode = System.Drawing.Drawing2D.SmoothingMode.AntiAlias;
            btnLogin.TabIndex = 7;
            btnLogin.Tag = "Cyber";
            btnLogin.TextButton = "";
            btnLogin.TextRenderingHint = System.Drawing.Text.TextRenderingHint.AntiAlias;
            btnLogin.Timer_Effect_1 = 5;
            btnLogin.Timer_RGB = 300;
            btnLogin.Click += btnLogin_Click;
            // 
            // lblLogin
            // 
            lblLogin.Anchor = AnchorStyles.Bottom;
            lblLogin.AutoSize = true;
            lblLogin.BackColor = Color.Transparent;
            lblLogin.Font = new Font("Segoe UI", 11.25F, FontStyle.Regular, GraphicsUnit.Point);
            lblLogin.Location = new Point(279, 453);
            lblLogin.Name = "lblLogin";
            lblLogin.Size = new Size(46, 20);
            lblLogin.TabIndex = 5;
            lblLogin.Text = "Login";
            // 
            // lblRegister
            // 
            lblRegister.Anchor = AnchorStyles.Bottom;
            lblRegister.AutoSize = true;
            lblRegister.BackColor = Color.Transparent;
            lblRegister.Font = new Font("Segoe UI", 11.25F, FontStyle.Regular, GraphicsUnit.Point);
            lblRegister.Location = new Point(466, 453);
            lblRegister.Name = "lblRegister";
            lblRegister.Size = new Size(63, 20);
            lblRegister.TabIndex = 5;
            lblRegister.Text = "Register";
            // 
            // pbLeftPicture
            // 
            pbLeftPicture.Anchor = AnchorStyles.Top | AnchorStyles.Bottom | AnchorStyles.Left | AnchorStyles.Right;
            pbLeftPicture.BackColor = Color.Transparent;
            pbLeftPicture.BackgroundImage = Properties.Resources.womanbody;
            pbLeftPicture.BackgroundImageLayout = ImageLayout.Zoom;
            pbLeftPicture.Location = new Point(12, 12);
            pbLeftPicture.Name = "pbLeftPicture";
            pbLeftPicture.Size = new Size(172, 451);
            pbLeftPicture.SizeMode = PictureBoxSizeMode.Zoom;
            pbLeftPicture.TabIndex = 8;
            pbLeftPicture.TabStop = false;
            // 
            // pbRightPicture
            // 
            pbRightPicture.Anchor = AnchorStyles.Top | AnchorStyles.Bottom | AnchorStyles.Left | AnchorStyles.Right;
            pbRightPicture.BackColor = Color.Transparent;
            pbRightPicture.BackgroundImage = Properties.Resources.manbody;
            pbRightPicture.BackgroundImageLayout = ImageLayout.Zoom;
            pbRightPicture.Location = new Point(617, 12);
            pbRightPicture.Name = "pbRightPicture";
            pbRightPicture.Size = new Size(172, 451);
            pbRightPicture.TabIndex = 8;
            pbRightPicture.TabStop = false;
            // 
            // btnRegister
            // 
            btnRegister.Alpha = 20;
            btnRegister.Anchor = AnchorStyles.Bottom;
            btnRegister.AutoSize = true;
            btnRegister.BackColor = Color.Transparent;
            btnRegister.Background = true;
            btnRegister.Background_WidthPen = 4F;
            btnRegister.BackgroundImage = Properties.Resources.user;
            btnRegister.BackgroundImageLayout = ImageLayout.Stretch;
            btnRegister.BackgroundPen = false;
            btnRegister.ColorBackground = Color.Transparent;
            btnRegister.ColorBackground_1 = Color.FromArgb(37, 52, 68);
            btnRegister.ColorBackground_2 = Color.FromArgb(41, 63, 86);
            btnRegister.ColorBackground_Pen = Color.FromArgb(29, 200, 238);
            btnRegister.ColorLighting = Color.FromArgb(50, 215, 255);
            btnRegister.ColorPen_1 = Color.FromArgb(37, 52, 68);
            btnRegister.ColorPen_2 = Color.FromArgb(41, 63, 86);
            btnRegister.Cursor = Cursors.Hand;
            btnRegister.CyberButtonStyle = ReaLTaiizor.Enum.Cyber.StateStyle.Custom;
            btnRegister.Effect_1 = true;
            btnRegister.Effect_1_ColorBackground = Color.FromArgb(29, 200, 238);
            btnRegister.Effect_1_Transparency = 25;
            btnRegister.Effect_2 = true;
            btnRegister.Effect_2_ColorBackground = Color.White;
            btnRegister.Effect_2_Transparency = 20;
            btnRegister.Font = new Font("Segoe UI Semibold", 12F, FontStyle.Bold, GraphicsUnit.Point);
            btnRegister.ForeColor = Color.Black;
            btnRegister.Lighting = false;
            btnRegister.LinearGradient_Background = false;
            btnRegister.LinearGradientPen = false;
            btnRegister.Location = new Point(460, 374);
            btnRegister.Name = "btnRegister";
            btnRegister.PenWidth = 20;
            btnRegister.Rounding = true;
            btnRegister.RoundingInt = 90;
            btnRegister.Size = new Size(75, 75);
            btnRegister.SmoothingMode = System.Drawing.Drawing2D.SmoothingMode.AntiAlias;
            btnRegister.TabIndex = 7;
            btnRegister.Tag = "Cyber";
            btnRegister.TextButton = "";
            btnRegister.TextRenderingHint = System.Drawing.Text.TextRenderingHint.AntiAlias;
            btnRegister.Timer_Effect_1 = 5;
            btnRegister.Timer_RGB = 300;
            btnRegister.Click += btnRegister_Click;
            // 
            // swcDarkMode
            // 
            swcDarkMode.Alpha = 50;
            swcDarkMode.Anchor = AnchorStyles.Bottom | AnchorStyles.Right;
            swcDarkMode.BackColor = Color.Transparent;
            swcDarkMode.Background = true;
            swcDarkMode.Background_WidthPen = 2F;
            swcDarkMode.BackgroundPen = true;
            swcDarkMode.Checked = false;
            swcDarkMode.ColorBackground = Color.White;
            swcDarkMode.ColorBackground_1 = Color.FromArgb(37, 52, 68);
            swcDarkMode.ColorBackground_2 = Color.FromArgb(41, 63, 86);
            swcDarkMode.ColorBackground_Pen = Color.FromArgb(29, 200, 238);
            swcDarkMode.ColorBackground_Value_1 = Color.FromArgb(28, 200, 238);
            swcDarkMode.ColorBackground_Value_2 = Color.FromArgb(100, 208, 232);
            swcDarkMode.ColorLighting = Color.FromArgb(29, 200, 238);
            swcDarkMode.ColorPen_1 = Color.FromArgb(37, 52, 68);
            swcDarkMode.ColorPen_2 = Color.FromArgb(41, 63, 86);
            swcDarkMode.ColorValue = Color.FromArgb(29, 200, 238);
            swcDarkMode.CyberSwitchStyle = ReaLTaiizor.Enum.Cyber.StateStyle.Custom;
            swcDarkMode.Font = new Font("Arial", 11F, FontStyle.Regular, GraphicsUnit.Point);
            swcDarkMode.ForeColor = Color.FromArgb(245, 245, 245);
            swcDarkMode.Lighting = false;
            swcDarkMode.LinearGradient_Background = false;
            swcDarkMode.LinearGradient_Value = false;
            swcDarkMode.LinearGradientPen = false;
            swcDarkMode.Location = new Point(745, 470);
            swcDarkMode.Name = "swcDarkMode";
            swcDarkMode.PenWidth = 10;
            swcDarkMode.RGB = false;
            swcDarkMode.Rounding = true;
            swcDarkMode.RoundingInt = 90;
            swcDarkMode.Size = new Size(35, 20);
            swcDarkMode.SmoothingMode = System.Drawing.Drawing2D.SmoothingMode.HighQuality;
            swcDarkMode.TabIndex = 10;
            swcDarkMode.Tag = "Cyber";
            swcDarkMode.TextRenderingHint = System.Drawing.Text.TextRenderingHint.ClearTypeGridFit;
            swcDarkMode.Timer_RGB = 300;
            swcDarkMode.CheckedChanged += swcDarkMode_CheckedChanged;
            // 
            // label5
            // 
            label5.Anchor = AnchorStyles.Bottom | AnchorStyles.Right;
            label5.AutoSize = true;
            label5.BackColor = Color.Transparent;
            label5.Font = new Font("Segoe UI", 11.25F, FontStyle.Regular, GraphicsUnit.Point);
            label5.Location = new Point(656, 469);
            label5.Name = "label5";
            label5.Size = new Size(83, 20);
            label5.TabIndex = 5;
            label5.Text = "Dark Mode";
            // 
            // btnMinimize
            // 
            btnMinimize.Anchor = AnchorStyles.Top | AnchorStyles.Right;
            btnMinimize.BackColor = Color.White;
            btnMinimize.BaseColor = Color.FromArgb(45, 47, 49);
            btnMinimize.DefaultLocation = false;
            btnMinimize.DownColor = Color.FromArgb(30, 0, 0, 0);
            btnMinimize.Font = new Font("Marlett", 12F, FontStyle.Regular, GraphicsUnit.Point);
            btnMinimize.Location = new Point(721, 12);
            btnMinimize.Name = "btnMinimize";
            btnMinimize.OverColor = Color.FromArgb(30, 255, 255, 255);
            btnMinimize.Size = new Size(18, 18);
            btnMinimize.TabIndex = 13;
            btnMinimize.Text = "foreverMinimize1";
            btnMinimize.TextColor = Color.FromArgb(243, 243, 243);
            // 
            // btnClose
            // 
            btnClose.Anchor = AnchorStyles.Top | AnchorStyles.Right;
            btnClose.BackColor = Color.IndianRed;
            btnClose.BaseColor = Color.FromArgb(45, 47, 49);
            btnClose.DefaultLocation = false;
            btnClose.DownColor = Color.FromArgb(30, 0, 0, 0);
            btnClose.Font = new Font("Marlett", 10F, FontStyle.Regular, GraphicsUnit.Point);
            btnClose.Location = new Point(769, 12);
            btnClose.Name = "btnClose";
            btnClose.OverColor = Color.FromArgb(30, 255, 255, 255);
            btnClose.Size = new Size(18, 18);
            btnClose.TabIndex = 14;
            btnClose.Text = "foreverClose1";
            btnClose.TextColor = Color.FromArgb(243, 243, 243);
            // 
            // FormOpening
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.White;
            ClientSize = new Size(800, 500);
            Controls.Add(btnClose);
            Controls.Add(btnMinimize);
            Controls.Add(swcDarkMode);
            Controls.Add(pbRightPicture);
            Controls.Add(pbLeftPicture);
            Controls.Add(btnRegister);
            Controls.Add(btnLogin);
            Controls.Add(lblFinal);
            Controls.Add(lblWhatWeProvide);
            Controls.Add(lblApp);
            Controls.Add(label5);
            Controls.Add(lblRegister);
            Controls.Add(lblLogin);
            Controls.Add(lblWelcome);
            Controls.Add(lblApplicatonName);
            Controls.Add(pictureBox1);
            FormBorderStyle = FormBorderStyle.None;
            Icon = (Icon)resources.GetObject("$this.Icon");
            Name = "FormOpening";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "Form1";
            Load += Form1_Load;
            ((System.ComponentModel.ISupportInitialize)pictureBox1).EndInit();
            ((System.ComponentModel.ISupportInitialize)pbLeftPicture).EndInit();
            ((System.ComponentModel.ISupportInitialize)pbRightPicture).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion
        private PictureBox pictureBox1;
        private Label lblApplicatonName;
        private Label lblWelcome;
        private Label lblApp;
        private Label lblWhatWeProvide;
        private Label lblFinal;
        private ReaLTaiizor.Controls.CyberButton btnLogin;
        private Label lblLogin;
        private Label lblRegister;
        private PictureBox pbLeftPicture;
        private PictureBox pbRightPicture;
        private ReaLTaiizor.Controls.CyberButton btnRegister;
        private ReaLTaiizor.Controls.CyberSwitch swcDarkMode;
        private Label label5;
        private ReaLTaiizor.Controls.ForeverMinimize btnMinimize;
        private ReaLTaiizor.Controls.ForeverClose btnClose;
    }
}