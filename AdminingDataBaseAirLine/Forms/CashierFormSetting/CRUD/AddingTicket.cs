using AdminingDataBaseAirLine.Authentication;
using AdminingDataBaseAirLine.Properties;
using AdminingDataBaseAirLine.UserControls;
using AdminingDataBaseAirLine.UserControls.Data;
using System.Data.Entity;

namespace AdminingDataBaseAirLine.Forms.CashierFormSetting.CRUD
{
    internal class AddingTicket : TicketOperation
    {
        public AddingTicket(TicketPanelControl control, AirlineContext db) : base(control, db)
        {
        }
        
        public void PreperingForAddingTicket()
        {

            ClearRelatedTextInTicketPanel();
            TicketPanel.NumberTicketBox.Enabled = false;
            TicketPanel.AddButton.Image = Resources.save;
            TicketPanel.UpdateButton.Enabled = false;
            TicketPanel.RemoveButton.Enabled = false;

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
            dataTicket.PriceTicket = decimal.Parse(TicketPanel.PriceTicketBox.Text);
            dataTicket.FromWhereTicket = TicketPanel.FromWhereTicketBox.Text;
            dataTicket.WhereTicket = TicketPanel.WhereTicketBox.Text;
            dataTicket.ModelAirplane = TicketPanel.AirplaneTicketBox.Text;
            dataTicket.SenderTicket = TicketPanel.SenderTicketBox.Text;
            return dataTicket;
        }

        private void ClearRelatedTextInTicketPanel()
        {
            TicketPanel.NumberTicketBox.Text = "";
            TicketPanel.PriceTicketBox.Text = "";
            TicketPanel. FromWhereTicketBox.Text = "";
            TicketPanel.WhereTicketBox.Text = "";
            TicketPanel.AirplaneTicketBox.Text = "";
            TicketPanel.SenderTicketBox.Text = "";
        }
               
        public void ErorHandling()
        {
            if (ErorIsActive)
            {
                ErorIsActive = false;
                TicketPanel.ErorLabel.Visible = false;
                return;
            }
        }
      
    }
}
