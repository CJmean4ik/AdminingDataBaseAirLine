using AdminingDataBaseAirLine.Authentication;
using AdminingDataBaseAirLine.Properties;
using AdminingDataBaseAirLine.UserControls;
using DataBaseModel.Entities.TicketAndOrders;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AdminingDataBaseAirLine.UserControls.TicketPanel.CRUD
{
    internal class UpdatingTicket : TicketOperation
    {
        public bool IsNowUpdate { get; set; }
        public Dictionary<int, bool> EntryTicket;

        public UpdatingTicket(TicketPanelControl ticketPanel, AirlineContext db) : base(ticketPanel, db)
        {
            EntryTicket = new Dictionary<int, bool>();
        }


        public void PreperingUpdateTicket()
        {
            ChangeStateButton();
            TicketPanel.UpdateButton.Image = Resources.done;
            TicketPanel.AddButton.Enabled = false;
            TicketPanel.RemoveButton.Enabled = false;
        }


        public bool ChekingOnNotEmptryPriceAndNumber(string price, string number)
        {
            if (price == "" && number == "")
            {
                TicketPanel.ErorLabel.Text = "Пусте значення.\nОновлення неможливе";
                TicketPanel.ErorLabel.Visible = true;
                ErorIsActive = true;
                return false;
            }
            return true;
        }
        public bool ChekingOnNotOldValuePrice(decimal price)
        {
            if (price == decimal.Parse(TicketPanel.PriceTicketBox.Text))
            {
                TicketPanel.ErorLabel.Text = "Значення не змінились.\nОновлення неможливе";
                TicketPanel.ErorLabel.Visible = true;
                return false;
            }
            return true;
        }

        public decimal GetTicketPriceById(int id)
        {
            return db.Tickets
              .Where(w => w.NumberTicket == id)
              .Select(s => s.Price)
              .FirstOrDefault();
        }
    }

}
