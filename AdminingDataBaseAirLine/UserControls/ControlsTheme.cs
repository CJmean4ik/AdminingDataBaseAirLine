using DataBaseModel.Entities.TicketAndOrders;
using System.Windows.Forms;

namespace AdminingDataBaseAirLine.UserControls
{
    internal class ControlsTheme
    {
        private ControlConfiguration _config;

        public ControlsTheme(ControlConfiguration config)
        {
            _config = config;
        }

        public void ChangeToDarkTheme(ref bool IsLight, Ticket ticket)
        {
            ticket.Panel1.BackColor = _config.ColorPanelWithDarkTheme;
            ticket.Panel2.BackColor = _config.ColorPanelWithDarkTheme;
            ticket.Panel3.BackColor = _config.ColorPanelWithDarkTheme;
            ticket.Panel4.BackColor = _config.ColorPanelWithDarkTheme;
            ticket.BackColor = _config.ColorControlWithDarkTheme;

            ChangeLabelAndFieldToDarkTheme_F(ticket.FlightLabel1, ticket.FlightField);
            ChangeLabelAndFieldToDarkTheme_F(ticket.PriceLabel, ticket.PriceField);
            ChangeLabelAndFieldToDarkTheme_F(ticket.ModelAirPlaneLabel, ticket.ModelAirPlaneField);
            ChangeLabelAndFieldToDarkTheme_F(ticket.SenderLabel, ticket.SenderField);

            ChangeLabelAndFieldToDarkTheme_S(ticket.FromWLabele,ticket.FromWField);
            ChangeLabelAndFieldToDarkTheme_S(ticket.WhereLabel, ticket.WhereField);
            ChangeLabelAndFieldToDarkTheme_S(ticket.DeparLabel, ticket.DeparField);
            ChangeLabelAndFieldToDarkTheme_S(ticket.ArrivalLabel, ticket.ArrivalField);
        }
        public void ChangeToLightTheme(ref bool IsLight, Ticket ticket)
        {
            ticket.Panel1.BackColor = _config.ColorPanelWithLightTheme;
            ticket.Panel2.BackColor = _config.ColorPanelWithLightTheme;
            ticket.Panel3.BackColor = _config.ColorPanelWithLightTheme;
            ticket.Panel4.BackColor = _config.ColorPanelWithLightTheme;
            ticket.BackColor = _config.ColorControlWithLightTheme;

            ChangeLabelAndFieldToLightTheme_F(ticket.FlightLabel1, ticket.FlightField);
            ChangeLabelAndFieldToLightTheme_F(ticket.PriceLabel, ticket.PriceField);
            ChangeLabelAndFieldToLightTheme_F(ticket.ModelAirPlaneLabel, ticket.ModelAirPlaneField);
            ChangeLabelAndFieldToLightTheme_F(ticket.SenderLabel, ticket.SenderField);

            ChangeLabelAndFieldToLightTheme_S(ticket.FromWLabele, ticket.FromWField);
            ChangeLabelAndFieldToLightTheme_S(ticket.WhereLabel, ticket.WhereField);
            ChangeLabelAndFieldToLightTheme_S(ticket.DeparLabel, ticket.DeparField);
            ChangeLabelAndFieldToLightTheme_S(ticket.ArrivalLabel, ticket.ArrivalField);
        }

        public void ChangeThemeControlInFlowPanel(ref bool IsLight,FlowLayoutPanel tickets)
        {
            if (!IsLight)
            {
                foreach (Ticket ticket in tickets.Controls)
                {
                    ChangeToDarkTheme(ref IsLight, ticket);
                }
                return;
            }

            foreach (Ticket ticket in tickets.Controls)
            {
                ChangeToLightTheme(ref IsLight, ticket);
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
        private void ChangeLabelAndFieldToDarkTheme_F(Label label,Label field)
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
