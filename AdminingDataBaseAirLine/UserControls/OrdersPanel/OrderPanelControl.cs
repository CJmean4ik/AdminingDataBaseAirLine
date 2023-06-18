using AdminingDataBaseAirLine.Properties;
using AirlineDataBase;
using AirlineDataBase.Entityes.Accounts;
using AirlineDataBase.Entityes.AirlinePlanes;
using AirlineDataBase.Entityes.RouteAndFlight;
using AirlineDataBase.Entityes.TicketAndOrders;
using System.Data;
using System.Data.Entity;

namespace AdminingDataBaseAirLine.UserControls.OrdersPanel
{
    public partial class OrderPanelControl : UserControl
    {
        public AirCompanyContext Context { get; set; }

        private AddingOrders _addingOrders;
        private List<Orders> _listForSorting;
        private OrderSorter _sorter;

        private int? _cashierId;
        private bool _prepering;
        private bool _loadedToLocalCash;

        public OrderPanelControl()
        {
            InitializeComponent();
        }
        public OrderPanelControl(AirCompanyContext airCompanyContext, int? cashierId) : this()
        {
            Context = airCompanyContext;
            _cashierId = cashierId;
            _addingOrders = new AddingOrders(Context, this);
            _listForSorting = new List<Orders>();
            _sorter = new OrderSorter(this);
        }
        private void OrderPanelControl_Load(object sender, EventArgs e)
        {
            OrdersDataBinder();
        }

        public async Task LoadDataInLocalCashAsync()
        {
            await Context.Flights.LoadAsync();
            await Context.AirlinePlanes.LoadAsync();
            await Context.Airplanes.LoadAsync();
            await Context.Routes.LoadAsync();
        }
        private void OrdersDataBinder()
        {
            var airplanesModel = Context.Airplanes.Select(s => s.Model).ToArray();
            var frightsName = Context.Flights.Select(s => s.NameRoute).ToArray();

            var routesFromWhere = Context.Routes.Select(s => s.FromWhere).ToArray();
            var routesWhere = Context.Routes.Select(s => s.Where).ToArray();

            airPlaneBox.Items.AddRange(airplanesModel);
            flightNamesBox.Items.AddRange(frightsName);
            fromWhereBox.Items.AddRange(routesFromWhere);
            whereBox.Items.AddRange(routesWhere);
        }
        public void BindDataGridView()
        {
            var orders = Context.Orders.Select(s => new
            {
                s.ID,
                s.Ticket.Flight.Route.FromWhere,
                s.Ticket.Flight.Route.Where,
                s.Passenger.Name,
                s.Passenger.Surname,
                s.Ticket.Flight.AirlinePlane.Airplane.Model,
                s.Ticket.Flight.NameRoute,
            })
            .AsEnumerable()
            .Select(s => new Orders()
            {
                ID = s.ID,
                Passenger = new Passenger()
                {
                    Name = s.Name,
                    Surname = s.Surname
                },
                Ticket = new Ticket()
                {
                    Flight = new Flight()
                    {
                        Route = new Route()
                        {
                            FromWhere = s.FromWhere,
                            Where = s.Where
                        },
                        NameRoute = s.NameRoute,
                        AirlinePlane = new AirlinePlane()
                        {
                            Airplane = new Airplane
                            {
                                Model = s.Model
                            }
                        }
                    }
                },
            })
            .ToList();

            _listForSorting.AddRange(orders);

            InsertDataToDataGridView(orders);
        }
        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            InsertValueInBoxFromCells();
        }
        private void InsertValueInBoxFromCells()
        {
            var textBoxs = SelectButtonFromControls().OrderBy(b => b.Tag).ToList();

            int clicedIndexCells = dataGridView1.CurrentRow.Index;

            for (int i = 0; i < dataGridView1.ColumnCount; i++)
            {
                if (int.TryParse(textBoxs[i].Tag.ToString(), out int res))
                {
                    if (i == res)
                        textBoxs[i].Text = dataGridView1.Rows[clicedIndexCells].Cells[i].Value.ToString();
                }
            }
        }
        private List<Control> SelectButtonFromControls()
        {
            var boxs = Controls;

            var textBoxs = new List<Control>();

            foreach (var control in boxs)
            {
                if (control is TextBox textBox)
                {
                    textBoxs.Add(textBox);
                    continue;
                }
                if (control is ComboBox comboBox)
                {
                    textBoxs.Add(comboBox);
                    continue;
                }
            }
            if (textBoxs.Count == 0) return new List<Control>();

            return textBoxs;

        }
        private async void addButton_Click(object sender, EventArgs e)
        {
            if (!_prepering)
            {
                _addingOrders.EnableIdBox(false);
                erorLabel.Visible = false;
                removeButton.Enabled = false;
                addButton.Image = Resources.save;
                clearButton_Click(this, new EventArgs());
                _prepering = true;
                return;
            }

            if (!_loadedToLocalCash)
            {
                await _addingOrders.LoadRelatedEnityToLocalCashAsync();
                _loadedToLocalCash = true;
            }

            Orders? orders = await _addingOrders.AddOrdersAsync(_cashierId);

            if (orders != null)
            {
                addButton.Image = Resources.add;
                _addingOrders.EnableIdBox(true);
                removeButton.Enabled = true;
                _prepering = false;
                erorLabel.Visible = false;
                InsertDataToDataGridView(orders);
                _listForSorting.Add(orders);
                return;
            }
        }
        private void InsertDataToDataGridView(List<Orders> orders)
        {
            for (int j = 0; j < orders.Count; j++)
            {
                InsertDataToDataGridView(orders[j]);
            }
        }
        private void InsertDataToDataGridView(Orders orders)
        {
            dataGridView1.Rows.Add(1);
            int rowIndex = dataGridView1.Rows.GetLastRow(DataGridViewElementStates.None);

            dataGridView1.Rows[rowIndex].Cells[0].Value = orders.ID;
            dataGridView1.Rows[rowIndex].Cells[1].Value = orders.Ticket.Flight.Route.FromWhere;
            dataGridView1.Rows[rowIndex].Cells[2].Value = orders.Ticket.Flight.Route.Where;
            dataGridView1.Rows[rowIndex].Cells[3].Value = orders.Passenger.Name;
            dataGridView1.Rows[rowIndex].Cells[4].Value = orders.Passenger.Surname;
            dataGridView1.Rows[rowIndex].Cells[5].Value = orders.Ticket.Flight.AirlinePlane.Airplane.Model;
            dataGridView1.Rows[rowIndex].Cells[6].Value = orders.Ticket.Flight.NameRoute;

        }
        private void clearButton_Click(object sender, EventArgs e)
        {
            var textBox = SelectButtonFromControls();

            foreach (var control in textBox)
            {
                if (control.Text != "")
                {
                    control.Text = "";
                    continue;
                }
            }
        }
        private void flightNamesBox_SelectedIndexChanged(object sender, EventArgs e)
        {

        
            var routes = Context.Flights.Local
                .Where(w => w.NameRoute == FlightNamesBox.Text)
                .Select(s => new
                {
                    s.Route.FromWhere,
                    s.Route.Where,
                    s.AirlinePlane.Airplane.Model,
                })
                .FirstOrDefault();

            FromWhereBox.Text = routes?.FromWhere;
            WhereBox.Text = routes?.Where;
            AirPlaneBox.Text = routes?.Model;

        }
        private async void removeButton_Click(object sender, EventArgs e)
        {
            try
            {

                int rowsIndex = dataGridView1.CurrentCell.RowIndex;
                Guid ordersId = Guid.Parse(dataGridView1.Rows[rowsIndex].Cells[0].Value.ToString()!);

                Orders orders = Context.Orders.Find(ordersId);

                Context.Orders.Remove(orders);

                await Context.SaveChangesAsync();
                dataGridView1.Rows.RemoveAt(rowsIndex);
                erorLabel.Visible = false;
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message + "Не вдалося видалити замовлення!");
            }
        }
        private void acceptFilterBtn_Click(object sender, EventArgs e)
        {
            var result = _sorter.SortingData(_listForSorting);
            if (result == null) return;

            dataGridView1.Rows.Clear();
            InsertDataToDataGridView(result);
            
        }
        private void declineFilter_Click(object sender, EventArgs e)
        {
            dataGridView1.Rows.Clear();
            InsertDataToDataGridView(_listForSorting);
        }
    }
}
