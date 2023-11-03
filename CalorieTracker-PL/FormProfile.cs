using CalorieTracker_BLL;
using CalorieTracker_PL.Methods;
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
    public partial class FormProfile : Form
    {
        int pictureBoxCounter = 0;
        BusinessLayer bll;

        public FormProfile()
        {
            InitializeComponent();
            bll = new BusinessLayer();
        }

        private void FormProfile_Load(object sender, EventArgs e)
        {
            User user = BusinessLayer.db.Users.FirstOrDefault(x => x.AccountID == FormLogin.account.AccountID);
            Method.DarkMode(this, FormOpening.isDarkMode);

            txtCurrentPassword.UseSystemPasswordChar = txtEnterNewPassword.UseSystemPasswordChar = txtReEnterNewPassword.UseSystemPasswordChar = true;

            txtFirstName.Text = FormLogin.account.FirstName;
            txtLastName.Text = FormLogin.account.LastName;
            txtEmail.Text = FormLogin.account.Email;
            txtCountry.Text = FormLogin.account.Country;
            txtCity.Text = FormLogin.account.City;

            if (user.Height == null)
            {
                nudHeight.Value = 0;
            }

            else if (user.Height > 0)
            {
                nudHeight.Value = (decimal)user.Height;
            }

            if (user.Weight == null)
            {
                nudWeight.Value = 0;
            }

            else if (user.Height > 0)
            {
                nudWeight.Value = (decimal)user.Weight;
            }

            dtBirthDate.Value = FormLogin.account.BirthDate;

            FormLogin.account.User = user;
        }

        private void pbShowHidePassword_Click(object sender, EventArgs e)
        {
            Image showPassword = Image.FromFile("../../../images/uiicons/show.png");
            Image hidePassword = Image.FromFile("../../../images/uiicons/hide.png");
            pictureBoxCounter++;

            if (pictureBoxCounter % 2 == 1)
            {
                pbShowHidePassword.Image = showPassword;
                txtCurrentPassword.UseSystemPasswordChar = txtEnterNewPassword.UseSystemPasswordChar = txtReEnterNewPassword.UseSystemPasswordChar = false;
            }

            else if (pictureBoxCounter % 2 == 0)
            {
                pbShowHidePassword.Image = hidePassword;
                txtCurrentPassword.UseSystemPasswordChar = txtEnterNewPassword.UseSystemPasswordChar = txtReEnterNewPassword.UseSystemPasswordChar = true;
            }
        }

        private void btnSaveChanges_Click(object sender, EventArgs e)
        {
            if (!string.IsNullOrEmpty(txtEmail.Text) &&
                !string.IsNullOrEmpty(txtCity.Text) &&
                !string.IsNullOrEmpty(txtCountry.Text) &&
                !string.IsNullOrEmpty(txtFirstName.Text) &&
                !string.IsNullOrEmpty(txtLastName.Text) &&
                Method.IsEmailValid(txtEmail.Text.Trim()))
            {
                FormLogin.account.FirstName = txtFirstName.Text;
                FormLogin.account.LastName = txtLastName.Text;
                FormLogin.account.Email = txtEmail.Text;
                FormLogin.account.City = txtCity.Text;
                FormLogin.account.Country = txtCountry.Text;
                FormLogin.account.User.Height = (double)nudHeight.Value;
                FormLogin.account.User.Weight = (double)nudWeight.Value;
                FormLogin.account.BirthDate = dtBirthDate.Value;
                FormLogin.account.User.UserBMI = Method.CalculateBMI((double)nudHeight.Value, (double)nudWeight.Value);
                FormLogin.account.User.BMIStatus = Method.CalculateBMIStatu((double)FormLogin.account.User.UserBMI, FormLogin.account.User);
                FormLogin.account.Age = DateTime.Now.Year - FormLogin.account.BirthDate.Year;
                FormLogin.account.User.BMR = Method.CalculateBMR((double)FormLogin.account.User.Height, (double)FormLogin.account.User.Weight, FormLogin.account.Gender, (int)FormLogin.account.Age);
                FormLogin.account.User.LimitOfCalories = FormLogin.account.User.BMR;
                FormLogin.account.User.LimitOfCarbonhydrate = (FormLogin.account.User.LimitOfCalories * 0.6) / 4;
                FormLogin.account.User.LimitOfFat = (FormLogin.account.User.LimitOfCalories * 0.25) / 9;
                FormLogin.account.User.LimitOfProtein = (FormLogin.account.User.LimitOfCalories * 0.15) / 4;

                bll.Users.Update(FormLogin.account.User);
                bll.Accounts.Update(FormLogin.account);

            }

            else if (!Method.IsEmailValid(txtEmail.Text.Trim()))
            {
                MessageBox.Show("The e-mail address you entered is not valid.", "Save Changes", MessageBoxButtons.OK, MessageBoxIcon.Stop);
            }

            else
            {
                MessageBox.Show("You must fill in all the required information", "Save Changes", MessageBoxButtons.OK, MessageBoxIcon.Stop);
            }

            bll.Accounts.Update(FormLogin.account);
            bll.Users.Update(FormLogin.account.User);
        }

        private void btnChangePassword_Click(object sender, EventArgs e)
        {
            if ((Method.SecretPassword(txtCurrentPassword.Text) == FormLogin.account.Password) && Method.PasswordControl(txtEnterNewPassword.Text) && Method.PasswordControl(txtReEnterNewPassword.Text) && txtEnterNewPassword.Text == txtReEnterNewPassword.Text)
            {
                FormLogin.account.Password = Method.SecretPassword(txtEnterNewPassword.Text);

                bll.Accounts.Update(FormLogin.account);

                ShowDialog showDialog = new ShowDialog();

                foreach (Label control in showDialog.Controls)
                {
                    if (control.Name == "lblDialogText")
                    {
                        control.Text = "Password succesfully changed";
                    }
                }

                showDialog.ShowDialog();
            }

            else if (!(Method.SecretPassword(txtCurrentPassword.Text) == FormLogin.account.Password))
            {
                MessageBox.Show("Your current password has not matched", "Change Password", MessageBoxButtons.OK, MessageBoxIcon.Stop);
            }

            else if (!Method.PasswordControl(txtEnterNewPassword.Text) || !Method.PasswordControl(txtReEnterNewPassword.Text))
            {
                MessageBox.Show("The password you have entered is not in valid format", "Change Password", MessageBoxButtons.OK, MessageBoxIcon.Stop);
            }

            else if (txtEnterNewPassword.Text != txtReEnterNewPassword.Text)
            {
                MessageBox.Show("The passwords you have entered do not match", "Change Password", MessageBoxButtons.OK, MessageBoxIcon.Stop);
            }
        }

        private void btnDeleteAccount_Click(object sender, EventArgs e)
        {
            DialogResult dr = new DialogResult();

            dr = MessageBox.Show("Are you sure?", "Delete Account", MessageBoxButtons.YesNo, MessageBoxIcon.Question);

            if (dr == DialogResult.Yes)
            {
                bll.Accounts.Delete(FormLogin.account);

                ShowDialog showDialog = new ShowDialog();

                foreach (Label control in showDialog.Controls)
                {
                    if (control.Name == "lblDialogText")
                    {
                        control.Text = "Your account has been deactivated. If you log in again within 30 days, you can activate it again. Otherwise, your account will be permanently deleted.";
                    }
                }

                showDialog.ShowDialog();

                FormLogin.isLoggedIn = false;
            }

            MdiParent.Close();
        }
    }
}
