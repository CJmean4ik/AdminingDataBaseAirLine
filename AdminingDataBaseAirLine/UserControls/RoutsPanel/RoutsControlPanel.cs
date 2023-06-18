using AdminingDataBaseAirLine.Properties;
using AdminingDataBaseAirLine.UserControls.RoutsPanel.CRUD;
using AirlineDataBase;
using AirlineDataBase.Entityes.RouteAndFlight;
using System.Data;


namespace AdminingDataBaseAirLine.UserControls.RoutsPanel
{
    public partial class RoutsControlPanel : UserControl
    {
        private AirCompanyContext context;
        private AddingRouts adding;
        private RemovingRouts removing;
        private UpdatingRouts updating;
        public RoutsControlPanel(AirCompanyContext context) : this()
        {
            this.context = context;
            removing = new RemovingRouts(context, this);
            adding = new AddingRouts(context, this);
            updating = new UpdatingRouts(this);
        }


        public RoutsControlPanel()
        {
            InitializeComponent();
        }

        private void RoutsControlPanel_Load(object sender, EventArgs e)
        {

        }
        public void InsertDataToDataGrigview()
        {
            var routs = context.Routes.Select(s => new
            {
                s.ID,
                s.FromWhere,
                s.Where,
                s.Departure,
                s.Incoming
            }).ToList();

            int count = routs.Count();
            dataGridView1.Rows.Add(count);

            for (int i = 0; i < count; i++)
            {
                dataGridView1.Rows[i].Cells[0].Value = routs[i].ID;
                dataGridView1.Rows[i].Cells[1].Value = routs[i].FromWhere;
                dataGridView1.Rows[i].Cells[2].Value = routs[i].Where;
                dataGridView1.Rows[i].Cells[3].Value = routs[i].Departure;
                dataGridView1.Rows[i].Cells[4].Value = routs[i].Incoming;
            }
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

            var resultAdded = await adding.AddRoute();

            if (!resultAdded.isAdded)
            {
                cancelOperationBtn_Click(this, new EventArgs());
                return;
            }

            AddToDataGridView(resultAdded.route);
            cancelOperationBtn_Click(this, new EventArgs());
        }

        private void AddToDataGridView(Route route)
        {
            dataGridView1.Rows.Add(1);
            int lastRowIndex = dataGridView1.Rows.GetLastRow(DataGridViewElementStates.None);

            dataGridView1.Rows[lastRowIndex].Cells[0].Value = route.ID;
            dataGridView1.Rows[lastRowIndex].Cells[1].Value = route.FromWhere;
            dataGridView1.Rows[lastRowIndex].Cells[2].Value = route.Where;
            dataGridView1.Rows[lastRowIndex].Cells[3].Value = route.Departure;
            dataGridView1.Rows[lastRowIndex].Cells[4].Value = route.Incoming;
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
            if (updating.IsPrepering)
            {
                updateButton.Image = Resources.update;
                updating.EnableControls(true);
                updating.IsPrepering = false;
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

            bool isRemoved = await removing.RemoveRoute();

            if (!isRemoved)
            {
                cancelOperationBtn_Click(this, new EventArgs());
                return;
            }

            int rowIndex = dataGridView1.CurrentCell.RowIndex;
            dataGridView1.Rows.RemoveAt(rowIndex);

            cancelOperationBtn_Click(this, new EventArgs());
        }

        private void departimeBox_MouseDoubleClick(object sender, MouseEventArgs e)
        {
            departimeBox.Text = DateTime.Now.ToString();
        }

        private void arivalBox_MouseDoubleClick(object sender, MouseEventArgs e)
        {
            arivalBox.Text = DateTime.Now.ToString();
        }

        private void clearButton_Click(object sender, EventArgs e)
        {
            string CLEAR_FIELD = "";

            routeId.Text = CLEAR_FIELD;
            fromWhereBox.Text = CLEAR_FIELD;
            fromBox.Text = CLEAR_FIELD;
            arivalBox.Text = CLEAR_FIELD;
            departimeBox.Text = CLEAR_FIELD;
        }

        private async void updateButton_Click(object sender, EventArgs e)
        {
            if (!updating.IsPrepering)
            {
                updating.EnableControls(false);
                updateButton.Image = Resources.done;
                updating.IsPrepering = true;
                return;
            }

            if (!int.TryParse(this.routeId.Text, out int routeid))
            {
                MessageBox.Show("Не вдалося отримати ID маршрута. Перевірте, чи не пусте поле");
                cancelOperationBtn_Click(this, new EventArgs());
                return;
            }

            var oldRout = context.Routes.Where(w => w.ID == routeid).FirstOrDefault();

            if (!DateTime.TryParse(departimeBox.Text, out DateTime departure))
            {
                MessageBox.Show("Не можливо отрмати дату. Перевірте коректність введення!");
                cancelOperationBtn_Click(this, new EventArgs());
                return;
            }
            if (!DateTime.TryParse(arivalBox.Text, out DateTime arival))
            {
                MessageBox.Show("Не можливо отрмати дату. Перевірте коректність введення!");
                cancelOperationBtn_Click(this, new EventArgs());
                return;
            }


            var newRout = new Route()
            {
                FromWhere = fromWhereBox.Text,
                Where = fromBox.Text,
                Departure = departure,
                Incoming = arival,
            };

            updating.SearchModifieRoutProperty(newRout, oldRout, context);
            updating.UpdateDataInDataGridview(oldRout);

            await context.SaveChangesAsync();
            updateButton.Image = Resources.update;
            cancelOperationBtn_Click(this, new EventArgs());


        }

        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            int rowIndex = dataGridView1.CurrentCell.RowIndex;

            routeId.Text = dataGridView1.Rows[rowIndex].Cells[0].Value.ToString();
            fromWhereBox.Text = dataGridView1.Rows[rowIndex].Cells[1].Value.ToString();
            fromBox.Text = dataGridView1.Rows[rowIndex].Cells[2].Value.ToString();
            departimeBox.Text = dataGridView1.Rows[rowIndex].Cells[3].Value.ToString();
            arivalBox.Text = dataGridView1.Rows[rowIndex].Cells[4].Value.ToString();
        }
    }
}
