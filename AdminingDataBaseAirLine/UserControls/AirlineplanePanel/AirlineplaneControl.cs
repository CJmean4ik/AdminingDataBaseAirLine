using AdminingDataBaseAirLine.Properties;
using AdminingDataBaseAirLine.UserControls.AirlineplanePanel.CRUD;
using AirlineDataBase;
using AirlineDataBase.Entityes.AirlinePlanes;
using System.Data;
using System.Data.Entity;

namespace AdminingDataBaseAirLine.UserControls.AirlineplanePanel
{
    public partial class AirlineplaneControl : UserControl
    {
        private AirCompanyContext _airlineContext;
        public bool isAdminControl;
        private AddingAirlineplane adding;
        private RemovingAirlineplane removing;
        private UpdatingAirlineplanes updating;
        public AirlineplaneControl()
        {
            InitializeComponent();
        }

        public AirlineplaneControl(AirCompanyContext airlineContext,bool isAdmin) : this()
        {
            _airlineContext = airlineContext;
            isAdminControl = isAdmin;
            adding = new AddingAirlineplane(_airlineContext,this);
            removing = new RemovingAirlineplane(_airlineContext,this);
            updating = new UpdatingAirlineplanes(this);
        }

        private void AirlineplaneControl_Load(object sender, EventArgs e)
        {
            if (isAdminControl) return;

            dataGridView1.Size = dataGridView1.MaximumSize;
            panel1.Size = panel1.MaximumSize;

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
            int index = dataGridView1.CurrentCell.RowIndex;

            airlinePlaneIdBox.Text = dataGridView1.Rows[index].Cells[0].Value.ToString();
            airlineBox.Text = dataGridView1.Rows[index].Cells[1].Value.ToString();
            airplaneIdBox.Text = dataGridView1.Rows[index].Cells[2].Value.ToString();
            airplaneTypeBox.Text = dataGridView1.Rows[index].Cells[3].Value.ToString();
            capacityAirplaneBox.Text = dataGridView1.Rows[index].Cells[4].Value.ToString();
            airplaneModelBox.Text = dataGridView1.Rows[index].Cells[5].Value.ToString();
            inFlightBox.Text = dataGridView1.Rows[index].Cells[6].Value.ToString();
            ownerAirlineBox.Text = dataGridView1.Rows[index].Cells[7].Value.ToString();
        }

        private async void addButton_Click(object sender, EventArgs e)
        {
            if (adding.PreperingAdd())
                return;
         
            var result =  await  adding.AddAirlineplane();

            adding.IsPrepering = false;


            if (!adding.PreperingAdd())
            {




                dataGridView1.Rows.Add(1);
                var row = dataGridView1.Rows.GetLastRow(DataGridViewElementStates.None);
                AddAirlineplaneToDataGrid(row, result.entity);
            }
        }
        public void AddAirlineplaneToDataGrid(int index,AirlinePlane airlinePlane)
        {

            dataGridView1.Rows[index].Cells[0].Value = airlinePlane.ID;
            dataGridView1.Rows[index].Cells[1].Value = airlinePlane.SendingAirline;
            dataGridView1.Rows[index].Cells[2].Value = airlinePlane.AirplaneId;
            dataGridView1.Rows[index].Cells[3].Value = airlinePlane.Airplane.TypeAirplane;
            dataGridView1.Rows[index].Cells[4].Value = airlinePlane.Airplane.Capacity;
            dataGridView1.Rows[index].Cells[5].Value = airlinePlane.Airplane.Model;
            dataGridView1.Rows[index].Cells[6].Value = airlinePlane.InRaise;
            dataGridView1.Rows[index].Cells[7].Value = airlinePlane.AirLine.Owner;
        }

        private void clearButton_Click(object sender, EventArgs e)
        {
            airlinePlaneIdBox.Text = "";
            airlineBox.Text = "";
            airplaneIdBox.Text = "";
            airplaneTypeBox.Text = "";
            capacityAirplaneBox.Text = "";
            airplaneModelBox.Text = "";
            inFlightBox.Text ="";
            ownerAirlineBox.Text = "";
        }

        private void cancelOperationBtn_Click(object sender, EventArgs e)
        {
            if (adding.IsPrepering)
            {

            }
        }

        private async void removeButton_Click(object sender, EventArgs e)
        {
            if (!removing.IdPrepering)
            {
                removing.EnableControls(false);
                removeButton.Image = Resources.doneDelete;
                removing.IdPrepering = true;
                return;
            }
           var res = await removing.RemoveAirLineplaneById();

            if (!res)
            {
                removing.EnableControls(true);
                removeButton.Image = Resources.remove;
                removing.IdPrepering = false;
                return;
            }
            var row = dataGridView1.CurrentRow.Index;
            dataGridView1.Rows.RemoveAt(row);

            removing.EnableControls(true);
            removeButton.Image = Resources.remove;
            removing.IdPrepering = false;
            return;
        }

        private async void updateButton_Click(object sender, EventArgs e)
        {
            if (!updating.IsNowUpdate)
            {
                updating.PreparingUpdate();
                updating.IsNowUpdate = true;
                updateButton.Image = Resources.done;
                return;
            }

            if (!int.TryParse(CapacityAirplaneBox.Text, out int capacity))
                return;

            AirlinePlane airlinePlane = new AirlinePlane()
            {
                SendingAirline = AirlineBox.Text,
                InRaise = InFlightBox.Text == "Так" ? true : false,                            
            };

            Airplane airplane = new Airplane()
            {
                TypeAirplane = AirplaneTypeBox.Text,
                Model = AirplaneModelBox.Text,
                Capacity = capacity,
            };

            AirLine airLine = new AirLine()
            {
                Name = AirlineBox.Text,
                Owner = OwnerAirlineBox.Text,
            };



            int airlineplaneOldId = int.Parse(airlinePlaneIdBox.Text);

            AirlinePlane airlinePlaneold = _airlineContext.AirlinePlanes.Where(w => w.ID == airlineplaneOldId)
                .Include(i => i.AirLine)
                .Include(i => i.Airplane)
                .FirstOrDefault()!;

            Airplane airplaneOld = airlinePlaneold.Airplane;
            AirLine airLineOld = airlinePlaneold.AirLine;

            updating.SearchModifieAirlinePlaneProperty(airlinePlane, airlinePlaneold, _airlineContext);
            updating.SearchModifieAirplaneProperty(airplane, airplaneOld, _airlineContext);
            updating.SearchModifieAirLineProperty(airLine, airLineOld, _airlineContext);

            await _airlineContext.SaveChangesAsync();

            int index = dataGridView1.CurrentRow.Index;

            updating.UpdateDataInDataGridview(airlinePlaneold);
            updateButton.Image = Resources.update;
            addButton.Enabled = true;
            removeButton.Enabled = true;

        }
    }
}
