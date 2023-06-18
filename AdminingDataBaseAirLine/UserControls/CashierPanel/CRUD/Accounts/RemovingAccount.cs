using AirlineDataBase;
using System.Data.Entity;

namespace AdminingDataBaseAirLine.UserControls.CashierPanel.CRUD.Accounts
{
    internal class RemovingAccount
    {
        private AirCompanyContext context;
        private CashierPanelControl cashierPanel;
        public bool IsPrepering { get; set; }

        public RemovingAccount(AirCompanyContext context, CashierPanelControl cashierPanel)
        {
            this.context = context;
            this.cashierPanel = cashierPanel;
        }
        public async Task LoadDataToLocalCash()
        {
            if (context.Accounts.Local.Count == 0)
                await context.Accounts.LoadAsync();

        }

        public void EnableControls(bool isEnable)
        {
            cashierPanel.NameBox.Enabled = isEnable;
            cashierPanel.SecondNameBox.Enabled = isEnable;
            cashierPanel.PatronicBox.Enabled = isEnable;
            cashierPanel.UpdateButton.Enabled = isEnable;
            cashierPanel.AddButton.Enabled = isEnable;
        }
        public async Task<bool> RemoveAccount()
        {
            try
            {
                if (!Guid.TryParse(cashierPanel.IdpassBox.Text, out Guid accountId))
                    return false;

                var cashier = context.Accounts.Find(accountId);
                if (cashier == null)
                {
                    MessageBox.Show("Даного касира не існує");
                    return false;
                }

                context.Accounts.Remove(cashier);

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
