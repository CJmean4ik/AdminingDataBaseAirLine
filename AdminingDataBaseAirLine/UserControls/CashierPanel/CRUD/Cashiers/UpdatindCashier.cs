using AdminingDataBaseAirLine.UserControls.PassangerPanel.CRUD;
using AirlineDataBase.Entityes.Accounts;
using AirlineDataBase;

namespace AdminingDataBaseAirLine.UserControls.CashierPanel.CRUD.Cashiers
{
    internal class UpdatindCashier
    {
        private Dictionary<Func<Cashier, Cashier, bool>, TrackingModifierArguments<Cashier, AirCompanyContext, CashierPanelControl>> modifiedProperty;

        private CashierPanelControl cashierPanel;
        public bool IsPrepering { get; set; }

        public UpdatindCashier(CashierPanelControl cashierPanel)
        {
            this.cashierPanel = cashierPanel;
            BindRouts();
        }

        public void SearchModifieRoutProperty(Cashier comparableCashier, Cashier oldCashier, AirCompanyContext context)
        {
            foreach (var attachment in modifiedProperty)
            {
                if (attachment.Key.Invoke(comparableCashier, oldCashier))
                {
                    attachment.Value.ValueModifier.Invoke(comparableCashier, oldCashier);
                    attachment.Value.IsModified = true;
                }
            }

            foreach (var attachment in modifiedProperty)
            {
                if (attachment.Value.IsModified)
                {
                    attachment.Value.Attacher.Invoke(oldCashier, context);
                }
            }
        }
        public void UpdateDataInDataGridview(Cashier oldCashier)
        {
            int airlineplaneIndex = cashierPanel.DataGridView2.CurrentCell.RowIndex;

            foreach (var attachment in modifiedProperty)
            {
                if (attachment.Value.IsModified)
                {
                    attachment.Value.ChangerCells.Invoke(oldCashier, cashierPanel, airlineplaneIndex);
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
                                                              .DataGridView1.Rows[rowIndex]
                                                              .Cells[2].Value = newV.Name
                },
                [(newV, oldV) => newV.Surname != oldV.Surname] = new()
                {
                    IsModified = false,
                    ValueModifier = (newV, oldV) => oldV.Surname = newV.Surname,
                    Attacher = (oldVm, db) => db.Entry(oldVm)
                                                .Property(p => p.Surname)
                                                .IsModified = true,
                    ChangerCells = (newV, panel, rowIndex) => panel
                                                              .DataGridView1.Rows[rowIndex]
                                                              .Cells[1].Value = newV.Surname
                },
                [(newV, oldV) => newV.Surname != oldV.Patronymic] = new()
                {
                    IsModified = false,
                    ValueModifier = (newV, oldV) => oldV.Patronymic = newV.Patronymic,
                    Attacher = (oldVm, db) => db.Entry(oldVm)
                                                .Property(p => p.Surname)
                                                .IsModified = true,
                    ChangerCells = (newV, panel, rowIndex) => panel
                                                              .DataGridView1.Rows[rowIndex]
                                                              .Cells[3].Value = newV.Patronymic
                },

            };


        }

        internal void EnableControls(bool isEnable)
        {
            cashierPanel.AddButton.Enabled = isEnable;
            cashierPanel.RemoveButton.Enabled = isEnable;
            cashierPanel.UserNameBox.Enabled = isEnable;
            cashierPanel.IdpassBox.Enabled = isEnable;
            cashierPanel.PasswordBox.Enabled = isEnable;
            cashierPanel.AdminBox.Enabled = isEnable;
            cashierPanel.MailBox.Enabled = isEnable;
        }
    }
}
