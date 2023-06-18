using AdminingDataBaseAirLine.UserControls.PassangerPanel.CRUD;
using AirlineDataBase;
using AirlineDataBase.Entityes.AirlinePlanes;
using AirlineDataBase.Entityes.RouteAndFlight;

namespace AdminingDataBaseAirLine.UserControls.RoutsPanel.CRUD
{
    internal class UpdatingRouts
    {
        private Dictionary<Func<Route, Route, bool>, TrackingModifierArguments<Route, AirCompanyContext, RoutsControlPanel>> modifiedProperty;


        private RoutsControlPanel routsControl;
        public bool IsPrepering { get; set; }

        public UpdatingRouts(RoutsControlPanel routsControl)
        {
            this.routsControl = routsControl;
            BindRouts();
        }
        public void EnableControls(bool isEnable)
        {
            routsControl.RouteId.Enabled = isEnable;
            routsControl.RemoveButton.Enabled = isEnable;
            routsControl.AddButton.Enabled = isEnable;
        }

        public void SearchModifieRoutProperty(Route comparableRoute, Route oldRoute, AirCompanyContext context)
        {
            foreach (var attachment in modifiedProperty)
            {
                if (attachment.Key.Invoke(comparableRoute, oldRoute))
                {
                    attachment.Value.ValueModifier.Invoke(comparableRoute, oldRoute);
                    attachment.Value.IsModified = true;
                }
            }

            foreach (var attachment in modifiedProperty)
            {
                if (attachment.Value.IsModified)
                {
                    attachment.Value.Attacher.Invoke(oldRoute, context);
                }
            }
        }

        public void UpdateDataInDataGridview(Route oldRoute)
        {
            int airlineplaneIndex = routsControl.dataGridView1.CurrentCell.RowIndex;

            foreach (var attachment in modifiedProperty)
            {
                if (attachment.Value.IsModified)
                {
                    attachment.Value.ChangerCells.Invoke(oldRoute, routsControl, airlineplaneIndex);
                }
            }
        }
        private void BindRouts()
        {
            modifiedProperty = new()
            {
                [(newV, oldV) => newV.FromWhere != oldV.FromWhere] = new()
                {
                    IsModified = false,
                    ValueModifier = (newV, oldV) => oldV.FromWhere = newV.FromWhere,
                    Attacher = (oldVm, db) => db.Entry(oldVm)
                                                .Property(p => p.FromWhere)
                                                .IsModified = true,
                    ChangerCells = (newV, panel, rowIndex) => panel
                                                              .dataGridView1.Rows[rowIndex]
                                                              .Cells[1].Value = newV.FromWhere
                },

                [(newV, oldV) => newV.Where != oldV.Where] = new()
                {
                    IsModified = false,
                    ValueModifier = (newV, oldV) => oldV.Where = newV.Where,
                    Attacher = (oldVm, db) => db.Entry(oldVm)
                                                .Property(p => p.Where)
                                                .IsModified = true,
                    ChangerCells = (newV, panel, rowIndex) => panel
                                                              .dataGridView1.Rows[rowIndex]
                                                              .Cells[2].Value = newV.Where
                },

                [(newV, oldV) => newV.Departure != oldV.Departure] = new()
                {
                    IsModified = false,
                    ValueModifier = (newV, oldV) => oldV.Departure = newV.Departure,
                    Attacher = (oldVm, db) => db.Entry(oldVm)
                                                .Property(p => p.Departure)
                                                .IsModified = true,
                    ChangerCells = (newV, panel, rowIndex) => panel
                                                              .dataGridView1.Rows[rowIndex]
                                                              .Cells[3].Value = newV.Departure
                },
                [(newV, oldV) => newV.Incoming != oldV.Incoming] = new()
                {
                    IsModified = false,
                    ValueModifier = (newV, oldV) => oldV.Incoming = newV.Incoming,
                    Attacher = (oldVm, db) => db.Entry(oldVm)
                                                .Property(p => p.Incoming)
                                                .IsModified = true,
                    ChangerCells = (newV, panel, rowIndex) => panel
                                                              .dataGridView1.Rows[rowIndex]
                                                              .Cells[4].Value = newV.Incoming
                },

            };

        }
    }
}
