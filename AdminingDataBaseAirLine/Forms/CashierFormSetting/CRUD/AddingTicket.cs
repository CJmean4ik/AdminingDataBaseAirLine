using AdminingDataBaseAirLine.Authentication;
using AdminingDataBaseAirLine.Properties;
using AdminingDataBaseAirLine.UserControls.Data;
using DataBaseModel.Entities;
using DataBaseModel.Entities.Accounts;
using System.Data.Entity;
using static System.Net.Mime.MediaTypeNames;

namespace AdminingDataBaseAirLine.Forms.CashierFormSetting.CRUD
{
    internal class AddingTicket
    {
        private CashierForm _cashierForm;
        private AirlineContext _db;
        public bool ErorIsActive { get; set; }

        public AddingTicket(CashierForm cashierForm, AirlineContext db)
        {
            _cashierForm = cashierForm;
            _db = db;
        }

        public void PreperingForAddingTicket()
        {

            ClearRelatedTextInTicketPanel();
            ChangeStateAddButton();
        }
        public async Task<bool> LoadDataToLocalCash()
        {
            await _db.Routes.LoadAsync();
            await _db.AirlinePlanes.LoadAsync();
            await _db.Airplanes.LoadAsync();
            await _db.Flights.LoadAsync();
            await _db.Tickets.LoadAsync();
            return true;
        }

        public DataTicketControl GetDataTicketControl()
        {
            DataTicketControl dataTicket = new DataTicketControl();
            dataTicket.PriceTicket = decimal.Parse(_cashierForm.PriceTicketBox.Text);
            dataTicket.FromWhereTicket = _cashierForm.FromWhereTicketBox.Text;
            dataTicket.WhereTicket = _cashierForm.WhereTicketBox.Text;
            dataTicket.ModelAirplane = _cashierForm.AirplaneTicketBox.Text;
            dataTicket.SenderTicket = _cashierForm.SenderTicketBox.Text;
            return dataTicket;
        }

        private void ClearRelatedTextInTicketPanel()
        {
            _cashierForm.NumberTicketBox.Text = "";
            _cashierForm.PriceTicketBox.Text = "";
            _cashierForm. FromWhereTicketBox.Text = "";
            _cashierForm.WhereTicketBox.Text = "";
            _cashierForm.AirplaneTicketBox.Text = "";
            _cashierForm.SenderTicketBox.Text = "";
        }
        private void ChangeStateAddButton()
        {
            _cashierForm.NumberTicketBox.Enabled = false;
            _cashierForm.AddButton1.Image = Resources.save;
            _cashierForm.UpdateButton1.Enabled = false;
            _cashierForm.RemoveButton1.Enabled = false;
        }
        public void ErorHandling()
        {
            if (ErorIsActive)
            {
                ErorIsActive = false;
                _cashierForm.ErorLabel.Visible = false;
                return;
            }
        }

        
    }
}
