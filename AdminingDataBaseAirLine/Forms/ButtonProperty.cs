using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AdminingDataBaseAirLine.Forms
{
    public class ButtonProperty
    {
        public bool IsOpen { get; set; }
        public Button Button { get; set; }

        public ButtonProperty(bool isOpen, Button button)
        {
            IsOpen = isOpen;
            Button = button;
        }
    }

      
}
