using CalorieTracker_BLL;
using CalorieTracker_PL.Methods;
using Entities.Concrete;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Diagnostics.Metrics;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace CalorieTracker_PL
{
    public partial class FormAddMeal : Form
    {
        BusinessLayer bll;
        User user;
        UserFood userFood;
        public static bool isUserFood;

        public FormAddMeal()
        {
            InitializeComponent();
            bll = new BusinessLayer();
        }

        private void FormAddMeal_Load(object sender, EventArgs e)
        {
            isUserFood = btnDelete.Visible = btnUpdate.Visible = false;
            btnAdd.Visible = true;
            user = bll.Users.Search(FormLogin.account.AccountID.ToString());
            rdoBreakfast.Checked = true;

            Method.DarkMode(this, FormOpening.isDarkMode);

            if (FormOpening.isDarkMode)
            {
                dgvFoodList.DefaultCellStyle.ForeColor = Color.White;
                dgvFoodList.DefaultCellStyle.BackColor = Color.FromArgb(10, 39, 74);
                dgvFoodList.ColumnHeadersDefaultCellStyle.ForeColor = Color.White;
                dgvFoodList.ColumnHeadersDefaultCellStyle.BackColor = Color.FromArgb(10, 39, 74);
                dgvFoodList.RowHeadersDefaultCellStyle.ForeColor = Color.White;
                dgvFoodList.RowHeadersDefaultCellStyle.BackColor = Color.FromArgb(10, 39, 74);
                dgvFoodList.BackgroundColor = Color.FromArgb(10, 39, 74);
            }

            else if (!FormOpening.isDarkMode)
            {
                dgvFoodList.DefaultCellStyle.ForeColor = Color.Black;
                dgvFoodList.DefaultCellStyle.BackColor = Color.White;
                dgvFoodList.ColumnHeadersDefaultCellStyle.ForeColor = Color.Black;
                dgvFoodList.ColumnHeadersDefaultCellStyle.BackColor = Color.White;
                dgvFoodList.RowHeadersDefaultCellStyle.ForeColor = Color.Black;
                dgvFoodList.RowHeadersDefaultCellStyle.BackColor = Color.White;
                dgvFoodList.BackgroundColor = Color.White;
            }
        }

        private void dataGridView1_CellMouseClick(object sender, DataGridViewCellMouseEventArgs e)
        {
            int rowIndex = e.RowIndex;
            DataGridViewRow selectedRow = dgvFoodList.Rows[rowIndex];

            if (isUserFood)
            {
                txtUserFoodID.Text = selectedRow.Cells["UserFoodID"].Value.ToString();
                txtFoodName.Text = selectedRow.Cells["FoodName"].Value.ToString();
                txtCalorie.Text = selectedRow.Cells["Calorie"].Value.ToString();
                txtCarb.Text = selectedRow.Cells["Carbonhydrate"].Value.ToString();
                txtProtein.Text = selectedRow.Cells["Protein"].Value.ToString();
                txtFat.Text = selectedRow.Cells["Fat"].Value.ToString();
                numAmount.Value = Convert.ToDecimal(selectedRow.Cells["Amount"].Value);
                if (selectedRow.Cells["RepastName"].Value.ToString() == "Breakfast") { rdoBreakfast.Checked = true; }
                else if (selectedRow.Cells["RepastName"].Value.ToString() == "Lunch") { rdoLunch.Checked = true; }
                else if (selectedRow.Cells["RepastName"].Value.ToString() == "Dinner") { rdoDinner.Checked = true; }
                else if (selectedRow.Cells["RepastName"].Value.ToString() == "Snacks") { rdoSnacks.Checked = true; }
            }

            else
            {
                txtFoodName.Text = selectedRow.Cells["FoodName"].Value.ToString();
                txtCategoryName.Text = selectedRow.Cells["CategoryName"].Value.ToString();
                txtCalorie.Text = selectedRow.Cells["Calorie"].Value.ToString();
                txtCarb.Text = selectedRow.Cells["Carbonhydrate"].Value.ToString();
                txtProtein.Text = selectedRow.Cells["Protein"].Value.ToString();
                txtFat.Text = selectedRow.Cells["Fat"].Value.ToString();
            }
        }

        private void btnAddNewMeal_Click(object sender, EventArgs e)
        {
            userFood = new UserFood();
            userFood.Carbonhydrate = double.Parse(txtCarb.Text) * (double)numAmount.Value;
            userFood.Calorie = double.Parse(txtCalorie.Text) * (double)numAmount.Value;
            userFood.Fat = double.Parse(txtFat.Text) * (double)numAmount.Value;
            userFood.Protein = double.Parse(txtProtein.Text) * (double)numAmount.Value;
            Food food = bll.Foods.SearchFoodName(txtFoodName.Text);
            food.Counter++;
            userFood.Foods = food;
            userFood.FoodID = food.FoodID;
            userFood.AccountID = user.AccountID;
            userFood.Amount = (double)numAmount.Value;
            userFood.Users = user;
            if (rdoBreakfast.Checked) { userFood.RepastID = 1; }
            else if (rdoLunch.Checked) { userFood.RepastID = 2; }
            else if (rdoDinner.Checked) { userFood.RepastID = 3; }
            else if (rdoSnacks.Checked) { userFood.RepastID = 4; }
            userFood.AddedTime = DateTime.Now;
            user.DailyCalories += double.Parse(txtCalorie.Text) * (double)numAmount.Value;
            user.DailyCarbonhydrate += double.Parse(txtCarb.Text) * (double)numAmount.Value;
            user.DailyFat += double.Parse(txtFat.Text) * (double)numAmount.Value;
            user.DailyProtein += double.Parse(txtProtein.Text) * (double)numAmount.Value;
            bll.UserFoods.Create(userFood);

            isUserFood = btnUpdate.Visible = btnDelete.Visible = true;
            btnAdd.Visible = false;
            dgvFoodList.DataSource = bll.UserFoods.SelectedFoods(user);
        }

        private void btnList_Click(object sender, EventArgs e)
        {
            isUserFood = btnDelete.Visible = btnUpdate.Visible = false;
            btnAdd.Visible = true;

            dgvFoodList.DataSource = bll.Foods.SearchFoodCategoryList("");
        }

        private void btnSearch_Click(object sender, EventArgs e)
        {
            dgvFoodList.DataSource = bll.Foods.SearchFoodCategoryList(txtSearch.Text);
        }

        private void btnUserFoods_Click(object sender, EventArgs e)
        {
            isUserFood = btnUpdate.Visible = btnDelete.Visible = true;
            btnAdd.Visible = false;
            dgvFoodList.DataSource = bll.UserFoods.SelectedFoods(user);
        }

        private void btnDelete_Click(object sender, EventArgs e)
        {
            if (!string.IsNullOrEmpty(txtFoodName.Text))
            {
                UserFood deleteUserFood = bll.UserFoods.Search(txtUserFoodID.Text);
                if (deleteUserFood != null)
                {
                    Food food = bll.Foods.SearchFoodName(txtFoodName.Text);
                    food.Counter--;
                    user.DailyCalories -= deleteUserFood.Calorie;
                    user.DailyCarbonhydrate -= deleteUserFood.Carbonhydrate;
                    user.DailyFat -= deleteUserFood.Fat;
                    user.DailyProtein -= deleteUserFood.Protein;
                    bll.UserFoods.Delete(deleteUserFood);
                    dgvFoodList.DataSource = bll.UserFoods.SelectedFoods(user);
                }
                else
                    MessageBox.Show("Seçilen öğün bulunamamıştır.");

            }
            else if (string.IsNullOrEmpty(txtFoodName.Text))
            {
                MessageBox.Show("Bir yemek seçin.");
            }
        }

        private void btnUpdate_Click(object sender, EventArgs e)
        {
            if (!string.IsNullOrEmpty(txtFoodName.Text))
            {
                UserFood updateUserFood = bll.UserFoods.Search(txtUserFoodID.Text);
                if (updateUserFood != null)
                {
                    user.DailyCalories -= updateUserFood.Calorie;
                    user.DailyCarbonhydrate -= updateUserFood.Carbonhydrate;
                    user.DailyFat -= updateUserFood.Fat;
                    user.DailyProtein -= updateUserFood.Protein;
                    Food food = bll.Foods.SearchFoodName(txtFoodName.Text);
                    updateUserFood.Carbonhydrate = food.Carbonhydrate * (double)numAmount.Value;
                    updateUserFood.Calorie = food.Calorie * (double)numAmount.Value;
                    updateUserFood.Fat = food.Fat * (double)numAmount.Value;
                    updateUserFood.Protein = food.Protein * (double)numAmount.Value;
                    user.DailyCalories += updateUserFood.Calorie;
                    user.DailyCarbonhydrate += updateUserFood.Carbonhydrate;
                    user.DailyFat += updateUserFood.Fat;
                    user.DailyProtein += updateUserFood.Protein;
                    food.Counter++;
                    updateUserFood.FoodID = food.FoodID;
                    updateUserFood.AccountID = user.AccountID;
                    updateUserFood.Amount = (double)numAmount.Value;
                    updateUserFood.Users = user;
                    if (rdoBreakfast.Checked) { updateUserFood.RepastID = 1; }
                    else if (rdoLunch.Checked) { updateUserFood.RepastID = 2; }
                    else if (rdoDinner.Checked) { updateUserFood.RepastID = 3; }
                    else if (rdoSnacks.Checked) { updateUserFood.RepastID = 4; }
                    updateUserFood.AddedTime = DateTime.Now;
                    bll.UserFoods.Update(updateUserFood);
                    dgvFoodList.DataSource = bll.UserFoods.SelectedFoods(user);
                }
            }

            else if (string.IsNullOrEmpty(txtFoodName.Text))
            {
                MessageBox.Show("Bir yemek seçin.");
            }
        }
    }
}
