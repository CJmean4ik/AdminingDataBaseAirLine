using AirlineDataBase;
using AirlineDataBase.Entityes.TicketAndOrders;

namespace AdminingDataBaseAirLine.UserControls.ReservedSeatsPanel.CRUD
{
    public class RemovingReservedSeats
    {
        public bool IsRemoving { get; set; }
        public AirCompanyContext Database { get; set; }
        public ReservedSeatsPanelControl ReservedSeats { get; set; }

        private bool erorIsActive;

        public RemovingReservedSeats(AirCompanyContext database, ReservedSeatsPanelControl reservedSeatsControl)
        {
            Database = database;
            this.ReservedSeats = reservedSeatsControl;
        }
        public void EnableControls(bool isEnable)
        {
            ReservedSeats.ShowPlace.Enabled = isEnable;
            ReservedSeats.AirplaneBox.Enabled = isEnable;
            ReservedSeats.UpdateButton.Enabled = isEnable;
            ReservedSeats.AddButton.Enabled = isEnable;
            ReservedSeats.IdpassBox.Enabled = isEnable;
            ReservedSeats.NameBox.Enabled = isEnable;
            ReservedSeats.SecondNameBox.Enabled = isEnable;
            ReservedSeats.SeatsNumberBox.Enabled = isEnable;
            ReservedSeats.FlightNamesBox.Enabled = isEnable;
            ReservedSeats.ReportCreate.Enabled = isEnable;
        }
        public async Task<bool> DeleteReservedSeats(int id)
        {
            try
            {
                var seats = Database.ReservedSeats.Where(w => w.Id == id).FirstOrDefault();
                Database.ReservedSeats.Remove(seats);
                await Database.SaveChangesAsync();
                return true;
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
                return false;
            }
        }
    }
}
