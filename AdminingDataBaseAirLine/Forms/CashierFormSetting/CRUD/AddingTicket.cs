using AdminingDataBaseAirLine.Authentication;
using AdminingDataBaseAirLine.Properties;
using AdminingDataBaseAirLine.UserControls.Data;
using DataBaseModel.Entities;
using System.Data.Entity;

namespace AdminingDataBaseAirLine.Forms.CashierFormSetting.CRUD
{
    internal class AddingTicket
    {
        private CashierForm _cashierForm;
        private AirlineContext _db;

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
            return true;
        }

        public DataTicketControl GetDataTicketControl()
        {
           return DataTicketBinder.GetDataTicket(_cashierForm);
        }

        private void ClearRelatedTextInTicketPanel()
        {
            _cashierForm.NumberTicketBox.Text = "";
            _cashierForm.PriceTicketBox.Text = "";
            _cashierForm. FromWhereTicketBox.Text = "";
            _cashierForm.WhereTicketBox.Text = "";
            _cashierForm.DepartTicketBox.Text = "";
            _cashierForm.ArivalTicketBox.Text = "";
            _cashierForm.AirplaneTicketBox.Text = "";
            _cashierForm.SenderTicketBox.Text = "";
        }
        private void ChangeStateAddButton()
        {
            _cashierForm.NumberTicketBox.Enabled = false;
            _cashierForm.AddButton1.Image = Resources.checkmark__1_;
            _cashierForm.AddButton1.Text = "Додати!";           
        }
    }
}
