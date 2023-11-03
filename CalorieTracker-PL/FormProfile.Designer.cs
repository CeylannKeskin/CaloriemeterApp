namespace CalorieTracker_PL
{
    partial class FormProfile
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FormProfile));
            lblFirstName = new Label();
            txtFirstName = new TextBox();
            lblLastName = new Label();
            txtLastName = new TextBox();
            lblEmail = new Label();
            txtEmail = new TextBox();
            lblCountry = new Label();
            txtCountry = new TextBox();
            label4 = new Label();
            txtCity = new TextBox();
            label5 = new Label();
            label6 = new Label();
            label1 = new Label();
            nudHeight = new NumericUpDown();
            nudWeight = new NumericUpDown();
            dtBirthDate = new DateTimePicker();
            lblCurrentPassword = new Label();
            txtCurrentPassword = new TextBox();
            lblNewPassword = new Label();
            txtEnterNewPassword = new TextBox();
            lblReEnterNewPassword = new Label();
            txtReEnterNewPassword = new TextBox();
            btnChangePassword = new Button();
            btnSaveChanges = new Button();
            btnDeleteAccount = new Button();
            pbShowHidePassword = new PictureBox();
            ((System.ComponentModel.ISupportInitialize)nudHeight).BeginInit();
            ((System.ComponentModel.ISupportInitialize)nudWeight).BeginInit();
            ((System.ComponentModel.ISupportInitialize)pbShowHidePassword).BeginInit();
            SuspendLayout();
            // 
            // lblFirstName
            // 
            lblFirstName.AutoSize = true;
            lblFirstName.Location = new Point(139, 56);
            lblFirstName.Name = "lblFirstName";
            lblFirstName.Size = new Size(67, 15);
            lblFirstName.TabIndex = 55;
            lblFirstName.Text = "First Name:";
            // 
            // txtFirstName
            // 
            txtFirstName.Location = new Point(220, 50);
            txtFirstName.Name = "txtFirstName";
            txtFirstName.Size = new Size(200, 23);
            txtFirstName.TabIndex = 1;
            // 
            // lblLastName
            // 
            lblLastName.AutoSize = true;
            lblLastName.Location = new Point(139, 90);
            lblLastName.Name = "lblLastName";
            lblLastName.Size = new Size(66, 15);
            lblLastName.TabIndex = 55;
            lblLastName.Text = "Last Name:";
            // 
            // txtLastName
            // 
            txtLastName.Location = new Point(220, 84);
            txtLastName.Name = "txtLastName";
            txtLastName.Size = new Size(200, 23);
            txtLastName.TabIndex = 2;
            // 
            // lblEmail
            // 
            lblEmail.AutoSize = true;
            lblEmail.Location = new Point(139, 124);
            lblEmail.Name = "lblEmail";
            lblEmail.Size = new Size(39, 15);
            lblEmail.TabIndex = 55;
            lblEmail.Text = "Email:";
            // 
            // txtEmail
            // 
            txtEmail.Location = new Point(220, 118);
            txtEmail.Name = "txtEmail";
            txtEmail.Size = new Size(200, 23);
            txtEmail.TabIndex = 3;
            // 
            // lblCountry
            // 
            lblCountry.AutoSize = true;
            lblCountry.Location = new Point(139, 158);
            lblCountry.Name = "lblCountry";
            lblCountry.Size = new Size(53, 15);
            lblCountry.TabIndex = 55;
            lblCountry.Text = "Country:";
            // 
            // txtCountry
            // 
            txtCountry.Location = new Point(220, 152);
            txtCountry.Name = "txtCountry";
            txtCountry.Size = new Size(200, 23);
            txtCountry.TabIndex = 4;
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Location = new Point(139, 192);
            label4.Name = "label4";
            label4.Size = new Size(31, 15);
            label4.TabIndex = 55;
            label4.Text = "City:";
            // 
            // txtCity
            // 
            txtCity.Location = new Point(220, 186);
            txtCity.Name = "txtCity";
            txtCity.Size = new Size(200, 23);
            txtCity.TabIndex = 5;
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.Location = new Point(139, 226);
            label5.Name = "label5";
            label5.Size = new Size(46, 15);
            label5.TabIndex = 55;
            label5.Text = "Height:";
            // 
            // label6
            // 
            label6.AutoSize = true;
            label6.Location = new Point(139, 260);
            label6.Name = "label6";
            label6.Size = new Size(48, 15);
            label6.TabIndex = 55;
            label6.Text = "Weight:";
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(139, 294);
            label1.Name = "label1";
            label1.Size = new Size(59, 15);
            label1.TabIndex = 55;
            label1.Text = "BirthDate:";
            // 
            // nudHeight
            // 
            nudHeight.Location = new Point(220, 221);
            nudHeight.Maximum = new decimal(new int[] { 255, 0, 0, 0 });
            nudHeight.Name = "nudHeight";
            nudHeight.Size = new Size(200, 23);
            nudHeight.TabIndex = 6;
            // 
            // nudWeight
            // 
            nudWeight.Location = new Point(220, 254);
            nudWeight.Maximum = new decimal(new int[] { 200, 0, 0, 0 });
            nudWeight.Name = "nudWeight";
            nudWeight.Size = new Size(200, 23);
            nudWeight.TabIndex = 7;
            // 
            // dtBirthDate
            // 
            dtBirthDate.Location = new Point(220, 288);
            dtBirthDate.Name = "dtBirthDate";
            dtBirthDate.Size = new Size(200, 23);
            dtBirthDate.TabIndex = 8;
            // 
            // lblCurrentPassword
            // 
            lblCurrentPassword.AutoSize = true;
            lblCurrentPassword.Location = new Point(450, 120);
            lblCurrentPassword.Name = "lblCurrentPassword";
            lblCurrentPassword.Size = new Size(103, 15);
            lblCurrentPassword.TabIndex = 55;
            lblCurrentPassword.Text = "Current Password:";
            // 
            // txtCurrentPassword
            // 
            txtCurrentPassword.Location = new Point(590, 117);
            txtCurrentPassword.Name = "txtCurrentPassword";
            txtCurrentPassword.Size = new Size(169, 23);
            txtCurrentPassword.TabIndex = 10;
            // 
            // lblNewPassword
            // 
            lblNewPassword.AutoSize = true;
            lblNewPassword.Location = new Point(450, 154);
            lblNewPassword.Name = "lblNewPassword";
            lblNewPassword.Size = new Size(117, 15);
            lblNewPassword.TabIndex = 55;
            lblNewPassword.Text = "Enter New Password:";
            // 
            // txtEnterNewPassword
            // 
            txtEnterNewPassword.Location = new Point(590, 151);
            txtEnterNewPassword.Name = "txtEnterNewPassword";
            txtEnterNewPassword.Size = new Size(200, 23);
            txtEnterNewPassword.TabIndex = 11;
            // 
            // lblReEnterNewPassword
            // 
            lblReEnterNewPassword.AutoSize = true;
            lblReEnterNewPassword.Location = new Point(450, 188);
            lblReEnterNewPassword.Name = "lblReEnterNewPassword";
            lblReEnterNewPassword.Size = new Size(135, 15);
            lblReEnterNewPassword.TabIndex = 55;
            lblReEnterNewPassword.Text = "Re-Enter New Password:";
            // 
            // txtReEnterNewPassword
            // 
            txtReEnterNewPassword.Location = new Point(590, 185);
            txtReEnterNewPassword.Name = "txtReEnterNewPassword";
            txtReEnterNewPassword.Size = new Size(200, 23);
            txtReEnterNewPassword.TabIndex = 12;
            // 
            // btnChangePassword
            // 
            btnChangePassword.Location = new Point(590, 221);
            btnChangePassword.Name = "btnChangePassword";
            btnChangePassword.Size = new Size(198, 37);
            btnChangePassword.TabIndex = 13;
            btnChangePassword.Text = "Change Password";
            btnChangePassword.UseVisualStyleBackColor = true;
            btnChangePassword.Click += btnChangePassword_Click;
            // 
            // btnSaveChanges
            // 
            btnSaveChanges.Location = new Point(220, 324);
            btnSaveChanges.Name = "btnSaveChanges";
            btnSaveChanges.Size = new Size(200, 36);
            btnSaveChanges.TabIndex = 9;
            btnSaveChanges.Text = "Save Changes";
            btnSaveChanges.UseVisualStyleBackColor = true;
            btnSaveChanges.Click += btnSaveChanges_Click;
            // 
            // btnDeleteAccount
            // 
            btnDeleteAccount.Location = new Point(588, 337);
            btnDeleteAccount.Name = "btnDeleteAccount";
            btnDeleteAccount.Size = new Size(200, 23);
            btnDeleteAccount.TabIndex = 14;
            btnDeleteAccount.Text = "Delete Account";
            btnDeleteAccount.UseVisualStyleBackColor = true;
            btnDeleteAccount.Click += btnDeleteAccount_Click;
            // 
            // pbShowHidePassword
            // 
            pbShowHidePassword.BackColor = Color.Transparent;
            pbShowHidePassword.Image = (Image)resources.GetObject("pbShowHidePassword.Image");
            pbShowHidePassword.Location = new Point(765, 117);
            pbShowHidePassword.Name = "pbShowHidePassword";
            pbShowHidePassword.Size = new Size(23, 23);
            pbShowHidePassword.SizeMode = PictureBoxSizeMode.Zoom;
            pbShowHidePassword.TabIndex = 61;
            pbShowHidePassword.TabStop = false;
            pbShowHidePassword.Click += pbShowHidePassword_Click;
            // 
            // FormProfile
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(800, 500);
            Controls.Add(pbShowHidePassword);
            Controls.Add(btnDeleteAccount);
            Controls.Add(btnSaveChanges);
            Controls.Add(btnChangePassword);
            Controls.Add(dtBirthDate);
            Controls.Add(nudWeight);
            Controls.Add(nudHeight);
            Controls.Add(label1);
            Controls.Add(label6);
            Controls.Add(label5);
            Controls.Add(txtCity);
            Controls.Add(label4);
            Controls.Add(txtCountry);
            Controls.Add(lblCountry);
            Controls.Add(txtReEnterNewPassword);
            Controls.Add(txtEmail);
            Controls.Add(lblReEnterNewPassword);
            Controls.Add(lblEmail);
            Controls.Add(txtEnterNewPassword);
            Controls.Add(lblNewPassword);
            Controls.Add(txtLastName);
            Controls.Add(txtCurrentPassword);
            Controls.Add(lblLastName);
            Controls.Add(lblCurrentPassword);
            Controls.Add(txtFirstName);
            Controls.Add(lblFirstName);
            FormBorderStyle = FormBorderStyle.None;
            Name = "FormProfile";
            Text = "FormProfile";
            Load += FormProfile_Load;
            ((System.ComponentModel.ISupportInitialize)nudHeight).EndInit();
            ((System.ComponentModel.ISupportInitialize)nudWeight).EndInit();
            ((System.ComponentModel.ISupportInitialize)pbShowHidePassword).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion
        private Label lblFirstName;
        private TextBox txtFirstName;
        private Label lblLastName;
        private TextBox txtLastName;
        private Label lblEmail;
        private TextBox txtEmail;
        private Label lblCountry;
        private TextBox txtCountry;
        private Label label4;
        private TextBox txtCity;
        private Label label5;
        private Label label6;
        private Label label1;
        private NumericUpDown nudHeight;
        private NumericUpDown nudWeight;
        private DateTimePicker dtBirthDate;
        private Label lblCurrentPassword;
        private TextBox txtCurrentPassword;
        private Label lblNewPassword;
        private TextBox txtEnterNewPassword;
        private Label lblReEnterNewPassword;
        private TextBox txtReEnterNewPassword;
        private Button btnChangePassword;
        private Button btnSaveChanges;
        private Button btnDeleteAccount;
        private PictureBox pbShowHidePassword;
    }
}