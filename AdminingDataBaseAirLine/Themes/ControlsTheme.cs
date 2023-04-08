using AdminingDataBaseAirLine.UserControls;
using AdminingDataBaseAirLine.UserControls.Config;

namespace AdminingDataBaseAirLine.Themes
{
    public class ControlsTheme
    {
        private ControlConfiguration _config;

        private TicketControl _ticket;
        public TicketControl Ticket { get => _ticket; set => _ticket = value; }
        public ControlsTheme(ControlConfiguration config)
        {
            _config = config;
        }
        public ControlsTheme(ControlConfiguration config, TicketControl ticket) : this(config)
        {
            _ticket = ticket;
        }

        public void ChangeToDarkTheme(ref bool IsLight)
        {
            _ticket.Panel1.BackColor = _config.ColorPanelWithDarkTheme;
            _ticket.Panel2.BackColor = _config.ColorPanelWithDarkTheme;
            _ticket.Panel3.BackColor = _config.ColorPanelWithDarkTheme;
            _ticket.Panel4.BackColor = _config.ColorPanelWithDarkTheme;
            _ticket.BackColor = _config.ColorControlWithDarkTheme;

            ChangeLabelAndFieldToDarkTheme_F(_ticket.FlightLabel1, _ticket.FlightField);
            ChangeLabelAndFieldToDarkTheme_F(_ticket.PriceLabel, _ticket.PriceField);
            ChangeLabelAndFieldToDarkTheme_F(_ticket.ModelAirPlaneLabel, _ticket.ModelAirPlaneField);
            ChangeLabelAndFieldToDarkTheme_F(_ticket.SenderLabel, _ticket.SenderField);

            ChangeLabelAndFieldToDarkTheme_S(_ticket.FromWLabele, _ticket.FromWField);
            ChangeLabelAndFieldToDarkTheme_S(_ticket.WhereLabel, _ticket.WhereField);
            ChangeLabelAndFieldToDarkTheme_S(_ticket.DeparLabel, _ticket.DeparField);
            ChangeLabelAndFieldToDarkTheme_S(_ticket.ArrivalLabel, _ticket.ArrivalField);
        }
        public void ChangeToLightTheme(ref bool IsLight)
        {
            _ticket.Panel1.BackColor = _config.ColorPanelWithLightTheme;
            _ticket.Panel2.BackColor = _config.ColorPanelWithLightTheme;
            _ticket.Panel3.BackColor = _config.ColorPanelWithLightTheme;
            _ticket.Panel4.BackColor = _config.ColorPanelWithLightTheme;
            _ticket.BackColor = _config.ColorControlWithLightTheme;

            ChangeLabelAndFieldToLightTheme_F(_ticket.FlightLabel1, _ticket.FlightField);
            ChangeLabelAndFieldToLightTheme_F(_ticket.PriceLabel, _ticket.PriceField);
            ChangeLabelAndFieldToLightTheme_F(_ticket.ModelAirPlaneLabel, _ticket.ModelAirPlaneField);
            ChangeLabelAndFieldToLightTheme_F(_ticket.SenderLabel, _ticket.SenderField);

            ChangeLabelAndFieldToLightTheme_S(_ticket.FromWLabele, _ticket.FromWField);
            ChangeLabelAndFieldToLightTheme_S(_ticket.WhereLabel, _ticket.WhereField);
            ChangeLabelAndFieldToLightTheme_S(_ticket.DeparLabel, _ticket.DeparField);
            ChangeLabelAndFieldToLightTheme_S(_ticket.ArrivalLabel, _ticket.ArrivalField);
        }

        public void ChangeThemeControlInFlowPanel(ref bool IsLight, FlowLayoutPanel tickets)
        {
            if (!IsLight)
            {
                foreach (TicketControl ticket in tickets.Controls)
                {
                    _ticket = ticket;
                    ChangeToDarkTheme(ref IsLight);
                }
                return;
            }
            foreach (TicketControl ticket in tickets.Controls)
            {
                _ticket = ticket;
                ChangeToLightTheme(ref IsLight);
            }
        }


        private void ChangeLabelAndFieldToLightTheme_F(Label label, Label field)
        {
            label.ForeColor = _config.ColorLabelWithLightThemeF;
            label.BackColor = _config.ColorControlWithLightTheme;
            field.ForeColor = _config.ColorLabelWithLightThemeF;
            field.BackColor = _config.ColorControlWithLightTheme;
        }
        private void ChangeLabelAndFieldToLightTheme_S(Label label, Label field)
        {
            label.ForeColor = _config.ColorLabelWithLightThemeS;
            label.BackColor = _config.ColorControlWithLightTheme;
            field.ForeColor = _config.ColorLabelWithLightThemeS;
            field.BackColor = _config.ColorControlWithLightTheme;
        }
        private void ChangeLabelAndFieldToDarkTheme_F(Label label, Label field)
        {
            label.ForeColor = _config.ColorLabelWithDarkThemeF;
            label.BackColor = _config.ColorControlWithDarkTheme;
            field.ForeColor = _config.ColorLabelWithDarkThemeF;
            field.BackColor = _config.ColorControlWithDarkTheme;
        }
        private void ChangeLabelAndFieldToDarkTheme_S(Label label, Label field)
        {
            label.ForeColor = _config.ColorLabelWithDarkThemeS;
            label.BackColor = _config.ColorControlWithDarkTheme;
            field.ForeColor = _config.ColorLabelWithDarkThemeS;
            field.BackColor = _config.ColorControlWithDarkTheme;
        }


    }
}
