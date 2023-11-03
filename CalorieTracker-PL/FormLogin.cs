using CalorieTracker_BLL;
using Entities.Concrete;
using KaloriTakipUygulamasi_DAL;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Security.Principal;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using CalorieTracker_PL.Methods;
using Timer = System.Windows.Forms.Timer;

namespace CalorieTracker_PL
{
    public partial class FormLogin : Form
    {
        int pictureBoxCounter = 0;
        BusinessLayer bll;
        public static Account account;
        public static User user;
        public static bool isLoggedIn = false;

        public FormLogin()
        {
            InitializeComponent();
            bll = new BusinessLayer();
        }

        private void FormLogin_Load(object sender, EventArgs e)
        {
            Method.DarkMode(this, FormOpening.isDarkMode);

            txtPassword.UseSystemPasswordChar = true;
        }

        private void btnLogin_Click(object sender, EventArgs e)
        {
            bool controlUserNamePassword = false;
            Timer loginTimer = new Timer();

            if (!string.IsNullOrEmpty(txtEmail.Text) || !string.IsNullOrEmpty(txtPassword.Text))
            {
                account = bll.Accounts.Search(txtEmail.Text);
                user = bll.Users.Search(account.AccountID.ToString());

                if (account != null)
                {
                    if (account.Email == txtEmail.Text && account.Password == Method.SecretPassword(txtPassword.Text))
                    {
                        ShowDialog showDialog = new ShowDialog();
                        foreach (Label label in showDialog.Controls)
                        {
                            if (label.Name == "lblDialogText")
                            {
                                label.Text = "Logged in succesfully";
                                isLoggedIn = true;

                                // Kullanıcının günlük verisini sıfırlar

                                foreach (var item in user.UserFoods) 
                                {
                                    if (item.AddedTime.Value.Year != DateTime.Now.Year && item.AddedTime.Value.Month != DateTime.Now.Month && item.AddedTime.Value.Day != DateTime.Now.Day)
                                    {
                                        user.DailyCalories = 0;
                                        user.DailyCarbonhydrate = 0;
                                        user.DailyFat = 0;
                                        user.DailyProtein = 0;
                                    }
                                }
                            }

                            if (account.AccountID > 0)
                            {
                                this.Close();
                            }
                        }

                        showDialog.ShowDialog();
                    }

                    else
                    {
                        MessageBox.Show("Invalid email or password", "Login", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    }
                }

                else if (account == null)
                {
                    MessageBox.Show("There is not any user belonging to this e-mail adress");
                }
            }
        }

        private void pbShowHidePassword_Click(object sender, EventArgs e)
        {
            Image showPassword = Image.FromFile("../../../images/uiicons/show.png");
            Image hidePassword = Image.FromFile("../../../images/uiicons/hide.png");
            pictureBoxCounter++;

            if (pictureBoxCounter % 2 == 1)
            {
                pbShowHidePassword.Image = showPassword;
                txtPassword.UseSystemPasswordChar = false;
            }

            else if (pictureBoxCounter % 2 == 0)
            {
                pbShowHidePassword.Image = hidePassword;
                txtPassword.UseSystemPasswordChar = true;
            }
        }

        private void btnForgotPassword_Click(object sender, EventArgs e)
        {
            FormForgotPassword formForgotPassword = new FormForgotPassword();
            this.Close();
            formForgotPassword.ShowDialog();

        }
    }
}
