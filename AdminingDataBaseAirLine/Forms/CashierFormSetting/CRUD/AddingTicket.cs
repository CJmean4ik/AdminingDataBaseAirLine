using AdminingDataBaseAirLine.Authentication;
using AdminingDataBaseAirLine.Properties;
using AdminingDataBaseAirLine.UserControls.Data;
using DataBaseModel.Entities;
using DataBaseModel.Entities.Accounts;
using System.Data.Entity;
using static System.Net.Mime.MediaTypeNames;

namespace AdminingDataBaseAirLine.Forms.CashierFormSetting.CRUD
{
    internal class AddingTicket : TicketOperation
    {
        public AddingTicket(CashierForm cashierForm, AirlineContext db) : base(cashierForm, db)
        {
        }

        public void PreperingForAddingTicket()
        {

            ClearRelatedTextInTicketPanel();
            ChangeStateAddButton();
        }
        public async Task<bool> LoadDataToLocalCash()
        {
            await db.Routes.LoadAsync();
            await db.AirlinePlanes.LoadAsync();
            await db.Airplanes.LoadAsync();
            await db.Flights.LoadAsync();
            await db.Tickets.LoadAsync();
            return true;
        }

        public DataTicketControl GetDataTicketControl()
        {
            DataTicketControl dataTicket = new DataTicketControl();
            dataTicket.PriceTicket = decimal.Parse(cashierForm.PriceTicketBox.Text);
            dataTicket.FromWhereTicket = cashierForm.FromWhereTicketBox.Text;
            dataTicket.WhereTicket = cashierForm.WhereTicketBox.Text;
            dataTicket.ModelAirplane = cashierForm.AirplaneTicketBox.Text;
            dataTicket.SenderTicket = cashierForm.SenderTicketBox.Text;
            return dataTicket;
        }

        private void ClearRelatedTextInTicketPanel()
        {
            cashierForm.NumberTicketBox.Text = "";
            cashierForm.PriceTicketBox.Text = "";
            cashierForm. FromWhereTicketBox.Text = "";
            cashierForm.WhereTicketBox.Text = "";
            cashierForm.AirplaneTicketBox.Text = "";
            cashierForm.SenderTicketBox.Text = "";
        }
        private void ChangeStateAddButton()
        {
            cashierForm.NumberTicketBox.Enabled = false;
            cashierForm.AddButton1.Image = Resources.save;
            cashierForm.UpdateButton1.Enabled = false;
            cashierForm.RemoveButton1.Enabled = false;
        }

        public void ReturnStateAddButton()
        {
            cashierForm.NumberTicketBox.Enabled = true;
            cashierForm.AddButton1.Image = Resources.add;
            cashierForm.UpdateButton1.Enabled = true;
            cashierForm.RemoveButton1.Enabled = true;
        }
        public void ErorHandling()
        {
            if (ErorIsActive)
            {
                ErorIsActive = false;
                cashierForm.ErorLabel.Visible = false;
                return;
            }
        }
       
    }
}
