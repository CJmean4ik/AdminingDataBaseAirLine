using AdminingDataBaseAirLine.Forms.ButtonSettings;
using AdminingDataBaseAirLine.Properties;

namespace AdminingDataBaseAirLine.Forms
{
    internal class CashierFormTheme
    {

        private readonly Color darkColorFirstView = Color.FromArgb(20, 21, 23);
        private readonly Color darkColorSecondView = Color.FromArgb(30, 31, 36);
        private readonly Color whiteColor = Color.FromName("Control");
        private readonly Color purpleColor = Color.FromArgb(80, 81, 249);
        private readonly Color blueColor = Color.FromArgb(10, 126, 245);


        private CashierForm cashierForm;
        private Dictionary<string, ButtonProperty> _buttonResourse;

        public CashierFormTheme(CashierForm cashierForm, Dictionary<string, ButtonProperty> buttonResourse)
        {
            this.cashierForm = cashierForm;
            _buttonResourse = buttonResourse;
        }

        public void ChangeToDarkTheme(ref bool _ligthMode)
        {


            cashierForm.BackColor = darkColorFirstView;
            cashierForm.BackPanel_P.BackColor = darkColorSecondView;
            cashierForm.Panel_P.BackColor = darkColorSecondView;
            cashierForm.ThemeButton_P.BackColor = darkColorSecondView;
            cashierForm.ThemeButton_P.Image = Resources.night_mode;
            cashierForm.CloseButton.BackColor = darkColorSecondView;
            cashierForm.CollapseButton.BackColor = darkColorSecondView;
            cashierForm.FlowTicketPanel.BackColor = darkColorSecondView;
            cashierForm.TicketPanel.BackColor = darkColorSecondView;
              
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
        public void ChangeToLightTheme(ref bool _ligthMode)
        {
            cashierForm.BackColor = whiteColor;
            cashierForm.BackPanel_P.BackColor = blueColor;
            cashierForm.Panel_P.BackColor = blueColor;
            cashierForm.ThemeButton_P.BackColor = blueColor;
            cashierForm.ThemeButton_P.Image = Resources.lightmode;
            cashierForm.CloseButton.BackColor = blueColor;
            cashierForm.CollapseButton.BackColor = blueColor;
            cashierForm.FlowTicketPanel.BackColor = whiteColor;
            cashierForm.TicketPanel.BackColor = whiteColor;
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
