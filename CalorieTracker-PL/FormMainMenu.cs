using CalorieTracker_BLL;
using CalorieTracker_PL.Methods;
using Entities.Concrete;
using ReaLTaiizor.Controls;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Runtime.CompilerServices;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace CalorieTracker_PL
{
    public partial class FormMainMenu : Form
    {
        public FormMainMenu()
        {
            InitializeComponent();
            bll = new BusinessLayer();

        }
        BusinessLayer bll;
        User user;
        private void FormMainMenu_Load(object sender, EventArgs e)
        {
            user = bll.Users.Search(FormLogin.account.AccountID.ToString());
            user.UserBMI = Method.CalculateBMI((double)user.Height, (double)user.Weight);
            user.BMIStatus = Method.CalculateBMIStatu((double)user.UserBMI, user);
            FormLogin.account.Age = DateTime.Now.Year - FormLogin.account.BirthDate.Year;
            user.BMR = Method.CalculateBMR((double)user.Height, (double)user.Weight, FormLogin.account.Gender, (int)FormLogin.account.Age);
            user.LimitOfCalories = user.BMR;
            user.LimitOfCarbonhydrate = (user.LimitOfCalories * 0.6) / 4;
            user.LimitOfFat = (user.LimitOfCalories * 0.25) / 9;
            user.LimitOfProtein = (user.LimitOfCalories * 0.15) / 4;
            lblBMIStatu.Text = user.BMIStatus.ToString();
            lblUserBMI.Text = Math.Round((double)user.UserBMI, 2).ToString();
            Method.DarkMode(this, FormOpening.isDarkMode);
            lblCalorieTaken.Text = Math.Round((double)user.DailyCalories, 2).ToString() + " kcal";
            lblCarbTaken.Text = Math.Round((double)user.DailyCarbonhydrate, 2).ToString() + " g";
            lblFatTaken.Text = Math.Round((double)user.DailyFat, 2).ToString() + " g";
            lblProteinTaken.Text = Math.Round((double)user.DailyProtein, 2).ToString() + " g";
            lblMaxCalorie.Text = Math.Round((double)user.LimitOfCalories, 2).ToString() + " kcal";
            lblMaxCarb.Text = Math.Round((double)user.LimitOfCarbonhydrate, 2).ToString() + " g";
            lblMaxFat.Text = Math.Round((double)user.LimitOfFat, 2).ToString() + " g";
            lblMaxProtein.Text = Math.Round((double)user.LimitOfProtein, 2).ToString() + " g";
            lblCaloriesLeft.Text = Math.Round((double)(user.LimitOfCalories - user.DailyCalories), 2).ToString() + " kcal";
            lblFatLeft.Text = Math.Round((double)(user.LimitOfFat - user.DailyFat), 2).ToString() + " g";
            lblProteinsLeft.Text = Math.Round((double)(user.LimitOfProtein - user.DailyProtein), 2).ToString() + " g";
            lblCarbsLeft.Text = Math.Round((double)(user.LimitOfCarbonhydrate - user.DailyCarbonhydrate), 2).ToString() + " g";
            prgbCalorieCounter.Percentage = (int)(user.DailyCalories * 100 / user.LimitOfCalories);
            prgbCarbonhyrateCounter.Percentage = (int)(user.DailyCarbonhydrate * 100 / user.LimitOfCarbonhydrate);
            prgbFatCounter.Percentage = (int)(user.DailyFat * 100 / user.LimitOfFat);
            prgbProteinCounter.Percentage = (int)(user.DailyProtein * 100 / user.LimitOfProtein);

            if (FormOpening.isDarkMode)
            {
                prgbCalorieCounter.UnFilledColor = Color.White;
                prgbCarbonhyrateCounter.UnFilledColor = Color.White;
                prgbFatCounter.UnFilledColor = Color.White;
                prgbProteinCounter.UnFilledColor = Color.White;
            }

            else if (!FormOpening.isDarkMode)
            {
                prgbCalorieCounter.UnFilledColor = Color.FromArgb(10, 39, 74);
                prgbCarbonhyrateCounter.UnFilledColor = Color.FromArgb(10, 39, 74);
                prgbFatCounter.UnFilledColor = Color.FromArgb(10, 39, 74);
                prgbProteinCounter.UnFilledColor = Color.FromArgb(10, 39, 74);
            }
        }
    }
}
