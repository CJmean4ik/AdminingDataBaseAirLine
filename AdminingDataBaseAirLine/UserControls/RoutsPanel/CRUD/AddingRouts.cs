using AirlineDataBase;
using AirlineDataBase.Entityes.RouteAndFlight;
using System.Data.Entity;

namespace AdminingDataBaseAirLine.UserControls.RoutsPanel.CRUD
{
    internal class AddingRouts
    {
        private AirCompanyContext context;
        private RoutsControlPanel routsControl;
        public bool IsPrepering { get; set; }

        public AddingRouts(AirCompanyContext context, RoutsControlPanel routsControl)
        {
            this.context = context;
            this.routsControl = routsControl;
        }
        public void EnableControls(bool isEnable)
        {
            routsControl.RouteId.Enabled = isEnable;
            routsControl.RemoveButton.Enabled = isEnable;
            routsControl.UpdateButton.Enabled = isEnable;
        }
        public async Task LoadToLocalCash()
        {
            if (context.Routes.Local.Count == 0)
                await context.Routes.LoadAsync();
        }
        private bool CheckNonExistRoute()
        {
            string fromWhere = routsControl.FromWhereBox.Text;
            string where = routsControl.FromBox.Text;

            int? route = context.Routes.Local
                .Where(w => w.FromWhere == fromWhere && w.Where == where)
                .Select(s => s.ID)
                .FirstOrDefault();

            if (route == 0) return true;
            return false;
        }

        private Route CreateRoute()
        {
            Route route = new Route()
            {
                FromWhere = routsControl.FromWhereBox.Text,
                Where = routsControl.FromBox.Text,
                Departure = DateTime.Parse(routsControl.DepartimeBox.Text),
                Incoming = DateTime.Parse(routsControl.ArivalBox.Text)
            };
            return route;
        }

        private Route? PreperingToAdding()
        {
            if (!CheckNonExistRoute())
            {
                MessageBox.Show("Данний маршрут за таким напрямков вже існує!");
                return null;
            }

            var route = CreateRoute();
            return route;
        }

        public async Task<(bool isAdded,Route? route)> AddRoute()
        {
            try
            {
                var route = PreperingToAdding();
                if (route == null) return (false,null);

                context.Routes.Add(route);
                await context.SaveChangesAsync();
                return (true, route);
            }
            catch (Exception ex)
            {
                MessageBox.Show("Не вдалося додати новий маршрут! " + ex.Message);
                return (false,null);
            }
        }

    }
}
