using AirlineDataBase;
using AirlineDataBase.Entityes.Accounts;
using System.Data.Entity;

namespace AdminingDataBaseAirLine.UserControls.CashierPanel.CRUD.Cashiers
{
    internal class AddinCashier
    {
        private AirCompanyContext context;
        private CashierPanelControl cashierPanel;
        public bool IsPrepering { get; set; }

        public AddinCashier(AirCompanyContext context, CashierPanelControl cashierPanel)
        {
            this.context = context;
            this.cashierPanel = cashierPanel;
        }
        public void EnableControls(bool isEnable)
        {
            cashierPanel.UserNameBox.Enabled = isEnable;
            cashierPanel.IdpassBox.Enabled = isEnable;
            cashierPanel.PasswordBox.Enabled = isEnable;
            cashierPanel.AdminBox.Enabled = isEnable;
            cashierPanel.MailBox.Enabled = isEnable;
            cashierPanel.UpdateButton.Enabled = isEnable;
            cashierPanel.RemoveButton.Enabled = isEnable;
        }
        public async Task LoadDataToLocalCash()
        {
            if (context.Cashiers.Local.Count == 0)
                await context.Accounts.LoadAsync();

        }
        private bool NonExistCashier()
        {
            string CASHIER_NAME = cashierPanel.NameBox.Text;
            string CASHIER_SECONDNAME = cashierPanel.SecondNameBox.Text;
            string CASHIER_PATRONIC = cashierPanel.PatronicBox.Text;

            var cashier = context.Cashiers.Local
                .Where(w => w.Name == CASHIER_NAME && w.Patronymic == CASHIER_PATRONIC && w.Surname == CASHIER_SECONDNAME)
                .FirstOrDefault();

            if (cashier != null) return false;

            return true;

        }
        private Cashier CreateCashier()
        {
            Cashier cashier = new Cashier()
            {
                Name = cashierPanel.NameBox.Text,
                Surname = cashierPanel.SecondNameBox.Text,
                Patronymic = cashierPanel.PatronicBox.Text,
            };
            return cashier;
        }
        private Cashier? PreperingToAdding()
        {
            if (!NonExistCashier())
            {
                MessageBox.Show("Даний касир вже є у системі");
                return null;
            }
            return CreateCashier();
        }
        public async Task<(bool isAdded, Cashier? addedCashier)> AddCashier()
        {
            try
            {
                var cashier = PreperingToAdding();
                if (cashier == null) return (false, null);

                context.Cashiers.Add(cashier);
                await context.SaveChangesAsync();

                return (true, cashier);
            }
            catch (Exception ex)
            {
                MessageBox.Show("Не вдалося додати касира " + ex.Message);
                return (false, null);
                throw;
            }
        }
    }
}
