using System.Data;

namespace AdminingDataBaseAirLine.UserControls.AirlineplanePanel
{
    public partial class AirlineplaneControl : UserControl
    {
        private AirlineContext _airlineContext;

        public AirlineplaneControl()
        {
            InitializeComponent();
        }

        public AirlineplaneControl(AirlineContext airlineContext) : this()
        {
            _airlineContext = airlineContext;
        }

        private void AirlineplaneControl_Load(object sender, EventArgs e)
        {

        }
        public void AddItemToDataGridView()
        {
            var Flights = _airlineContext.AirlinePlanes.Select(s => new
            {
                s.ID,
                AirplaneId = s.Airplane.ID,
                s.Airplane.Model,
                s.Airplane.Capacity,
                s.Airplane.TypeAirplane,
                s.AirLine.Name,
                s.AirLine.Owner,
                s.InRaise
            }).ToList();

            int count = Flights.Count();
            dataGridView1.Rows.Add(count);

            for (int i = 0; i < count; i++)
            {
                dataGridView1.Rows[i].Cells[0].Value = Flights[i].ID;
                dataGridView1.Rows[i].Cells[1].Value = Flights[i].Name;
                dataGridView1.Rows[i].Cells[2].Value = Flights[i].AirplaneId;
                dataGridView1.Rows[i].Cells[3].Value = Flights[i].TypeAirplane;
                dataGridView1.Rows[i].Cells[4].Value = Flights[i].Capacity;
                dataGridView1.Rows[i].Cells[5].Value = Flights[i].Model;
                dataGridView1.Rows[i].Cells[6].Value = Flights[i].InRaise;
                dataGridView1.Rows[i].Cells[7].Value = Flights[i].Owner;
            }
        }

        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }
    }
}
