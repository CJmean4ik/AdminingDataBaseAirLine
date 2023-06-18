using AirlineDataBase;
using System.Data.Entity;

namespace AdminingDataBaseAirLine.UserControls.CashierPanel.CRUD.Cashiers
{
    internal class RemovingCashier
    {
        private AirCompanyContext context;
        private CashierPanelControl cashierPanel;
        public bool IsPrepering { get; set; }

        public RemovingCashier(AirCompanyContext context, CashierPanelControl control)
        {
            this.context = context;
            cashierPanel = control;
        }

        public async Task LoadDataToLocalCash()
        {
            if (context.Cashiers.Local.Count == 0)
                await context.Cashiers.LoadAsync();

        }

        public void EnableControls(bool isEnable)
        {
            cashierPanel.UserNameBox.Enabled = isEnable;
            cashierPanel.IdpassBox.Enabled = isEnable;
            cashierPanel.PasswordBox.Enabled = isEnable;
            cashierPanel.AdminBox.Enabled = isEnable;
            cashierPanel.MailBox.Enabled = isEnable;
            cashierPanel.UpdateButton.Enabled = isEnable;
            cashierPanel.AddButton.Enabled = isEnable;
        }

        public async Task<bool> RemoveCashier()
        {
            try
            {
                if (!int.TryParse(cashierPanel.IdpassBox.Text, out int cashierId)) 
                    return false;

                var cashier = context.Cashiers.Find(cashierId);
                if (cashier == null)
                {
                    MessageBox.Show("Даного касира не існує");
                    return false;
                }

                context.Cashiers.Remove(cashier);

                await context.SaveChangesAsync();
                return true;
            }
            catch (Exception ex)
            {

                MessageBox.Show("Не вдалося видалити " + ex.Message);
                return false;
            }
        }
    }
}
