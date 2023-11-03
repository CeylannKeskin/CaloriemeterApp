using System;
using System.Collections.Generic;
using System.Linq;
using System.Net.Mail;
using System.Net;
using System.Text;
using System.Threading.Tasks;
using CalorieTracker_BLL;
using Entities.Concrete;
using System.Runtime.CompilerServices;
using ReaLTaiizor.Controls;
using System.Windows.Forms;
using ReaLTaiizor.Extension;
using Button = System.Windows.Forms.Button;
using System.Security.Cryptography;
using Panel = System.Windows.Forms.Panel;
using Entities;
using Entities.Enums;
using System.ComponentModel.DataAnnotations;
using System.Reflection;

namespace CalorieTracker_PL.Methods
{
    public static class Method
    {
        #region değişkenler
        static int digitCounter = 0; //Şifredeki rakam sayısı
        static int letterCounter = 0; //Şifredeki harf sayısı
        static int upperLetterCounter = 0; //Şifredeki büyük harf sayısı
        static int lowerLetterCounter = 0; //Şifredeki küçük harf sayısı
        static bool isCorrect = false; //Şifrenin şartlara uyup uymadığını kontrol ettiğimiz değişken
        static BusinessLayer bll = new BusinessLayer();
        #endregion

        public static void SendEmail(string email, string activationCode) //Aktivasyon kodunu gönderdiğimiz metot
        {
            using (MailMessage mail = new MailMessage())
            {
                mail.From = new MailAddress("yazilimbarcode@gmail.com", "BarCode Yazılım A.Ş.");
                mail.To.Add(email);
                mail.Subject = "Activation Code";
                mail.Body = $"<h1>Activation Code={activationCode}</h1>";
                mail.IsBodyHtml = true;


                using (SmtpClient smtp = new SmtpClient("smtp.gmail.com", 587))
                {
                    smtp.Credentials = new NetworkCredential("yazilimbarcode@gmail.com", "wgremulymsskmswk");
                    smtp.UseDefaultCredentials = false;
                    smtp.EnableSsl = true;
                    smtp.Send(mail);
                }
                MessageBox.Show($"Activation code has been sent to {email} mail. After entering the activation code, your registration will be completed.", "Success!", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
        }
        public static bool PasswordControl(string password) //Şifreyi kontrol ettiğimiz metot
        {
            foreach (char c in password)
            {
                if (char.IsLetterOrDigit(c)) //Girilen şifrenin sadece harf ve sayılardan oluşup oluşmadığını kontrol ediyoruz.
                {
                    if (char.IsLetter(c)) //1 büyük harf,1 küçük harf ve 1 sayıdan oluşup oluşmadığını kontrol ediyoruz.
                    {
                        letterCounter++;
                        if (char.IsUpper(c))
                        {
                            upperLetterCounter++;
                        }
                        else
                            lowerLetterCounter++;

                    }
                    else digitCounter++;
                }
                else
                {
                    MessageBox.Show("Oluşturduğunuz şifre sadece harf ve sayılardan oluşmalıdır.");
                }
            }
            if (password.Length > 12 || password.Length < 8) //Girilen şifrenin 8-12 karakter uzunluğunda olup olmadığını kontrol ediyoruz.
            {
                MessageBox.Show("Oluşturduğunuz şifre en az 8, en fazla 12 karakterden oluşmalıdır.");
                isCorrect = false;
                return isCorrect;

            }
            else if ((lowerLetterCounter == 0 || upperLetterCounter == 0) || (digitCounter == 0 || letterCounter == 0))
            {
                MessageBox.Show("Oluşturmak istediğiniz şifre en az 1 küçük harf, 1 büyük harf ve 1 sayı içermelidir.");
                isCorrect = false;
                return isCorrect;
            }
            else
            {
                isCorrect = true;
                return isCorrect;
            }
        }
        public static bool SendPassword(string email, string newPassword) //Yeni şifre gönderdiğimiz metot
        {
            try
            {
                using (MailMessage mail = new MailMessage())
                {
                    mail.From = new MailAddress("yazilimbarcode@gmail.com", "BarCode Yazılım A.Ş.");
                    mail.To.Add(email);
                    mail.Subject = "New Password";
                    mail.Body = $"<h1>New Password={newPassword}</h1>";
                    mail.IsBodyHtml = true;


                    using (SmtpClient smtp = new SmtpClient("smtp.gmail.com", 587))
                    {
                        smtp.Credentials = new NetworkCredential("yazilimbarcode@gmail.com", "wgremulymsskmswk");
                        smtp.UseDefaultCredentials = false;
                        smtp.EnableSsl = true;
                        smtp.Send(mail);
                    }
                    MessageBox.Show($"New password has been sent to {email}.", "Success!", MessageBoxButtons.OK, MessageBoxIcon.Information);
                }
                return isCorrect = true;
            }
            catch (Exception)
            {
                return isCorrect = false;
            }

        }
        public static string SecretPassword(string password) //Girilen şifreyi database'e hash code olarak gönderdiğimiz metot
        {
            SHA1 sha = new SHA1CryptoServiceProvider();
            string passwordWithHashCode = Convert.ToBase64String(sha.ComputeHash(Encoding.UTF8.GetBytes(password)));
            return passwordWithHashCode;
        }
        public static bool MailControl(string email) //Mailin database'de kayıtlı olup olmadığını kontrol ediyoruz.
        {
            Account account = bll.Accounts.Search(email);
            if (account == null)
            {
                isCorrect = true;
                return isCorrect;
            }
            else
            {
                MessageBox.Show("Bu maile ait bir kullanıcı mevcuttur.");
                isCorrect = false;
                return isCorrect;
            }
        } 
        public static void DarkMode(Control container, bool isDarkMode) //Karanlık mod metodu
        {
            if (isDarkMode)
            {
                container.BackColor = Color.FromArgb(10, 39, 74);

                foreach (Control control in container.Controls)
                {
                    if (control is Button)
                    {
                        control.BackColor = Color.FromArgb(10, 39, 74);
                        control.ForeColor = Color.White;
                    }

                    else if (control is Label)
                    {
                        control.BackColor = Color.FromArgb(10, 39, 74);
                        control.ForeColor = Color.White;
                    }

                    else if (control is PictureBox)
                    {
                        control.BackColor = Color.FromArgb(10, 39, 74);
                    }

                    else if (control is Panel)
                    {
                        control.BackColor = Color.FromArgb(10, 39, 74);

                        foreach (Control grpControl in control.Controls)
                        {
                            if (grpControl is Button)
                            {
                                grpControl.BackColor = Color.FromArgb(10, 39, 74);
                                grpControl.ForeColor = Color.White;
                            }

                            else if (grpControl is Label)
                            {
                                grpControl.BackColor = Color.FromArgb(10, 39, 74);
                                grpControl.ForeColor = Color.White;
                            }

                            else if (grpControl is PictureBox)
                            {
                                grpControl.BackColor = Color.FromArgb(10, 39, 74);
                            }
                        }
                    }
                }
            }

            else if (!isDarkMode)
            {
                container.BackColor = Color.White;

                foreach (Control control in container.Controls)
                {
                    if (control is Button)
                    {
                        control.BackColor = Color.White;
                        control.ForeColor = Color.Black;
                    }

                    else if (control is Label)
                    {
                        control.BackColor = Color.White;
                        control.ForeColor = Color.Black;
                    }

                    else if (control is PictureBox)
                    {
                        control.BackColor = Color.White;
                    }

                    else if (control is Panel)
                    {
                        control.BackColor = Color.White;

                        foreach (Control grpControl in control.Controls)
                        {
                            if (grpControl is Button)
                            {
                                grpControl.BackColor = Color.White;
                                grpControl.ForeColor = Color.Black;
                            }

                            else if (grpControl is Label)
                            {
                                grpControl.BackColor = Color.White;
                                grpControl.ForeColor = Color.Black;
                            }

                            else if (grpControl is PictureBox)
                            {
                                grpControl.BackColor = Color.White;
                            }
                        }
                    }
                }
            }
        } 
        public static bool IsEmailValid(string email)
        {
            try
            {
                MailAddress mailAddress = new MailAddress(email);
                return true;
            }
            catch (FormatException)
            {
                return false;
            }
        }
        public static double CalculateBMI(double Height, double Weight) //Vücut kitle indeksini hesaplattığımız metot
        {
            double mHeight = Height / 100;
            double BMI = Weight / (mHeight * mHeight);
            return BMI;
        }
        public static double CalculateBMR(double Height, double Weight, bool Gender, int Yas) //Bazal Metobalik hızı hesaplattığımız metot
        {
            double BMR;
            if (Gender)
            {
                return BMR = 66.5 + (13.75 * Weight) + (5 * Height) - (6.77 * Yas);
            }
            else
            {
                return BMR = 655.1 + (9.56 * Weight) + (1.85 * Height) - (4.67 * Yas);
            }
        }
        public static BMIStatus CalculateBMIStatu(double BMI, User user) //BMI statüsünü belirlediğimiz metot
        {
            if (BMI < 18.5)
            {
                user.BMIStatus = Entities.BMIStatus.Underweight;
            }
            else if (18.5 <= BMI && BMI < 25)
            {
                user.BMIStatus = Entities.BMIStatus.Normal;
            }
            else if (25 <= BMI && BMI < 30)
            {
                user.BMIStatus = Entities.BMIStatus.Overweight;
            }
            else if (30 >= BMI) { user.BMIStatus = Entities.BMIStatus.Obesity; }
            return (BMIStatus)user.BMIStatus;
        }
        public static void ClearControls(Control container)
        {
            foreach(Control control in container.Controls)
            {
                if (control is TextBox)
                {
                    control.Text = string.Empty;
                }

                else if (control is NumericUpDown)
                {
                    ((NumericUpDown)control).Value = 1;
                }

                else if (control is DataGridView)
                {
                    ((DataGridView)control).SelectedRows.Clear();
                }
            }
        }
        public static List<Food> SearchFoodsByName(string searchName)
        {
            return BusinessLayer.db.Foods.Where(f => f.FoodName.ToLower().Contains(searchName.ToLower())).ToList();
        }
        public static string GetActivityStatusDisplayName(ActivityStatus status)
        {
            switch (status)
            {
                case ActivityStatus.NotActive:
                    return "No Active";
                case ActivityStatus.LessActive:
                    return "Less Active";
                case ActivityStatus.NormalActive:
                    return "Normal Active";
                case ActivityStatus.VeryActive:
                    return "Very Active";
                default:
                    return status.ToString();
            }
        }
        public static string GetDisplayName(this Enum enumValue)
        {
            return enumValue.GetType().GetMember(enumValue.ToString()).First().GetCustomAttribute<DisplayAttribute>()?.GetName();
        }
        public static object GetEnumDisplayName(ActivityStatus value)
        {
            var fieldinfo = value.GetType().GetField(value.ToString());
            var attribute = fieldinfo.GetCustomAttributes(typeof(DisplayAttribute), false).Cast<DisplayAttribute>().FirstOrDefault();
            return attribute?.Name ?? value.ToString();
        }
    }
}
