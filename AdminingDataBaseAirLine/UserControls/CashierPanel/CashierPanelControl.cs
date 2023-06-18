using AdminingDataBaseAirLine.Properties;
using AdminingDataBaseAirLine.UserControls.CashierPanel.CRUD.Accounts;
using AdminingDataBaseAirLine.UserControls.CashierPanel.CRUD.Cashiers;
using AirlineDataBase;
using AirlineDataBase.Entityes.Accounts;
using System.Data;

namespace AdminingDataBaseAirLine.UserControls.CashierPanel
{
    public partial class CashierPanelControl : UserControl
    {
        private AirCompanyContext airlineContext;

        private AddinCashier addinCashier;
        private AddingAccount addingAccount;

        private UpdatingAccount updatingAccount;
        private UpdatindCashier updatinCashier;

        private RemovingCashier removingCashier;
        private RemovingAccount removingAccount;

        public CashierPanelControl()
        {
            InitializeComponent();
        }
        public CashierPanelControl(AirCompanyContext airlineContext) : this()
        {
            this.airlineContext = airlineContext;
            addinCashier = new AddinCashier(airlineContext, this);
            addingAccount = new AddingAccount(airlineContext, this);
            updatingAccount = new UpdatingAccount(this);
            updatinCashier = new UpdatindCashier(this);
            removingCashier = new RemovingCashier(airlineContext, this);
            removingAccount = new RemovingAccount(airlineContext, this);
        }
        private void clearButton_Click(object sender, EventArgs e)
        {

        }
        private void CashierPanelControl_Load(object sender, EventArgs e)
        {

        }
        public void InsertDataToDataGrigview()
        {
            var accounts = airlineContext.Accounts.Select(s => new
            {
                s.ID,
                s.Password,
                s.IsAdmin,
                s.Email,
                s.Name
            }).ToList();

            int count = accounts.Count();
            dataGridView2.Rows.Add(count);

            for (int i = 0; i < count; i++)
            {
                dataGridView2.Rows[i].Cells[0].Value = accounts[i].ID;
                dataGridView2.Rows[i].Cells[1].Value = accounts[i].Name;
                dataGridView2.Rows[i].Cells[2].Value = accounts[i].Password;
                dataGridView2.Rows[i].Cells[3].Value = accounts[i].Email;
                dataGridView2.Rows[i].Cells[4].Value = accounts[i].IsAdmin;
            }

            var cashiers = airlineContext.Cashiers.Select(s => new
            {
                s.ID,
                s.Name,
                s.Surname,
                s.Patronymic,
            }).ToList();

            int countCashier = cashiers.Count();
            dataGridView1.Rows.Add(countCashier);

            for (int i = 0; i < countCashier; i++)
            {
                dataGridView1.Rows[i].Cells[0].Value = cashiers[i].ID;
                dataGridView1.Rows[i].Cells[1].Value = cashiers[i].Surname;
                dataGridView1.Rows[i].Cells[2].Value = cashiers[i].Name;
                dataGridView1.Rows[i].Cells[3].Value = cashiers[i].Patronymic;
            }
        }
        private void isCashierAdd_CheckedChanged(object sender, EventArgs e)
        {
            if (!isAccounOperation.Checked)
            {
                isCashierOperation.Checked = true;
            }
        }
        private void checkBox1_CheckedChanged(object sender, EventArgs e)
        {
            if (!isCashierOperation.Checked)
            {
                isAccounOperation.Checked = true;
            }
        }
        private async void addButton_Click(object sender, EventArgs e)
        {
            if (isAccounOperation.Checked)
            {
                await AddOnlyAccount();
                return;
            }
            if (isCashierOperation.Checked)
            {
                await AddOnlyCashier();
                return;
            }
        }
        private async Task AddOnlyCashier()
        {
            if (!addinCashier.IsPrepering)
            {
                addinCashier.EnableControls(false);
                addButton.Image = Resources.save;
                addinCashier.IsPrepering = true;
                return;
            }

            await addinCashier.LoadDataToLocalCash();

            var result = await addinCashier.AddCashier();
            if (!result.isAdded)
            {
                cancelOperationBtn_Click(this, new EventArgs());
                return;
            }

            AddCashierToDataGrid(result.addedCashier!);

            cancelOperationBtn_Click(this, new EventArgs());
            return;

        }
        private void AddCashierToDataGrid(Cashier cashier)
        {
            dataGridView1.Rows.Add(1);
            int lastIndex = dataGridView1.Rows.GetLastRow(DataGridViewElementStates.None);

            dataGridView1.Rows[lastIndex].Cells[0].Value = cashier.ID;
            dataGridView1.Rows[lastIndex].Cells[1].Value = cashier.Surname;
            dataGridView1.Rows[lastIndex].Cells[2].Value = cashier.Name;
            dataGridView1.Rows[lastIndex].Cells[3].Value = cashier.Patronymic;

        }
        private async Task AddOnlyAccount()
        {
            if (!addingAccount.IsPrepering)
            {
                addingAccount.EnableControls(false);
                addButton.Image = Resources.save;
                addingAccount.IsPrepering = true;
                return;
            }

            await addingAccount.LoadDataToLocalCash();

            var result = await addingAccount.AddAccount();

            if (!result.isComplete)
            {
                cancelOperationBtn_Click(this, new EventArgs());
                return;
            }

            AddAccountToDataGrid(result.addedAccount!);

            cancelOperationBtn_Click(this, new EventArgs());
            return;
        }
        private void AddAccountToDataGrid(Account account)
        {
            dataGridView2.Rows.Add(1);
            int lastIndex = dataGridView2.Rows.GetLastRow(DataGridViewElementStates.None);

            dataGridView2.Rows[lastIndex].Cells[0].Value = account.ID;
            dataGridView2.Rows[lastIndex].Cells[1].Value = account.Name;
            dataGridView2.Rows[lastIndex].Cells[2].Value = account.Password;
            dataGridView2.Rows[lastIndex].Cells[3].Value = account.Email;
            dataGridView2.Rows[lastIndex].Cells[4].Value = account.IsAdmin;

        }
        private void cancelOperationBtn_Click(object sender, EventArgs e)
        {
            if (addingAccount.IsPrepering)
            {
                addingAccount.EnableControls(true);
                addButton.Image = Resources.add;
                addingAccount.IsPrepering = false;
                return;
            }
            if (addinCashier.IsPrepering)
            {
                addinCashier.EnableControls(true);
                addButton.Image = Resources.add;
                addinCashier.IsPrepering = false;
                return;
            }
            if (updatingAccount.IsPrepering)
            {
                updatingAccount.EnableControls(true);
                updateButton.Image = Resources.update;
                updatingAccount.IsPrepering = false;
                return;
            }
            if (updatinCashier.IsPrepering)
            {
                updatinCashier.EnableControls(true);
                updateButton.Image = Resources.update;
                updatinCashier.IsPrepering = false;
                return;
            }
            if (removingCashier.IsPrepering)
            {
                removingCashier.EnableControls(true);
                removeButton.Image = Resources.remove;
                removingCashier.IsPrepering = false;
                return;
            }
            if (removingAccount.IsPrepering)
            {
                removingCashier.EnableControls(true);
                removeButton.Image = Resources.remove;
                removingCashier.IsPrepering = false;
                return;
            }
        }
        private async void updateButton_Click(object sender, EventArgs e)
        {
            if (isAccounOperation.Checked)
            {
                await UpdateOnlyAccount();
                return;
            }
            if (isCashierOperation.Checked)
            {
                await UpdateOnlyCashier();
                return;
            }
        }
        private async Task UpdateOnlyCashier()
        {
            if (!updatinCashier.IsPrepering)
            {
                updatinCashier.EnableControls(false);
                updateButton.Image = Resources.done;
                updatinCashier.IsPrepering = true;
                return;
            }

            Cashier newCashier = new Cashier()
            {
                Name = NameBox.Text,
                Surname = SecondNameBox.Text,
                Patronymic = PatronicBox.Text,

            };

            if (!int.TryParse(idpassBox.Text, out int cashierId))
            {
                MessageBox.Show("Не вдалося отримати ID касира");
                cancelOperationBtn_Click(this, new EventArgs());
                return;
            }

            Cashier? oldCashier = airlineContext.Cashiers.Where(w => w.ID == cashierId).FirstOrDefault();

            updatinCashier.SearchModifieRoutProperty(newCashier, oldCashier, airlineContext);

            await airlineContext.SaveChangesAsync();

            updatinCashier.UpdateDataInDataGridview(newCashier);

            cancelOperationBtn_Click(this, new EventArgs());
        }
        private async Task UpdateOnlyAccount()
        {
            if (!updatingAccount.IsPrepering)
            {
                updatingAccount.EnableControls(false);
                updateButton.Image = Resources.done;
                updatingAccount.IsPrepering = true;
                return;
            }

            Account newAccount = new Account()
            {
                Name = UserNameBox.Text,
                Password = PasswordBox.Text,
                Email = mailBox.Text
            };

            if (!Guid.TryParse(IdpassBox.Text, out Guid accountId))
            {
                MessageBox.Show("Не можливо отримати ID цього користувача");
                cancelOperationBtn_Click(this, new EventArgs());
                return;
            }

            var oldAccount = airlineContext.Accounts.Where(s => s.ID == accountId).FirstOrDefault();

            updatingAccount.SearchModifieRoutProperty(newAccount, oldAccount, airlineContext);

            await airlineContext.SaveChangesAsync();

            updatingAccount.UpdateDataInDataGridview(newAccount);

            cancelOperationBtn_Click(this, new EventArgs());
        }
        private void dataGridView2_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

            int Index = dataGridView2.CurrentCell.RowIndex;

            idpassBox.Text = dataGridView2.Rows[Index].Cells[0].Value.ToString();
            UserNameBox.Text = dataGridView2.Rows[Index].Cells[1].Value.ToString();
            PasswordBox.Text = dataGridView2.Rows[Index].Cells[2].Value.ToString();
            MailBox.Text = dataGridView2.Rows[Index].Cells[3].Value.ToString();
            AdminBox.Text = (bool)dataGridView2.Rows[Index].Cells[4].Value ? "Так" : "Ні";
        }
        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            int Index = dataGridView1.CurrentCell.RowIndex;

            idpassBox.Text = dataGridView1.Rows[Index].Cells[0].Value.ToString();
            SecondNameBox.Text = dataGridView1.Rows[Index].Cells[1].Value.ToString();
            nameBox.Text = dataGridView1.Rows[Index].Cells[2].Value.ToString();
            patronicBox.Text = dataGridView1.Rows[Index].Cells[3].Value.ToString();
        }
        private async void removeButton_Click(object sender, EventArgs e)
        {
            if (isAccounOperation.Checked)
            {
                await RemoveOnlyAccount();
                return;
            }
            if (isCashierOperation.Checked)
            {
                await RemoveOnlyCashier();
                return;
            }
        }
        private async Task RemoveOnlyCashier()
        {
            if (!removingCashier.IsPrepering)
            {
                removingCashier.EnableControls(false);
                removeButton.Image = Resources.doneDelete;
                removingCashier.IsPrepering = true;
                return;
            }

            await removingCashier.LoadDataToLocalCash();

            bool isRemoved = await removingCashier.RemoveCashier();

            if (!isRemoved)
            {
                cancelOperationBtn_Click(this, new EventArgs());
                return;
            }

            int rowsId = dataGridView1.CurrentCell.RowIndex;
            DataGridView1.Rows.RemoveAt(rowsId);
            cancelOperationBtn_Click(this, new EventArgs());
        }
        private async Task RemoveOnlyAccount()
        {
            if (!removingAccount.IsPrepering)
            {
                removingAccount.EnableControls(false);
                removeButton.Image = Resources.doneDelete;
                removingAccount.IsPrepering = true;
                return;
            }

            await removingAccount.LoadDataToLocalCash();

            bool isRemoved = await removingAccount.RemoveAccount();

            if (!isRemoved)
            {
                cancelOperationBtn_Click(this, new EventArgs());
                return;
            }

            int rowsId = dataGridView2.CurrentCell.RowIndex;
            DataGridView2.Rows.RemoveAt(rowsId);
            cancelOperationBtn_Click(this, new EventArgs());
        }
    }
}
