using CalorieTracker_BLL;
using CalorieTracker_PL.Methods;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Security.AccessControl;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace CalorieTracker_PL
{
    public partial class FormActivation : Form
    {
        public FormActivation()
        {
            InitializeComponent();
        }
        public static bool isTrue = false;
        private void btnActivationCode_Click(object sender, EventArgs e)
        {
            if (txtActivationCode.Text == FormRegister.activationCode)
            {
                isTrue = true;
                this.Close();
            }
            else
            {
                MessageBox.Show("Wrong Activation Code.");
            }
        }

        private void FormActivation_Load(object sender, EventArgs e)
        {
            Method.DarkMode(this, FormOpening.isDarkMode);
        }
    }
}
