using AdminingDataBaseAirLine.Authentication;
using AdminingDataBaseAirLine.Properties;
using AdminingDataBaseAirLine.UserControls;
using AirlineDataBase.DataBaseContext;
using AirlineDataBase.Entityes.TicketAndOrders;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AdminingDataBaseAirLine.UserControls.TicketPanel.CRUD
{
    internal class RemovingTicket : TicketOperation
    {
        public RemovingTicket(TicketPanelControl ticketPanel, AirCompanyContext db) : base(ticketPanel, db)
        {

        }

        public bool IsNowRemove { get; set; }


        public void PreperingDeleteTicket()
        {
            ChangeStateButton();
            TicketPanel.RemoveButton.Image = Resources.doneDelete;
            TicketPanel.AddButton.Enabled = false;
            TicketPanel.UpdateButton.Enabled = false;
        }

        public bool ChekingOnNotEmptryIdTicket(string number)
        {
            if (number == "")
            {
                TicketPanel.ErorLabel.Text = "Пусте значення.\nВидалення неможливе";
                TicketPanel.ErorLabel.Visible = true;
                ErorIsActive = true;
                return false;
            }
            return true;
        }
        public bool ContainsEntityById(int id, ref Ticket ticket)
        {
            ticket = db.Tickets.Where(w => w.NumberTicket == id).Select(s => s).FirstOrDefault()!;

            if (ticket == null)
            {
                TicketPanel.ErorLabel.Text = "Такого квитка не існує!";
                TicketPanel.ErorLabel.Visible = true;
                ErorIsActive = true;
                return false;
            }

            return true;
        }


    }
}
