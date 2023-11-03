namespace CalorieTracker_PL
{
    partial class FormLogin
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FormLogin));
            txtEmail = new TextBox();
            txtPassword = new TextBox();
            lblEmail = new Label();
            lblPassword = new Label();
            pbShowHidePassword = new PictureBox();
            foreverClose1 = new ReaLTaiizor.Controls.ForeverClose();
            foreverMinimize1 = new ReaLTaiizor.Controls.ForeverMinimize();
            pbEmail = new PictureBox();
            btnForgotPassword = new ReaLTaiizor.Controls.CyberButton();
            btnLogin = new ReaLTaiizor.Controls.CyberButton();
            lblForgotPassword = new Label();
            lblLogin = new Label();
            lblWelcome = new Label();
            lblApplicatonName = new Label();
            pbLogo = new PictureBox();
            pbPassword = new PictureBox();
            ((System.ComponentModel.ISupportInitialize)pbShowHidePassword).BeginInit();
            ((System.ComponentModel.ISupportInitialize)pbEmail).BeginInit();
            ((System.ComponentModel.ISupportInitialize)pbLogo).BeginInit();
            ((System.ComponentModel.ISupportInitialize)pbPassword).BeginInit();
            SuspendLayout();
            // 
            // txtEmail
            // 
            txtEmail.Location = new Point(124, 227);
            txtEmail.Name = "txtEmail";
            txtEmail.Size = new Size(194, 23);
            txtEmail.TabIndex = 0;
            txtEmail.Text = "sametarsl@gmail.com";
            // 
            // txtPassword
            // 
            txtPassword.Location = new Point(124, 265);
            txtPassword.Name = "txtPassword";
            txtPassword.Size = new Size(194, 23);
            txtPassword.TabIndex = 1;
            txtPassword.Text = "123123Sa";
            // 
            // lblEmail
            // 
            lblEmail.AutoSize = true;
            lblEmail.BackColor = Color.Transparent;
            lblEmail.Location = new Point(14, 230);
            lblEmail.Name = "lblEmail";
            lblEmail.Size = new Size(44, 15);
            lblEmail.TabIndex = 2;
            lblEmail.Text = "E-mail:";
            // 
            // lblPassword
            // 
            lblPassword.AutoSize = true;
            lblPassword.BackColor = Color.Transparent;
            lblPassword.Location = new Point(14, 268);
            lblPassword.Name = "lblPassword";
            lblPassword.Size = new Size(60, 15);
            lblPassword.TabIndex = 2;
            lblPassword.Text = "Password:";
            // 
            // pbShowHidePassword
            // 
            pbShowHidePassword.BackColor = Color.Transparent;
            pbShowHidePassword.Image = (Image)resources.GetObject("pbShowHidePassword.Image");
            pbShowHidePassword.Location = new Point(334, 265);
            pbShowHidePassword.Name = "pbShowHidePassword";
            pbShowHidePassword.Size = new Size(23, 23);
            pbShowHidePassword.SizeMode = PictureBoxSizeMode.Zoom;
            pbShowHidePassword.TabIndex = 4;
            pbShowHidePassword.TabStop = false;
            pbShowHidePassword.Click += pbShowHidePassword_Click;
            // 
            // foreverClose1
            // 
            foreverClose1.Anchor = AnchorStyles.Top | AnchorStyles.Right;
            foreverClose1.BackColor = Color.IndianRed;
            foreverClose1.BaseColor = Color.FromArgb(45, 47, 49);
            foreverClose1.DefaultLocation = false;
            foreverClose1.DownColor = Color.FromArgb(30, 0, 0, 0);
            foreverClose1.Font = new Font("Marlett", 10F, FontStyle.Regular, GraphicsUnit.Point);
            foreverClose1.Location = new Point(382, 12);
            foreverClose1.Name = "foreverClose1";
            foreverClose1.OverColor = Color.FromArgb(30, 255, 255, 255);
            foreverClose1.Size = new Size(18, 18);
            foreverClose1.TabIndex = 18;
            foreverClose1.Text = "foreverClose1";
            foreverClose1.TextColor = Color.FromArgb(243, 243, 243);
            // 
            // foreverMinimize1
            // 
            foreverMinimize1.Anchor = AnchorStyles.Top | AnchorStyles.Right;
            foreverMinimize1.BackColor = Color.White;
            foreverMinimize1.BaseColor = Color.FromArgb(45, 47, 49);
            foreverMinimize1.DefaultLocation = false;
            foreverMinimize1.DownColor = Color.FromArgb(30, 0, 0, 0);
            foreverMinimize1.Font = new Font("Marlett", 12F, FontStyle.Regular, GraphicsUnit.Point);
            foreverMinimize1.Location = new Point(334, 12);
            foreverMinimize1.Name = "foreverMinimize1";
            foreverMinimize1.OverColor = Color.FromArgb(30, 255, 255, 255);
            foreverMinimize1.Size = new Size(18, 18);
            foreverMinimize1.TabIndex = 17;
            foreverMinimize1.Text = "foreverMinimize1";
            foreverMinimize1.TextColor = Color.FromArgb(243, 243, 243);
            // 
            // pbEmail
            // 
            pbEmail.BackColor = Color.Transparent;
            pbEmail.Image = Properties.Resources.email;
            pbEmail.Location = new Point(95, 227);
            pbEmail.Name = "pbEmail";
            pbEmail.Size = new Size(23, 23);
            pbEmail.SizeMode = PictureBoxSizeMode.Zoom;
            pbEmail.TabIndex = 4;
            pbEmail.TabStop = false;
            pbEmail.Click += pbShowHidePassword_Click;
            // 
            // btnForgotPassword
            // 
            btnForgotPassword.Alpha = 20;
            btnForgotPassword.Anchor = AnchorStyles.Bottom;
            btnForgotPassword.AutoSize = true;
            btnForgotPassword.BackColor = Color.Transparent;
            btnForgotPassword.Background = true;
            btnForgotPassword.Background_WidthPen = 4F;
            btnForgotPassword.BackgroundImage = Properties.Resources.password;
            btnForgotPassword.BackgroundImageLayout = ImageLayout.Stretch;
            btnForgotPassword.BackgroundPen = false;
            btnForgotPassword.ColorBackground = Color.Transparent;
            btnForgotPassword.ColorBackground_1 = Color.FromArgb(37, 52, 68);
            btnForgotPassword.ColorBackground_2 = Color.FromArgb(41, 63, 86);
            btnForgotPassword.ColorBackground_Pen = Color.FromArgb(29, 200, 238);
            btnForgotPassword.ColorLighting = Color.FromArgb(50, 215, 255);
            btnForgotPassword.ColorPen_1 = Color.FromArgb(37, 52, 68);
            btnForgotPassword.ColorPen_2 = Color.FromArgb(41, 63, 86);
            btnForgotPassword.Cursor = Cursors.Hand;
            btnForgotPassword.CyberButtonStyle = ReaLTaiizor.Enum.Cyber.StateStyle.Custom;
            btnForgotPassword.Effect_1 = true;
            btnForgotPassword.Effect_1_ColorBackground = Color.FromArgb(29, 200, 238);
            btnForgotPassword.Effect_1_Transparency = 25;
            btnForgotPassword.Effect_2 = true;
            btnForgotPassword.Effect_2_ColorBackground = Color.White;
            btnForgotPassword.Effect_2_Transparency = 20;
            btnForgotPassword.Font = new Font("Segoe UI Semibold", 12F, FontStyle.Bold, GraphicsUnit.Point);
            btnForgotPassword.ForeColor = Color.Black;
            btnForgotPassword.Lighting = false;
            btnForgotPassword.LinearGradient_Background = false;
            btnForgotPassword.LinearGradientPen = false;
            btnForgotPassword.Location = new Point(256, 315);
            btnForgotPassword.Name = "btnForgotPassword";
            btnForgotPassword.PenWidth = 20;
            btnForgotPassword.Rounding = true;
            btnForgotPassword.RoundingInt = 90;
            btnForgotPassword.Size = new Size(40, 40);
            btnForgotPassword.SmoothingMode = System.Drawing.Drawing2D.SmoothingMode.AntiAlias;
            btnForgotPassword.TabIndex = 27;
            btnForgotPassword.Tag = "Cyber";
            btnForgotPassword.TextButton = "";
            btnForgotPassword.TextRenderingHint = System.Drawing.Text.TextRenderingHint.AntiAlias;
            btnForgotPassword.Timer_Effect_1 = 5;
            btnForgotPassword.Timer_RGB = 300;
            btnForgotPassword.Click += btnForgotPassword_Click;
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
            btnLogin.Location = new Point(118, 315);
            btnLogin.Name = "btnLogin";
            btnLogin.PenWidth = 20;
            btnLogin.Rounding = true;
            btnLogin.RoundingInt = 90;
            btnLogin.Size = new Size(40, 40);
            btnLogin.SmoothingMode = System.Drawing.Drawing2D.SmoothingMode.AntiAlias;
            btnLogin.TabIndex = 28;
            btnLogin.Tag = "Cyber";
            btnLogin.TextButton = "";
            btnLogin.TextRenderingHint = System.Drawing.Text.TextRenderingHint.AntiAlias;
            btnLogin.Timer_Effect_1 = 5;
            btnLogin.Timer_RGB = 300;
            btnLogin.Click += btnLogin_Click;
            // 
            // lblForgotPassword
            // 
            lblForgotPassword.Anchor = AnchorStyles.Bottom;
            lblForgotPassword.AutoSize = true;
            lblForgotPassword.BackColor = Color.Transparent;
            lblForgotPassword.Font = new Font("Segoe UI", 11.25F, FontStyle.Regular, GraphicsUnit.Point);
            lblForgotPassword.Location = new Point(214, 370);
            lblForgotPassword.Name = "lblForgotPassword";
            lblForgotPassword.Size = new Size(125, 20);
            lblForgotPassword.TabIndex = 25;
            lblForgotPassword.Text = "Forgot Password?";
            // 
            // lblLogin
            // 
            lblLogin.Anchor = AnchorStyles.Bottom;
            lblLogin.AutoSize = true;
            lblLogin.BackColor = Color.Transparent;
            lblLogin.Font = new Font("Segoe UI", 11.25F, FontStyle.Regular, GraphicsUnit.Point);
            lblLogin.Location = new Point(115, 370);
            lblLogin.Name = "lblLogin";
            lblLogin.Size = new Size(46, 20);
            lblLogin.TabIndex = 26;
            lblLogin.Text = "Login";
            // 
            // lblWelcome
            // 
            lblWelcome.Anchor = AnchorStyles.Top | AnchorStyles.Bottom | AnchorStyles.Left | AnchorStyles.Right;
            lblWelcome.AutoSize = true;
            lblWelcome.BackColor = Color.Transparent;
            lblWelcome.Font = new Font("Segoe UI", 11.25F, FontStyle.Regular, GraphicsUnit.Point);
            lblWelcome.Location = new Point(161, 181);
            lblWelcome.Name = "lblWelcome";
            lblWelcome.Size = new Size(79, 20);
            lblWelcome.TabIndex = 31;
            lblWelcome.Text = "Welcome! ";
            // 
            // lblApplicatonName
            // 
            lblApplicatonName.Anchor = AnchorStyles.Top | AnchorStyles.Bottom | AnchorStyles.Left | AnchorStyles.Right;
            lblApplicatonName.AutoSize = true;
            lblApplicatonName.BackColor = Color.Transparent;
            lblApplicatonName.Font = new Font("Segoe UI Semibold", 14.25F, FontStyle.Bold, GraphicsUnit.Point);
            lblApplicatonName.Location = new Point(137, 144);
            lblApplicatonName.Name = "lblApplicatonName";
            lblApplicatonName.Size = new Size(138, 25);
            lblApplicatonName.TabIndex = 30;
            lblApplicatonName.Text = "Calorie Tracker";
            lblApplicatonName.TextAlign = ContentAlignment.MiddleCenter;
            // 
            // pbLogo
            // 
            pbLogo.Anchor = AnchorStyles.Top | AnchorStyles.Bottom | AnchorStyles.Left | AnchorStyles.Right;
            pbLogo.BackColor = Color.Transparent;
            pbLogo.BackgroundImage = Properties.Resources.icon;
            pbLogo.BackgroundImageLayout = ImageLayout.Zoom;
            pbLogo.Location = new Point(140, 12);
            pbLogo.Name = "pbLogo";
            pbLogo.Size = new Size(132, 120);
            pbLogo.SizeMode = PictureBoxSizeMode.StretchImage;
            pbLogo.TabIndex = 29;
            pbLogo.TabStop = false;
            // 
            // pbPassword
            // 
            pbPassword.BackColor = Color.Transparent;
            pbPassword.Image = Properties.Resources.password;
            pbPassword.Location = new Point(95, 265);
            pbPassword.Name = "pbPassword";
            pbPassword.Size = new Size(23, 23);
            pbPassword.SizeMode = PictureBoxSizeMode.Zoom;
            pbPassword.TabIndex = 4;
            pbPassword.TabStop = false;
            pbPassword.Click += pbShowHidePassword_Click;
            // 
            // FormLogin
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.White;
            ClientSize = new Size(412, 495);
            Controls.Add(lblWelcome);
            Controls.Add(lblApplicatonName);
            Controls.Add(pbLogo);
            Controls.Add(btnForgotPassword);
            Controls.Add(btnLogin);
            Controls.Add(lblForgotPassword);
            Controls.Add(lblLogin);
            Controls.Add(foreverClose1);
            Controls.Add(foreverMinimize1);
            Controls.Add(pbPassword);
            Controls.Add(pbEmail);
            Controls.Add(pbShowHidePassword);
            Controls.Add(lblPassword);
            Controls.Add(lblEmail);
            Controls.Add(txtPassword);
            Controls.Add(txtEmail);
            FormBorderStyle = FormBorderStyle.None;
            Name = "FormLogin";
            StartPosition = FormStartPosition.CenterParent;
            Text = "frmLogin";
            Load += FormLogin_Load;
            ((System.ComponentModel.ISupportInitialize)pbShowHidePassword).EndInit();
            ((System.ComponentModel.ISupportInitialize)pbEmail).EndInit();
            ((System.ComponentModel.ISupportInitialize)pbLogo).EndInit();
            ((System.ComponentModel.ISupportInitialize)pbPassword).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private TextBox txtEmail;
        private TextBox txtPassword;
        private Label lblEmail;
        private Label lblPassword;
        private PictureBox pbShowHidePassword;
        private ReaLTaiizor.Controls.ForeverClose foreverClose1;
        private ReaLTaiizor.Controls.ForeverMinimize foreverMinimize1;
        private PictureBox pbEmail;
        private ReaLTaiizor.Controls.CyberButton btnForgotPassword;
        private ReaLTaiizor.Controls.CyberButton btnLogin;
        private Label lblForgotPassword;
        private Label lblLogin;
        private Label lblWelcome;
        private Label lblApplicatonName;
        private PictureBox pbLogo;
        private PictureBox pbPassword;
    }
}