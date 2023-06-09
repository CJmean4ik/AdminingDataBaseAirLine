using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AdminingDataBaseAirLine.UserControls.TicketPanel.Data
{
    public class DataTicketControl
    {
        public string NumberTicket { get; set; }
        public decimal PriceTicket { get; set; }
        public string FromWhereTicket { get; set; }
        public string WhereTicket { get; set; }
        public DateTime DepartmentTicket { get; set; }
        public DateTime ArrivalTicket { get; set; }
        public string ModelAirplane { get; set; }
        public string SenderTicket { get; set; }

    }
}
