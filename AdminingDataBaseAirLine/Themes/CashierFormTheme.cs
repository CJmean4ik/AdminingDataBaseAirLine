using AdminingDataBaseAirLine.Forms.CashierFormSetting;
using AdminingDataBaseAirLine.Forms.CashierFormSetting.ButtonSettings;
using AdminingDataBaseAirLine.Forms.CashierFormSetting.FormConfiguration;
using AdminingDataBaseAirLine.Properties;

namespace AdminingDataBaseAirLine.Themes
{
    internal class CashierFormTheme
    {
        private CashierForm cashierForm;
        private Dictionary<string, ButtonProperty> _buttonResourse;
        private CashierFormConfiguration _config;
        public CashierFormTheme(CashierForm cashierForm, Dictionary<string, ButtonProperty> buttonResourse,CashierFormConfiguration config)
        {
            this.cashierForm = cashierForm;
            _buttonResourse = buttonResourse;
            _config = config;
        }

        public void ChangeToDarkTheme(ref bool _ligthMode)
        {
            cashierForm.BackColor = _config.darkColorFirstView;
            cashierForm.BackPanel_P.BackColor = _config.darkColorSecondView;
            cashierForm.Panel_P.BackColor = _config.darkColorSecondView;
            cashierForm.ThemeButton_P.BackColor = _config.darkColorSecondView;
            cashierForm.ThemeButton_P.Image = Resources.dark_mode;
            cashierForm.CloseButton.BackColor = _config.darkColorSecondView;
            cashierForm.CollapseButton.BackColor = _config.darkColorSecondView;
           // cashierForm.FlowTicketPanel.BackColor = _config.darkColorSecondView;
           // cashierForm.TicketPanel.BackColor = _config.darkColorSecondView;


            foreach (var item in _buttonResourse)
            {
                if (item.Value.IsOpen)
                {
                    item.Value.Button.BackColor = _config.darkColorFirstView;
                    item.Value.Button.ForeColor = _config.whiteColor;
                    item.Value.Button.Image = _buttonResourse[item.Key].WhiteImage;
                    continue;
                }

                item.Value.Button.BackColor = _config.darkColorSecondView;
                item.Value.Button.ForeColor = _config.purpleColor;
                item.Value.Button.Image = item.Value.DarkImage;
            }
            _ligthMode = false;
            return;
        }
        public void ChangeToLightTheme(ref bool _ligthMode)
        {
            cashierForm.BackColor = _config.whiteColor;
            cashierForm.BackPanel_P.BackColor = _config.blueColor;
            cashierForm.Panel_P.BackColor = _config.blueColor;
            cashierForm.ThemeButton_P.BackColor = _config.blueColor;
            cashierForm.ThemeButton_P.Image = Resources.light_mode;
            cashierForm.CloseButton.BackColor = _config.blueColor;
            cashierForm.CollapseButton.BackColor = _config.blueColor;
            //cashierForm.FlowTicketPanel.BackColor = _config.whiteColor;
           // cashierForm.TicketPanel.BackColor = _config.whiteColor;
            foreach (var item in _buttonResourse)
            {
                if (item.Value.IsOpen)
                {
                    item.Value.Button.ForeColor = _config.blueColor;
                    item.Value.Button.BackColor = _config.whiteColor;
                    item.Value.Button.Image = _buttonResourse[item.Key].BlueImage;
                    continue;
                }

                item.Value.Button.BackColor = _config.blueColor;
                item.Value.Button.ForeColor = _config.whiteColor;
                item.Value.Button.Image = item.Value.WhiteImage;
            }
            _ligthMode = true;
            return;
        }
    }
}
