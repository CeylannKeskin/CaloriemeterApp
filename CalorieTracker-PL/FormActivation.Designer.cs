namespace CalorieTracker_PL
{
    partial class FormActivation
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
            btnActivationCode = new Button();
            lblActivationCode = new Label();
            txtActivationCode = new TextBox();
            lblApplicatonName = new Label();
            pbLogo = new PictureBox();
            foreverClose1 = new ReaLTaiizor.Controls.ForeverClose();
            foreverMinimize1 = new ReaLTaiizor.Controls.ForeverMinimize();
            ((System.ComponentModel.ISupportInitialize)pbLogo).BeginInit();
            SuspendLayout();
            // 
            // btnActivationCode
            // 
            btnActivationCode.Location = new Point(192, 234);
            btnActivationCode.Name = "btnActivationCode";
            btnActivationCode.Size = new Size(142, 33);
            btnActivationCode.TabIndex = 0;
            btnActivationCode.Text = "Enter Activation Code";
            btnActivationCode.UseVisualStyleBackColor = true;
            btnActivationCode.Click += btnActivationCode_Click;
            // 
            // lblActivationCode
            // 
            lblActivationCode.AutoSize = true;
            lblActivationCode.Location = new Point(69, 207);
            lblActivationCode.Name = "lblActivationCode";
            lblActivationCode.Size = new Size(95, 15);
            lblActivationCode.TabIndex = 1;
            lblActivationCode.Text = "Activation Code:";
            // 
            // txtActivationCode
            // 
            txtActivationCode.Location = new Point(192, 204);
            txtActivationCode.Name = "txtActivationCode";
            txtActivationCode.Size = new Size(142, 23);
            txtActivationCode.TabIndex = 2;
            // 
            // lblApplicatonName
            // 
            lblApplicatonName.Anchor = AnchorStyles.Top | AnchorStyles.Bottom | AnchorStyles.Left | AnchorStyles.Right;
            lblApplicatonName.AutoSize = true;
            lblApplicatonName.BackColor = Color.Transparent;
            lblApplicatonName.Font = new Font("Segoe UI Semibold", 14.25F, FontStyle.Bold, GraphicsUnit.Point);
            lblApplicatonName.Location = new Point(131, 142);
            lblApplicatonName.Name = "lblApplicatonName";
            lblApplicatonName.Size = new Size(138, 25);
            lblApplicatonName.TabIndex = 33;
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
            pbLogo.TabIndex = 36;
            pbLogo.TabStop = false;
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
            foreverClose1.TabIndex = 35;
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
            foreverMinimize1.TabIndex = 34;
            foreverMinimize1.Text = "foreverMinimize1";
            foreverMinimize1.TextColor = Color.FromArgb(243, 243, 243);
            // 
            // FormActivation
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(412, 495);
            Controls.Add(pbLogo);
            Controls.Add(foreverClose1);
            Controls.Add(foreverMinimize1);
            Controls.Add(lblApplicatonName);
            Controls.Add(txtActivationCode);
            Controls.Add(lblActivationCode);
            Controls.Add(btnActivationCode);
            FormBorderStyle = FormBorderStyle.None;
            Name = "FormActivation";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "ActivationForm";
            Load += FormActivation_Load;
            ((System.ComponentModel.ISupportInitialize)pbLogo).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Button btnActivationCode;
        private Label lblActivationCode;
        private TextBox txtActivationCode;
        private Label lblApplicatonName;
        private PictureBox pbLogo;
        private ReaLTaiizor.Controls.ForeverClose foreverClose1;
        private ReaLTaiizor.Controls.ForeverMinimize foreverMinimize1;
    }
}