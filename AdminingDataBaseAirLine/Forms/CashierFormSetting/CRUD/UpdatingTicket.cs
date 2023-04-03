using AdminingDataBaseAirLine.Authentication;
using AdminingDataBaseAirLine.Properties;
using DataBaseModel.Entities.TicketAndOrders;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AdminingDataBaseAirLine.Forms.CashierFormSetting.CRUD
{
    internal class UpdatingTicket : TicketOperation
    {
        public bool IsNowUpdate { get; set; }
        public Dictionary<int, bool> EntryTicket;
        public UpdatingTicket(CashierForm cashierForm, AirlineContext db) : base(cashierForm, db)
        {
            EntryTicket = new Dictionary<int, bool>();
        }

        public void PreperingUpdateTicket()
        {          
            ChangeStateUpdateButton();
        }
        private void ChangeStateUpdateButton()
        {
            cashierForm.NumberTicketBox.Enabled = false;
          
            cashierForm.FromWhereTicketBox.Enabled = false;
            cashierForm.WhereTicketBox.Enabled = false;
            cashierForm.AirplaneTicketBox.Enabled = false;
            cashierForm.SenderTicketBox.Enabled = false;

            cashierForm.UpdateButton1.Image = Resources.done;
            cashierForm.AddButton1.Enabled = false;
            cashierForm.RemoveButton1.Enabled = false;

        }

        public bool ChekingOnNotEmptryPriceAndNumber(string price,string number)
        {
            if (price  == "" && number  == "")
            {
                cashierForm.ErorLabel.Text = "Пусте значення.\nОновлення неможливе";
                cashierForm.ErorLabel.Visible = true;
                ErorIsActive = true;
                return false;
            }
            return true;
        }
        public bool ChekingOnNotOldValuePrice(decimal price)
        {
            if (price == decimal.Parse(cashierForm.PriceTicketBox.Text))
            {
                cashierForm.ErorLabel.Text = "Значення не змінились.\nОновлення неможливе";
                cashierForm.ErorLabel.Visible = true;
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

        public void ReturnStateUpdateButton()
        {
            cashierForm.NumberTicketBox.Enabled = true;

            cashierForm.FromWhereTicketBox.Enabled = true;
            cashierForm.WhereTicketBox.Enabled = true;
            cashierForm.AirplaneTicketBox.Enabled = true;
            cashierForm.SenderTicketBox.Enabled = true;

            cashierForm.UpdateButton1.Image = Resources.update;
            cashierForm.AddButton1.Enabled = true;
            cashierForm.RemoveButton1.Enabled = true;
            IsNowUpdate = false;
        }
    }
}
