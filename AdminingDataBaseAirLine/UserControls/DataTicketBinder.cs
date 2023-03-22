using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AdminingDataBaseAirLine.UserControls
{
    internal class DataTicketBinder
    {
        public static void BindTicketData(Ticket ticket, DataTicketControl dataTicket)
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
    }
}
