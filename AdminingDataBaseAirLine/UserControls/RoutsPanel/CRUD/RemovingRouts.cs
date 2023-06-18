using AirlineDataBase;
using AirlineDataBase.Entityes.RouteAndFlight;
using System.Data.Entity;

namespace AdminingDataBaseAirLine.UserControls.RoutsPanel.CRUD
{
    internal class RemovingRouts
    {
        private AirCompanyContext context;
        private RoutsControlPanel routsControl;
        public bool IsPrepering { get; set; }

        public RemovingRouts(AirCompanyContext context, RoutsControlPanel routsControl)
        {
            this.context = context;
            this.routsControl = routsControl;
        }

        public void EnableControls(bool isEnable)
        { 
            routsControl.AddButton.Enabled = isEnable;
            routsControl.UpdateButton.Enabled = isEnable;
            routsControl.FromWhereBox.Enabled = isEnable;
            routsControl.FromBox.Enabled = isEnable;
            routsControl.ArivalBox.Enabled = isEnable;
            routsControl.DepartimeBox.Enabled = isEnable;
        }
        public async Task LoadToLocalCash()
        {
            if (context.Routes.Local.Count == 0)
                await context.Routes.LoadAsync();
        }
        private bool CheckExistRouts(out int routeId)
        {
            string routeIdStr = routsControl.RouteId.Text;

            if (!int.TryParse(routeIdStr, out int parsedrouteId))
            {
                MessageBox.Show("Вы ввели не вірний форма ID");
                routeId = parsedrouteId;
                return false;
            }
            routeId = parsedrouteId;

            var route = context.Routes.Local
                .Where(w => w.ID == parsedrouteId)
                .FirstOrDefault();

            if (route == null) return false;

            return true;
        }
        private Route? PreperingToRemoving()
        {
            if (!CheckExistRouts(out int routeId))
            {
                MessageBox.Show("Даного рейса не існує!");
                return null;
            }

            return GetRout(routeId);
        }

        private Route? GetRout(int routeId)
        {
           return context.Routes.Local
                .Where(w => w.ID == routeId)
                .FirstOrDefault();
        }
        public async Task<bool> RemoveRoute()
        {
            try
            {
                var route = PreperingToRemoving();
                if (route == null) return false;

                context.Routes.Remove(route);
                await context.SaveChangesAsync();
                return true;
            }
            catch (Exception ex)
            {
                MessageBox.Show("Не вдалося видалити цей маршрут: " + ex.Message);
                return false;
            }
        }
    }
}
