using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AdminingDataBaseAirLine.Forms.CashierFormSetting.FormConfiguration
{
    internal class CashierFormConfigurationBuilder
    {
        private CashierFormConfiguration configuration;

        public CashierFormConfigurationBuilder()
        {
            configuration = new CashierFormConfiguration();
        }
        public CashierFormConfigurationBuilder SetDarkColor(Color firstColor, Color secColor)
        {
            configuration.darkColorFirstView = firstColor;
            configuration.darkColorSecondView = secColor;
            return this;
        }
        public CashierFormConfigurationBuilder SetWhiteColor(Color white)
        {
            configuration.whiteColor = white;
            return this;
        }
        public CashierFormConfigurationBuilder SetBlueColor(Color blue)
        {
            configuration.blueColor = blue;
            return this;
        }
        public CashierFormConfigurationBuilder SetPurpleColor(Color purple)
        {
            configuration.purpleColor = purple;
            return this;
        }
        public CashierFormConfiguration Build()
        {
            return configuration;
        }

    }
}
