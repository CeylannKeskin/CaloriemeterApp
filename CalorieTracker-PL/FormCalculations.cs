using CalorieTracker_BLL;
using CalorieTracker_PL.Methods;
using Entities.Concrete;
using Entities.Enums;
using KaloriTakipUygulamasi_DAL;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Reflection;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using static System.Windows.Forms.VisualStyles.VisualStyleElement;

namespace CalorieTracker_PL
{
    public partial class FormCalculations : Form
    {
        KTUContext db;
        private readonly Food_BLL foodBLL;
        private readonly FoodCategory_BLL foodCategoryBLL;
        public FormCalculations()
        {
            InitializeComponent();
            db = new KTUContext();
            foodBLL = new Food_BLL();
            foodCategoryBLL = new FoodCategory_BLL();
        }

        private void FormCalculations_Load(object sender, EventArgs e)
        {
            Method.DarkMode(this, FormOpening.isDarkMode);
        }

        private void btnCalculateNutritions_Click(object sender, EventArgs e)
        {
            pnlNutritionCalculator.Visible = true;
            pnlCalculateIdealWeight.Visible = false;
            pnlBasalMetabolism.Visible = false;

            LoadFoodCategories();
        }

        private void LoadFoodCategories()
        {
            List<Food> foodname = foodBLL.List();

            cmbFoods.DisplayMember = "FoodName";
            cmbFoods.ValueMember = "FoodID";
            cmbFoods.DataSource = foodname;
        }

        private void btnCalculateIdealWeight_Click(object sender, EventArgs e)
        {
            pnlCalculateIdealWeight.Visible = true;
            pnlNutritionCalculator.Visible = false;
            pnlBasalMetabolism.Visible = false;
        }

        private void btnBasalMetabolism_Click(object sender, EventArgs e)
        {
            pnlBasalMetabolism.Visible = true;
            pnlCalculateIdealWeight.Visible = false;
            pnlNutritionCalculator.Visible = false;

            cmbActivity.DataSource = Enum.GetValues(typeof(ActivityStatus)).Cast<ActivityStatus>().Select(x => new { Value = x, DisplayName = Method.GetEnumDisplayName(x) }).ToList();
            cmbActivity.DisplayMember = "DisplayName";
            cmbActivity.ValueMember = "Value";
            cmbActivity.SelectedIndex = -1;
        }

        private void lstFoodList_SelectedIndexChanged(object sender, EventArgs e)
        {
            double amount = 0;

            if (lstFoodList.SelectedItems.Count > 0)
            {
                ListViewItem selectedItem = lstFoodList.SelectedItems[0];

                if (txtWeightInformation.Text == "")
                {
                    txtWeightInformation.Text = "100";
                    amount = Convert.ToDouble(txtWeightInformation.Text);
                }

                else if (txtWeightInformation.Text != null)
                {
                    amount = Convert.ToDouble(txtWeightInformation.Text);
                }

                string foodName = Convert.ToString(selectedItem.SubItems[0].Text);

                double calorie = Convert.ToDouble(selectedItem.SubItems[1].Text);
                double protein = Convert.ToDouble(selectedItem.SubItems[2].Text);
                double carbonhydrate = Convert.ToDouble(selectedItem.SubItems[3].Text);
                double fat = Convert.ToDouble(selectedItem.SubItems[4].Text);

                double calculatedCalorie = calorie * amount / 100;
                double calculatedProtein = protein * amount / 100;
                double calculatedCarbonhydrate = carbonhydrate * amount / 100;
                double calculatedFat = fat * amount / 100;

                txtCalorie.Text = calculatedCalorie.ToString();
                txtProtein.Text = calculatedProtein.ToString();
                txtCarbohydrate.Text = calculatedCarbonhydrate.ToString();
                txtFat.Text = calculatedFat.ToString();
                lstFoodList.Items.Clear();
            }
        }

        private void txtWeightInformation_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!char.IsControl(e.KeyChar) && !char.IsDigit(e.KeyChar))
            {
                e.Handled = true;
            }
        }

        private void btnCalculate_Click(object sender, EventArgs e)
        {
            double idealWeight = 0;
            bool genderControl = rdoMale.Checked ? true : false;

            string gender = genderControl ? "Erkek" : "Kadın";

            int age = Convert.ToInt32(nudAge.Value);
            double height = Convert.ToDouble(nudHeight.Value);

            if (gender == "Erkek")
            {
                idealWeight = (height - 100) - (age / 10);
            }
            else if (gender == "Kadın")
            {
                idealWeight = (height - 100) - (age / 10) - ((height - 150) / 4);
            }

            lblWeight.Text = idealWeight.ToString();
        }

        private void btnBMCalculate_Click(object sender, EventArgs e)
        {
            bool genderControl = rdoBMMale.Checked ? true : false;

            int age = int.Parse(txtAge.Text);
            double height = Convert.ToDouble(nudBMHeight.Value);
            double weight = Convert.ToDouble(nudBMWeight.Value);

            double bmr = 0;

            // Kadınlar için BMR hesaplama formülü
            if (!genderControl)
            {
                bmr = 655 + (4.35 * weight) + (4.7 * height) - (4.7 * age);
            }
            // Erkekler için BMR hesaplama formülü
            else
            {
                bmr = 66 + (6.23 * weight) + (12.7 * height) - (6.8 * age);
            }

            // Aktivite seviyesine göre BMR'yi güncelleme
            switch (cmbActivity.Text)
            {
                case "NotActive":
                    bmr = bmr * 1.2;
                    break;
                case "LessActive":
                    bmr = bmr * 1.375;
                    break;
                case "NormalActive":
                    bmr = bmr * 1.55;
                    break;
                case "VeryActive":
                    bmr = bmr * 1.725;
                    break;
            }

            lblResult.Text = bmr.ToString();
        }

        private void cmbFoods_SelectedIndexChanged(object sender, EventArgs e)
        {
            Food selectedFood = cmbFoods.SelectedItem as Food;
            if (selectedFood != null)
            {
                ListViewItem listViewItem = new ListViewItem(selectedFood.FoodName);
                listViewItem.SubItems.Add(selectedFood.Calorie.ToString());
                listViewItem.SubItems.Add(selectedFood.Protein.ToString());
                listViewItem.SubItems.Add(selectedFood.Carbonhydrate.ToString());
                listViewItem.SubItems.Add(selectedFood.Fat.ToString());
                lstFoodList.Items.Add(listViewItem);

            }
        }
    }
}
