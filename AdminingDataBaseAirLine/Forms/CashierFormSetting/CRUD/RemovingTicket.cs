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
    internal class RemovingTicket : TicketOperation
    {
        public bool IsNowRemove { get; set; }
        public RemovingTicket(CashierForm cashierForm, AirlineContext db) : base(cashierForm, db)
        {
        }

        public void PreperingDeleteTicket()
        {
            ChangeStateUpdateButton();
        }
        private void ChangeStateUpdateButton()
        {
            cashierForm.PriceTicketBox.Enabled = false;
            cashierForm.FromWhereTicketBox.Enabled = false;
            cashierForm.WhereTicketBox.Enabled = false;
            cashierForm.AirplaneTicketBox.Enabled = false;
            cashierForm.SenderTicketBox.Enabled = false;
            cashierForm.RemoveButton1.Image = Resources.doneDelete;
            cashierForm.AddButton1.Enabled = false;
            cashierForm.UpdateButton1.Enabled = false;

        }
        public void ReturnStateUpdateButton()
        {
            cashierForm.PriceTicketBox.Enabled = true;
            cashierForm.FromWhereTicketBox.Enabled = true;
            cashierForm.WhereTicketBox.Enabled = true;
            cashierForm.AirplaneTicketBox.Enabled = true;
            cashierForm.SenderTicketBox.Enabled = true;
            cashierForm.RemoveButton1.Image = Resources.remove;
            cashierForm.AddButton1.Enabled = true;
            cashierForm.UpdateButton1.Enabled = true;
        }
        public bool ChekingOnNotEmptryIdTicket(string number)
        {
            if (number == "")
            {
                cashierForm.ErorLabel.Text = "Пусте значення.\nВидалення неможливе";
                cashierForm.ErorLabel.Visible = true;
                ErorIsActive = true;
                return false;
            }
            return true;
        }
        public bool ContainsEntityById(int id,ref Ticket ticket)
        {
            ticket = db.Tickets.Where(w => w.NumberTicket == id).Select(s => s).FirstOrDefault()!;

            if (ticket == null)
            {
                cashierForm.ErorLabel.Text = "Такого квитка не існує!";
                cashierForm.ErorLabel.Visible = true;
                ErorIsActive = true;
                return false;  
            }
            
            return true;
        }

    }
}
