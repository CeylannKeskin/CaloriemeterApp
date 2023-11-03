namespace CalorieTracker_PL
{
    partial class FormAnalyse
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
            System.Windows.Forms.DataVisualization.Charting.ChartArea chartArea1 = new System.Windows.Forms.DataVisualization.Charting.ChartArea();
            System.Windows.Forms.DataVisualization.Charting.Legend legend1 = new System.Windows.Forms.DataVisualization.Charting.Legend();
            System.Windows.Forms.DataVisualization.Charting.Series series1 = new System.Windows.Forms.DataVisualization.Charting.Series();
            System.Windows.Forms.DataVisualization.Charting.ChartArea chartArea2 = new System.Windows.Forms.DataVisualization.Charting.ChartArea();
            System.Windows.Forms.DataVisualization.Charting.Legend legend2 = new System.Windows.Forms.DataVisualization.Charting.Legend();
            System.Windows.Forms.DataVisualization.Charting.Series series2 = new System.Windows.Forms.DataVisualization.Charting.Series();
            mcPickDate = new MonthCalendar();
            btnCalendar = new ReaLTaiizor.Controls.CyberButton();
            panel1 = new Panel();
            btnLogin = new ReaLTaiizor.Controls.CyberButton();
            btnUserProfile = new ReaLTaiizor.Controls.CyberButton();
            btnHome = new ReaLTaiizor.Controls.CyberButton();
            btnAdminPanel = new ReaLTaiizor.Controls.CyberButton();
            btnAdd = new ReaLTaiizor.Controls.CyberButton();
            btnAnalyse = new ReaLTaiizor.Controls.CyberButton();
            pbLogo = new PictureBox();
            pbLeftFrame = new PictureBox();
            chart1 = new System.Windows.Forms.DataVisualization.Charting.Chart();
            chart2 = new System.Windows.Forms.DataVisualization.Charting.Chart();
            panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)pbLogo).BeginInit();
            ((System.ComponentModel.ISupportInitialize)pbLeftFrame).BeginInit();
            ((System.ComponentModel.ISupportInitialize)chart1).BeginInit();
            ((System.ComponentModel.ISupportInitialize)chart2).BeginInit();
            SuspendLayout();
            // 
            // mcPickDate
            // 
            mcPickDate.BackColor = Color.White;
            mcPickDate.Location = new Point(492, 37);
            mcPickDate.Name = "mcPickDate";
            mcPickDate.TabIndex = 0;
            mcPickDate.Visible = false;
            // 
            // btnCalendar
            // 
            btnCalendar.Alpha = 20;
            btnCalendar.BackColor = Color.Transparent;
            btnCalendar.Background = true;
            btnCalendar.Background_WidthPen = 4F;
            btnCalendar.BackgroundImage = Properties.Resources.calendar;
            btnCalendar.BackgroundImageLayout = ImageLayout.Zoom;
            btnCalendar.BackgroundPen = false;
            btnCalendar.ColorBackground = Color.Transparent;
            btnCalendar.ColorBackground_1 = Color.FromArgb(37, 52, 68);
            btnCalendar.ColorBackground_2 = Color.FromArgb(41, 63, 86);
            btnCalendar.ColorBackground_Pen = Color.FromArgb(29, 200, 238);
            btnCalendar.ColorLighting = Color.FromArgb(29, 200, 238);
            btnCalendar.ColorPen_1 = Color.FromArgb(37, 52, 68);
            btnCalendar.ColorPen_2 = Color.FromArgb(41, 63, 86);
            btnCalendar.CyberButtonStyle = ReaLTaiizor.Enum.Cyber.StateStyle.Custom;
            btnCalendar.Effect_1 = true;
            btnCalendar.Effect_1_ColorBackground = Color.FromArgb(29, 200, 238);
            btnCalendar.Effect_1_Transparency = 25;
            btnCalendar.Effect_2 = true;
            btnCalendar.Effect_2_ColorBackground = Color.White;
            btnCalendar.Effect_2_Transparency = 20;
            btnCalendar.Font = new Font("Arial", 11F, FontStyle.Regular, GraphicsUnit.Point);
            btnCalendar.ForeColor = Color.FromArgb(245, 245, 245);
            btnCalendar.Lighting = false;
            btnCalendar.LinearGradient_Background = false;
            btnCalendar.LinearGradientPen = false;
            btnCalendar.Location = new Point(738, 37);
            btnCalendar.Name = "btnCalendar";
            btnCalendar.PenWidth = 15;
            btnCalendar.Rounding = true;
            btnCalendar.RoundingInt = 90;
            btnCalendar.Size = new Size(50, 50);
            btnCalendar.SmoothingMode = System.Drawing.Drawing2D.SmoothingMode.HighQuality;
            btnCalendar.TabIndex = 1;
            btnCalendar.Tag = "Cyber";
            btnCalendar.TextButton = "";
            btnCalendar.TextRenderingHint = System.Drawing.Text.TextRenderingHint.ClearTypeGridFit;
            btnCalendar.Timer_Effect_1 = 5;
            btnCalendar.Timer_RGB = 300;
            btnCalendar.Click += btnCalendar_Click;
            // 
            // panel1
            // 
            panel1.BackColor = Color.Transparent;
            panel1.Controls.Add(btnLogin);
            panel1.Controls.Add(btnUserProfile);
            panel1.Controls.Add(btnHome);
            panel1.Controls.Add(btnAdminPanel);
            panel1.Controls.Add(btnAdd);
            panel1.Controls.Add(btnAnalyse);
            panel1.Location = new Point(13, 400);
            panel1.Name = "panel1";
            panel1.Size = new Size(776, 88);
            panel1.TabIndex = 50;
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
            btnUserProfile.Location = new Point(483, 21);
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
            btnHome.Location = new Point(258, 21);
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
            btnAdd.Location = new Point(333, 21);
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
            btnAnalyse.Location = new Point(408, 21);
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
            pbLogo.TabIndex = 52;
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
            pbLeftFrame.TabIndex = 51;
            pbLeftFrame.TabStop = false;
            // 
            // chart1
            // 
            chartArea1.Name = "ChartArea1";
            chart1.ChartAreas.Add(chartArea1);
            legend1.Name = "Legend1";
            chart1.Legends.Add(legend1);
            chart1.Location = new Point(164, 28);
            chart1.Name = "chart1";
            series1.ChartArea = "ChartArea1";
            series1.Legend = "Legend1";
            series1.Name = "Series1";
            chart1.Series.Add(series1);
            chart1.Size = new Size(562, 171);
            chart1.TabIndex = 53;
            chart1.Text = "chart1";
            // 
            // chart2
            // 
            chartArea2.Name = "ChartArea1";
            chart2.ChartAreas.Add(chartArea2);
            legend2.Name = "Legend1";
            chart2.Legends.Add(legend2);
            chart2.Location = new Point(164, 211);
            chart2.Name = "chart2";
            series2.ChartArea = "ChartArea1";
            series2.Legend = "Legend1";
            series2.Name = "Series1";
            chart2.Series.Add(series2);
            chart2.Size = new Size(562, 171);
            chart2.TabIndex = 53;
            chart2.Text = "chart1";
            // 
            // FormAnalyse
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(800, 500);
            Controls.Add(chart2);
            Controls.Add(chart1);
            Controls.Add(mcPickDate);
            Controls.Add(panel1);
            Controls.Add(pbLogo);
            Controls.Add(pbLeftFrame);
            Controls.Add(btnCalendar);
            FormBorderStyle = FormBorderStyle.None;
            Name = "FormAnalyse";
            Text = "FormAnalyse";
            Load += FormAnalyse_Load;
            panel1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)pbLogo).EndInit();
            ((System.ComponentModel.ISupportInitialize)pbLeftFrame).EndInit();
            ((System.ComponentModel.ISupportInitialize)chart1).EndInit();
            ((System.ComponentModel.ISupportInitialize)chart2).EndInit();
            ResumeLayout(false);
        }

        #endregion

        private MonthCalendar mcPickDate;
        private ReaLTaiizor.Controls.CyberButton btnCalendar;
        private Panel panel1;
        private ReaLTaiizor.Controls.CyberButton btnLogin;
        private ReaLTaiizor.Controls.CyberButton btnUserProfile;
        private ReaLTaiizor.Controls.CyberButton btnHome;
        private ReaLTaiizor.Controls.CyberButton btnAdminPanel;
        private ReaLTaiizor.Controls.CyberButton btnAdd;
        private ReaLTaiizor.Controls.CyberButton btnAnalyse;
        private PictureBox pbLogo;
        private PictureBox pbLeftFrame;
        private System.Windows.Forms.DataVisualization.Charting.Chart chart1;
        private System.Windows.Forms.DataVisualization.Charting.Chart chart2;
    }
}