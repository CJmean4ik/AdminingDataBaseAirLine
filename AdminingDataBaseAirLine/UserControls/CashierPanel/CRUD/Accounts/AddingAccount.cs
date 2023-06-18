using AirlineDataBase;
using AirlineDataBase.Entityes.Accounts;
using System.Data.Entity;

namespace AdminingDataBaseAirLine.UserControls.CashierPanel.CRUD.Accounts
{
    internal class AddingAccount
    {
        private AirCompanyContext context;
        private CashierPanelControl cashierPanel;
        public bool IsPrepering { get; set; }

        public AddingAccount(AirCompanyContext context, CashierPanelControl cashierPanel)
        {
            this.context = context;
            this.cashierPanel = cashierPanel;
        }

        public void EnableControls(bool isEnable)
        {
            cashierPanel.PatronicBox.Enabled = isEnable;
            cashierPanel.SecondNameBox.Enabled = isEnable;
        }

        public async Task LoadDataToLocalCash()
        {
            if (context.Accounts.Local.Count == 0)
            {
                await context.Accounts.LoadAsync();
            }
        }

        private bool ExistAccount()
        {
            string PASSWORD = cashierPanel.PasswordBox.Text;
            string USERNAME = cashierPanel.UserNameBox.Text;

            var account = context.Accounts.Local.Where(w => w.Password == PASSWORD && w.Name == USERNAME)
                .FirstOrDefault();

            if (account != null) return false;

            return true;
        }
        private TypeAccount CheckTypeAccount()
        {
            string CASHIER_ID = cashierPanel.IdpassBox.Text;

            if (CASHIER_ID == "")
                return TypeAccount.Admin;

            return TypeAccount.Cashier;

        }
        private bool ExistCashierAccount()
        {
            if (!int.TryParse(cashierPanel.IdpassBox.Text, out int cashieId))
            {
                MessageBox.Show("Не вдалося отримати ID касира");
                return false;
            }

            var account = context.Accounts.Local.Where(w => w.Cashier.ID == cashieId)
                .FirstOrDefault();

            if (account != null) return false;

            return true;
        }
        private Account CreateAccount(TypeAccount typeAccount)
        {
            Account account = new Account()
            {
                IsAdmin = true,
                Email = cashierPanel.MailBox.Text,
                Name = cashierPanel.UserNameBox.Text,
                Password = cashierPanel.PasswordBox.Text,
                          
            };

            if (typeAccount == TypeAccount.Admin) return account;

            account.IsAdmin = false;

            int cashierId = int.Parse(cashierPanel.IdpassBox.Text);
            account.Cashier = context.Cashiers.Where(w => w.ID == cashierId).FirstOrDefault();
            return account;
        }
        private Account PreperingToAdding()
        {
            TypeAccount type = CheckTypeAccount();
            if (type == TypeAccount.Admin)
                return PreperingToAddingAdminAccount(type);

            if (type == TypeAccount.Cashier)
                return PreperingToAddingCashierAccount(type);

            MessageBox.Show("Не знайдено відповідного типу акаунта");
            return null;
        }
        private Account PreperingToAddingCashierAccount(TypeAccount type)
        {
            if (!ExistCashierAccount())
            {
                MessageBox.Show("Даний акаунт для касира вже є");
                return null;
            }

            return CreateAccount(type);
        }
        private Account PreperingToAddingAdminAccount(TypeAccount type)
        {
            if (!ExistAccount())
            {
                MessageBox.Show("Даний акаунт вже є");
                return null;
            }

            return CreateAccount(type);
        }

        public async Task<(bool isComplete, Account? addedAccount)> AddAccount()
        {
            try
            {
                var account = PreperingToAdding();
                if (account == null) return (false, null);

                context.Accounts.Add(account);
                await context.SaveChangesAsync();
                return (true, account);
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
                return (false, null);
            }
        }
    }

    enum TypeAccount
    {
        Admin,
        Cashier
    }
}
