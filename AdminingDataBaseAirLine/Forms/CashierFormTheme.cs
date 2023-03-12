using AdminingDataBaseAirLine.Forms.ButtonSettings;
using AdminingDataBaseAirLine.Properties;
using AdminingDataBaseAirLine.UserControls;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace AdminingDataBaseAirLine.Forms
{
    internal class CashierFormTheme
    {       
        public static void ChangeCashierFormTheme(ref bool _ligthMode,CashierForm cashierForm,Dictionary<string,ButtonProperty> _buttonResourse)
        {
            Color darkColorFirstView = Color.FromArgb(20, 21, 23);
            Color darkColorSecondView = Color.FromArgb(30, 31, 36);
            Color whiteColor = Color.FromName("Control");
            Color purpleColor = Color.FromArgb(80, 81, 249);
            Color blueColor = Color.FromArgb(10, 126, 245); 


            Image darkImage = Resources.night_mode;
            Image whiteImage = Resources.lightmode;

            ControlConfiguration configuration = cashierForm.GetConfiguration();

            if (_ligthMode)
            {
                cashierForm.BackColor = darkColorFirstView;
                cashierForm.BackPanel_P.BackColor = darkColorSecondView;
                cashierForm.Panel_P.BackColor = darkColorSecondView;
                cashierForm.ThemeButton_P.BackColor = darkColorSecondView;
                cashierForm.ThemeButton_P.Image = darkImage;
                cashierForm.CloseButton.BackColor = darkColorSecondView;
                cashierForm.CollapseButton.BackColor = darkColorSecondView;

                foreach (var item in _buttonResourse)
                {
                    if (item.Value.IsOpen)
                    {
                        item.Value.Button.BackColor = darkColorFirstView;
                        item.Value.Button.ForeColor = whiteColor;
                        item.Value.Button.Image = _buttonResourse[item.Key].WhiteImage;
                        continue;
                    }

                    item.Value.Button.BackColor = darkColorSecondView;
                    item.Value.Button.ForeColor = purpleColor;
                    item.Value.Button.Image = item.Value.DarkImage;               
                }             
                _ligthMode = false;
                return;
            }
            if (!_ligthMode)
            {
                cashierForm.BackColor  = whiteColor;
                cashierForm.BackPanel_P.BackColor = blueColor;
                cashierForm.Panel_P.BackColor = blueColor;
                cashierForm.ThemeButton_P.BackColor = blueColor;
                cashierForm.ThemeButton_P.Image = whiteImage;
                cashierForm.CloseButton.BackColor = blueColor;
                cashierForm.CollapseButton.BackColor = blueColor;

                foreach (var item in _buttonResourse)
                {
                    if (item.Value.IsOpen)
                    {
                        item.Value.Button.ForeColor = blueColor;
                        item.Value.Button.BackColor = whiteColor;
                        item.Value.Button.Image = _buttonResourse[item.Key].BlueImage;
                        continue;
                    }

                    item.Value.Button.BackColor = blueColor;
                    item.Value.Button.ForeColor = whiteColor;
                    item.Value.Button.Image = item.Value.WhiteImage;
                }


                _ligthMode = true;
                return;
            }
        }
    }
}
