using AirlineDataBase;
using AirlineDataBase.Entityes.AirlinePlanes;
using AirlineDataBase.Entityes.RouteAndFlight;
using System.Data.Entity;

namespace AdminingDataBaseAirLine.UserControls.FlightPanel.CRUD
{
    internal class AddingFlight
    {
        private AirCompanyContext context;
        private FlightPanelControl flightControl;
        public bool IsPrepering { get; set; }

        public AddingFlight(AirCompanyContext context, FlightPanelControl airlineplane)
        {
            this.context = context;
            this.flightControl = airlineplane;
        }
        public void EnableControls(bool isEnable)
        {
            flightControl.FlightID.Enabled = isEnable;
            flightControl.UploadToCsvButton.Enabled = isEnable;
            flightControl.RemoveButton.Enabled = isEnable;
        }

        public async Task LoadToLocalCash()
        {
            if (context.Routes.Local.Count == 0)
                await context.Routes.LoadAsync();

            if (context.Flights.Local.Count == 0)
                await context.Flights.LoadAsync();

            if (context.AirlinePlanes.Local.Count == 0)
                await context.AirlinePlanes.LoadAsync();

            if (context.Airplanes.Local.Count == 0)
                await context.Airplanes.LoadAsync();
        }

        private bool CheckExistRoute(out Route? route)
        {
            string fromWhere = flightControl.FromWhereBox.Text;
            string where = flightControl.FromBox.Text;

             route = context.Routes.Local
                .Where(w => w.FromWhere == fromWhere && w.Where == where)
                .FirstOrDefault();
            

            if (route == null) return false;
            return true;
        }
        private bool CheckExistAirlinePlane(out AirlinePlane? airlinePlane)
        {
            string sender = flightControl.SenderBox.Text;
            string airplane = flightControl.AirplaneTypeBox.Text;

            airlinePlane = context.AirlinePlanes.Local
                .Where(w => w.SendingAirline == sender && w.Airplane.Model == airplane)
                .FirstOrDefault();

            if (airlinePlane == null) return false;
            return true;
        }
        private bool CheckNonExistFlight()
        {
            string nameRoute = flightControl.RouteFlightNameBox.Text;

            var route = context.Flights.Local
                .Where(w => w.NameRoute == nameRoute)
                .FirstOrDefault();

            if (route == null) return true;

            return false;
        }
        private Flight CreateFlight(Route route, AirlinePlane airlineplane) 
        {
            Flight flight = new Flight()
            {
                Route = route,
                AirlinePlane = airlineplane,
                NameRoute = flightControl.RouteFlightNameBox.Text,
            };

            return flight;
        }

        private Flight? PreperingToAdding()
        {
            if (!CheckExistRoute(out Route? routeId))
            {
                MessageBox.Show("Даного маршрута не існує!");
                return null;
            }

            if (!CheckNonExistFlight())
            {
                MessageBox.Show($"Рейс типу: {flightControl.RouteFlightNameBox.Text} вже є у БД");
                return null;
            }

            if (!CheckExistAirlinePlane(out AirlinePlane? airlinePlaneId))
            {
                MessageBox.Show("Компанія з таким літаком не надає послуги з авіаперевезень");
                return null;
            }

            return CreateFlight(routeId!, airlinePlaneId!);
        }
        public async Task<(bool isAdded, Flight? addedFlight)> AddFlight()
        {
            try
            {
                var flight = PreperingToAdding();
                if (flight == null) return (false, null);

                context.Flights.Add(flight);

                await context.SaveChangesAsync();
                return (true, flight);
            }
            catch (Exception ex)
            {
                MessageBox.Show("Не вдалося додати новий рейс. Повідомлення помилки " + ex.Message);
                return (false, null);
            }
        }

    }
}
