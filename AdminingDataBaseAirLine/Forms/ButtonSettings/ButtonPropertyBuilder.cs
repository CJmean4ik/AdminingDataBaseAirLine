using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AdminingDataBaseAirLine.Forms.ButtonSettings
{
    internal class ButtonPropertyBuilder
    {
        private ButtonProperty _buttonProperty;

        public ButtonPropertyBuilder()
        {
            _buttonProperty = new ButtonProperty();
        }
        public ButtonPropertyBuilder SetIsOpen(bool isopen)
        {
            _buttonProperty.IsOpen = isopen;
            return this;
        }


        public ButtonPropertyBuilder SetButton(Button button) 
        {            
            _buttonProperty.Button = button; 
            return this; 
        }

        public ButtonPropertyBuilder SetWhiteImage(Image whiteImage)
        {
            _buttonProperty.WhiteImage = whiteImage;
            return this;
        }
        public ButtonPropertyBuilder SetBlueImage(Image blueImage)
        {
            _buttonProperty.BlueImage = blueImage;
            return this;
        }

        public ButtonPropertyBuilder SetDarkImage(Image darkImage)
        {
            _buttonProperty.DarkImage = darkImage;
            return this;
        }
        public ButtonProperty Build()
        {
            return _buttonProperty;
        }

    }
}
