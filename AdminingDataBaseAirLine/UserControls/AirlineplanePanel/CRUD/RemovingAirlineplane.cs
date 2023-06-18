using AirlineDataBase;
using AirlineDataBase.Entityes.AirlinePlanes;

namespace AdminingDataBaseAirLine.UserControls.AirlineplanePanel.CRUD
{
    public class RemovingAirlineplane
    {
        public AirCompanyContext Context { get; set; }
        public AirlineplaneControl Control { get; set; }
        public bool IdPrepering { get; set; }

        public RemovingAirlineplane(AirCompanyContext context, AirlineplaneControl control)
        {
            Context = context;
            Control = control;
        }

        public void EnableControls(bool isEnable)
        {
            Control.AirlinePlaneIdBox.Enabled = isEnable;
            Control.AirplaneIdBox.Enabled = isEnable;
            Control.UpdateButton.Enabled = isEnable;
            Control.AddButton.Enabled = isEnable;
            Control.InFlightBox.Enabled = isEnable;
            Control.AirplaneTypeBox.Enabled = isEnable;
            Control.AirplaneModelBox.Enabled = isEnable;
            Control.CapacityAirplaneBox.Enabled = isEnable;
        }
        public async Task<bool> RemoveAirLineplaneById()
        {
            try
            {
                var AirLine = Context.AirLines.Where(w => w.Name == Control.AirlineBox.Text
                && w.Owner == Control.OwnerAirlineBox.Text) .FirstOrDefault();


                if (AirLine == null) return false;

                if (!int.TryParse(Control.AirlinePlaneIdBox.Text, out int airlinePlaneId)) return false;

                if (!int.TryParse(Control.AirplaneIdBox.Text, out int airplaneId)) return false;

                var AirlinePlane = Context.AirlinePlanes.Where(w => w.ID == airlinePlaneId)
                    .FirstOrDefault();

                var Airplane = Context.Airplanes.Where(w => w.ID == airplaneId).FirstOrDefault();

                Context.AirLines.Remove(AirLine);
                Context.Airplanes.Remove(Airplane);
                Context.AirlinePlanes.Remove(AirlinePlane);

                await Context.SaveChangesAsync();

                return true;
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
                return false;
            }

        }

        private AirlinePlane CreateAirlinePlane(int airlinePlaneId,int? airlineId, int airplaneId)
        {
            AirlinePlane airlinePlane = new AirlinePlane()
            {
                ID = airlinePlaneId,              
                
            };
            return airlinePlane;
        }

    }
}
