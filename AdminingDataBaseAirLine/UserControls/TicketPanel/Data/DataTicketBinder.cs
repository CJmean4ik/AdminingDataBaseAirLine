using AdminingDataBaseAirLine.Forms.CashierFormSetting;

namespace AdminingDataBaseAirLine.UserControls.TicketPanel.Data
{
    internal class DataTicketBinder
    {
        /// <summary>
        /// Устанавливает данные билету с помощью DataTicketControl
        /// <br/>
        /// Данные представляют собой свойства Ticket
        /// </summary>
        /// <param name="ticket"></param>
        /// <param name="dataTicket"></param>
        public static void BindTicketData(TicketControl ticket, DataTicketControl dataTicket)
        {
            ticket.FlightField.Text = dataTicket.NumberTicket.ToString();
            ticket.PriceField.Text = dataTicket.PriceTicket.ToString();
            ticket.FromWField.Text = dataTicket.FromWhereTicket;
            ticket.WhereField.Text = dataTicket.WhereTicket;
            ticket.DeparField.Text = dataTicket.DepartmentTicket.ToString();
            ticket.ArrivalField.Text = dataTicket.ArrivalTicket.ToString();
            ticket.ModelAirPlaneField.Text = dataTicket.ModelAirplane;
            ticket.SenderField.Text = dataTicket.SenderTicket;
        }


        /// <summary>
        /// Возвращает данные из Ticket в  виде обьекта DataTicketControl
        /// </summary>
        /// <param name="ticket"></param>
        /// <returns></returns>
        public static DataTicketControl GetDataTicket(TicketControl ticket)
        {
            DataTicketControl dataTicket = new DataTicketControl();
            dataTicket.NumberTicket = ticket.FlightField.Text;
            dataTicket.PriceTicket = decimal.Parse(ticket.PriceField.Text);
            dataTicket.FromWhereTicket = ticket.FromWField.Text;
            dataTicket.WhereTicket = ticket.WhereField.Text;
            dataTicket.DepartmentTicket = Convert.ToDateTime(ticket.DeparField.Text);
            dataTicket.ArrivalTicket = Convert.ToDateTime(ticket.ArrivalField.Text);
            dataTicket.ModelAirplane = ticket.ModelAirPlaneField.Text;
            dataTicket.SenderTicket = ticket.SenderField.Text;
            return dataTicket;
        }


    }
}
