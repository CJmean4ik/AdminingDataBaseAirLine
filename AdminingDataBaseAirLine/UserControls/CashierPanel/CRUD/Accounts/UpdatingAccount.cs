using AdminingDataBaseAirLine.UserControls.PassangerPanel.CRUD;
using AirlineDataBase;
using AirlineDataBase.Entityes.Accounts;
using AirlineDataBase.Entityes.RouteAndFlight;

namespace AdminingDataBaseAirLine.UserControls.CashierPanel.CRUD.Accounts
{
    internal class UpdatingAccount
    {
        private Dictionary<Func<Account, Account, bool>, TrackingModifierArguments<Account, AirCompanyContext, CashierPanelControl>> modifiedProperty;
       
        private CashierPanelControl cashierPanel;
        public bool IsPrepering { get; set; }

        public UpdatingAccount(CashierPanelControl cashierPanel)
        {
            this.cashierPanel = cashierPanel;
            BindRouts();
        }

        public void EnableControls(bool isEnable)
        {
            cashierPanel.IdpassBox.Enabled = isEnable;
            cashierPanel.NameBox.Enabled = isEnable;
            cashierPanel.SecondNameBox.Enabled = isEnable;
            cashierPanel.PatronicBox.Enabled = isEnable;
            cashierPanel.IsCashierOperation.Enabled = isEnable;
            cashierPanel.RemoveButton.Enabled = isEnable;
            cashierPanel.AddButton.Enabled = isEnable;
            cashierPanel.AdminBox.Enabled = isEnable;
        }

        public void SearchModifieRoutProperty(Account comparableAccount, Account oldAccount, AirCompanyContext context)
        {
            foreach (var attachment in modifiedProperty)
            {
                if (attachment.Key.Invoke(comparableAccount, oldAccount))
                {
                    attachment.Value.ValueModifier.Invoke(comparableAccount, oldAccount);
                    attachment.Value.IsModified = true;
                }
            }

            foreach (var attachment in modifiedProperty)
            {
                if (attachment.Value.IsModified)
                {
                    attachment.Value.Attacher.Invoke(oldAccount, context);
                }
            }
        }
        public void UpdateDataInDataGridview(Account oldAccount)
        {
            int airlineplaneIndex = cashierPanel.DataGridView2.CurrentCell.RowIndex;

            foreach (var attachment in modifiedProperty)
            {
                if (attachment.Value.IsModified)
                {
                    attachment.Value.ChangerCells.Invoke(oldAccount, cashierPanel, airlineplaneIndex);
                }
            }
        }
        private void BindRouts()
        {
            modifiedProperty = new()
            {
                [(newV, oldV) => newV.Name != oldV.Name] = new()
                {
                    IsModified = false,
                    ValueModifier = (newV, oldV) => oldV.Name = newV.Name,
                    Attacher = (oldVm, db) => db.Entry(oldVm)
                                                .Property(p => p.Name)
                                                .IsModified = true,
                    ChangerCells = (newV, panel, rowIndex) => panel
                                                              .DataGridView2.Rows[rowIndex]
                                                              .Cells[1].Value = newV.Name
                },

                [(newV, oldV) => newV.Password != oldV.Password] = new()
                {
                    IsModified = false,
                    ValueModifier = (newV, oldV) => oldV.Password = newV.Password,
                    Attacher = (oldVm, db) => db.Entry(oldVm)
                                                .Property(p => p.Password)
                                                .IsModified = true,
                    ChangerCells = (newV, panel, rowIndex) => panel
                                                              .DataGridView2.Rows[rowIndex]
                                                              .Cells[2].Value = newV.Password
                },

                [(newV, oldV) => newV.Email != oldV.Email] = new()
                {
                    IsModified = false,
                    ValueModifier = (newV, oldV) => oldV.Email = newV.Email,
                    Attacher = (oldVm, db) => db.Entry(oldVm)
                                                .Property(p => p.Email)
                                                .IsModified = true,
                    ChangerCells = (newV, panel, rowIndex) => panel
                                                              .DataGridView2.Rows[rowIndex]
                                                              .Cells[3].Value = newV.Email
                },
              

            };

        }
    }
}
