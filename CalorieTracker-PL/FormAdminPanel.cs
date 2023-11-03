using CalorieTracker_BLL;
using Entities.Concrete;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace CalorieTracker_PL
{
    public partial class FormAdminPanel : Form
    {
        FoodCategory_BLL foodCategoryBLL;
        Food_BLL foodBLL;
        public FormAdminPanel()
        {
            InitializeComponent();
            foodCategoryBLL = new FoodCategory_BLL();
            foodBLL = new Food_BLL();
        }

        private void FormAdminPanel_Load(object sender, EventArgs e)
        {
            List<FoodCategory> foodCategory = foodCategoryBLL.List();
            List<FoodCategory> updateFoodCategory = foodCategoryBLL.List();

            cmbFoodCategories.DisplayMember = "CategoryName";
            cmbFoodCategories.ValueMember = "FoodCategoryID";
            cmbFoodCategories.DataSource = foodCategory;

            cmbSelectCategoryName.DisplayMember = "CategoryName";
            cmbSelectCategoryName.ValueMember = "FoodCategoryID";
            cmbSelectCategoryName.DataSource = foodCategory;

            cmbSelectUpdatedFoodCategory.DisplayMember = "CategoryName";
            cmbSelectUpdatedFoodCategory.ValueMember = "FoodCategoryID";
            cmbSelectUpdatedFoodCategory.DataSource = updateFoodCategory;

            cmbDeletedCategory.DisplayMember = "CategoryName";
            cmbDeletedCategory.ValueMember = "FoodCategoryID";
            cmbDeletedCategory.DataSource = updateFoodCategory;

            List<Food> food = foodBLL.List();

            cmbSelectFood.DisplayMember = "FoodName";
            cmbSelectFood.ValueMember = "FoodID";
            cmbSelectFood.DataSource = food;

            cmbDeletedFood.DisplayMember = "FoodName";
            cmbDeletedFood.ValueMember = "FoodID";
            cmbDeletedFood.DataSource = food;

        }

        private void btnAddNewFood_Click(object sender, EventArgs e)
        {
            Food newFood = new Food();
            newFood.FoodName = txtFoodName.Text;
            newFood.FoodCategoryID = Convert.ToInt32(cmbFoodCategories.SelectedValue);
            newFood.Calorie = Convert.ToDouble(txtCalorie.Text);
            newFood.Fat = Convert.ToDouble(txtFat.Text);
            newFood.Carbonhydrate = Convert.ToDouble(txtCarbonhydrate.Text);
            newFood.Protein = Convert.ToDouble(txtProtein.Text);
            newFood.Description = txtDescription.Text;
            newFood.Amount = 100;

            foodBLL.Create(newFood);
        }

        private void btnAddNewFoodCategory_Click(object sender, EventArgs e)
        {
            FoodCategory newFoodCategory = new FoodCategory();

            newFoodCategory.CategoryName = txtFoodCategoryName.Text;

            foodCategoryBLL.Create(newFoodCategory);
        }

        private void btnAdd_Click(object sender, EventArgs e)
        {
            pnlAdd.Visible = true;
            pnlUpdate.Visible = false;
            pnlDelete.Visible = false;
        }

        private void btnUpdate_Click(object sender, EventArgs e)
        {
            pnlUpdate.Visible = true;
            pnlAdd.Visible = false;
            pnlDelete.Visible = false;
        }

        private void btnUpdateFood_Click(object sender, EventArgs e)
        {
            int foodId = Convert.ToInt32(cmbSelectFood.SelectedValue);
            Food updatedFood = foodBLL.Search(foodId.ToString());

            updatedFood.FoodCategoryID = Convert.ToInt32(cmbSelectUpdatedFoodCategory.SelectedValue);
            updatedFood.Calorie = Convert.ToDouble(txtUpdatedCalorie.Text);
            updatedFood.Carbonhydrate = Convert.ToDouble(txtUpdatedCarbonhydrate.Text);
            updatedFood.Protein = Convert.ToDouble(txtUpdatedProtein.Text);
            updatedFood.Fat = Convert.ToDouble(txtUpdatedFat.Text);
            updatedFood.Description = txtUpdatedDescription.Text;

            foodBLL.Update(updatedFood);
        }

        private void btnUpdateCategory_Click(object sender, EventArgs e)
        {
            int foodCategoryId = Convert.ToInt32(cmbSelectCategoryName.SelectedValue);
            FoodCategory updatedFoodCategory = foodCategoryBLL.Search(foodCategoryId.ToString());
            updatedFoodCategory.CategoryName = txtNewCategoryName.Text;
            foodCategoryBLL.Update(updatedFoodCategory);
        }

        private void cmbSelectFood_SelectedIndexChanged(object sender, EventArgs e)
        {
            int foodId = Convert.ToInt32(cmbSelectFood.SelectedValue);
            Food updatedFood = foodBLL.Search(foodId.ToString());

            cmbSelectUpdatedFoodCategory.SelectedValue = updatedFood.FoodCategoryID;
            txtUpdatedCalorie.Text = updatedFood.Calorie.ToString();
            txtUpdatedCarbonhydrate.Text = updatedFood.Carbonhydrate.ToString();
            txtUpdatedProtein.Text = updatedFood.Protein.ToString();
            txtUpdatedFat.Text = updatedFood.Fat.ToString();
            txtUpdatedDescription.Text = updatedFood.Description;
        }

        private void cmbSelectCategoryName_SelectedIndexChanged(object sender, EventArgs e)
        {
            FoodCategory updatedFoodCategory = new FoodCategory();
            int foodCategoryId = Convert.ToInt32(cmbSelectCategoryName.SelectedValue);
            txtNewCategoryName.Text = updatedFoodCategory.CategoryName;
        }

        private void btnDelete_Click(object sender, EventArgs e)
        {
            pnlAdd.Visible = false;
            pnlUpdate.Visible = false;
            pnlDelete.Visible = true;
        }

        private void btnDeleteFood_Click(object sender, EventArgs e)
        {
            int foodId = Convert.ToInt32(cmbDeletedFood.SelectedValue);
            Food deleteFood = foodBLL.Search(foodId.ToString());
            foodBLL.Delete(deleteFood);
        }

        private void btnDeleteFoodCategory_Click(object sender, EventArgs e)
        {
            int foodCategoryId = Convert.ToInt32(cmbDeletedCategory.SelectedValue);
            FoodCategory deleteFoodCategory = foodCategoryBLL.Search(foodCategoryId.ToString());
            foodCategoryBLL.Delete(deleteFoodCategory);
        }
    }
}
