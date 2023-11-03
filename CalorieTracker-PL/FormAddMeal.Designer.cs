namespace CalorieTracker_PL
{
    partial class FormAddMeal
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
            numAmount = new NumericUpDown();
            txtFat = new TextBox();
            txtCarb = new TextBox();
            txtProtein = new TextBox();
            txtCalorie = new TextBox();
            txtCategoryName = new TextBox();
            dgvFoodList = new DataGridView();
            txtSearch = new TextBox();
            rdoSnacks = new RadioButton();
            rdoDinner = new RadioButton();
            rdoLunch = new RadioButton();
            rdoBreakfast = new RadioButton();
            btnAdd = new ReaLTaiizor.Controls.CyberButton();
            btnUpdate = new ReaLTaiizor.Controls.CyberButton();
            btnDelete = new ReaLTaiizor.Controls.CyberButton();
            btnList = new ReaLTaiizor.Controls.CyberButton();
            btnSearch = new ReaLTaiizor.Controls.CyberButton();
            btnUserFoods = new ReaLTaiizor.Controls.CyberButton();
            lblFoodList = new Label();
            lblUserFoodInfo = new Label();
            lblBreakfast = new Label();
            lblLunch = new Label();
            lblDinner = new Label();
            lblSnacks = new Label();
            txtUserFoodID = new TextBox();
            txtFoodName = new TextBox();
            ((System.ComponentModel.ISupportInitialize)numAmount).BeginInit();
            ((System.ComponentModel.ISupportInitialize)dgvFoodList).BeginInit();
            SuspendLayout();
            // 
            // numAmount
            // 
            numAmount.Location = new Point(732, 126);
            numAmount.Name = "numAmount";
            numAmount.Size = new Size(50, 23);
            numAmount.TabIndex = 31;
            numAmount.TextAlign = HorizontalAlignment.Center;
            numAmount.Value = new decimal(new int[] { 1, 0, 0, 0 });
            // 
            // txtFat
            // 
            txtFat.Location = new Point(680, 93);
            txtFat.Name = "txtFat";
            txtFat.Size = new Size(34, 23);
            txtFat.TabIndex = 30;
            // 
            // txtCarb
            // 
            txtCarb.Location = new Point(640, 93);
            txtCarb.Name = "txtCarb";
            txtCarb.Size = new Size(34, 23);
            txtCarb.TabIndex = 29;
            // 
            // txtProtein
            // 
            txtProtein.Location = new Point(600, 93);
            txtProtein.Name = "txtProtein";
            txtProtein.Size = new Size(34, 23);
            txtProtein.TabIndex = 28;
            // 
            // txtCalorie
            // 
            txtCalorie.Location = new Point(560, 93);
            txtCalorie.Name = "txtCalorie";
            txtCalorie.Size = new Size(34, 23);
            txtCalorie.TabIndex = 27;
            // 
            // txtCategoryName
            // 
            txtCategoryName.Location = new Point(379, 93);
            txtCategoryName.Name = "txtCategoryName";
            txtCategoryName.Size = new Size(175, 23);
            txtCategoryName.TabIndex = 26;
            // 
            // dgvFoodList
            // 
            dgvFoodList.BackgroundColor = Color.White;
            dgvFoodList.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dgvFoodList.Location = new Point(140, 126);
            dgvFoodList.Name = "dgvFoodList";
            dgvFoodList.RowTemplate.Height = 25;
            dgvFoodList.SelectionMode = DataGridViewSelectionMode.FullRowSelect;
            dgvFoodList.Size = new Size(576, 251);
            dgvFoodList.TabIndex = 19;
            dgvFoodList.CellMouseClick += dataGridView1_CellMouseClick;
            // 
            // txtSearch
            // 
            txtSearch.Location = new Point(614, 63);
            txtSearch.Name = "txtSearch";
            txtSearch.Size = new Size(100, 23);
            txtSearch.TabIndex = 17;
            // 
            // rdoSnacks
            // 
            rdoSnacks.BackgroundImage = Properties.Resources.burger;
            rdoSnacks.BackgroundImageLayout = ImageLayout.Zoom;
            rdoSnacks.CheckAlign = ContentAlignment.MiddleCenter;
            rdoSnacks.Location = new Point(544, 7);
            rdoSnacks.Name = "rdoSnacks";
            rdoSnacks.Size = new Size(50, 50);
            rdoSnacks.TabIndex = 36;
            rdoSnacks.TabStop = true;
            rdoSnacks.UseVisualStyleBackColor = true;
            // 
            // rdoDinner
            // 
            rdoDinner.BackgroundImage = Properties.Resources.sunset;
            rdoDinner.BackgroundImageLayout = ImageLayout.Zoom;
            rdoDinner.CheckAlign = ContentAlignment.MiddleCenter;
            rdoDinner.Location = new Point(474, 7);
            rdoDinner.Name = "rdoDinner";
            rdoDinner.Size = new Size(50, 50);
            rdoDinner.TabIndex = 36;
            rdoDinner.TabStop = true;
            rdoDinner.UseVisualStyleBackColor = true;
            // 
            // rdoLunch
            // 
            rdoLunch.BackgroundImage = Properties.Resources.beach;
            rdoLunch.BackgroundImageLayout = ImageLayout.Zoom;
            rdoLunch.CheckAlign = ContentAlignment.MiddleCenter;
            rdoLunch.Location = new Point(404, 7);
            rdoLunch.Name = "rdoLunch";
            rdoLunch.Size = new Size(50, 50);
            rdoLunch.TabIndex = 36;
            rdoLunch.TabStop = true;
            rdoLunch.UseVisualStyleBackColor = true;
            // 
            // rdoBreakfast
            // 
            rdoBreakfast.BackgroundImage = Properties.Resources.sunrise;
            rdoBreakfast.BackgroundImageLayout = ImageLayout.Zoom;
            rdoBreakfast.CheckAlign = ContentAlignment.MiddleCenter;
            rdoBreakfast.Location = new Point(334, 7);
            rdoBreakfast.Name = "rdoBreakfast";
            rdoBreakfast.Size = new Size(50, 50);
            rdoBreakfast.TabIndex = 36;
            rdoBreakfast.TabStop = true;
            rdoBreakfast.UseVisualStyleBackColor = true;
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
            btnAdd.Location = new Point(732, 155);
            btnAdd.Name = "btnAdd";
            btnAdd.PenWidth = 15;
            btnAdd.Rounding = true;
            btnAdd.RoundingInt = 90;
            btnAdd.Size = new Size(50, 50);
            btnAdd.SmoothingMode = System.Drawing.Drawing2D.SmoothingMode.HighQuality;
            btnAdd.TabIndex = 67;
            btnAdd.Tag = "Cyber";
            btnAdd.TextButton = "";
            btnAdd.TextRenderingHint = System.Drawing.Text.TextRenderingHint.ClearTypeGridFit;
            btnAdd.Timer_Effect_1 = 5;
            btnAdd.Timer_RGB = 300;
            btnAdd.Click += btnAddNewMeal_Click;
            // 
            // btnUpdate
            // 
            btnUpdate.Alpha = 20;
            btnUpdate.BackColor = Color.Transparent;
            btnUpdate.Background = true;
            btnUpdate.Background_WidthPen = 4F;
            btnUpdate.BackgroundImage = Properties.Resources.refresh;
            btnUpdate.BackgroundImageLayout = ImageLayout.Zoom;
            btnUpdate.BackgroundPen = false;
            btnUpdate.ColorBackground = Color.Transparent;
            btnUpdate.ColorBackground_1 = Color.FromArgb(37, 52, 68);
            btnUpdate.ColorBackground_2 = Color.FromArgb(41, 63, 86);
            btnUpdate.ColorBackground_Pen = Color.FromArgb(29, 200, 238);
            btnUpdate.ColorLighting = Color.FromArgb(29, 200, 238);
            btnUpdate.ColorPen_1 = Color.FromArgb(37, 52, 68);
            btnUpdate.ColorPen_2 = Color.FromArgb(41, 63, 86);
            btnUpdate.CyberButtonStyle = ReaLTaiizor.Enum.Cyber.StateStyle.Custom;
            btnUpdate.Effect_1 = true;
            btnUpdate.Effect_1_ColorBackground = Color.FromArgb(29, 200, 238);
            btnUpdate.Effect_1_Transparency = 25;
            btnUpdate.Effect_2 = true;
            btnUpdate.Effect_2_ColorBackground = Color.White;
            btnUpdate.Effect_2_Transparency = 20;
            btnUpdate.Font = new Font("Arial", 11F, FontStyle.Regular, GraphicsUnit.Point);
            btnUpdate.ForeColor = Color.FromArgb(245, 245, 245);
            btnUpdate.Lighting = false;
            btnUpdate.LinearGradient_Background = false;
            btnUpdate.LinearGradientPen = false;
            btnUpdate.Location = new Point(732, 239);
            btnUpdate.Name = "btnUpdate";
            btnUpdate.PenWidth = 15;
            btnUpdate.Rounding = true;
            btnUpdate.RoundingInt = 90;
            btnUpdate.Size = new Size(50, 50);
            btnUpdate.SmoothingMode = System.Drawing.Drawing2D.SmoothingMode.HighQuality;
            btnUpdate.TabIndex = 67;
            btnUpdate.Tag = "Cyber";
            btnUpdate.TextButton = "";
            btnUpdate.TextRenderingHint = System.Drawing.Text.TextRenderingHint.ClearTypeGridFit;
            btnUpdate.Timer_Effect_1 = 5;
            btnUpdate.Timer_RGB = 300;
            btnUpdate.Click += btnUpdate_Click;
            // 
            // btnDelete
            // 
            btnDelete.Alpha = 20;
            btnDelete.BackColor = Color.Transparent;
            btnDelete.Background = true;
            btnDelete.Background_WidthPen = 4F;
            btnDelete.BackgroundImage = Properties.Resources.minus;
            btnDelete.BackgroundImageLayout = ImageLayout.Zoom;
            btnDelete.BackgroundPen = false;
            btnDelete.ColorBackground = Color.Transparent;
            btnDelete.ColorBackground_1 = Color.FromArgb(37, 52, 68);
            btnDelete.ColorBackground_2 = Color.FromArgb(41, 63, 86);
            btnDelete.ColorBackground_Pen = Color.FromArgb(29, 200, 238);
            btnDelete.ColorLighting = Color.FromArgb(29, 200, 238);
            btnDelete.ColorPen_1 = Color.FromArgb(37, 52, 68);
            btnDelete.ColorPen_2 = Color.FromArgb(41, 63, 86);
            btnDelete.CyberButtonStyle = ReaLTaiizor.Enum.Cyber.StateStyle.Custom;
            btnDelete.Effect_1 = true;
            btnDelete.Effect_1_ColorBackground = Color.FromArgb(29, 200, 238);
            btnDelete.Effect_1_Transparency = 25;
            btnDelete.Effect_2 = true;
            btnDelete.Effect_2_ColorBackground = Color.White;
            btnDelete.Effect_2_Transparency = 20;
            btnDelete.Font = new Font("Arial", 11F, FontStyle.Regular, GraphicsUnit.Point);
            btnDelete.ForeColor = Color.FromArgb(245, 245, 245);
            btnDelete.Lighting = false;
            btnDelete.LinearGradient_Background = false;
            btnDelete.LinearGradientPen = false;
            btnDelete.Location = new Point(732, 327);
            btnDelete.Name = "btnDelete";
            btnDelete.PenWidth = 15;
            btnDelete.Rounding = true;
            btnDelete.RoundingInt = 90;
            btnDelete.Size = new Size(50, 50);
            btnDelete.SmoothingMode = System.Drawing.Drawing2D.SmoothingMode.HighQuality;
            btnDelete.TabIndex = 67;
            btnDelete.Tag = "Cyber";
            btnDelete.TextButton = "";
            btnDelete.TextRenderingHint = System.Drawing.Text.TextRenderingHint.ClearTypeGridFit;
            btnDelete.Timer_Effect_1 = 5;
            btnDelete.Timer_RGB = 300;
            btnDelete.Click += btnDelete_Click;
            // 
            // btnList
            // 
            btnList.Alpha = 20;
            btnList.BackColor = Color.Transparent;
            btnList.Background = true;
            btnList.Background_WidthPen = 4F;
            btnList.BackgroundImage = Properties.Resources.clipboard;
            btnList.BackgroundImageLayout = ImageLayout.Zoom;
            btnList.BackgroundPen = false;
            btnList.ColorBackground = Color.Transparent;
            btnList.ColorBackground_1 = Color.FromArgb(37, 52, 68);
            btnList.ColorBackground_2 = Color.FromArgb(41, 63, 86);
            btnList.ColorBackground_Pen = Color.FromArgb(29, 200, 238);
            btnList.ColorLighting = Color.FromArgb(29, 200, 238);
            btnList.ColorPen_1 = Color.FromArgb(37, 52, 68);
            btnList.ColorPen_2 = Color.FromArgb(41, 63, 86);
            btnList.CyberButtonStyle = ReaLTaiizor.Enum.Cyber.StateStyle.Custom;
            btnList.Effect_1 = true;
            btnList.Effect_1_ColorBackground = Color.FromArgb(29, 200, 238);
            btnList.Effect_1_Transparency = 25;
            btnList.Effect_2 = true;
            btnList.Effect_2_ColorBackground = Color.White;
            btnList.Effect_2_Transparency = 20;
            btnList.Font = new Font("Arial", 11F, FontStyle.Regular, GraphicsUnit.Point);
            btnList.ForeColor = Color.FromArgb(245, 245, 245);
            btnList.Lighting = false;
            btnList.LinearGradient_Background = false;
            btnList.LinearGradientPen = false;
            btnList.Location = new Point(140, 7);
            btnList.Name = "btnList";
            btnList.PenWidth = 15;
            btnList.Rounding = true;
            btnList.RoundingInt = 90;
            btnList.Size = new Size(50, 50);
            btnList.SmoothingMode = System.Drawing.Drawing2D.SmoothingMode.HighQuality;
            btnList.TabIndex = 67;
            btnList.Tag = "Cyber";
            btnList.TextButton = "";
            btnList.TextRenderingHint = System.Drawing.Text.TextRenderingHint.ClearTypeGridFit;
            btnList.Timer_Effect_1 = 5;
            btnList.Timer_RGB = 300;
            btnList.Click += btnList_Click;
            // 
            // btnSearch
            // 
            btnSearch.Alpha = 20;
            btnSearch.BackColor = Color.Transparent;
            btnSearch.Background = true;
            btnSearch.Background_WidthPen = 4F;
            btnSearch.BackgroundImage = Properties.Resources.search;
            btnSearch.BackgroundImageLayout = ImageLayout.Zoom;
            btnSearch.BackgroundPen = false;
            btnSearch.ColorBackground = Color.Transparent;
            btnSearch.ColorBackground_1 = Color.FromArgb(37, 52, 68);
            btnSearch.ColorBackground_2 = Color.FromArgb(41, 63, 86);
            btnSearch.ColorBackground_Pen = Color.FromArgb(29, 200, 238);
            btnSearch.ColorLighting = Color.FromArgb(29, 200, 238);
            btnSearch.ColorPen_1 = Color.FromArgb(37, 52, 68);
            btnSearch.ColorPen_2 = Color.FromArgb(41, 63, 86);
            btnSearch.CyberButtonStyle = ReaLTaiizor.Enum.Cyber.StateStyle.Custom;
            btnSearch.Effect_1 = true;
            btnSearch.Effect_1_ColorBackground = Color.FromArgb(29, 200, 238);
            btnSearch.Effect_1_Transparency = 25;
            btnSearch.Effect_2 = true;
            btnSearch.Effect_2_ColorBackground = Color.White;
            btnSearch.Effect_2_Transparency = 20;
            btnSearch.Font = new Font("Arial", 11F, FontStyle.Regular, GraphicsUnit.Point);
            btnSearch.ForeColor = Color.FromArgb(245, 245, 245);
            btnSearch.Lighting = false;
            btnSearch.LinearGradient_Background = false;
            btnSearch.LinearGradientPen = false;
            btnSearch.Location = new Point(640, 7);
            btnSearch.Name = "btnSearch";
            btnSearch.PenWidth = 15;
            btnSearch.Rounding = true;
            btnSearch.RoundingInt = 90;
            btnSearch.Size = new Size(50, 50);
            btnSearch.SmoothingMode = System.Drawing.Drawing2D.SmoothingMode.HighQuality;
            btnSearch.TabIndex = 67;
            btnSearch.Tag = "Cyber";
            btnSearch.TextButton = "";
            btnSearch.TextRenderingHint = System.Drawing.Text.TextRenderingHint.ClearTypeGridFit;
            btnSearch.Timer_Effect_1 = 5;
            btnSearch.Timer_RGB = 300;
            btnSearch.Click += btnSearch_Click;
            // 
            // btnUserFoods
            // 
            btnUserFoods.Alpha = 20;
            btnUserFoods.BackColor = Color.Transparent;
            btnUserFoods.Background = true;
            btnUserFoods.Background_WidthPen = 4F;
            btnUserFoods.BackgroundImage = Properties.Resources.barcode;
            btnUserFoods.BackgroundImageLayout = ImageLayout.Zoom;
            btnUserFoods.BackgroundPen = false;
            btnUserFoods.ColorBackground = Color.Transparent;
            btnUserFoods.ColorBackground_1 = Color.FromArgb(37, 52, 68);
            btnUserFoods.ColorBackground_2 = Color.FromArgb(41, 63, 86);
            btnUserFoods.ColorBackground_Pen = Color.FromArgb(29, 200, 238);
            btnUserFoods.ColorLighting = Color.FromArgb(29, 200, 238);
            btnUserFoods.ColorPen_1 = Color.FromArgb(37, 52, 68);
            btnUserFoods.ColorPen_2 = Color.FromArgb(41, 63, 86);
            btnUserFoods.CyberButtonStyle = ReaLTaiizor.Enum.Cyber.StateStyle.Custom;
            btnUserFoods.Effect_1 = true;
            btnUserFoods.Effect_1_ColorBackground = Color.FromArgb(29, 200, 238);
            btnUserFoods.Effect_1_Transparency = 25;
            btnUserFoods.Effect_2 = true;
            btnUserFoods.Effect_2_ColorBackground = Color.White;
            btnUserFoods.Effect_2_Transparency = 20;
            btnUserFoods.Font = new Font("Arial", 11F, FontStyle.Regular, GraphicsUnit.Point);
            btnUserFoods.ForeColor = Color.FromArgb(245, 245, 245);
            btnUserFoods.Lighting = false;
            btnUserFoods.LinearGradient_Background = false;
            btnUserFoods.LinearGradientPen = false;
            btnUserFoods.Location = new Point(226, 7);
            btnUserFoods.Name = "btnUserFoods";
            btnUserFoods.PenWidth = 15;
            btnUserFoods.Rounding = true;
            btnUserFoods.RoundingInt = 90;
            btnUserFoods.Size = new Size(50, 50);
            btnUserFoods.SmoothingMode = System.Drawing.Drawing2D.SmoothingMode.HighQuality;
            btnUserFoods.TabIndex = 67;
            btnUserFoods.Tag = "Cyber";
            btnUserFoods.TextButton = "";
            btnUserFoods.TextRenderingHint = System.Drawing.Text.TextRenderingHint.ClearTypeGridFit;
            btnUserFoods.Timer_Effect_1 = 5;
            btnUserFoods.Timer_RGB = 300;
            btnUserFoods.Click += btnUserFoods_Click;
            // 
            // lblFoodList
            // 
            lblFoodList.AutoSize = true;
            lblFoodList.Location = new Point(137, 63);
            lblFoodList.Name = "lblFoodList";
            lblFoodList.Size = new Size(55, 15);
            lblFoodList.TabIndex = 68;
            lblFoodList.Text = "Food List";
            // 
            // lblUserFoodInfo
            // 
            lblUserFoodInfo.AutoSize = true;
            lblUserFoodInfo.Location = new Point(207, 63);
            lblUserFoodInfo.Name = "lblUserFoodInfo";
            lblUserFoodInfo.Size = new Size(86, 15);
            lblUserFoodInfo.TabIndex = 69;
            lblUserFoodInfo.Text = "Get User Foods";
            // 
            // lblBreakfast
            // 
            lblBreakfast.AutoSize = true;
            lblBreakfast.Location = new Point(329, 63);
            lblBreakfast.Name = "lblBreakfast";
            lblBreakfast.Size = new Size(55, 15);
            lblBreakfast.TabIndex = 68;
            lblBreakfast.Text = "Breakfast";
            // 
            // lblLunch
            // 
            lblLunch.AutoSize = true;
            lblLunch.Location = new Point(409, 63);
            lblLunch.Name = "lblLunch";
            lblLunch.Size = new Size(40, 15);
            lblLunch.TabIndex = 68;
            lblLunch.Text = "Lunch";
            // 
            // lblDinner
            // 
            lblDinner.AutoSize = true;
            lblDinner.Location = new Point(476, 63);
            lblDinner.Name = "lblDinner";
            lblDinner.Size = new Size(42, 15);
            lblDinner.TabIndex = 68;
            lblDinner.Text = "Dinner";
            // 
            // lblSnacks
            // 
            lblSnacks.AutoSize = true;
            lblSnacks.Location = new Point(549, 63);
            lblSnacks.Name = "lblSnacks";
            lblSnacks.Size = new Size(43, 15);
            lblSnacks.TabIndex = 68;
            lblSnacks.Text = "Snacks";
            // 
            // txtUserFoodID
            // 
            txtUserFoodID.Location = new Point(140, 93);
            txtUserFoodID.Name = "txtUserFoodID";
            txtUserFoodID.Size = new Size(74, 23);
            txtUserFoodID.TabIndex = 27;
            // 
            // txtFoodName
            // 
            txtFoodName.Location = new Point(220, 93);
            txtFoodName.Name = "txtFoodName";
            txtFoodName.Size = new Size(153, 23);
            txtFoodName.TabIndex = 25;
            // 
            // FormAddMeal
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(800, 500);
            Controls.Add(lblUserFoodInfo);
            Controls.Add(lblSnacks);
            Controls.Add(lblDinner);
            Controls.Add(lblLunch);
            Controls.Add(lblBreakfast);
            Controls.Add(lblFoodList);
            Controls.Add(btnDelete);
            Controls.Add(btnUpdate);
            Controls.Add(btnSearch);
            Controls.Add(btnUserFoods);
            Controls.Add(btnList);
            Controls.Add(btnAdd);
            Controls.Add(rdoBreakfast);
            Controls.Add(rdoLunch);
            Controls.Add(rdoDinner);
            Controls.Add(rdoSnacks);
            Controls.Add(numAmount);
            Controls.Add(txtFat);
            Controls.Add(txtCarb);
            Controls.Add(txtProtein);
            Controls.Add(txtUserFoodID);
            Controls.Add(txtCalorie);
            Controls.Add(txtCategoryName);
            Controls.Add(txtFoodName);
            Controls.Add(dgvFoodList);
            Controls.Add(txtSearch);
            FormBorderStyle = FormBorderStyle.None;
            Name = "FormAddMeal";
            Text = "FormAddMeal";
            Load += FormAddMeal_Load;
            ((System.ComponentModel.ISupportInitialize)numAmount).EndInit();
            ((System.ComponentModel.ISupportInitialize)dgvFoodList).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion
        private NumericUpDown numAmount;
        private TextBox txtFat;
        private TextBox txtCarb;
        private TextBox txtProtein;
        private TextBox txtCalorie;
        private TextBox txtCategoryName;
        private DataGridView dgvFoodList;
        private TextBox txtSearch;
        private RadioButton rdoSnacks;
        private RadioButton rdoDinner;
        private RadioButton rdoLunch;
        private RadioButton rdoBreakfast;
        private ReaLTaiizor.Controls.CyberButton btnAdd;
        private ReaLTaiizor.Controls.CyberButton btnUpdate;
        private ReaLTaiizor.Controls.CyberButton btnDelete;
        private ReaLTaiizor.Controls.CyberButton btnList;
        private ReaLTaiizor.Controls.CyberButton btnSearch;
        private ReaLTaiizor.Controls.CyberButton btnUserFoods;
        private Label lblFoodList;
        private Label lblUserFoodInfo;
        private Label lblBreakfast;
        private Label lblLunch;
        private Label lblDinner;
        private Label lblSnacks;
        private TextBox txtUserFoodID;
        private TextBox txtFoodName;
    }
}