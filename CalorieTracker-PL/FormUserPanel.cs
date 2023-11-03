using CalorieTracker_PL.Methods;
using Entities.Concrete;
using Entities.Enums;
using ReaLTaiizor.Controls;
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

namespace CalorieTracker_PL
{
    public partial class FormUserPanel : Form
    {
        public static bool isClosed = false;
        public FormUserPanel()
        {
            InitializeComponent();
        }

        private void FormUserPanel_Load(object sender, EventArgs e)
        {
            IsAdmin(FormLogin.account);

            if (FormOpening.isDarkMode == true)
            {
                Method.DarkMode(this, FormOpening.isDarkMode);

                if (this.IsMdiContainer == true)
                {
                    Controls.OfType<MdiClient>().FirstOrDefault().BackColor = Color.FromArgb(10, 39, 74);
                }
            }

            else if (FormOpening.isDarkMode == false)
            {
                Method.DarkMode(this, FormOpening.isDarkMode);

                if (this.IsMdiContainer == true)
                {
                    Controls.OfType<MdiClient>().FirstOrDefault().BackColor = Color.White;
                }
            }

            Image manBody = Image.FromFile("../../../images/manbody.png");
            Image womanBody = Image.FromFile("../../../images/womanbody.png");

            if (FormLogin.account.Gender == true)
            {
                pbLeftFrame.BackgroundImage = manBody;
            }

            else if (FormLogin.account.Gender == false)
            {
                pbLeftFrame.BackgroundImage = womanBody;
            }

            lblUserName.Text = $"Welcome {FormLogin.account.FirstName} {FormLogin.account.LastName}";
            lblUserAge.Text = $"{FormLogin.account.Age}";
            lblHeight.Text = $"{FormLogin.account.User.Height} cm";
            lblWeight.Text = $"{FormLogin.account.User.Weight} kg";
        }

        void ChildForm(Form childForm)
        {
            this.Width = childForm.Width;
            this.Height = childForm.Height;
            bool durum = false;
            lblUserName.Text = $"Welcome {FormLogin.account.FirstName} {FormLogin.account.LastName}";
            lblAge.Text = $"{FormLogin.account.Age}";
            lblHeight.Text = $"{FormLogin.account.User.Height} cm";
            lblWeight.Text = $"{FormLogin.account.User.Weight} kg";

            foreach (Form form in this.MdiChildren)
            {
                if (form.Text == childForm.Text)
                {
                    durum = true;
                    form.Activate();
                }

                else
                {
                    form.Close();
                }
            }

            childForm.FormClosed += (sender, e) =>
            {
                if (sender is DialogResult)
                {
                    this.Close();
                }
            };

            if (durum == false)
            {
                childForm.MdiParent = this;
                childForm.Dock = DockStyle.Fill;
                childForm.Show();
            }
        }

        private void btnHome_Click(object sender, EventArgs e)
        {
            ChildForm(new FormMainMenu());
        }

        private void btnLogin_Click(object sender, EventArgs e)
        {
            FormLogin.isLoggedIn = false;
            this.Close();
        }

        private void btnClose_Click(object sender, EventArgs e)
        {
            isClosed = true;
            FormLogin.isLoggedIn = false;
            Application.Exit();
        }

        private void btnAdd_Click(object sender, EventArgs e)
        {
            ChildForm(new FormAddMeal());
        }

        private void btnUserProfile_Click(object sender, EventArgs e)
        {
            ChildForm(new FormProfile());
        }

        private void btnAnalyse_Click(object sender, EventArgs e)
        {
            ChildForm(new FormAnalyse());
        }

        private void btnAdminPanel_Click(object sender, EventArgs e)
        {
            ChildForm(new FormAdminPanel());
        }

        private void btnCalculations_Click(object sender, EventArgs e)
        {
            ChildForm(new FormCalculations());
        }

        private void IsAdmin(Account account)
        {
            if (account.AccountType == AccountType.Admin)
            {
                btnAdminPanel.Visible = true;
            }

            else if (account.AccountType == AccountType.User)
            {
                btnAdminPanel.Visible = false;
            }
        }

        
    }
}
