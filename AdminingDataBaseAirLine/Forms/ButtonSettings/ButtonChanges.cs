using AdminingDataBaseAirLine.Forms.ButtonSettings;

namespace AdminingDataBaseAirLine.Forms
{
    internal class ButtonChanges
    {
        private Dictionary<string, ButtonProperty> _buttonResourse;
        public ButtonChanges(Dictionary<string, ButtonProperty> buttonResourse)
        {
            _buttonResourse = buttonResourse;
        }

        public void ChangeButtonProperties(string butnName, bool _IsLight)
        {
            Button button = _buttonResourse[butnName].Button;
            _buttonResourse[butnName].IsOpen = true;
            if (_IsLight)
            {
                button.ForeColor = Color.FromArgb(10, 126, 245);
                button.BackColor = Color.FromName("Control");
                button.Image = _buttonResourse[butnName].BlueImage;
            }
            else button.BackColor = Color.FromArgb(20, 21, 23);

            ChangeButtonPressed(butnName, _IsLight);
        }


        private void ButtonColorChangingToDeffault(Button button, bool _IsLight,string scipName)
        {
            if (!_IsLight)
            {
                button.BackColor = Color.FromArgb(30, 31, 36);
                button.Image = _buttonResourse[scipName].DarkImage;
            }
            else
            {
                button.ForeColor = Color.FromName("Control");
                button.BackColor = Color.FromArgb(10, 126, 245);
                button.Image = _buttonResourse[scipName].WhiteImage;
            }
        }



        private void ChangeButtonPressed(string scipName, bool _IsLight)
        {
            foreach (var item in _buttonResourse)
            {
                if (item.Key == scipName) continue;

                if (!item.Value.IsOpen) continue;
                _buttonResourse[item.Key].IsOpen = false;
                ButtonColorChangingToDeffault(item.Value.Button, _IsLight,item.Key);             
            }
        }


    }
}
