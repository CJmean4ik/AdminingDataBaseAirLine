using ABI.Windows.UI;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Color = System.Drawing.Color;

namespace AdminingDataBaseAirLine.Authentication
{
    internal class ValidationUserAccount
    {

        public static bool IsNotEmptyBoxField(TextBox textfield, ref string result)
        {
            if (textfield.Text != string.Empty || textfield.Text.Length >= 3 && textfield.Text.Length <= 30)
            {
                result = textfield.Text;
                return true;
            }
            return false;
        }

        public static void ErrorHandling(string systemEror,MainForm mainForm)
        {
            mainForm.LogInBtn1.Enabled = true;

            Color backRed = Color.FromArgb(226, 76, 75);
            if (systemEror == "account")
            {
                NameErorHandling(mainForm, backRed);
                return;
            }
            if (systemEror == "password")
            {
                PasswordErorHandling(mainForm, backRed);
                return;
            }
        }

        private static void NameErorHandling(MainForm mainForm, Color backRed)
        {
            mainForm.PanelName.BackColor = backRed;
            mainForm.PanelName2.BackColor = backRed;

            mainForm.NameMistake.ForeColor = backRed;
            mainForm.NameMistake.Text = "Невірне ім'я або \r\nтакого користувача не існує\r\n";
            mainForm.NameMistake.Visible = true;

            mainForm.UserNameBox1.ForeColor = backRed;
        }

        private static void PasswordErorHandling(MainForm mainForm, Color backRed)
        {
            mainForm.PanelPass.BackColor = backRed;
            mainForm.PanelPass2.BackColor = backRed;

            mainForm.PasswordMistake.ForeColor = backRed;        
            mainForm.PasswordMistake.Text = "Невірний пароль";
            mainForm.PasswordMistake.Visible = true;

            mainForm.PasswordBox1.ForeColor = backRed;
        }

        public static void EmptyFieldErorHandling(Label label)
        {
            label.Text = "Поле не повине бути пустим!";
            label.ForeColor = Color.FromArgb(226, 76, 75);
            label.Visible = true;
        }


    }
}
