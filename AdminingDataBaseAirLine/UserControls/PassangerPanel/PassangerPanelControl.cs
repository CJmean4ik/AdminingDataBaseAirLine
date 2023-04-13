using AdminingDataBaseAirLine.Properties;
using AdminingDataBaseAirLine.UserControls.PassangerPanel.CRUD;
using DataBaseModel.Entities.Accounts;

namespace AdminingDataBaseAirLine.UserControls.PassangerPanel
{
    public partial class PassangerPanelControl : UserControl
    {
        private AirlineContext _context;
        private AddingPassenger _addingPassenger;
        private bool _isNowAdded;
        private UpdatingPassenger _updateTicket;
        private RemovingPassenger _removePassenger;
        public PassangerPanelControl()
        {
            InitializeComponent();
        }
        public PassangerPanelControl(AirlineContext context) : this()
        {
            _context = context;
            _addingPassenger = new AddingPassenger(this);
            _updateTicket = new UpdatingPassenger(this);
            _removePassenger = new RemovingPassenger(this);
        }

        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            int index = dataGridView1.CurrentCell.RowIndex;

            idpassBox.Text = dataGridView1.Rows[index].Cells[0].Value.ToString();
            nameBox.Text = dataGridView1.Rows[index].Cells[2].Value.ToString();
            secondNameBox.Text = dataGridView1.Rows[index].Cells[1].Value.ToString();
            patronicBox.Text = dataGridView1.Rows[index].Cells[3].Value.ToString();
            ageBox.Text = dataGridView1.Rows[index].Cells[5].Value.ToString();
            genderBox.Text = dataGridView1.Rows[index].Cells[4].Value.ToString();
            phoneNumberBox.Text = dataGridView1.Rows[index].Cells[6].Value.ToString();
            emailBox.Text = dataGridView1.Rows[index].Cells[7].Value.ToString();
        }

        private void label6_Click(object sender, EventArgs e)
        {

           
        }       
        public void AddPassengerToDataGrid()
        {
            var passengers = _context.Passengers.ToList();

            int count = passengers.Count();

            if (count == 0) return;                    

            foreach (var passenger in passengers)
            {
               AddDataToCells(passenger);
            }
        }
        private void AddDataToCells(Passenger passenger)
        {
            dataGridView1.Rows.Add(1);
            dataGridView1.Rows[0].Cells[0].Value = passenger.ID;
            dataGridView1.Rows[0].Cells[1].Value = passenger.Surname;
            dataGridView1.Rows[0].Cells[2].Value = passenger.Name;
            dataGridView1.Rows[0].Cells[3].Value = passenger.Patronymic;
            dataGridView1.Rows[0].Cells[4].Value = passenger.Gender == GenderType.Male ? "Чоловік" : "Жінка";
            dataGridView1.Rows[0].Cells[5].Value = passenger.Age;
            dataGridView1.Rows[0].Cells[6].Value = passenger.PhoneNumber;
            dataGridView1.Rows[0].Cells[7].Value = passenger.Email;
        }
        private void clearButton_Click(object sender, EventArgs e)
        {
            CleatTextBox();
        }
        public void CleatTextBox()
        {
            idpassBox.Text = "";
            nameBox.Text = "";
            secondNameBox.Text = "";
            patronicBox.Text = "";
            ageBox.Text = "";
            genderBox.Text = "";
            phoneNumberBox.Text = "";
            emailBox.Text = "";
        }
        private async void addButton_Click(object sender, EventArgs e)
        {
            _addingPassenger.ErorHandling();
            if (!_isNowAdded)
            {
                _addingPassenger.PreperingForAddingPassanger();
                _isNowAdded = true;
                return;
            }

            idpassBox.Enabled = false;


            Passenger passenger = new Passenger()
            {
                Name = nameBox.Text,
                Surname = secondNameBox.Text,
                Patronymic = patronicBox.Text,
                Age = int.Parse(ageBox.Text),
                Gender = genderBox.Text == "Чоловік" ? GenderType.Male : GenderType.Female,
                PhoneNumber = phoneNumberBox.Text,
                Email = emailBox.Text
            };



            var existPassenger = _context.Passengers
                .Where(w => w.Name == passenger.Name && w.Surname == passenger.Surname)
                .Where(w => w.Patronymic == passenger.Patronymic)
                .Select(s => s.Name)
                .ToList();

            if (existPassenger.Count != 0)
            {
                erorLabel.Text = "Такий пасажир вже є в системі";
                erorLabel.Visible = true;
                return;
            } 


            _context.Passengers.Add(passenger);
            await _context.SaveChangesAsync();
            AddDataToCells(passenger);

            idpassBox.Enabled = true;
            addButton.Image = Resources.add;
            updateButton.Enabled = true;
            removeButton.Enabled = true;

        }

        private void PassangerPanelControl_Load(object sender, EventArgs e)
        {

        }

        private async void updateButton_Click(object sender, EventArgs e)
        {
            _updateTicket.ErorHandling();

            if (!_updateTicket.IsNowUpdate)
            {
                _updateTicket.PreparingUpdateTicket();
                _updateTicket.IsNowUpdate = true;
                return;
            }

            Passenger newPassenger = new Passenger()
            {
                Name = nameBox.Text,
                Surname = secondNameBox.Text,
                Patronymic = patronicBox.Text,
                Age = int.Parse(ageBox.Text),
                Gender = genderBox.Text == "Чоловік" ? GenderType.Male : GenderType.Female,
                PhoneNumber = phoneNumberBox.Text,
                Email = emailBox.Text
            };


            Passenger oldPassenger = _context.Passengers.Find(int.Parse(idpassBox.Text));

             _updateTicket.SearchModifiePassengerProperty(newPassenger, oldPassenger, _context);
            
            await _context.SaveChangesAsync();
            int index = dataGridView1.CurrentRow.Index;
            
            _updateTicket.UpdateDataInDataGridview(this, oldPassenger, index);
            updateButton.Image = Resources.update;
            addButton.Enabled = true;
            removeButton.Enabled = true;
        }

        private async void removeButton_Click(object sender, EventArgs e)
        {
            _removePassenger.ErorHandling();

            if (!_removePassenger.IsNowRemoving)
            {
                _removePassenger.PreperingDeletePassenger();
                _removePassenger.ChangeStateBox();
                _removePassenger.IsNowRemoving = true;
                return;
            }

            var beingDelPassngr = _context.Passengers.Find(int.Parse(idpassBox.Text));

            if (beingDelPassngr == null)
            {
                erorLabel.Text = "Даного пасажира не існує";
                _removePassenger.ErorIsActive = true;
                return;
            }

            _context.Passengers.Remove(beingDelPassngr);
           await _context.SaveChangesAsync();

            int index = dataGridView1.CurrentRow.Index;

            dataGridView1.Rows.RemoveAt(index);
            _removePassenger.ChangeStateBox();
        }
    }
}
