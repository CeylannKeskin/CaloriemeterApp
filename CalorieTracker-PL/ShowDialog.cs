using CalorieTracker_PL.Methods;
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
    public partial class ShowDialog : Form
    {
        FormOpening form1 = new FormOpening();
        int counter = 0;
        public ShowDialog()
        {
            InitializeComponent();
        }

        private void ShowDialog_Load(object sender, EventArgs e)
        {
            tmrShowDialog.Start();

            if (FormOpening.isDarkMode)
            {
                this.BackColor = Color.FromArgb(10, 39, 74);
                lblDialogText.ForeColor = Color.White;
            }

            else if (!FormOpening.isDarkMode)
            {
                this.BackColor = Color.White;
                lblDialogText.ForeColor = Color.Black;
            }
        }

        private void tmrShowDialog_Tick(object sender, EventArgs e)
        {
            counter++;

            if (counter >= 4)
            {
                tmrShowDialog.Stop();
                this.Close();
            }
        }
    }
}
