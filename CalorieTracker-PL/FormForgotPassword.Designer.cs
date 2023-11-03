namespace CalorieTracker_PL
{
    partial class FormForgotPassword
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
            lblEmail = new Label();
            foreverClose1 = new ReaLTaiizor.Controls.ForeverClose();
            foreverMinimize1 = new ReaLTaiizor.Controls.ForeverMinimize();
            pbEmail = new PictureBox();
            txtEmail = new TextBox();
            btnSendPassword = new Button();
            lblApplicatonName = new Label();
            pbLogo = new PictureBox();
            ((System.ComponentModel.ISupportInitialize)pbEmail).BeginInit();
            ((System.ComponentModel.ISupportInitialize)pbLogo).BeginInit();
            SuspendLayout();
            // 
            // lblEmail
            // 
            lblEmail.AutoSize = true;
            lblEmail.Location = new Point(42, 249);
            lblEmail.Name = "lblEmail";
            lblEmail.Size = new Size(39, 15);
            lblEmail.TabIndex = 0;
            lblEmail.Text = "Email:";
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
            foreverClose1.TabIndex = 22;
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
            foreverMinimize1.TabIndex = 21;
            foreverMinimize1.Text = "foreverMinimize1";
            foreverMinimize1.TextColor = Color.FromArgb(243, 243, 243);
            // 
            // pbEmail
            // 
            pbEmail.BackColor = Color.Transparent;
            pbEmail.Image = Properties.Resources.email;
            pbEmail.Location = new Point(110, 246);
            pbEmail.Name = "pbEmail";
            pbEmail.Size = new Size(23, 23);
            pbEmail.SizeMode = PictureBoxSizeMode.Zoom;
            pbEmail.TabIndex = 20;
            pbEmail.TabStop = false;
            // 
            // txtEmail
            // 
            txtEmail.Location = new Point(139, 246);
            txtEmail.Name = "txtEmail";
            txtEmail.Size = new Size(194, 23);
            txtEmail.TabIndex = 19;
            // 
            // btnSendPassword
            // 
            btnSendPassword.Location = new Point(110, 288);
            btnSendPassword.Name = "btnSendPassword";
            btnSendPassword.Size = new Size(223, 28);
            btnSendPassword.TabIndex = 23;
            btnSendPassword.Text = "Send Password";
            btnSendPassword.UseVisualStyleBackColor = true;
            btnSendPassword.Click += btnSendPassword_Click;
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
            lblApplicatonName.TabIndex = 32;
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
            pbLogo.TabIndex = 31;
            pbLogo.TabStop = false;
            // 
            // FormForgotPassword
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(412, 495);
            Controls.Add(lblApplicatonName);
            Controls.Add(pbLogo);
            Controls.Add(btnSendPassword);
            Controls.Add(foreverClose1);
            Controls.Add(foreverMinimize1);
            Controls.Add(pbEmail);
            Controls.Add(txtEmail);
            Controls.Add(lblEmail);
            FormBorderStyle = FormBorderStyle.None;
            Name = "FormForgotPassword";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "FormForgotPassword";
            Load += FormForgotPassword_Load;
            ((System.ComponentModel.ISupportInitialize)pbEmail).EndInit();
            ((System.ComponentModel.ISupportInitialize)pbLogo).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label lblEmail;
        private ReaLTaiizor.Controls.ForeverClose foreverClose1;
        private ReaLTaiizor.Controls.ForeverMinimize foreverMinimize1;
        private PictureBox pbEmail;
        private TextBox txtEmail;
        private Button btnSendPassword;
        private Label lblApplicatonName;
        private PictureBox pbLogo;
    }
}