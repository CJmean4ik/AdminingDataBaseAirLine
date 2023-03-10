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

        public void ChangeButtonProperties(string butnName)
        {
            Button button = _buttonResourse[butnName].Button;
            _buttonResourse[butnName].IsOpen = true;
            ButtonColorChangingToWhite(button);
            button.Image = _buttonResourse[butnName].BlueImage;
            ChangeButtonPressed(butnName);
        }

        private void ButtonColorChangingToWhite(Button button)
        {
            button.ForeColor = Color.FromArgb(10, 126, 245);
            button.BackColor = Color.FromName("Control");
        }
        private void ButtonColorChangingToDeffault(Button button)
        {
            button.ForeColor = Color.FromName("Control");
            button.BackColor = Color.FromArgb(10, 126, 245);
        }
        private void ChangeButtonPressed(string scipName)
        {
            foreach (var item in _buttonResourse)
            {
                if (item.Key == scipName) continue;

                if (!item.Value.IsOpen) continue;

                _buttonResourse[item.Key].IsOpen = false;
                ButtonColorChangingToDeffault(item.Value.Button);
                item.Value.Button.Image = _buttonResourse[item.Key].WhiteImage;

            }
        }


    }
}
