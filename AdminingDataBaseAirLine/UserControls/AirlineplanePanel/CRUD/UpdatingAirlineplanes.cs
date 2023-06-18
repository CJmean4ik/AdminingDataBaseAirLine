using AdminingDataBaseAirLine.UserControls.PassangerPanel.CRUD;
using AirlineDataBase;
using AirlineDataBase.Entityes.AirlinePlanes;

namespace AdminingDataBaseAirLine.UserControls.AirlineplanePanel.CRUD
{
    internal class UpdatingAirlineplanes
    {
        private Dictionary<Func<AirlinePlane, AirlinePlane, bool>, TrackingModifierArguments<AirlinePlane, AirCompanyContext, AirlineplaneControl>> modifiedProperty;
        private Dictionary<Func<AirLine, AirLine, bool>, TrackingModifierArguments<AirLine, AirCompanyContext, AirlineplaneControl>> modifiedPropertyAirLine;
        private Dictionary<Func<Airplane, Airplane, bool>, TrackingModifierArguments<Airplane, AirCompanyContext, AirlineplaneControl>> modifiedPropertyAirPlane;

        public bool IsNowUpdate { get; internal set; }
        public AirlineplaneControl airlineplane { get; set; }
        public UpdatingAirlineplanes(AirlineplaneControl airlineplane)
        {

            this.airlineplane = airlineplane;
            BindAirLine();
            BindAirplane();
            BinderAirlLineplane();
        }
        public void PreparingUpdate()
        {
            airlineplane.AddButton.Enabled = false;
            airlineplane.RemoveButton.Enabled = false;
        }
        public void SearchModifieAirlinePlaneProperty(AirlinePlane comparableAirlinePlane, AirlinePlane oldAirlinePlane, AirCompanyContext context)
        {
            foreach (var attachment in modifiedProperty)
            {
                if (attachment.Key.Invoke(comparableAirlinePlane, oldAirlinePlane))
                {
                    attachment.Value.ValueModifier.Invoke(comparableAirlinePlane, oldAirlinePlane);
                    attachment.Value.IsModified = true;
                }
            }

            foreach (var attachment in modifiedProperty)
            {
                if (attachment.Value.IsModified)
                {
                    attachment.Value.Attacher.Invoke(oldAirlinePlane, context);
                }
            }
        }
        public void SearchModifieAirLineProperty(AirLine comparableAirlinePlane, AirLine oldAirlinePlane, AirCompanyContext context)
        {
            foreach (var attachment in modifiedPropertyAirLine)
            {
                if (attachment.Key.Invoke(comparableAirlinePlane, oldAirlinePlane))
                {
                    attachment.Value.ValueModifier.Invoke(comparableAirlinePlane, oldAirlinePlane);
                    attachment.Value.IsModified = true;
                }
            }

            foreach (var attachment in modifiedPropertyAirLine)
            {
                if (attachment.Value.IsModified)
                {
                    attachment.Value.Attacher.Invoke(oldAirlinePlane, context);
                }
            }
        }
        public void SearchModifieAirplaneProperty(Airplane comparableAirlinePlane, Airplane oldAirlinePlane, AirCompanyContext context)
        {
            foreach (var attachment in modifiedPropertyAirPlane)
            {
                if (attachment.Key.Invoke(comparableAirlinePlane, oldAirlinePlane))
                {
                    attachment.Value.ValueModifier.Invoke(comparableAirlinePlane, oldAirlinePlane);
                    attachment.Value.IsModified = true;
                }
            }

            foreach (var attachment in modifiedPropertyAirPlane)
            {
                if (attachment.Value.IsModified)
                {
                    attachment.Value.Attacher.Invoke(oldAirlinePlane, context);
                }
            }
        }

        public void UpdateDataInDataGridview(AirlinePlane oldAirlinePlane)
        {
            int airlineplaneIndex = airlineplane.DataGridView1.CurrentCell.RowIndex;

            foreach (var attachment in modifiedProperty)
            {
                if (attachment.Value.IsModified)
                {
                    attachment.Value.ChangerCells.Invoke(oldAirlinePlane, airlineplane, airlineplaneIndex);
                }
            }
        }
        private void BinderAirlLineplane()
        {
            modifiedProperty = new Dictionary<Func<AirlinePlane, AirlinePlane, bool>, TrackingModifierArguments<AirlinePlane, AirCompanyContext, AirlineplaneControl>>()
            {
                [(newV, oldV) => newV.InRaise != oldV.InRaise] = new()
                {
                    IsModified = false,
                    ValueModifier = (newV, oldV) => oldV.InRaise = newV.InRaise,
                    Attacher = (oldVm, db) => db.Entry(oldVm)
                                                .Property(p => p.InRaise)
                                                .IsModified = true,
                    ChangerCells = (newV, panel, rowIndex) => panel
                                                                    .DataGridView1.Rows[rowIndex]
                                                                    .Cells[6].Value = newV.InRaise
                },
                [(newV, oldV) => newV.SendingAirline != oldV.SendingAirline] = new()
                {
                    IsModified = false,
                    ValueModifier = (newV, oldV) => oldV.SendingAirline = newV.SendingAirline,
                    Attacher = (oldVm, db) => db.Entry(oldVm)
                                                .Property(p => p.SendingAirline)
                                                .IsModified = true,
                    ChangerCells = (newV, panel, rowIndex) => panel
                                                                 .DataGridView1.Rows[rowIndex]
                                                                 .Cells[6].Value = newV.InRaise
                },
            };
        }
        private void BindAirLine()
        {
            modifiedPropertyAirLine = new()
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
                                                              .Cells[1].Value = newV.Name
                },
                [(newV, oldV) => newV.Owner != oldV.Owner] = new()
                {
                    IsModified = false,
                    ValueModifier = (newV, oldV) => oldV.Owner = newV.Owner,
                    Attacher = (oldVm, db) => db.Entry(oldVm)
                                                .Property(p => p.Owner)
                                                .IsModified = true,
                    ChangerCells = (newV, panel, rowIndex) => panel
                                                                    .DataGridView1.Rows[rowIndex]
                                                                    .Cells[7].Value = newV.Owner
                },
            };

            
        }
        private void BindAirplane()
        {
            modifiedPropertyAirPlane = new Dictionary<Func<Airplane, Airplane, bool>, TrackingModifierArguments<Airplane, AirCompanyContext, AirlineplaneControl>>()
            {
                [(newV, oldV) => newV.Capacity != oldV.Capacity] = new()
                {
                    IsModified = false,
                    ValueModifier = (newV, oldV) => oldV.Capacity = newV.Capacity,
                    Attacher = (oldVm, db) => db.Entry(oldVm)
                                                .Property(p => p.Capacity)
                                                .IsModified = true,
                    ChangerCells = (newV, panel, rowIndex) => panel
                                                                    .DataGridView1.Rows[rowIndex]
                                                                    .Cells[4].Value = newV.Capacity
                },
                [(newV, oldV) => newV.TypeAirplane != oldV.TypeAirplane] = new()
                {
                    IsModified = false,
                    ValueModifier = (newV, oldV) => oldV.TypeAirplane = newV.TypeAirplane,
                    Attacher = (oldVm, db) => db.Entry(oldVm)
                                                .Property(p => p.TypeAirplane)
                                                .IsModified = true,
                    ChangerCells = (newV, panel, rowIndex) => panel
                                                                    .DataGridView1.Rows[rowIndex]
                                                                    .Cells[3].Value = newV.TypeAirplane
                },

                [(newV, oldV) => newV.Model != oldV.Model] = new()
                {
                    IsModified = false,
                    ValueModifier = (newV, oldV) => oldV.Model = newV.Model,
                    Attacher = (oldVm, db) => db.Entry(oldVm)
                                                .Property(p => p.Model)
                                                .IsModified = true,
                    ChangerCells = (newV, panel, rowIndex) => panel
                                                                    .DataGridView1.Rows[rowIndex]
                                                                    .Cells[5].Value = newV.Model
                },
            };
        }
    }
}
