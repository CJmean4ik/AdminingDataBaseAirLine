using AdminingDataBaseAirLine.Properties;
using AdminingDataBaseAirLine.UserControls.PassangerPanel.CRUD;
using AirlineDataBase;
using AirlineDataBase.Entityes.Accounts;
using AirlineDataBase.Entityes.TicketAndOrders;

namespace AdminingDataBaseAirLine.UserControls.PassangerPanel
{
    public partial class PassangerPanelControl : UserControl
    {
        private List<Passenger> _passengers;
        private AirCompanyContext _context;
        private AddingPassenger _addingPassenger;
        private UpdatingPassenger _updateTicket;
        private RemovingPassenger _removePassenger;


        private bool _filterPanelIsExpand;
        private bool _isNowAdded;
        private bool _isExpand;

        public PassangerPanelControl()
        {
            InitializeComponent();
        }
        public PassangerPanelControl(AirCompanyContext context) : this()
        {
            _context = context;
            _addingPassenger = new AddingPassenger(this);
            _updateTicket = new UpdatingPassenger(this);
            _removePassenger = new RemovingPassenger(this);
            _passengers = new List<Passenger>();
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
            
            dataGridView1.Rows.Add(count);

            for (int i = 0; i < count; i++)
            {
                _passengers.Add(passengers[i]);
                AddDataToCells(passengers[i],i);
            }
            
        }
        private void AddDataToCells(Passenger passenger,int index)
        {
            dataGridView1.Rows[index].Cells[0].Value = passenger.ID;
            dataGridView1.Rows[index].Cells[1].Value = passenger.Surname;
            dataGridView1.Rows[index].Cells[2].Value = passenger.Name;
            dataGridView1.Rows[index].Cells[3].Value = passenger.Patronymic;
            dataGridView1.Rows[index].Cells[4].Value = passenger.Gender == GenderType.Male ? "Чоловік" : "Жінка";
            dataGridView1.Rows[index].Cells[5].Value = passenger.Age;
            dataGridView1.Rows[index].Cells[6].Value = passenger.PhoneNumber;
            dataGridView1.Rows[index].Cells[7].Value = passenger.Email;
        }
        private void AddDataToCells(Passenger passenger)
        {
            
            dataGridView1.Rows.Add(1);
            int rowsCount = dataGridView1.Rows.GetLastRow(DataGridViewElementStates.None);
            AddDataToCells(passenger, rowsCount);
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
            dataGridView1.Rows.Add(1);
            int lasRowIndex = dataGridView1.Rows.GetLastRow(DataGridViewElementStates.None);
            AddDataToCells(passenger, lasRowIndex);

            idpassBox.Enabled = true;
            addButton.Image = Resources.add;
            updateButton.Enabled = true;
            removeButton.Enabled = true;

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
                _removePassenger.ChangeStateBox(false);
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

            var orders = _context.Orders.Where(w => w.PassengerId == beingDelPassngr.ID).ToList();
            var reservedSeats = _context.ReservedSeats.Where(w => w.Order.PassengerId == beingDelPassngr.ID).ToList();

            _context.ReservedSeats.RemoveRange(reservedSeats);
            _context.Orders.RemoveRange(orders);

            _context.Passengers.Remove(beingDelPassngr);
            await _context.SaveChangesAsync();

            int index = dataGridView1.CurrentRow.Index;
            removeButton.Image = Resources.remove;

            dataGridView1.Rows.RemoveAt(index);
            _removePassenger.ChangeStateBox(true);
        }
        private void slideFilterPanelTimer_Tick(object sender, EventArgs e)
        {
            if (!slideFilterPanel.Visible)
                slideFilterPanel.Visible = true;

            if (!_filterPanelIsExpand)
            {
                slideFilterPanel.Height += 40;
                if (slideFilterPanel.Height == slideFilterPanel.MaximumSize.Height)
                {
                    slideFilterPanelTimer.Stop();
                    _filterPanelIsExpand = true;
                  
                    return;
                }
            }
            if (_filterPanelIsExpand)
            {
                slideFilterPanel.Height -= 40;
                if (slideFilterPanel.Height == slideFilterPanel.MinimumSize.Height)
                {
                    slideFilterPanelTimer.Stop();
                    _filterPanelIsExpand = false;
                    slideFilterPanel.Visible = false;
                    return;
                }
            }
        }
        private void filterButton_Click(object sender, EventArgs e)
        {
            slideFilterPanelTimer.Start();
        }
        private void acceptFilterBtn_Click(object sender, EventArgs e)
        {
            bool IsAgeFilter = ageFromBox.Text != "" || ageToBox.Text != "" ? true : false;
            var sortedList = new List<Passenger>();

            if (IsAgeFilter)
            {
                int ageFrom = int.Parse(ageFromBox.Text);
                int.TryParse(ageToBox.Text, out int ageTo);
                foreach (var passenger in _passengers.Where(w => w.Age >= ageFrom || w.Age <= ageTo))
                {
                    sortedList.Add(passenger);
                }

            }

            if (passNameBox.Text != "")
            {
                if (sortedList.Count == 0)
                {
                    AddPassengerToFilterList(sortedList.Where(w => w.Name == passNameBox.Text),sortedList);
                }
                else
                {
                    RemovePassengerFromFilterList(sortedList.Where(w => w.Name != passNameBox.Text), sortedList);                   
                }
            }
            if (phoneBox.Text != "")
            {
                if (sortedList.Count == 0)
                {
                    AddPassengerToFilterList(sortedList.Where(w => w.PhoneNumber == phoneBox.Text), sortedList);
                }
                else
                {
                    RemovePassengerFromFilterList(sortedList.Where(w => w.PhoneNumber != phoneBox.Text), sortedList);
                }
            }
            if (SurnameBox.Text != "")
            {
                if (sortedList.Count == 0)
                {
                    AddPassengerToFilterList(sortedList.Where(w => w.Surname == SurnameBox.Text), sortedList);
                }
                else
                {
                    RemovePassengerFromFilterList(sortedList.Where(w => w.Surname != SurnameBox.Text), sortedList);
                }
            }

            if (sortedList.Count == 0) return;



            dataGridView1.Rows.Clear();
            foreach (var passenger in sortedList)
            {
                AddDataToCells(passenger);
            }
        }
        private void AddPassengerToFilterList(IEnumerable<Passenger> filterPassenger, List<Passenger> forAdding)
        {
            foreach (var passenger in filterPassenger)
            {
                forAdding.Add(passenger);
            }
        }
        private void RemovePassengerFromFilterList(IEnumerable<Passenger> filterPassenger, List<Passenger> forRemoving)
        {
            foreach (var passenger in filterPassenger)
            {
                forRemoving.Remove(passenger);
            }
        }
        private void declineFilter_Click(object sender, EventArgs e)
        {
            dataGridView1.Rows.Clear();
            foreach (var passenger in _passengers)
            {
                AddDataToCells(passenger);
            }
        }
        private void slideControlPanel_Tick(object sender, EventArgs e)
        {
            if (!_isExpand)
            {
                panelControlsPassenger.Height += 20;
                if (panelControlsPassenger.Height == panelControlsPassenger.MaximumSize.Height)
                {
                    slideControlPanel.Stop();
                    _isExpand = true;
                    buttonSlide.Image = Resources.angle_small_up;
                    return;
                }
            }
            if (_isExpand)
            {
                panelControlsPassenger.Height -= 20;
                if (panelControlsPassenger.Height == panelControlsPassenger.MinimumSize.Height)
                {
                    slideControlPanel.Stop();
                    _isExpand = false;
                    buttonSlide.Image = Resources.angle_small_down;
                    return;
                }
            }
        }

        private void buttonSlide_Click(object sender, EventArgs e)
        {
            slideControlPanel.Start();
        }

        private void slideFilterPanel_Paint(object sender, PaintEventArgs e)
        {

        }

        private void PassangerPanelControl_Load(object sender, EventArgs e)
        {

        }
    }
}
