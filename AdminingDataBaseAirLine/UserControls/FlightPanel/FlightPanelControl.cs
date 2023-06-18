using AdminingDataBaseAirLine.Properties;
using AdminingDataBaseAirLine.UserControls.FlightPanel.CRUD;
using AirlineDataBase;
using AirlineDataBase.Entityes.AirlinePlanes;
using AirlineDataBase.Entityes.RouteAndFlight;
using System.Data;

namespace AdminingDataBaseAirLine.UserControls.FlightPanel
{
    public partial class FlightPanelControl : UserControl
    {
        private AirCompanyContext _context;
        private bool isAdminControl;
        private AddingFlight adding;
        private RemovingFlight removing;

        public FlightPanelControl()
        {
            InitializeComponent();


        }
        public FlightPanelControl(AirCompanyContext airlineContext, bool isAdmin) : this()
        {
            _context = airlineContext;
            isAdminControl = isAdmin;
            adding = new AddingFlight(_context, this);
            removing = new RemovingFlight(_context, this);
        }


        private void FlightPanelControl_Load(object sender, EventArgs e)
        {
            if (isAdminControl)
            {
                airplaneTypeBox.Items.AddRange(_context.Airplanes.Select(s => s.Model).ToArray());
                senderBox.Items.AddRange(_context.AirLines.Select(s => s.Name).ToArray());
                return;

            }


            dataGridView1.Size = dataGridView1.MaximumSize;
            panel1.Size = panel1.MaximumSize;


        }

        public void InsertDataToDataGrigview()
        {
            var Flights = _context.Flights.Select(s => new
            {
                s.NumberFlight,
                s.Route.FromWhere,
                s.Route.Where,
                s.Route.Incoming,
                s.Route.Departure,
                s.AirlinePlane.SendingAirline,
                s.AirlinePlane.Airplane.Model,
                s.NameRoute
            })
            .AsEnumerable()
            .Select(s => new Flight()
            {
                NumberFlight = s.NumberFlight,
                NameRoute = s.NameRoute,
                AirlinePlane = new AirlinePlane()
                {
                    SendingAirline = s.SendingAirline,
                    Airplane = new Airplane()
                    {
                        Model = s.Model
                    }
                },
                Route = new Route()
                {
                    Where = s.Where,
                    FromWhere = s.FromWhere,
                    Departure = s.Departure,
                    Incoming = s.Incoming,
                }
            }).ToList();


            int count = Flights.Count();
            dataGridView1.Rows.Add(count);

            for (int i = 0; i < count; i++)
                InsertFlightToDataGrid(Flights[i], i);

        }

        private void panel11_Paint(object sender, PaintEventArgs e)
        {

        }

        private void dataGridView1_CellContentClick_1(object sender, DataGridViewCellEventArgs e)
        {
            int currentRow = dataGridView1.CurrentCell.RowIndex;

            flightID.Text = dataGridView1.Rows[currentRow].Cells[0].Value.ToString();
            senderBox.Text = dataGridView1.Rows[currentRow].Cells[1].Value.ToString();
            fromWhereBox.Text = dataGridView1.Rows[currentRow].Cells[2].Value.ToString();
            fromBox.Text = dataGridView1.Rows[currentRow].Cells[3].Value.ToString();
            departimeBox.Text = dataGridView1.Rows[currentRow].Cells[4].Value.ToString();
            arivalBox.Text = dataGridView1.Rows[currentRow].Cells[5].Value.ToString();
            airplaneTypeBox.Text = dataGridView1.Rows[currentRow].Cells[6].Value.ToString();
            routeFlightNameBox.Text = dataGridView1.Rows[currentRow].Cells[7].Value.ToString();
        }

        private void groupBox2_Enter(object sender, EventArgs e)
        {

        }

        private async void addButton_Click(object sender, EventArgs e)
        {
            if (!adding.IsPrepering)
            {
                addButton.Image = Resources.save;
                adding.EnableControls(false);
                adding.IsPrepering = true;
                return;
            }

            await adding.LoadToLocalCash();

            var resultAdded = await adding.AddFlight();

            if (!resultAdded.isAdded)
            {
                cancelOperationBtn_Click(this, new EventArgs());
                return;
            }

            dataGridView1.Rows.Add(1);
            InsertFlightToDataGrid(resultAdded.addedFlight, dataGridView1.Rows.GetLastRow(DataGridViewElementStates.None));

            cancelOperationBtn_Click(this, new EventArgs());

        }

        private void InsertFlightToDataGrid(Flight? flight, int currentRow)
        {
            dataGridView1.Rows[currentRow].Cells[0].Value = flight.NumberFlight;
            dataGridView1.Rows[currentRow].Cells[1].Value = flight.AirlinePlane.SendingAirline;
            dataGridView1.Rows[currentRow].Cells[2].Value = flight.Route.FromWhere;
            dataGridView1.Rows[currentRow].Cells[3].Value = flight.Route.Where;
            dataGridView1.Rows[currentRow].Cells[4].Value = flight.Route.Departure;
            dataGridView1.Rows[currentRow].Cells[5].Value = flight.Route.Incoming;
            dataGridView1.Rows[currentRow].Cells[6].Value = flight.AirlinePlane.Airplane.Model;
            dataGridView1.Rows[currentRow].Cells[7].Value = flight.NameRoute;
        }

     

        private void cancelOperationBtn_Click(object sender, EventArgs e)
        {
            if (adding.IsPrepering)
            {
                addButton.Image = Resources.add;
                adding.EnableControls(true);
                adding.IsPrepering = false;
                return;
            }
            if (removing.IsPrepering)
            {
                removeButton.Image = Resources.remove;
                removing.EnableControls(true);
                removing.IsPrepering = false;
                return;
            }
        }

        private async void removeButton_Click(object sender, EventArgs e)
        {
            if (!removing.IsPrepering)
            {
                removeButton.Image = Resources.doneDelete;
                removing.EnableControls(false);
                removing.IsPrepering = true;
                return;
            }

           await removing.LoadToLocalCash();

           bool isRemove = await removing.RemoveFlight();

            if (!isRemove)
            {
                cancelOperationBtn_Click(this, new EventArgs());
                return;
            }

            int currentRow = dataGridView1.CurrentCell.RowIndex;
            dataGridView1.Rows.RemoveAt(currentRow);

            cancelOperationBtn_Click(this, new EventArgs());
        }
    }
}
