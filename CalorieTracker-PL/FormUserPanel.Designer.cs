namespace CalorieTracker_PL
{
    partial class FormUserPanel
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FormUserPanel));
            btnClose = new ReaLTaiizor.Controls.ForeverClose();
            btnMinimize = new ReaLTaiizor.Controls.ForeverMinimize();
            lblWeight = new Label();
            lblHeight = new Label();
            lblAge = new Label();
            lblUserName = new Label();
            btnAnalyse = new ReaLTaiizor.Controls.CyberButton();
            btnAdd = new ReaLTaiizor.Controls.CyberButton();
            btnAdminPanel = new ReaLTaiizor.Controls.CyberButton();
            btnHome = new ReaLTaiizor.Controls.CyberButton();
            btnUserProfile = new ReaLTaiizor.Controls.CyberButton();
            btnLogin = new ReaLTaiizor.Controls.CyberButton();
            panel1 = new Panel();
            btnCalculations = new ReaLTaiizor.Controls.CyberButton();
            pbLogo = new PictureBox();
            pbLeftFrame = new PictureBox();
            lblUserAge = new Label();
            panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)pbLogo).BeginInit();
            ((System.ComponentModel.ISupportInitialize)pbLeftFrame).BeginInit();
            SuspendLayout();
            // 
            // btnClose
            // 
            btnClose.Anchor = AnchorStyles.Top | AnchorStyles.Right;
            btnClose.BackColor = Color.IndianRed;
            btnClose.BaseColor = Color.FromArgb(45, 47, 49);
            btnClose.DefaultLocation = false;
            btnClose.DownColor = Color.FromArgb(30, 0, 0, 0);
            btnClose.Font = new Font("Marlett", 10F, FontStyle.Regular, GraphicsUnit.Point);
            btnClose.Location = new Point(770, 12);
            btnClose.Name = "btnClose";
            btnClose.OverColor = Color.FromArgb(30, 255, 255, 255);
            btnClose.Size = new Size(18, 18);
            btnClose.TabIndex = 47;
            btnClose.Text = "foreverClose1";
            btnClose.TextColor = Color.FromArgb(243, 243, 243);
            btnClose.Click += btnClose_Click;
            // 
            // btnMinimize
            // 
            btnMinimize.Anchor = AnchorStyles.Top | AnchorStyles.Right;
            btnMinimize.BackColor = Color.White;
            btnMinimize.BaseColor = Color.FromArgb(45, 47, 49);
            btnMinimize.DefaultLocation = false;
            btnMinimize.DownColor = Color.FromArgb(30, 0, 0, 0);
            btnMinimize.Font = new Font("Marlett", 12F, FontStyle.Regular, GraphicsUnit.Point);
            btnMinimize.Location = new Point(722, 12);
            btnMinimize.Name = "btnMinimize";
            btnMinimize.OverColor = Color.FromArgb(30, 255, 255, 255);
            btnMinimize.Size = new Size(18, 18);
            btnMinimize.TabIndex = 46;
            btnMinimize.Text = "foreverMinimize1";
            btnMinimize.TextColor = Color.FromArgb(243, 243, 243);
            // 
            // lblWeight
            // 
            lblWeight.AutoSize = true;
            lblWeight.Font = new Font("Segoe UI Semibold", 9.75F, FontStyle.Bold, GraphicsUnit.Point);
            lblWeight.Location = new Point(561, 383);
            lblWeight.Name = "lblWeight";
            lblWeight.Size = new Size(52, 17);
            lblWeight.TabIndex = 54;
            lblWeight.Text = "Weight";
            // 
            // lblHeight
            // 
            lblHeight.AutoSize = true;
            lblHeight.Font = new Font("Segoe UI Semibold", 9.75F, FontStyle.Bold, GraphicsUnit.Point);
            lblHeight.Location = new Point(476, 383);
            lblHeight.Name = "lblHeight";
            lblHeight.Size = new Size(49, 17);
            lblHeight.TabIndex = 55;
            lblHeight.Text = "Height";
            // 
            // lblAge
            // 
            lblAge.Location = new Point(0, 0);
            lblAge.Name = "lblAge";
            lblAge.Size = new Size(100, 23);
            lblAge.TabIndex = 0;
            // 
            // lblUserName
            // 
            lblUserName.AutoSize = true;
            lblUserName.Font = new Font("Segoe UI Semibold", 9.75F, FontStyle.Bold, GraphicsUnit.Point);
            lblUserName.Location = new Point(217, 383);
            lblUserName.Name = "lblUserName";
            lblUserName.Size = new Size(75, 17);
            lblUserName.TabIndex = 57;
            lblUserName.Text = "User Name";
            // 
            // btnAnalyse
            // 
            btnAnalyse.Alpha = 20;
            btnAnalyse.BackColor = Color.Transparent;
            btnAnalyse.Background = true;
            btnAnalyse.Background_WidthPen = 4F;
            btnAnalyse.BackgroundImage = Properties.Resources.bar_chart;
            btnAnalyse.BackgroundImageLayout = ImageLayout.Zoom;
            btnAnalyse.BackgroundPen = false;
            btnAnalyse.ColorBackground = Color.Transparent;
            btnAnalyse.ColorBackground_1 = Color.FromArgb(37, 52, 68);
            btnAnalyse.ColorBackground_2 = Color.FromArgb(41, 63, 86);
            btnAnalyse.ColorBackground_Pen = Color.FromArgb(29, 200, 238);
            btnAnalyse.ColorLighting = Color.FromArgb(29, 200, 238);
            btnAnalyse.ColorPen_1 = Color.FromArgb(37, 52, 68);
            btnAnalyse.ColorPen_2 = Color.FromArgb(41, 63, 86);
            btnAnalyse.CyberButtonStyle = ReaLTaiizor.Enum.Cyber.StateStyle.Custom;
            btnAnalyse.Effect_1 = true;
            btnAnalyse.Effect_1_ColorBackground = Color.FromArgb(29, 200, 238);
            btnAnalyse.Effect_1_Transparency = 25;
            btnAnalyse.Effect_2 = true;
            btnAnalyse.Effect_2_ColorBackground = Color.White;
            btnAnalyse.Effect_2_Transparency = 20;
            btnAnalyse.Font = new Font("Arial", 11F, FontStyle.Regular, GraphicsUnit.Point);
            btnAnalyse.ForeColor = Color.FromArgb(245, 245, 245);
            btnAnalyse.Lighting = false;
            btnAnalyse.LinearGradient_Background = false;
            btnAnalyse.LinearGradientPen = false;
            btnAnalyse.Location = new Point(369, 21);
            btnAnalyse.Name = "btnAnalyse";
            btnAnalyse.PenWidth = 15;
            btnAnalyse.Rounding = true;
            btnAnalyse.RoundingInt = 90;
            btnAnalyse.Size = new Size(50, 50);
            btnAnalyse.SmoothingMode = System.Drawing.Drawing2D.SmoothingMode.HighQuality;
            btnAnalyse.TabIndex = 2;
            btnAnalyse.Tag = "Cyber";
            btnAnalyse.TextButton = "";
            btnAnalyse.TextRenderingHint = System.Drawing.Text.TextRenderingHint.ClearTypeGridFit;
            btnAnalyse.Timer_Effect_1 = 5;
            btnAnalyse.Timer_RGB = 300;
            btnAnalyse.Click += btnAnalyse_Click;
            // 
            // btnAdd
            // 
            btnAdd.Alpha = 20;
            btnAdd.BackColor = Color.Transparent;
            btnAdd.Background = true;
            btnAdd.Background_WidthPen = 4F;
            btnAdd.BackgroundImage = Properties.Resources.plus;
            btnAdd.BackgroundImageLayout = ImageLayout.Zoom;
            btnAdd.BackgroundPen = false;
            btnAdd.ColorBackground = Color.Transparent;
            btnAdd.ColorBackground_1 = Color.FromArgb(37, 52, 68);
            btnAdd.ColorBackground_2 = Color.FromArgb(41, 63, 86);
            btnAdd.ColorBackground_Pen = Color.FromArgb(29, 200, 238);
            btnAdd.ColorLighting = Color.FromArgb(29, 200, 238);
            btnAdd.ColorPen_1 = Color.FromArgb(37, 52, 68);
            btnAdd.ColorPen_2 = Color.FromArgb(41, 63, 86);
            btnAdd.CyberButtonStyle = ReaLTaiizor.Enum.Cyber.StateStyle.Custom;
            btnAdd.Effect_1 = true;
            btnAdd.Effect_1_ColorBackground = Color.FromArgb(29, 200, 238);
            btnAdd.Effect_1_Transparency = 25;
            btnAdd.Effect_2 = true;
            btnAdd.Effect_2_ColorBackground = Color.White;
            btnAdd.Effect_2_Transparency = 20;
            btnAdd.Font = new Font("Arial", 11F, FontStyle.Regular, GraphicsUnit.Point);
            btnAdd.ForeColor = Color.FromArgb(245, 245, 245);
            btnAdd.Lighting = false;
            btnAdd.LinearGradient_Background = false;
            btnAdd.LinearGradientPen = false;
            btnAdd.Location = new Point(294, 21);
            btnAdd.Name = "btnAdd";
            btnAdd.PenWidth = 15;
            btnAdd.Rounding = true;
            btnAdd.RoundingInt = 90;
            btnAdd.Size = new Size(50, 50);
            btnAdd.SmoothingMode = System.Drawing.Drawing2D.SmoothingMode.HighQuality;
            btnAdd.TabIndex = 2;
            btnAdd.Tag = "Cyber";
            btnAdd.TextButton = "";
            btnAdd.TextRenderingHint = System.Drawing.Text.TextRenderingHint.ClearTypeGridFit;
            btnAdd.Timer_Effect_1 = 5;
            btnAdd.Timer_RGB = 300;
            btnAdd.Click += btnAdd_Click;
            // 
            // btnAdminPanel
            // 
            btnAdminPanel.Alpha = 20;
            btnAdminPanel.BackColor = Color.Transparent;
            btnAdminPanel.Background = true;
            btnAdminPanel.Background_WidthPen = 4F;
            btnAdminPanel.BackgroundImage = Properties.Resources.leftpanel;
            btnAdminPanel.BackgroundImageLayout = ImageLayout.Zoom;
            btnAdminPanel.BackgroundPen = false;
            btnAdminPanel.ColorBackground = Color.Transparent;
            btnAdminPanel.ColorBackground_1 = Color.FromArgb(37, 52, 68);
            btnAdminPanel.ColorBackground_2 = Color.FromArgb(41, 63, 86);
            btnAdminPanel.ColorBackground_Pen = Color.FromArgb(29, 200, 238);
            btnAdminPanel.ColorLighting = Color.FromArgb(29, 200, 238);
            btnAdminPanel.ColorPen_1 = Color.FromArgb(37, 52, 68);
            btnAdminPanel.ColorPen_2 = Color.FromArgb(41, 63, 86);
            btnAdminPanel.CyberButtonStyle = ReaLTaiizor.Enum.Cyber.StateStyle.Custom;
            btnAdminPanel.Effect_1 = true;
            btnAdminPanel.Effect_1_ColorBackground = Color.FromArgb(29, 200, 238);
            btnAdminPanel.Effect_1_Transparency = 25;
            btnAdminPanel.Effect_2 = true;
            btnAdminPanel.Effect_2_ColorBackground = Color.White;
            btnAdminPanel.Effect_2_Transparency = 20;
            btnAdminPanel.Font = new Font("Arial", 11F, FontStyle.Regular, GraphicsUnit.Point);
            btnAdminPanel.ForeColor = Color.FromArgb(245, 245, 245);
            btnAdminPanel.Lighting = false;
            btnAdminPanel.LinearGradient_Background = false;
            btnAdminPanel.LinearGradientPen = false;
            btnAdminPanel.Location = new Point(25, 21);
            btnAdminPanel.Name = "btnAdminPanel";
            btnAdminPanel.PenWidth = 15;
            btnAdminPanel.Rounding = true;
            btnAdminPanel.RoundingInt = 90;
            btnAdminPanel.Size = new Size(50, 50);
            btnAdminPanel.SmoothingMode = System.Drawing.Drawing2D.SmoothingMode.HighQuality;
            btnAdminPanel.TabIndex = 2;
            btnAdminPanel.Tag = "Cyber";
            btnAdminPanel.TextButton = "";
            btnAdminPanel.TextRenderingHint = System.Drawing.Text.TextRenderingHint.ClearTypeGridFit;
            btnAdminPanel.Timer_Effect_1 = 5;
            btnAdminPanel.Timer_RGB = 300;
            btnAdminPanel.Click += btnAdminPanel_Click;
            // 
            // btnHome
            // 
            btnHome.Alpha = 20;
            btnHome.BackColor = Color.Transparent;
            btnHome.Background = true;
            btnHome.Background_WidthPen = 4F;
            btnHome.BackgroundImage = Properties.Resources.home;
            btnHome.BackgroundImageLayout = ImageLayout.Zoom;
            btnHome.BackgroundPen = false;
            btnHome.ColorBackground = Color.Transparent;
            btnHome.ColorBackground_1 = Color.FromArgb(37, 52, 68);
            btnHome.ColorBackground_2 = Color.FromArgb(41, 63, 86);
            btnHome.ColorBackground_Pen = Color.FromArgb(29, 200, 238);
            btnHome.ColorLighting = Color.FromArgb(29, 200, 238);
            btnHome.ColorPen_1 = Color.FromArgb(37, 52, 68);
            btnHome.ColorPen_2 = Color.FromArgb(41, 63, 86);
            btnHome.CyberButtonStyle = ReaLTaiizor.Enum.Cyber.StateStyle.Custom;
            btnHome.Effect_1 = true;
            btnHome.Effect_1_ColorBackground = Color.FromArgb(29, 200, 238);
            btnHome.Effect_1_Transparency = 25;
            btnHome.Effect_2 = true;
            btnHome.Effect_2_ColorBackground = Color.White;
            btnHome.Effect_2_Transparency = 20;
            btnHome.Font = new Font("Arial", 11F, FontStyle.Regular, GraphicsUnit.Point);
            btnHome.ForeColor = Color.FromArgb(245, 245, 245);
            btnHome.Lighting = false;
            btnHome.LinearGradient_Background = false;
            btnHome.LinearGradientPen = false;
            btnHome.Location = new Point(219, 21);
            btnHome.Name = "btnHome";
            btnHome.PenWidth = 15;
            btnHome.Rounding = true;
            btnHome.RoundingInt = 90;
            btnHome.Size = new Size(50, 50);
            btnHome.SmoothingMode = System.Drawing.Drawing2D.SmoothingMode.HighQuality;
            btnHome.TabIndex = 2;
            btnHome.Tag = "Cyber";
            btnHome.TextButton = "";
            btnHome.TextRenderingHint = System.Drawing.Text.TextRenderingHint.ClearTypeGridFit;
            btnHome.Timer_Effect_1 = 5;
            btnHome.Timer_RGB = 300;
            btnHome.Click += btnHome_Click;
            // 
            // btnUserProfile
            // 
            btnUserProfile.Alpha = 20;
            btnUserProfile.BackColor = Color.Transparent;
            btnUserProfile.Background = true;
            btnUserProfile.Background_WidthPen = 4F;
            btnUserProfile.BackgroundImage = Properties.Resources.user;
            btnUserProfile.BackgroundImageLayout = ImageLayout.Zoom;
            btnUserProfile.BackgroundPen = false;
            btnUserProfile.ColorBackground = Color.Transparent;
            btnUserProfile.ColorBackground_1 = Color.FromArgb(37, 52, 68);
            btnUserProfile.ColorBackground_2 = Color.FromArgb(41, 63, 86);
            btnUserProfile.ColorBackground_Pen = Color.FromArgb(29, 200, 238);
            btnUserProfile.ColorLighting = Color.FromArgb(29, 200, 238);
            btnUserProfile.ColorPen_1 = Color.FromArgb(37, 52, 68);
            btnUserProfile.ColorPen_2 = Color.FromArgb(41, 63, 86);
            btnUserProfile.CyberButtonStyle = ReaLTaiizor.Enum.Cyber.StateStyle.Custom;
            btnUserProfile.Effect_1 = true;
            btnUserProfile.Effect_1_ColorBackground = Color.FromArgb(29, 200, 238);
            btnUserProfile.Effect_1_Transparency = 25;
            btnUserProfile.Effect_2 = true;
            btnUserProfile.Effect_2_ColorBackground = Color.White;
            btnUserProfile.Effect_2_Transparency = 20;
            btnUserProfile.Font = new Font("Arial", 11F, FontStyle.Regular, GraphicsUnit.Point);
            btnUserProfile.ForeColor = Color.FromArgb(245, 245, 245);
            btnUserProfile.Lighting = false;
            btnUserProfile.LinearGradient_Background = false;
            btnUserProfile.LinearGradientPen = false;
            btnUserProfile.Location = new Point(519, 21);
            btnUserProfile.Name = "btnUserProfile";
            btnUserProfile.PenWidth = 15;
            btnUserProfile.Rounding = true;
            btnUserProfile.RoundingInt = 90;
            btnUserProfile.Size = new Size(50, 50);
            btnUserProfile.SmoothingMode = System.Drawing.Drawing2D.SmoothingMode.HighQuality;
            btnUserProfile.TabIndex = 2;
            btnUserProfile.Tag = "Cyber";
            btnUserProfile.TextButton = "";
            btnUserProfile.TextRenderingHint = System.Drawing.Text.TextRenderingHint.ClearTypeGridFit;
            btnUserProfile.Timer_Effect_1 = 5;
            btnUserProfile.Timer_RGB = 300;
            btnUserProfile.Click += btnUserProfile_Click;
            // 
            // btnLogin
            // 
            btnLogin.Alpha = 20;
            btnLogin.BackColor = Color.Transparent;
            btnLogin.Background = true;
            btnLogin.Background_WidthPen = 4F;
            btnLogin.BackgroundImage = Properties.Resources.logout;
            btnLogin.BackgroundImageLayout = ImageLayout.Zoom;
            btnLogin.BackgroundPen = false;
            btnLogin.ColorBackground = Color.Transparent;
            btnLogin.ColorBackground_1 = Color.FromArgb(37, 52, 68);
            btnLogin.ColorBackground_2 = Color.FromArgb(41, 63, 86);
            btnLogin.ColorBackground_Pen = Color.FromArgb(29, 200, 238);
            btnLogin.ColorLighting = Color.FromArgb(29, 200, 238);
            btnLogin.ColorPen_1 = Color.FromArgb(37, 52, 68);
            btnLogin.ColorPen_2 = Color.FromArgb(41, 63, 86);
            btnLogin.CyberButtonStyle = ReaLTaiizor.Enum.Cyber.StateStyle.Custom;
            btnLogin.Effect_1 = true;
            btnLogin.Effect_1_ColorBackground = Color.FromArgb(29, 200, 238);
            btnLogin.Effect_1_Transparency = 25;
            btnLogin.Effect_2 = true;
            btnLogin.Effect_2_ColorBackground = Color.White;
            btnLogin.Effect_2_Transparency = 20;
            btnLogin.Font = new Font("Arial", 11F, FontStyle.Regular, GraphicsUnit.Point);
            btnLogin.ForeColor = Color.FromArgb(245, 245, 245);
            btnLogin.Lighting = false;
            btnLogin.LinearGradient_Background = false;
            btnLogin.LinearGradientPen = false;
            btnLogin.Location = new Point(701, 21);
            btnLogin.Name = "btnLogin";
            btnLogin.PenWidth = 15;
            btnLogin.Rounding = true;
            btnLogin.RoundingInt = 90;
            btnLogin.Size = new Size(50, 50);
            btnLogin.SmoothingMode = System.Drawing.Drawing2D.SmoothingMode.HighQuality;
            btnLogin.TabIndex = 2;
            btnLogin.Tag = "Cyber";
            btnLogin.TextButton = "";
            btnLogin.TextRenderingHint = System.Drawing.Text.TextRenderingHint.ClearTypeGridFit;
            btnLogin.Timer_Effect_1 = 5;
            btnLogin.Timer_RGB = 300;
            btnLogin.Click += btnLogin_Click;
            // 
            // panel1
            // 
            panel1.BackColor = Color.Transparent;
            panel1.Controls.Add(btnLogin);
            panel1.Controls.Add(btnCalculations);
            panel1.Controls.Add(btnUserProfile);
            panel1.Controls.Add(btnHome);
            panel1.Controls.Add(btnAdminPanel);
            panel1.Controls.Add(btnAdd);
            panel1.Controls.Add(btnAnalyse);
            panel1.Location = new Point(13, 400);
            panel1.Name = "panel1";
            panel1.Size = new Size(776, 88);
            panel1.TabIndex = 3;
            // 
            // btnCalculations
            // 
            btnCalculations.Alpha = 20;
            btnCalculations.BackColor = Color.Transparent;
            btnCalculations.Background = true;
            btnCalculations.Background_WidthPen = 4F;
            btnCalculations.BackgroundImage = Properties.Resources.calculator;
            btnCalculations.BackgroundImageLayout = ImageLayout.Zoom;
            btnCalculations.BackgroundPen = false;
            btnCalculations.ColorBackground = Color.Transparent;
            btnCalculations.ColorBackground_1 = Color.FromArgb(37, 52, 68);
            btnCalculations.ColorBackground_2 = Color.FromArgb(41, 63, 86);
            btnCalculations.ColorBackground_Pen = Color.FromArgb(29, 200, 238);
            btnCalculations.ColorLighting = Color.FromArgb(29, 200, 238);
            btnCalculations.ColorPen_1 = Color.FromArgb(37, 52, 68);
            btnCalculations.ColorPen_2 = Color.FromArgb(41, 63, 86);
            btnCalculations.CyberButtonStyle = ReaLTaiizor.Enum.Cyber.StateStyle.Custom;
            btnCalculations.Effect_1 = true;
            btnCalculations.Effect_1_ColorBackground = Color.FromArgb(29, 200, 238);
            btnCalculations.Effect_1_Transparency = 25;
            btnCalculations.Effect_2 = true;
            btnCalculations.Effect_2_ColorBackground = Color.White;
            btnCalculations.Effect_2_Transparency = 20;
            btnCalculations.Font = new Font("Arial", 11F, FontStyle.Regular, GraphicsUnit.Point);
            btnCalculations.ForeColor = Color.FromArgb(245, 245, 245);
            btnCalculations.Lighting = false;
            btnCalculations.LinearGradient_Background = false;
            btnCalculations.LinearGradientPen = false;
            btnCalculations.Location = new Point(444, 21);
            btnCalculations.Name = "btnCalculations";
            btnCalculations.PenWidth = 15;
            btnCalculations.Rounding = true;
            btnCalculations.RoundingInt = 90;
            btnCalculations.Size = new Size(50, 50);
            btnCalculations.SmoothingMode = System.Drawing.Drawing2D.SmoothingMode.HighQuality;
            btnCalculations.TabIndex = 2;
            btnCalculations.Tag = "Cyber";
            btnCalculations.TextButton = "";
            btnCalculations.TextRenderingHint = System.Drawing.Text.TextRenderingHint.ClearTypeGridFit;
            btnCalculations.Timer_Effect_1 = 5;
            btnCalculations.Timer_RGB = 300;
            btnCalculations.Click += btnCalculations_Click;
            // 
            // pbLogo
            // 
            pbLogo.Anchor = AnchorStyles.Top | AnchorStyles.Bottom | AnchorStyles.Left | AnchorStyles.Right;
            pbLogo.BackColor = Color.Transparent;
            pbLogo.BackgroundImage = Properties.Resources.icon;
            pbLogo.BackgroundImageLayout = ImageLayout.Zoom;
            pbLogo.Location = new Point(11, 12);
            pbLogo.Name = "pbLogo";
            pbLogo.Size = new Size(75, 75);
            pbLogo.SizeMode = PictureBoxSizeMode.StretchImage;
            pbLogo.TabIndex = 49;
            pbLogo.TabStop = false;
            // 
            // pbLeftFrame
            // 
            pbLeftFrame.BackColor = Color.Transparent;
            pbLeftFrame.BackgroundImage = Properties.Resources.womanbody;
            pbLeftFrame.BackgroundImageLayout = ImageLayout.Zoom;
            pbLeftFrame.ErrorImage = null;
            pbLeftFrame.Location = new Point(11, 93);
            pbLeftFrame.Name = "pbLeftFrame";
            pbLeftFrame.Size = new Size(115, 284);
            pbLeftFrame.TabIndex = 48;
            pbLeftFrame.TabStop = false;
            // 
            // lblUserAge
            // 
            lblUserAge.AutoSize = true;
            lblUserAge.Font = new Font("Segoe UI Semibold", 9.75F, FontStyle.Bold, GraphicsUnit.Point);
            lblUserAge.Location = new Point(382, 383);
            lblUserAge.Name = "lblUserAge";
            lblUserAge.Size = new Size(32, 17);
            lblUserAge.TabIndex = 57;
            lblUserAge.Text = "Age";
            // 
            // FormUserPanel
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(800, 500);
            Controls.Add(lblWeight);
            Controls.Add(lblHeight);
            Controls.Add(lblUserAge);
            Controls.Add(lblUserName);
            Controls.Add(panel1);
            Controls.Add(pbLogo);
            Controls.Add(pbLeftFrame);
            Controls.Add(btnClose);
            Controls.Add(btnMinimize);
            FormBorderStyle = FormBorderStyle.None;
            Icon = (Icon)resources.GetObject("$this.Icon");
            IsMdiContainer = true;
            Name = "FormUserPanel";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "FormUserPanel";
            Load += FormUserPanel_Load;
            panel1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)pbLogo).EndInit();
            ((System.ComponentModel.ISupportInitialize)pbLeftFrame).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private ReaLTaiizor.Controls.ForeverClose btnClose;
        private ReaLTaiizor.Controls.ForeverMinimize btnMinimize;
        private Label lblWeight;
        private Label lblHeight;
        private Label lblAge;
        private Label lblUserName;
        private ReaLTaiizor.Controls.CyberButton btnAnalyse;
        private ReaLTaiizor.Controls.CyberButton btnAdd;
        private ReaLTaiizor.Controls.CyberButton btnAdminPanel;
        private ReaLTaiizor.Controls.CyberButton btnHome;
        private ReaLTaiizor.Controls.CyberButton btnUserProfile;
        private ReaLTaiizor.Controls.CyberButton btnLogin;
        private Panel panel1;
        private PictureBox pbLogo;
        private PictureBox pbLeftFrame;
        private ReaLTaiizor.Controls.CyberButton btnCalculations;
        private Label lblUserAge;
    }
}