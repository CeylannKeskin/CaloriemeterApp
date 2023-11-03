namespace CalorieTracker_PL
{
    partial class FormCalculations
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
            btnBasalMetabolism = new ReaLTaiizor.Controls.CyberButton();
            btnCalculateNutritions = new ReaLTaiizor.Controls.CyberButton();
            btnCalculateIdealWeight = new ReaLTaiizor.Controls.CyberButton();
            label1 = new Label();
            lblFat = new Label();
            lblCarbonhydrate = new Label();
            lblProtein = new Label();
            lblCalorie = new Label();
            txtFat = new TextBox();
            txtCarbohydrate = new TextBox();
            txtProtein = new TextBox();
            txtCalorie = new TextBox();
            lstFoodList = new ListView();
            columnHeader1 = new ColumnHeader();
            columnHeader2 = new ColumnHeader();
            columnHeader3 = new ColumnHeader();
            columnHeader4 = new ColumnHeader();
            columnHeader5 = new ColumnHeader();
            txtWeightInformation = new TextBox();
            cmbFoods = new ComboBox();
            pnlNutritionCalculator = new Panel();
            lblSearchFoodName = new Label();
            pnlCalculateIdealWeight = new Panel();
            nudHeight = new NumericUpDown();
            nudAge = new NumericUpDown();
            rdoFemale = new RadioButton();
            rdoMale = new RadioButton();
            pbFemale = new PictureBox();
            pbMale = new PictureBox();
            lblYourIdealWeight = new Label();
            lblKg = new Label();
            lblWeight = new Label();
            lblAge = new Label();
            lblHeight = new Label();
            lblGender = new Label();
            btnCalculate = new Button();
            pnlBasalMetabolism = new Panel();
            btnBMCalculate = new Button();
            nudBMHeight = new NumericUpDown();
            nudBMWeight = new NumericUpDown();
            rdoBMFemale = new RadioButton();
            rdoBMMale = new RadioButton();
            pbBMFemale = new PictureBox();
            pbBMMale = new PictureBox();
            lblResult = new Label();
            lblDailyCalories = new Label();
            cmbActivity = new ComboBox();
            lblBMActivity = new Label();
            txtAge = new TextBox();
            lblBMHeight = new Label();
            lblBMWeight = new Label();
            lblBMAge = new Label();
            lblBMGender = new Label();
            pnlNutritionCalculator.SuspendLayout();
            pnlCalculateIdealWeight.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)nudHeight).BeginInit();
            ((System.ComponentModel.ISupportInitialize)nudAge).BeginInit();
            ((System.ComponentModel.ISupportInitialize)pbFemale).BeginInit();
            ((System.ComponentModel.ISupportInitialize)pbMale).BeginInit();
            pnlBasalMetabolism.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)nudBMHeight).BeginInit();
            ((System.ComponentModel.ISupportInitialize)nudBMWeight).BeginInit();
            ((System.ComponentModel.ISupportInitialize)pbBMFemale).BeginInit();
            ((System.ComponentModel.ISupportInitialize)pbBMMale).BeginInit();
            SuspendLayout();
            // 
            // btnBasalMetabolism
            // 
            btnBasalMetabolism.Alpha = 20;
            btnBasalMetabolism.BackColor = Color.Transparent;
            btnBasalMetabolism.Background = true;
            btnBasalMetabolism.Background_WidthPen = 4F;
            btnBasalMetabolism.BackgroundImage = Properties.Resources.metabolism;
            btnBasalMetabolism.BackgroundImageLayout = ImageLayout.Zoom;
            btnBasalMetabolism.BackgroundPen = false;
            btnBasalMetabolism.ColorBackground = Color.Transparent;
            btnBasalMetabolism.ColorBackground_1 = Color.FromArgb(37, 52, 68);
            btnBasalMetabolism.ColorBackground_2 = Color.FromArgb(41, 63, 86);
            btnBasalMetabolism.ColorBackground_Pen = Color.FromArgb(29, 200, 238);
            btnBasalMetabolism.ColorLighting = Color.FromArgb(29, 200, 238);
            btnBasalMetabolism.ColorPen_1 = Color.FromArgb(37, 52, 68);
            btnBasalMetabolism.ColorPen_2 = Color.FromArgb(41, 63, 86);
            btnBasalMetabolism.CyberButtonStyle = ReaLTaiizor.Enum.Cyber.StateStyle.Custom;
            btnBasalMetabolism.Effect_1 = true;
            btnBasalMetabolism.Effect_1_ColorBackground = Color.FromArgb(29, 200, 238);
            btnBasalMetabolism.Effect_1_Transparency = 25;
            btnBasalMetabolism.Effect_2 = true;
            btnBasalMetabolism.Effect_2_ColorBackground = Color.White;
            btnBasalMetabolism.Effect_2_Transparency = 20;
            btnBasalMetabolism.Font = new Font("Arial", 11F, FontStyle.Regular, GraphicsUnit.Point);
            btnBasalMetabolism.ForeColor = Color.FromArgb(245, 245, 245);
            btnBasalMetabolism.Lighting = false;
            btnBasalMetabolism.LinearGradient_Background = false;
            btnBasalMetabolism.LinearGradientPen = false;
            btnBasalMetabolism.Location = new Point(600, 12);
            btnBasalMetabolism.Name = "btnBasalMetabolism";
            btnBasalMetabolism.PenWidth = 15;
            btnBasalMetabolism.Rounding = true;
            btnBasalMetabolism.RoundingInt = 90;
            btnBasalMetabolism.Size = new Size(120, 120);
            btnBasalMetabolism.SmoothingMode = System.Drawing.Drawing2D.SmoothingMode.HighQuality;
            btnBasalMetabolism.TabIndex = 2;
            btnBasalMetabolism.Tag = "Cyber";
            btnBasalMetabolism.TextButton = "";
            btnBasalMetabolism.TextRenderingHint = System.Drawing.Text.TextRenderingHint.ClearTypeGridFit;
            btnBasalMetabolism.Timer_Effect_1 = 5;
            btnBasalMetabolism.Timer_RGB = 300;
            btnBasalMetabolism.Click += btnBasalMetabolism_Click;
            // 
            // btnCalculateNutritions
            // 
            btnCalculateNutritions.Alpha = 20;
            btnCalculateNutritions.BackColor = Color.Transparent;
            btnCalculateNutritions.Background = true;
            btnCalculateNutritions.Background_WidthPen = 4F;
            btnCalculateNutritions.BackgroundImage = Properties.Resources.nutritioncalculate;
            btnCalculateNutritions.BackgroundImageLayout = ImageLayout.Zoom;
            btnCalculateNutritions.BackgroundPen = false;
            btnCalculateNutritions.ColorBackground = Color.Transparent;
            btnCalculateNutritions.ColorBackground_1 = Color.FromArgb(37, 52, 68);
            btnCalculateNutritions.ColorBackground_2 = Color.FromArgb(41, 63, 86);
            btnCalculateNutritions.ColorBackground_Pen = Color.FromArgb(29, 200, 238);
            btnCalculateNutritions.ColorLighting = Color.FromArgb(29, 200, 238);
            btnCalculateNutritions.ColorPen_1 = Color.FromArgb(37, 52, 68);
            btnCalculateNutritions.ColorPen_2 = Color.FromArgb(41, 63, 86);
            btnCalculateNutritions.CyberButtonStyle = ReaLTaiizor.Enum.Cyber.StateStyle.Custom;
            btnCalculateNutritions.Effect_1 = true;
            btnCalculateNutritions.Effect_1_ColorBackground = Color.FromArgb(29, 200, 238);
            btnCalculateNutritions.Effect_1_Transparency = 25;
            btnCalculateNutritions.Effect_2 = true;
            btnCalculateNutritions.Effect_2_ColorBackground = Color.White;
            btnCalculateNutritions.Effect_2_Transparency = 20;
            btnCalculateNutritions.Font = new Font("Arial", 11F, FontStyle.Regular, GraphicsUnit.Point);
            btnCalculateNutritions.ForeColor = Color.FromArgb(245, 245, 245);
            btnCalculateNutritions.Lighting = false;
            btnCalculateNutritions.LinearGradient_Background = false;
            btnCalculateNutritions.LinearGradientPen = false;
            btnCalculateNutritions.Location = new Point(385, 12);
            btnCalculateNutritions.Name = "btnCalculateNutritions";
            btnCalculateNutritions.PenWidth = 15;
            btnCalculateNutritions.Rounding = true;
            btnCalculateNutritions.RoundingInt = 90;
            btnCalculateNutritions.Size = new Size(120, 120);
            btnCalculateNutritions.SmoothingMode = System.Drawing.Drawing2D.SmoothingMode.HighQuality;
            btnCalculateNutritions.TabIndex = 2;
            btnCalculateNutritions.Tag = "Cyber";
            btnCalculateNutritions.TextButton = "";
            btnCalculateNutritions.TextRenderingHint = System.Drawing.Text.TextRenderingHint.ClearTypeGridFit;
            btnCalculateNutritions.Timer_Effect_1 = 5;
            btnCalculateNutritions.Timer_RGB = 300;
            btnCalculateNutritions.Click += btnCalculateNutritions_Click;
            // 
            // btnCalculateIdealWeight
            // 
            btnCalculateIdealWeight.Alpha = 20;
            btnCalculateIdealWeight.BackColor = Color.Transparent;
            btnCalculateIdealWeight.Background = true;
            btnCalculateIdealWeight.Background_WidthPen = 4F;
            btnCalculateIdealWeight.BackgroundImage = Properties.Resources.scale;
            btnCalculateIdealWeight.BackgroundImageLayout = ImageLayout.Zoom;
            btnCalculateIdealWeight.BackgroundPen = false;
            btnCalculateIdealWeight.ColorBackground = Color.Transparent;
            btnCalculateIdealWeight.ColorBackground_1 = Color.FromArgb(37, 52, 68);
            btnCalculateIdealWeight.ColorBackground_2 = Color.FromArgb(41, 63, 86);
            btnCalculateIdealWeight.ColorBackground_Pen = Color.FromArgb(29, 200, 238);
            btnCalculateIdealWeight.ColorLighting = Color.FromArgb(29, 200, 238);
            btnCalculateIdealWeight.ColorPen_1 = Color.FromArgb(37, 52, 68);
            btnCalculateIdealWeight.ColorPen_2 = Color.FromArgb(41, 63, 86);
            btnCalculateIdealWeight.CyberButtonStyle = ReaLTaiizor.Enum.Cyber.StateStyle.Custom;
            btnCalculateIdealWeight.Effect_1 = true;
            btnCalculateIdealWeight.Effect_1_ColorBackground = Color.FromArgb(29, 200, 238);
            btnCalculateIdealWeight.Effect_1_Transparency = 25;
            btnCalculateIdealWeight.Effect_2 = true;
            btnCalculateIdealWeight.Effect_2_ColorBackground = Color.White;
            btnCalculateIdealWeight.Effect_2_Transparency = 20;
            btnCalculateIdealWeight.Font = new Font("Arial", 11F, FontStyle.Regular, GraphicsUnit.Point);
            btnCalculateIdealWeight.ForeColor = Color.FromArgb(245, 245, 245);
            btnCalculateIdealWeight.Lighting = false;
            btnCalculateIdealWeight.LinearGradient_Background = false;
            btnCalculateIdealWeight.LinearGradientPen = false;
            btnCalculateIdealWeight.Location = new Point(170, 12);
            btnCalculateIdealWeight.Name = "btnCalculateIdealWeight";
            btnCalculateIdealWeight.PenWidth = 15;
            btnCalculateIdealWeight.Rounding = true;
            btnCalculateIdealWeight.RoundingInt = 90;
            btnCalculateIdealWeight.Size = new Size(120, 120);
            btnCalculateIdealWeight.SmoothingMode = System.Drawing.Drawing2D.SmoothingMode.HighQuality;
            btnCalculateIdealWeight.TabIndex = 2;
            btnCalculateIdealWeight.Tag = "Cyber";
            btnCalculateIdealWeight.TextButton = "";
            btnCalculateIdealWeight.TextRenderingHint = System.Drawing.Text.TextRenderingHint.ClearTypeGridFit;
            btnCalculateIdealWeight.Timer_Effect_1 = 5;
            btnCalculateIdealWeight.Timer_RGB = 300;
            btnCalculateIdealWeight.Click += btnCalculateIdealWeight_Click;
            // 
            // label1
            // 
            label1.Location = new Point(18, 74);
            label1.Name = "label1";
            label1.Size = new Size(100, 23);
            label1.TabIndex = 116;
            label1.Text = "gr(100-1000)";
            // 
            // lblFat
            // 
            lblFat.AutoSize = true;
            lblFat.Location = new Point(329, 100);
            lblFat.Name = "lblFat";
            lblFat.Size = new Size(23, 15);
            lblFat.TabIndex = 115;
            lblFat.Text = "Fat";
            // 
            // lblCarbonhydrate
            // 
            lblCarbonhydrate.AutoSize = true;
            lblCarbonhydrate.Location = new Point(329, 71);
            lblCarbonhydrate.Name = "lblCarbonhydrate";
            lblCarbonhydrate.Size = new Size(79, 15);
            lblCarbonhydrate.TabIndex = 114;
            lblCarbonhydrate.Text = "Carbohydrate";
            // 
            // lblProtein
            // 
            lblProtein.AutoSize = true;
            lblProtein.Location = new Point(329, 42);
            lblProtein.Name = "lblProtein";
            lblProtein.Size = new Size(45, 15);
            lblProtein.TabIndex = 113;
            lblProtein.Text = "Protein";
            // 
            // lblCalorie
            // 
            lblCalorie.AutoSize = true;
            lblCalorie.Location = new Point(329, 13);
            lblCalorie.Name = "lblCalorie";
            lblCalorie.Size = new Size(44, 15);
            lblCalorie.TabIndex = 112;
            lblCalorie.Text = "Calorie";
            // 
            // txtFat
            // 
            txtFat.Location = new Point(426, 97);
            txtFat.Name = "txtFat";
            txtFat.Size = new Size(127, 23);
            txtFat.TabIndex = 111;
            // 
            // txtCarbohydrate
            // 
            txtCarbohydrate.Location = new Point(426, 68);
            txtCarbohydrate.Name = "txtCarbohydrate";
            txtCarbohydrate.Size = new Size(127, 23);
            txtCarbohydrate.TabIndex = 110;
            // 
            // txtProtein
            // 
            txtProtein.Location = new Point(426, 39);
            txtProtein.Name = "txtProtein";
            txtProtein.Size = new Size(127, 23);
            txtProtein.TabIndex = 109;
            // 
            // txtCalorie
            // 
            txtCalorie.Location = new Point(426, 10);
            txtCalorie.Name = "txtCalorie";
            txtCalorie.Size = new Size(127, 23);
            txtCalorie.TabIndex = 108;
            // 
            // lstFoodList
            // 
            lstFoodList.Columns.AddRange(new ColumnHeader[] { columnHeader1, columnHeader2, columnHeader3, columnHeader4, columnHeader5 });
            lstFoodList.FullRowSelect = true;
            lstFoodList.GridLines = true;
            lstFoodList.Location = new Point(14, 135);
            lstFoodList.Name = "lstFoodList";
            lstFoodList.Size = new Size(539, 104);
            lstFoodList.TabIndex = 107;
            lstFoodList.UseCompatibleStateImageBehavior = false;
            lstFoodList.View = View.Details;
            lstFoodList.SelectedIndexChanged += lstFoodList_SelectedIndexChanged;
            // 
            // columnHeader1
            // 
            columnHeader1.Text = "FoodName";
            columnHeader1.Width = 130;
            // 
            // columnHeader2
            // 
            columnHeader2.Text = "Calorie";
            columnHeader2.Width = 100;
            // 
            // columnHeader3
            // 
            columnHeader3.Text = "Protein";
            columnHeader3.Width = 100;
            // 
            // columnHeader4
            // 
            columnHeader4.Text = "Carbohydrate";
            columnHeader4.Width = 100;
            // 
            // columnHeader5
            // 
            columnHeader5.Text = "Fat";
            columnHeader5.Width = 100;
            // 
            // txtWeightInformation
            // 
            txtWeightInformation.Location = new Point(14, 100);
            txtWeightInformation.Name = "txtWeightInformation";
            txtWeightInformation.Size = new Size(172, 23);
            txtWeightInformation.TabIndex = 106;
            txtWeightInformation.KeyPress += txtWeightInformation_KeyPress;
            // 
            // cmbFoods
            // 
            cmbFoods.FormattingEnabled = true;
            cmbFoods.Location = new Point(14, 39);
            cmbFoods.Name = "cmbFoods";
            cmbFoods.Size = new Size(172, 23);
            cmbFoods.TabIndex = 104;
            cmbFoods.SelectedIndexChanged += cmbFoods_SelectedIndexChanged;
            // 
            // pnlNutritionCalculator
            // 
            pnlNutritionCalculator.Controls.Add(lblSearchFoodName);
            pnlNutritionCalculator.Controls.Add(label1);
            pnlNutritionCalculator.Controls.Add(lblFat);
            pnlNutritionCalculator.Controls.Add(lblCarbonhydrate);
            pnlNutritionCalculator.Controls.Add(lblProtein);
            pnlNutritionCalculator.Controls.Add(lblCalorie);
            pnlNutritionCalculator.Controls.Add(cmbFoods);
            pnlNutritionCalculator.Controls.Add(txtFat);
            pnlNutritionCalculator.Controls.Add(txtCarbohydrate);
            pnlNutritionCalculator.Controls.Add(txtWeightInformation);
            pnlNutritionCalculator.Controls.Add(txtProtein);
            pnlNutritionCalculator.Controls.Add(lstFoodList);
            pnlNutritionCalculator.Controls.Add(txtCalorie);
            pnlNutritionCalculator.Location = new Point(162, 138);
            pnlNutritionCalculator.Name = "pnlNutritionCalculator";
            pnlNutritionCalculator.Size = new Size(570, 239);
            pnlNutritionCalculator.TabIndex = 118;
            pnlNutritionCalculator.Visible = false;
            // 
            // lblSearchFoodName
            // 
            lblSearchFoodName.Location = new Point(14, 10);
            lblSearchFoodName.Name = "lblSearchFoodName";
            lblSearchFoodName.Size = new Size(172, 23);
            lblSearchFoodName.TabIndex = 118;
            lblSearchFoodName.Text = "Search Food Name:";
            // 
            // pnlCalculateIdealWeight
            // 
            pnlCalculateIdealWeight.Controls.Add(nudHeight);
            pnlCalculateIdealWeight.Controls.Add(nudAge);
            pnlCalculateIdealWeight.Controls.Add(rdoFemale);
            pnlCalculateIdealWeight.Controls.Add(rdoMale);
            pnlCalculateIdealWeight.Controls.Add(pbFemale);
            pnlCalculateIdealWeight.Controls.Add(pbMale);
            pnlCalculateIdealWeight.Controls.Add(lblYourIdealWeight);
            pnlCalculateIdealWeight.Controls.Add(lblKg);
            pnlCalculateIdealWeight.Controls.Add(lblWeight);
            pnlCalculateIdealWeight.Controls.Add(lblAge);
            pnlCalculateIdealWeight.Controls.Add(lblHeight);
            pnlCalculateIdealWeight.Controls.Add(lblGender);
            pnlCalculateIdealWeight.Controls.Add(btnCalculate);
            pnlCalculateIdealWeight.Location = new Point(162, 138);
            pnlCalculateIdealWeight.Name = "pnlCalculateIdealWeight";
            pnlCalculateIdealWeight.Size = new Size(570, 239);
            pnlCalculateIdealWeight.TabIndex = 119;
            pnlCalculateIdealWeight.Visible = false;
            // 
            // nudHeight
            // 
            nudHeight.Location = new Point(262, 92);
            nudHeight.Maximum = new decimal(new int[] { 300, 0, 0, 0 });
            nudHeight.Name = "nudHeight";
            nudHeight.Size = new Size(146, 23);
            nudHeight.TabIndex = 49;
            // 
            // nudAge
            // 
            nudAge.Location = new Point(262, 58);
            nudAge.Maximum = new decimal(new int[] { 300, 0, 0, 0 });
            nudAge.Name = "nudAge";
            nudAge.Size = new Size(146, 23);
            nudAge.TabIndex = 49;
            // 
            // rdoFemale
            // 
            rdoFemale.AutoSize = true;
            rdoFemale.Checked = true;
            rdoFemale.Location = new Point(354, 29);
            rdoFemale.Name = "rdoFemale";
            rdoFemale.Size = new Size(14, 13);
            rdoFemale.TabIndex = 46;
            rdoFemale.TabStop = true;
            rdoFemale.UseVisualStyleBackColor = true;
            // 
            // rdoMale
            // 
            rdoMale.AutoSize = true;
            rdoMale.Location = new Point(268, 29);
            rdoMale.Name = "rdoMale";
            rdoMale.Size = new Size(14, 13);
            rdoMale.TabIndex = 45;
            rdoMale.UseVisualStyleBackColor = true;
            // 
            // pbFemale
            // 
            pbFemale.BackColor = Color.Transparent;
            pbFemale.Image = Properties.Resources.femenine;
            pbFemale.Location = new Point(383, 23);
            pbFemale.Name = "pbFemale";
            pbFemale.Size = new Size(23, 23);
            pbFemale.SizeMode = PictureBoxSizeMode.Zoom;
            pbFemale.TabIndex = 47;
            pbFemale.TabStop = false;
            // 
            // pbMale
            // 
            pbMale.BackColor = Color.Transparent;
            pbMale.Image = Properties.Resources.masculine;
            pbMale.Location = new Point(295, 23);
            pbMale.Name = "pbMale";
            pbMale.Size = new Size(23, 23);
            pbMale.SizeMode = PictureBoxSizeMode.Zoom;
            pbMale.TabIndex = 48;
            pbMale.TabStop = false;
            // 
            // lblYourIdealWeight
            // 
            lblYourIdealWeight.Location = new Point(141, 191);
            lblYourIdealWeight.Name = "lblYourIdealWeight";
            lblYourIdealWeight.Size = new Size(115, 23);
            lblYourIdealWeight.TabIndex = 21;
            lblYourIdealWeight.Text = "Your Ideal Weight";
            // 
            // lblKg
            // 
            lblKg.Location = new Point(330, 191);
            lblKg.Name = "lblKg";
            lblKg.Size = new Size(100, 23);
            lblKg.TabIndex = 20;
            lblKg.Text = "Kg";
            // 
            // lblWeight
            // 
            lblWeight.Location = new Point(282, 191);
            lblWeight.Name = "lblWeight";
            lblWeight.Size = new Size(42, 23);
            lblWeight.TabIndex = 19;
            lblWeight.Text = "0";
            // 
            // lblAge
            // 
            lblAge.Location = new Point(200, 60);
            lblAge.Name = "lblAge";
            lblAge.Size = new Size(56, 15);
            lblAge.TabIndex = 18;
            lblAge.Text = "Age";
            // 
            // lblHeight
            // 
            lblHeight.Location = new Point(200, 94);
            lblHeight.Name = "lblHeight";
            lblHeight.Size = new Size(56, 15);
            lblHeight.TabIndex = 18;
            lblHeight.Text = "Height:";
            // 
            // lblGender
            // 
            lblGender.Location = new Point(200, 28);
            lblGender.Name = "lblGender";
            lblGender.Size = new Size(56, 23);
            lblGender.TabIndex = 14;
            lblGender.Text = "Gender:";
            // 
            // btnCalculate
            // 
            btnCalculate.Location = new Point(258, 132);
            btnCalculate.Name = "btnCalculate";
            btnCalculate.Size = new Size(150, 23);
            btnCalculate.TabIndex = 12;
            btnCalculate.Text = "Calculate";
            btnCalculate.UseVisualStyleBackColor = true;
            btnCalculate.Click += btnCalculate_Click;
            // 
            // pnlBasalMetabolism
            // 
            pnlBasalMetabolism.Controls.Add(btnBMCalculate);
            pnlBasalMetabolism.Controls.Add(nudBMHeight);
            pnlBasalMetabolism.Controls.Add(nudBMWeight);
            pnlBasalMetabolism.Controls.Add(rdoBMFemale);
            pnlBasalMetabolism.Controls.Add(rdoBMMale);
            pnlBasalMetabolism.Controls.Add(pbBMFemale);
            pnlBasalMetabolism.Controls.Add(pbBMMale);
            pnlBasalMetabolism.Controls.Add(lblResult);
            pnlBasalMetabolism.Controls.Add(lblDailyCalories);
            pnlBasalMetabolism.Controls.Add(cmbActivity);
            pnlBasalMetabolism.Controls.Add(lblBMActivity);
            pnlBasalMetabolism.Controls.Add(txtAge);
            pnlBasalMetabolism.Controls.Add(lblBMHeight);
            pnlBasalMetabolism.Controls.Add(lblBMWeight);
            pnlBasalMetabolism.Controls.Add(lblBMAge);
            pnlBasalMetabolism.Controls.Add(lblBMGender);
            pnlBasalMetabolism.Location = new Point(162, 138);
            pnlBasalMetabolism.Name = "pnlBasalMetabolism";
            pnlBasalMetabolism.Size = new Size(570, 239);
            pnlBasalMetabolism.TabIndex = 120;
            pnlBasalMetabolism.Visible = false;
            // 
            // btnBMCalculate
            // 
            btnBMCalculate.Location = new Point(258, 155);
            btnBMCalculate.Name = "btnBMCalculate";
            btnBMCalculate.Size = new Size(138, 23);
            btnBMCalculate.TabIndex = 50;
            btnBMCalculate.Text = "Calculate";
            btnBMCalculate.UseVisualStyleBackColor = true;
            btnBMCalculate.Click += btnBMCalculate_Click;
            // 
            // nudBMHeight
            // 
            nudBMHeight.Location = new Point(258, 68);
            nudBMHeight.Maximum = new decimal(new int[] { 300, 0, 0, 0 });
            nudBMHeight.Name = "nudBMHeight";
            nudBMHeight.Size = new Size(137, 23);
            nudBMHeight.TabIndex = 49;
            // 
            // nudBMWeight
            // 
            nudBMWeight.Location = new Point(259, 97);
            nudBMWeight.Maximum = new decimal(new int[] { 300, 0, 0, 0 });
            nudBMWeight.Name = "nudBMWeight";
            nudBMWeight.Size = new Size(137, 23);
            nudBMWeight.TabIndex = 49;
            // 
            // rdoBMFemale
            // 
            rdoBMFemale.AutoSize = true;
            rdoBMFemale.Checked = true;
            rdoBMFemale.Location = new Point(345, 18);
            rdoBMFemale.Name = "rdoBMFemale";
            rdoBMFemale.Size = new Size(14, 13);
            rdoBMFemale.TabIndex = 46;
            rdoBMFemale.TabStop = true;
            rdoBMFemale.UseVisualStyleBackColor = true;
            // 
            // rdoBMMale
            // 
            rdoBMMale.AutoSize = true;
            rdoBMMale.Location = new Point(259, 18);
            rdoBMMale.Name = "rdoBMMale";
            rdoBMMale.Size = new Size(14, 13);
            rdoBMMale.TabIndex = 45;
            rdoBMMale.UseVisualStyleBackColor = true;
            // 
            // pbBMFemale
            // 
            pbBMFemale.BackColor = Color.Transparent;
            pbBMFemale.Image = Properties.Resources.femenine;
            pbBMFemale.Location = new Point(374, 12);
            pbBMFemale.Name = "pbBMFemale";
            pbBMFemale.Size = new Size(23, 23);
            pbBMFemale.SizeMode = PictureBoxSizeMode.Zoom;
            pbBMFemale.TabIndex = 47;
            pbBMFemale.TabStop = false;
            // 
            // pbBMMale
            // 
            pbBMMale.BackColor = Color.Transparent;
            pbBMMale.Image = Properties.Resources.masculine;
            pbBMMale.Location = new Point(286, 12);
            pbBMMale.Name = "pbBMMale";
            pbBMMale.Size = new Size(23, 23);
            pbBMMale.SizeMode = PictureBoxSizeMode.Zoom;
            pbBMMale.TabIndex = 48;
            pbBMMale.TabStop = false;
            // 
            // lblResult
            // 
            lblResult.Location = new Point(259, 214);
            lblResult.Name = "lblResult";
            lblResult.Size = new Size(137, 23);
            lblResult.TabIndex = 25;
            lblResult.Text = "0";
            // 
            // lblDailyCalories
            // 
            lblDailyCalories.Location = new Point(77, 214);
            lblDailyCalories.Name = "lblDailyCalories";
            lblDailyCalories.Size = new Size(179, 23);
            lblDailyCalories.TabIndex = 25;
            lblDailyCalories.Text = "Daily calorie value you need:";
            // 
            // cmbActivity
            // 
            cmbActivity.FormattingEnabled = true;
            cmbActivity.Location = new Point(258, 126);
            cmbActivity.Name = "cmbActivity";
            cmbActivity.Size = new Size(138, 23);
            cmbActivity.TabIndex = 23;
            // 
            // lblBMActivity
            // 
            lblBMActivity.Location = new Point(122, 126);
            lblBMActivity.Name = "lblBMActivity";
            lblBMActivity.Size = new Size(100, 23);
            lblBMActivity.TabIndex = 22;
            lblBMActivity.Text = "Activity:";
            // 
            // txtAge
            // 
            txtAge.Location = new Point(258, 41);
            txtAge.Name = "txtAge";
            txtAge.Size = new Size(139, 23);
            txtAge.TabIndex = 19;
            // 
            // lblBMHeight
            // 
            lblBMHeight.Location = new Point(122, 71);
            lblBMHeight.Name = "lblBMHeight";
            lblBMHeight.Size = new Size(100, 23);
            lblBMHeight.TabIndex = 18;
            lblBMHeight.Text = "Height:";
            // 
            // lblBMWeight
            // 
            lblBMWeight.Location = new Point(122, 100);
            lblBMWeight.Name = "lblBMWeight";
            lblBMWeight.Size = new Size(100, 23);
            lblBMWeight.TabIndex = 18;
            lblBMWeight.Text = "Weight:";
            // 
            // lblBMAge
            // 
            lblBMAge.Location = new Point(122, 44);
            lblBMAge.Name = "lblBMAge";
            lblBMAge.Size = new Size(100, 23);
            lblBMAge.TabIndex = 17;
            lblBMAge.Text = "Age:";
            // 
            // lblBMGender
            // 
            lblBMGender.Location = new Point(122, 15);
            lblBMGender.Name = "lblBMGender";
            lblBMGender.Size = new Size(100, 23);
            lblBMGender.TabIndex = 15;
            lblBMGender.Text = "Gender:";
            // 
            // FormCalculations
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(800, 500);
            Controls.Add(pnlNutritionCalculator);
            Controls.Add(btnBasalMetabolism);
            Controls.Add(btnCalculateNutritions);
            Controls.Add(btnCalculateIdealWeight);
            Controls.Add(pnlCalculateIdealWeight);
            Controls.Add(pnlBasalMetabolism);
            FormBorderStyle = FormBorderStyle.None;
            Name = "FormCalculations";
            Text = "FormCalculations";
            Load += FormCalculations_Load;
            pnlNutritionCalculator.ResumeLayout(false);
            pnlNutritionCalculator.PerformLayout();
            pnlCalculateIdealWeight.ResumeLayout(false);
            pnlCalculateIdealWeight.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)nudHeight).EndInit();
            ((System.ComponentModel.ISupportInitialize)nudAge).EndInit();
            ((System.ComponentModel.ISupportInitialize)pbFemale).EndInit();
            ((System.ComponentModel.ISupportInitialize)pbMale).EndInit();
            pnlBasalMetabolism.ResumeLayout(false);
            pnlBasalMetabolism.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)nudBMHeight).EndInit();
            ((System.ComponentModel.ISupportInitialize)nudBMWeight).EndInit();
            ((System.ComponentModel.ISupportInitialize)pbBMFemale).EndInit();
            ((System.ComponentModel.ISupportInitialize)pbBMMale).EndInit();
            ResumeLayout(false);
        }

        #endregion

        private Label lblWeight;
        private Label lblHeight;
        private ReaLTaiizor.Controls.CyberButton btnBasalMetabolism;
        private ReaLTaiizor.Controls.CyberButton btnCalculateNutritions;
        private ReaLTaiizor.Controls.CyberButton btnCalculateIdealWeight;
        private Label label1;
        private Label lblFat;
        private Label lblCarbonhydrate;
        private Label lblProtein;
        private Label lblCalorie;
        private TextBox txtFat;
        private TextBox txtCarbohydrate;
        private TextBox txtProtein;
        private TextBox txtCalorie;
        private ListView lstFoodList;
        private ColumnHeader columnHeader1;
        private ColumnHeader columnHeader2;
        private ColumnHeader columnHeader3;
        private ColumnHeader columnHeader4;
        private ColumnHeader columnHeader5;
        private TextBox txtWeightInformation;
        private ComboBox cmbFoods;
        private Panel pnlNutritionCalculator;
        private Panel pnlCalculateIdealWeight;
        private Label lblYourIdealWeight;
        private Label lblKg;
        private Label lblConclusion;
        private Label label3;
        private Label lblGender;
        private Button btnCalculate;
        private NumericUpDown nudHeight;
        private NumericUpDown nudAge;
        private RadioButton rdoFemale;
        private RadioButton rdoMale;
        private PictureBox pbFemale;
        private PictureBox pbMale;
        private Label lblAge;
        private Panel pnlBasalMetabolism;
        private Label lblDailyCalories;
        private ComboBox cmbActivity;
        private Label lblBMActivity;
        private TextBox txtHeight;
        private TextBox txtAge;
        private Label lblBMWeight;
        private Label lblBMAge;
        private Button button1;
        private Label lblBMGender;
        private RadioButton rdoBMFemale;
        private RadioButton rdoBMMale;
        private PictureBox pbBMFemale;
        private PictureBox pbBMMale;
        private Label lblResult;
        private NumericUpDown nudBMWeight;
        private NumericUpDown nudBMHeight;
        private Label lblBMHeight;
        private Button btnBMCalculate;
        private Label lblSearchFoodName;
    }
}