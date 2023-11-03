using Microsoft.EntityFrameworkCore.ChangeTracking.Internal;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Net;
using System.Net.Mail;
using CalorieTracker_BLL;
using Entities.Concrete;
using CalorieTracker_PL.Methods;
using Entities;
using Entities.Enums;

namespace CalorieTracker_PL
{
    public partial class FormRegister : Form
    {
        private ToolTip toolTip;
        int pictureBoxCounter = 0;
        BusinessLayer bll = new BusinessLayer();
        Random rnd = new Random();
        public static string activationCode;  //Maile gönderdiğimiz aktivasyon kodu
                                              //Aktivasyon kodu onaylandıktan sonra oluşacak hesap

        public FormRegister()
        {
            InitializeComponent();
        }

        private void RegisterForm_Load(object sender, EventArgs e)
        {
            txtPassword.UseSystemPasswordChar = txtAgainPassword.UseSystemPasswordChar = true;
            toolTip = new ToolTip();
            pbPasswordRules.MouseEnter += pbPasswordRules_MouseEnter;
            pbPasswordRules.MouseLeave += pbPasswordRules_MouseLeave;
            Method.DarkMode(this, FormOpening.isDarkMode);
        }

        private void pbPasswordRules_MouseLeave(object? sender, EventArgs e)
        {
            toolTip.SetToolTip(pbPasswordRules, null);
        }

        private void pbPasswordRules_MouseEnter(object? sender, EventArgs e)
        {
            string toolTipText = "Password has to contains 8-12 characters.\nPassword has to contains an upper case, a lower case and a number.\nPassword hasn't to contains special characters.";
            toolTip.SetToolTip(pbPasswordRules, toolTipText);
        }

        private void btnSendActivationCode_Click(object sender, EventArgs e)
        {
            if (!string.IsNullOrEmpty(txtEmail.Text) &&
                !string.IsNullOrEmpty(txtPassword.Text) &&
                !string.IsNullOrEmpty(txtAgainPassword.Text) &&
                !string.IsNullOrEmpty(txtCity.Text) &&
                !string.IsNullOrEmpty(txtCountry.Text) &&
                !string.IsNullOrEmpty(txtFirstName.Text) &&
                !string.IsNullOrEmpty(txtLastName.Text)) //Boş alan var mı kontrolü
            {

                foreach (Control control in this.Controls) //Kırmızı olan boş alanları tekrar beyaza çevirmek için yapılan döngü
                {
                    if (control is TextBox)
                    {
                        control.BackColor = Color.White;
                    }
                }
                if (txtPassword.Text == txtAgainPassword.Text) //Şifreleri karşılaştırma yapmak için kullanılan koşul
                {
                    txtPassword.BackColor = Color.White;
                    txtAgainPassword.BackColor = Color.White;
                    if (Method.PasswordControl(txtPassword.Text) &&
                        Method.MailControl(txtEmail.Text)) //Eğer herşey doğruysa ve şifre şartlara uygunsa belirtilen emaile mail gönderiliyor.
                    {
                        activationCode = rnd.Next(1000, 9999).ToString(); //4 haneli aktivasyon kodu
                        Method.SendEmail(txtEmail.Text, activationCode); //Methods klasöründeki methods classındaki SendEmail metodu
                        FormActivation activationForm = new FormActivation(); //aktivasyon formu
                        activationForm.ShowDialog();
                        if (FormActivation.isTrue)
                        {
                            Account account = new Account
                            {
                                FirstName = txtFirstName.Text,
                                LastName = txtLastName.Text,
                                Email = txtEmail.Text,
                                Password = Method.SecretPassword(txtPassword.Text),
                                Gender = rdoMale.Checked ? true : false,
                                City = txtCity.Text,
                                Country = txtCountry.Text,
                                BirthDate = dtpBirthDate.Value,
                                Age = DateTime.Now.Year - dtpBirthDate.Value.Year,
                                IsActive = true,
                                UpdatedTime = DateTime.Now,
                                AccountType = AccountType.User
                            };
                            bll.Accounts.Create(account);

                            User user = new User
                            {
                                AccountID = account.AccountID,
                                Height = 0,
                                Weight = 0,
                                UserBMI = 0,
                                BMIStatus = BMIStatus.Normal
                            };
                            bll.Users.Create(user);

                            MessageBox.Show("Registered succesfully");
                            this.Close();
                        }

                        else
                        {
                            MessageBox.Show("Please enter your activation code");
                        }
                    }

                    else
                    {
                        MessageBox.Show("Please check information you have entered");
                    }
                }

                else
                {
                    txtPassword.BackColor = Color.Red; //Şifreler uyuşmaz ise textboxları kırmızıya dönüyor.
                    txtAgainPassword.BackColor = Color.Red;
                    MessageBox.Show("Passwords don't match");
                }
            }

            else
            {
                foreach (Control control in this.Controls)
                {
                    if (control is TextBox)
                    {
                        control.BackColor = Color.Red; //doldurulmayan alanlar kırmızıya dönüyor.
                    }
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
    }
}
