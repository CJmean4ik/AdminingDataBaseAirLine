using AdminingDataBaseAirLine.Forms.ButtonSettings;
using AdminingDataBaseAirLine.Properties;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AdminingDataBaseAirLine.Forms
{
    internal class CashierFormTheme
    {       
        public static void ChangeCashierFormTheme(ref bool _ligthMode,CashierForm cashierForm,Dictionary<string,ButtonProperty> _buttonResourse)
        {
            if (_ligthMode)
            {
                cashierForm.BackColor = Color.FromArgb(20, 21, 23);
                cashierForm.BackPanel_P.BackColor = Color.FromArgb(30, 31, 36);
                cashierForm.Panel_P.BackColor = Color.FromArgb(30, 31, 36);
                cashierForm.ThemeButton_P.BackColor = Color.FromArgb(30, 31, 36);
                cashierForm.ThemeButton_P.Image = Resources.night_mode;

                foreach (var item in _buttonResourse)
                {
                    item.Value.Button.BackColor = Color.FromArgb(30, 31, 36);
                    item.Value.Button.ForeColor = Color.FromArgb(80, 81, 249);
                    item.Value.Button.Image = item.Value.DarkImage;
                }

                _ligthMode = false;
                return;
            }
            if (!_ligthMode)
            {
                cashierForm.BackColor  = Color.FromName("Control");
                cashierForm.BackPanel_P.BackColor = Color.FromArgb(10, 126, 245);
                cashierForm.Panel_P.BackColor = Color.FromArgb(10, 126, 245);
                cashierForm.ThemeButton_P.BackColor = Color.FromArgb(10, 126, 245);

                cashierForm.ThemeButton_P.Image = Resources.lightmode;

                foreach (var item in _buttonResourse)
                {
                    item.Value.Button.BackColor = Color.FromArgb(10, 126, 245);
                    item.Value.Button.ForeColor = Color.FromName("Control");
                    item.Value.Button.Image = item.Value.WhiteImage;
                }

                _ligthMode = true;
                return;
            }
        }
    }
}
