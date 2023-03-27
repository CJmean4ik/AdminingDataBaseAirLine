using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AdminingDataBaseAirLine.UserControls.Config
{
    internal class ControlConfigurationBuilder
    {
        private ControlConfiguration configuration;

        public ControlConfigurationBuilder()
        {
            configuration = new ControlConfiguration();
        }
        public ControlConfigurationBuilder SetPanelColor(Color dark, Color light)
        {
            configuration.ColorPanelWithLightTheme = light;
            configuration.ColorPanelWithDarkTheme = dark;
            return this;
        }

        public ControlConfigurationBuilder SetControlColor(Color dark, Color light)
        {
            configuration.ColorControlWithLightTheme = light;
            configuration.ColorControlWithDarkTheme = dark;
            return this;
        }
        public ControlConfigurationBuilder SetLabelFColor(Color dark, Color light)
        {
            configuration.ColorLabelWithLightThemeF = light;
            configuration.ColorLabelWithDarkThemeF = dark;
            return this;
        }
        public ControlConfigurationBuilder SetLabelSColor(Color dark, Color light)
        {
            configuration.ColorLabelWithLightThemeS = light;
            configuration.ColorLabelWithDarkThemeS = dark;
            return this;
        }
        public ControlConfiguration Build()
        {
            return configuration;
        }

    }
}
