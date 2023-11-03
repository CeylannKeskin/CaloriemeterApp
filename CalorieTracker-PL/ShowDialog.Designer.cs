namespace CalorieTracker_PL
{
    partial class ShowDialog
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
            components = new System.ComponentModel.Container();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(ShowDialog));
            tmrShowDialog = new System.Windows.Forms.Timer(components);
            lblDialogText = new Label();
            lblTopBorder = new Label();
            lblBottomBorder = new Label();
            lblRightBorder = new Label();
            lblLeftBorder = new Label();
            SuspendLayout();
            // 
            // tmrShowDialog
            // 
            tmrShowDialog.Interval = 1000;
            tmrShowDialog.Tick += tmrShowDialog_Tick;
            // 
            // lblDialogText
            // 
            lblDialogText.Dock = DockStyle.Fill;
            lblDialogText.Location = new Point(0, 0);
            lblDialogText.Name = "lblDialogText";
            lblDialogText.Size = new Size(283, 146);
            lblDialogText.TabIndex = 0;
            lblDialogText.TextAlign = ContentAlignment.MiddleCenter;
            // 
            // lblTopBorder
            // 
            lblTopBorder.BackColor = Color.FromArgb(51, 215, 255);
            lblTopBorder.Location = new Point(0, -5);
            lblTopBorder.Name = "lblTopBorder";
            lblTopBorder.Size = new Size(283, 10);
            lblTopBorder.TabIndex = 1;
            // 
            // lblBottomBorder
            // 
            lblBottomBorder.BackColor = Color.FromArgb(51, 215, 255);
            lblBottomBorder.Location = new Point(0, 141);
            lblBottomBorder.Name = "lblBottomBorder";
            lblBottomBorder.Size = new Size(283, 10);
            lblBottomBorder.TabIndex = 1;
            // 
            // lblRightBorder
            // 
            lblRightBorder.BackColor = Color.FromArgb(51, 215, 255);
            lblRightBorder.Location = new Point(278, 0);
            lblRightBorder.Name = "lblRightBorder";
            lblRightBorder.Size = new Size(10, 146);
            lblRightBorder.TabIndex = 1;
            // 
            // lblLeftBorder
            // 
            lblLeftBorder.BackColor = Color.FromArgb(51, 215, 255);
            lblLeftBorder.Location = new Point(-5, 0);
            lblLeftBorder.Name = "lblLeftBorder";
            lblLeftBorder.Size = new Size(10, 146);
            lblLeftBorder.TabIndex = 1;
            // 
            // ShowDialog
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(283, 146);
            Controls.Add(lblLeftBorder);
            Controls.Add(lblRightBorder);
            Controls.Add(lblBottomBorder);
            Controls.Add(lblTopBorder);
            Controls.Add(lblDialogText);
            FormBorderStyle = FormBorderStyle.None;
            Icon = (Icon)resources.GetObject("$this.Icon");
            Name = "ShowDialog";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "ShowDialog";
            Load += ShowDialog_Load;
            ResumeLayout(false);
        }

        #endregion

        private System.Windows.Forms.Timer tmrShowDialog;
        private Label lblDialogText;
        private Label lblTopBorder;
        private Label lblBottomBorder;
        private Label lblRightBorder;
        private Label lblLeftBorder;
    }
}