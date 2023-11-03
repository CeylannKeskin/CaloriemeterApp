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
    public partial class FormForgotPassword : Form
    {
        public FormForgotPassword()
        {
            InitializeComponent();
        }

        private void FormForgotPassword_Load(object sender, EventArgs e)
        {
            Method.DarkMode(this, FormOpening.isDarkMode);
        }

        private void btnSendPassword_Click(object sender, EventArgs e)
        {
            BusinessLayer bll = new BusinessLayer();
            Random rnd = new Random();
            string newPassword;

            newPassword = (Convert.ToChar(rnd.Next(65, 90))).ToString() + (Convert.ToChar(rnd.Next(97, 122))).ToString() + rnd.Next(100000, 1000000).ToString();
            Account account = bll.Accounts.Search(txtEmail.Text);
            if (account != null)
            {
                if (!Method.SendPassword(txtEmail.Text, newPassword))
                {
                    MessageBox.Show("You have entered an incorrect email.");
                }
                else
                {
                    account.Password = Method.SecretPassword(newPassword);
                    bll.Accounts.Update(account);
                    this.Close();
                }
            }
            else MessageBox.Show("You have entered an incorrect email.");
        }
    }
}
