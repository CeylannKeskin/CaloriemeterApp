using CalorieTracker_BLL;
using CalorieTracker_PL.Methods;
using Entities.Concrete;
using KaloriTakipUygulamasi_DAL;
using ReaLTaiizor.Controls;
using System.ComponentModel;
using Button = ReaLTaiizor.Controls.Button;
using CheckBox = System.Windows.Forms.CheckBox;

namespace CalorieTracker_PL
{
    public partial class FormOpening : Form
    {
        public static bool isSwitchChecked;
        KTUContext db;
        public static bool isDarkMode = false;
        public FormOpening()
        {
            InitializeComponent();
            db = new KTUContext();
        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private void btnLogin_Click(object sender, EventArgs e)
        {
            FormLogin formLogin = new FormLogin();

            btnClose.Visible = false;
            btnMinimize.Visible = false;

            formLogin.ShowDialog();
            if (FormLogin.isLoggedIn == true)
            {
                this.Close();
            }

            btnClose.Visible = true;
            btnMinimize.Visible = true;
            formLogin.Location = new Point(this.Location.X + 150, this.Location.Y + 30);
        }

        private void btnRegister_Click(object sender, EventArgs e)
        {
            FormRegister formRegister = new FormRegister();

            btnClose.Visible = false;
            btnMinimize.Visible = false;

            formRegister.ShowDialog();
            btnClose.Visible = true;
            btnMinimize.Visible = true;

            formRegister.Location = new Point(this.Location.X + 150, this.Location.Y + 30);
        }

        private void swcDarkMode_CheckedChanged()
        {
            if (swcDarkMode.Checked == true)
            {
                isSwitchChecked = true;
                isDarkMode = true;
                Method.DarkMode(this, isDarkMode);
            }

            else if (swcDarkMode.Checked == false)
            {
                isSwitchChecked = false;
                isDarkMode = false;
                Method.DarkMode(this, isDarkMode);
            }
        }
    }
}