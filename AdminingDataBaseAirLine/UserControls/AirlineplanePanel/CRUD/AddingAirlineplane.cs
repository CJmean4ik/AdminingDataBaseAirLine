using AdminingDataBaseAirLine.Properties;
using AirlineDataBase;
using AirlineDataBase.Entityes.AirlinePlanes;

namespace AdminingDataBaseAirLine.UserControls.AirlineplanePanel.CRUD
{
    internal class AddingAirlineplane
    {
        private AirCompanyContext context;
        private AirlineplaneControl airlineplane;
        public bool IsPrepering { get; set; }

        public AddingAirlineplane(AirCompanyContext context, AirlineplaneControl airlineplane)
        {
            this.context = context;
            this.airlineplane = airlineplane;
        }

        public void EnableControls(bool isEnable)
        {
            airlineplane.AirplaneIdBox.Enabled = isEnable;
            airlineplane.AirlinePlaneIdBox.Enabled = isEnable;
            airlineplane.UpdateButton.Enabled = isEnable;
            airlineplane.RemoveButton.Enabled = isEnable;
        }

        private bool CheckNotEmptyFields()
        {
            bool airplaneFields = airlineplane.CapacityAirplaneBox.Text != "" &&
                                  airlineplane.AirplaneTypeBox.Text != "" &&
                                  airlineplane.AirplaneModelBox.Text != "";

            bool airlineFields = airlineplane.OwnerAirlineBox.Text != "" &&
                                 airlineplane.AirlineBox.Text != "" &&
                                 airlineplane.InFlightBox.Text != "";

            

            if (airlineFields && airlineFields)
            {
                if (airlineplane.InFlightBox.Text == "Так" || airlineplane.InFlightBox.Text == "Ні")
                    return true;

                return false;
            }

            
              
            return false;

        }

        private AirlinePlane CreateAirlineplane()
        {

            if (!int.TryParse(airlineplane.CapacityAirplaneBox.Text, out int capacity))
                return null;


            AirlinePlane airlinePlane = new AirlinePlane()
            {
                SendingAirline = airlineplane.AirlineBox.Text,
                InRaise = airlineplane.InFlightBox.Text == "Так" ? true : false,
                AirLine = new AirLine()
                {
                    Name = airlineplane.AirlineBox.Text,
                    Owner = airlineplane.OwnerAirlineBox.Text,
                },
                Airplane = new Airplane()
                {
                    TypeAirplane = airlineplane.AirplaneTypeBox.Text,
                    Model = airlineplane.AirplaneModelBox.Text,
                    Capacity = capacity,
                }
            };
            return airlinePlane;
        }

        public bool PreperingAdd()
        {
            if (!IsPrepering)
            {
                EnableControls(false);
                airlineplane.AddButton.Image = Resources.save;
                IsPrepering = true;
                return true;
            }

            EnableControls(true);
            airlineplane.AddButton.Image = Resources.add;
            IsPrepering = false;
            return false;
        }

        public async Task<(bool isAdded, AirlinePlane entity)> AddAirlineplane()
        {
            try
            {
                if (!CheckNotEmptyFields()) return (false,null);

                var airlinePlane = CreateAirlineplane();

                if (airlinePlane == null) return (false,null);

                context.AirlinePlanes.Add(airlinePlane);

                await context.SaveChangesAsync();
                return (true,airlinePlane);

            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
                return (false, null);
            }
        }
    }
}
