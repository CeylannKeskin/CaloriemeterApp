using CalorieTracker_BLL;
using CalorieTracker_PL.Methods;
using KaloriTakipUygulamasi_DAL;
using ReaLTaiizor.Controls;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Windows.Forms.DataVisualization.Charting;
using static ReaLTaiizor.Drawing.Poison.PoisonPaint;

namespace CalorieTracker_PL
{
    public partial class FormAnalyse : Form
    {
        BusinessLayer bll;
        KTUContext db;
        int calendarCounter = 1;
        public FormAnalyse()
        {
            InitializeComponent();
            bll = new BusinessLayer();
            db = new KTUContext();
        }

        private void FormAnalyse_Load(object sender, EventArgs e)
        {
            if (FormOpening.isDarkMode)
            {
                this.BackColor = Color.FromArgb(10, 39, 74);
                mcPickDate.BackColor = Color.FromArgb(10, 39, 74);
                mcPickDate.ForeColor = Color.White;
            }

            else if (!FormOpening.isDarkMode)
            {
                this.BackColor = Color.White;
                mcPickDate.BackColor = Color.White;
                mcPickDate.ForeColor = Color.Black;
            }

            Method.DarkMode(this, FormOpening.isDarkMode);

            // Verileri tutmak için listeler oluşturun
            List<DateTime> dates = new List<DateTime>();
            List<double> totalCalories = new List<double>();
            List<double> proteinValues = new List<double>();
            List<double> fatValues = new List<double>();
            List<double> carbohydrateValues = new List<double>();

            // Verileri veritabanından alın
            var userFoods = db.UserFoods.Where(x => x.AccountID == FormLogin.account.AccountID).ToList();

            // Verileri tarihlerine göre gruplayın
            var groupedUserFoods = userFoods.OrderBy(x => x.AddedTime.Value.Date).GroupBy(x => x.AddedTime.Value.Date);

            foreach (var group in groupedUserFoods)
            {
                dates.Add(group.Key);
                totalCalories.Add(group.Sum(x => x.Calorie.Value));
                proteinValues.Add(group.Sum(x => x.Protein.Value));
                fatValues.Add(group.Sum(x => x.Fat.Value));
                carbohydrateValues.Add(group.Sum(x => x.Carbonhydrate.Value));
            }

            // İlk Chart kontrolünü veriyle güncelleyin (sadece kalori değerleri)
            chart1.Series.Clear();
            chart1.Series.Add("Total Calories");
            chart1.Series["Total Calories"].ChartType = SeriesChartType.Line;
            for (int i = 0; i < dates.Count; i++)
            {
                chart1.Series["Total Calories"].Points.AddXY(dates[i], totalCalories[i]);
            }

            // İkinci Chart kontrolünü veriyle güncelleyin (protein, yağ ve karbonhidrat değerleri)
            chart2.Series.Clear();
            chart2.Series.Add("Protein");
            chart2.Series["Protein"].ChartType = SeriesChartType.Line;
            for (int i = 0; i < dates.Count; i++)
            {
                chart2.Series["Protein"].Points.AddXY(dates[i], proteinValues[i]);
            }

            chart2.Series.Add("Fat");
            chart2.Series["Fat"].ChartType = SeriesChartType.Line;
            for (int i = 0; i < dates.Count; i++)
            {
                chart2.Series["Fat"].Points.AddXY(dates[i], fatValues[i]);
            }

            chart2.Series.Add("Carbohydrate");
            chart2.Series["Carbohydrate"].ChartType = SeriesChartType.Line;
            for (int i = 0; i < dates.Count; i++)
            {
                chart2.Series["Carbohydrate"].Points.AddXY(dates[i], carbohydrateValues[i]);
            }
        }

        private void btnCalendar_Click(object sender, EventArgs e)
        {
            if (calendarCounter % 2 == 0)
            {
                mcPickDate.Visible = false;
                calendarCounter++;
            }

            else if (calendarCounter % 2 == 1)
            {
                mcPickDate.Visible = true;
                calendarCounter++;
            }

            mcPickDate.BringToFront();
        }
    }
}
