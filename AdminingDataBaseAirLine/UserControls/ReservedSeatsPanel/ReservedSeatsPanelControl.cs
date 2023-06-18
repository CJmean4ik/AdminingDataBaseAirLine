using AdminingDataBaseAirLine.Configs;
using AdminingDataBaseAirLine.Properties;
using AdminingDataBaseAirLine.UserControls.ReservedSeatsPanel.CRUD;
using AirlineDataBase;
using AirlineDataBase;
using AirlineDataBase.Entityes.Accounts;
using AirlineDataBase.Entityes.AirlinePlanes;
using AirlineDataBase.Entityes.TicketAndOrders;
using PDFGroupDocs.PDFReport;
using PDFGroupDocs.PDFReport.ReportEntity;
using System.Data;
using System.Data.Entity;
using System.Windows.Forms;

namespace AdminingDataBaseAirLine.UserControls.ReservedSeatsPanel
{

    public partial class ReservedSeatsPanelControl : UserControl
    {
        private AirCompanyContext _db;

        private List<Airplane> _airplanes;
        private List<ReservedSeatsControl> _reservedSeats;

        private ReservedSeatsTableControl reservedSeatsTableControl;
        private PdfWorker pdfWorker;

        private UpdatingReservedSeats updating;
        private AddingReservedSeats adding;
        private RemovingReservedSeats removing;


        private bool _isTableLoad;
        private bool _isAded;
        private bool _isLoadedToCash;

        public ReservedSeatsPanelControl()
        {
            InitializeComponent();
        }

        public ReservedSeatsPanelControl(AirCompanyContext db) : this()
        {
            _db = db;
            _reservedSeats = new List<ReservedSeatsControl>();
            adding = new AddingReservedSeats(this, _db);
            updating = new UpdatingReservedSeats(_db, this);
            removing = new RemovingReservedSeats(_db,this);
            pdfWorker = new PdfWorker(new GroupDocs.Assembly.DocumentAssembler(), this, FormatingEntityReport);
        }



        private void InserdItemInComboBox(List<Airplane> airplanes)
        {
            foreach (var item in airplanes)
            {
                airplaneBox.Items.Add(item.Model);
            }
        }
        private void DisableVisibleTableControl()
        {
            if (_isTableLoad)
            {
                reservedSeatsTableControl.Visible = false;
                mainForm.Visible = true;
                underPanel.Visible = true;
                _isTableLoad = true;
                airplaneBox.Enabled = true;
                return;
            }
        }
        public void TicketButton_Click(object sender, EventArgs e)
        {
            if (updating.IsPrepering)
            {
                DisableVisibleTableControl();
                HideReservedSeatsControl(_reservedSeats);
                HandlingSeatsForUpdate();
                return;
            }


            DisableVisibleTableControl();

            foreach (var reservedSeats in _reservedSeats)
            {
                HideReservedSeatsControl(reservedSeats);

                if (reservedSeats.AirplaneName == airplaneBox.Text)
                {
                    ShowReservedSeatsControl(reservedSeats, airplaneBox.Text);
                    break;
                }
            }
        }
        public void HandlingSeatsForUpdate()
        {
            int NUMBER_SEATS = int.Parse(idpassBox.Text);

            var airplaneName = _db.ReservedSeats.Where(w => w.Id == NUMBER_SEATS)
                   .Select(s => s.Airplane.Model)
                   .FirstOrDefault();

            if (airplaneName == "")
            {
                MessageBox.Show("Не вдалося виявити літак у цього замовлення");
                return;
            }


            if (!_reservedSeats.Exists(ex => ex.AirplaneName == airplaneName))
            {
                InsertCreatedControlInList(airplaneName!);
                ShowReservedSeatsControl(_reservedSeats, airplaneName!);
                return;
            }


            ShowReservedSeatsControl(_reservedSeats, airplaneName!);
            return;

        }


        public async Task LoadDataToLocalCash()
        {
            if (_isLoadedToCash) return;
                      
            await _db.Tickets.LoadAsync();
            await _db.Flights.LoadAsync();
            await _db.ReservedSeats.LoadAsync();
            await _db.Orders.LoadAsync();
            await _db.AirlinePlanes.LoadAsync();
            await _db.Airplanes.LoadAsync();
            _isLoadedToCash = true;
        }
   
        public void CreateReservedSeatsControls()
        {
         
            if (_isAded) return;

            foreach (var airplane in _airplanes)
            {
                if (_reservedSeats.Exists(ex => ex.AirplaneName == airplane.Model))
                    return;

                InsertCreatedControlInList(airplane.Model);
            }
            _isAded = true;
        }
        private async void InsertCreatedControlInList(string airplaneName)
        {
       

            int[] seats = _db.ReservedSeats.Local
                .Where(w => w.Airplane.Model == airplaneName)
                .Select(w => w.BookSeats)
                .ToArray();

            ReservedSeatsControl seatsControl = new ReservedSeatsControl(airplaneName, seats);

            seatsControl.Event += GetNumberSeats;

            seatsControl.Capacity = _airplanes
                .Where(w => w.Model == airplaneName)
                .Select(s => s.Capacity)
                .FirstOrDefault();

            seatsControl.FillInFlowPanel();

            _reservedSeats.Add(seatsControl);

            seatsControl.Location = new Point(0, 0);
            seatsControl.Hide();
            seatsControl.IsShow = false;

            this.mainForm.Controls.Add(seatsControl);
        }
        public void GetNumberSeats(object? sender, EventArgs? e)
        {
            if (sender is Button button)
            {
                seatsNumberBox.Text = button.Text;

                return;
            }
        }
        private void ShowReservedSeatsControl(List<ReservedSeatsControl> reservedSeats, string airplaneModel)
        {
            foreach (var seatsControl in reservedSeats)
            {
                ShowReservedSeatsControl(seatsControl, airplaneModel);
            }
        }
        private void ShowReservedSeatsControl(ReservedSeatsControl reservedSeats, string airplaneModel)
        {
            if (!reservedSeats.IsShow && reservedSeats.AirplaneName == airplaneModel)
            {
                reservedSeats.Show();
                reservedSeats.IsShow = true;
                return;
            }
        }
        private void HideReservedSeatsControl(ReservedSeatsControl reservedSeats)
        {
            if (reservedSeats.IsShow)
            {
                reservedSeats.Hide();
                reservedSeats.IsShow = false;
                return;
            }
        }
        private void HideReservedSeatsControl(List<ReservedSeatsControl> reservedSeats)
        {
            foreach (var reservedSeat in reservedSeats)
            {
                HideReservedSeatsControl(reservedSeat);
            }
        }
        private void ReservedSeatsPanelControl_LoadAsync(object? sender, EventArgs? e)
        {
            

        }

        private void InsertDataToDataGridView(ReservedSeats reservedSeats)
        {
            if (reservedSeatsTableControl == null)
                showTable_Click(this, new EventArgs());

            reservedSeatsTableControl!.LoadDataToDataGrigView();
        }

        public void LoadAirPlaneData()
        {
            _airplanes = _db.Airplanes.Select(s => new
            {
                s.Model,
                s.Capacity
            })
             .AsEnumerable()
             .Select(s => new Airplane
             {
                 Model = s.Model,
                 Capacity = s.Capacity
             })
             .ToList();

            flightNamesBox.Items.AddRange(_db.Flights.Select(s => s.NameRoute).ToArray());

            InserdItemInComboBox(_airplanes);
        }
        private async void removeButton_Click(object sender, EventArgs e)
        {
            if (!removing.IsRemoving)
            {
                removing.EnableControls(false);
                removeButton.Image = Resources.doneDelete;
                removing.IsRemoving = true;
                return;
            }

            int RESERVED_SEATS_ID = int.Parse(idpassBox.Text);
            string AIRPLANE_NAME = airplaneBox.Text;
            int OLD_PLACE = int.Parse(seatsNumberBox.Text);

            var panel = _reservedSeats.Where(w => w.AirplaneName == AIRPLANE_NAME)
                .FirstOrDefault();

            bool isRemoved = await removing.DeleteReservedSeats(RESERVED_SEATS_ID);


            if (!isRemoved)
            {
                cancelOperationBtn_Click(this,new EventArgs());
                clearButton_Click(this, new EventArgs());
                return;
            }
            panel.ChangeToDeffault(OLD_PLACE);

            int index = reservedSeatsTableControl.DataGridView1.CurrentRow.Index;
            reservedSeatsTableControl.DataGridView1.Rows.RemoveAt(index);

            cancelOperationBtn_Click(this, new EventArgs());
            clearButton_Click(this, new EventArgs());

        }
        private async void addButton_Click(object sender, EventArgs e)
        {
            if (!adding.IsPrepering)
            {
                adding.EnableControls(false);
                addButton.Image = Resources.save;
                clearButton_Click(this, new EventArgs());
                adding.IsPrepering = true;

                cancelOperationBtn.Enabled = true;

                if (!adding.IsLoadedToLocalCash)
                {
                    await adding.LoadRelatedEnityToLocalCashAsync();
                    adding.IsLoadedToLocalCash = true;
                }
                return;
            }          
            var reservedSeats = await adding.AddReservedSeatsAsync();

            var panel = _reservedSeats.Where(w => w.AirplaneName == reservedSeats.Airplane.Model).FirstOrDefault();
            panel?.ChangeSeats(reservedSeats.BookSeats);

            if (reservedSeats != null)
            {
                adding.EnableControls(true);

                addButton.Image = Resources.add;
                adding.IsPrepering = false;
                cancelOperationBtn.Enabled = false;

                InsertDataToDataGridView(reservedSeats);
                return;
            }
        }
        private void showTable_Click(object sender, EventArgs e)
        {
           // airplaneBox.Enabled = false;

            mainForm.Visible = false;
            underPanel.Visible = false;

            if (reservedSeatsTableControl == null)
            {
                reservedSeatsTableControl = new ReservedSeatsTableControl(_db);

                reservedSeatsTableControl.LoadDataToDataGrigView();
                reservedSeatsTableControl.Location = new Point(37, 0);
                reservedSeatsTableControl.Show();
                reservedSeatsTableControl.BindCellContentClick(CellsContentClick);
                this.Controls.Add(reservedSeatsTableControl);

                _isTableLoad = true;

                return;
            }

            reservedSeatsTableControl.Visible = true;
            _isTableLoad = true;
            return;
        }
        private void IdLabel_Click(object sender, EventArgs e)
        {

        }
        private void clearButton_Click(object sender, EventArgs e)
        {
            seatsNumberBox.Text = "";
            secondNameBox.Text = "";
            nameBox.Text = "";
            idpassBox.Text = "";
            flightNamesBox.Text = "";
        }
        private void idpassBox_TextChanged(object sender, EventArgs e)
        {

        }

        private void cancelOperationBtn_Click(object sender, EventArgs e)
        {
            if (adding.IsPrepering)
            {
                adding.EnableControls(true);

                addButton.Image = Resources.add;
                adding.IsPrepering = false;
                cancelOperationBtn.Enabled = false;
                return;
            }
            if (updating.IsPrepering)
            {
                updating.EnabledControls(true);
                updateButton.Image = Resources.update;
                updating.IsPrepering = false;
                cancelOperationBtn.Enabled = false;
                return;
            }
            if (removing.IsRemoving)
            {
                removing.EnableControls(true);
                removeButton.Image = Resources.remove;
                removing.IsRemoving = false;
                cancelOperationBtn.Enabled = false;
                return;
            }
        }

        private async void updateButton_Click(object sender, EventArgs e)
        {
            

            if (!updating.IsPrepering)
            {
                if (updating.IsActiveEror)
                    erorLabel.Visible = false;

                updating.EnabledControls(false);
                updateButton.Image = Resources.done;
                cancelOperationBtn.Enabled = true;
                updating.IsPrepering = true;

                return;
            }
            int oldPlace = _db.ReservedSeats.Local.Where(w => w.Id == int.Parse(idpassBox.Text))
                .Select(s => s.BookSeats)
                .FirstOrDefault();

            await updating.UpdateReservedSeatsAsync();

            var panel = _reservedSeats.Where(w => w.AirplaneName == airplaneBox.Text).FirstOrDefault();

            panel.ChangeToDeffault(oldPlace);

            panel.ChangeSeats(int.Parse(seatsNumberBox.Text));

            updating.IsPrepering = false;

            updating.EnabledControls(true);
            updateButton.Image = Resources.update;
            cancelOperationBtn.Enabled = false;
        }

        public void CellsContentClick(object? obj, DataGridViewCellEventArgs? e)
        {
            if (obj is DataGridView dataGridView)
            {
                int CELLS_INDEX = dataGridView.CurrentCell.RowIndex;

                nameBox.Text = dataGridView.Rows[CELLS_INDEX].Cells[3].Value.ToString();
                secondNameBox.Text = dataGridView.Rows[CELLS_INDEX].Cells[4].Value.ToString();
                flightNamesBox.Text = dataGridView.Rows[CELLS_INDEX].Cells[6].Value.ToString();
                airplaneBox.Text = dataGridView.Rows[CELLS_INDEX].Cells[5].Value.ToString();
                seatsNumberBox.Text = dataGridView.Rows[CELLS_INDEX].Cells[7].Value.ToString();
                idpassBox.Text = dataGridView.Rows[CELLS_INDEX].Cells[0].Value.ToString();
            }
        }

        private async void reportCreate_Click(object sender, EventArgs e)
        {
            if (!pdfWorker.IsMake)
            {
                pdfWorker.EnableControls(false);
                pdfWorker.IsMake = true;
                reportCreate.Image = Resources.inbox_out;
                return;
            }

            pdfWorker.PathToDocumentTemplate = JsonConfiguration.GetPathToTemplateWord("C:\\Users\\Стас\\source\\repos\\AdminingDataBaseAirLine\\AdminingDataBaseAirLine\\Configs\\Configurations.json");

            var result = pdfWorker.CreateReport(_db,this);

            if (!result)
            {
                erorLabel.Text = "Замовлення у форматі PDF для цього користувача вже є";
                pdfWorker.EnableControls(true);
                pdfWorker.IsMake = false;
                reportCreate.Image = Resources.file_pdf;
                return;
            }
            pdfWorker.EnableControls(true);
            pdfWorker.IsMake = false;
            reportCreate.Image = Resources.file_pdf;
        }
        public PassengerOrder FormatingEntityReport(AirCompanyContext airCompany, ReservedSeatsPanelControl panelControl)
        {
            var orderId = int.Parse(panelControl.IdpassBox.Text);
            var passengerOrder = airCompany.ReservedSeats
           .Where(w => w.Id == orderId)
           .Select(s => new
           {
               NumberSeats = s.BookSeats.ToString(),
               OrderId = s.OrderId.ToString(),
               s.Airplane.Model,
               s.Airplane.TypeAirplane,
               CashierId =  s.Order.CashierId.ToString(),
               CashierName = s.Order.Cashier.Name,
               PassengerName = s.Order.Passenger.Name,
               s.Order.Passenger.Surname,
               s.Order.Passenger.Patronymic,
               Gender = s.Order.Passenger.Gender.ToString(),
               Age = s.Order.Passenger.Age.ToString(),
               PassengerId = s.Order.Passenger.ID.ToString(),
               s.Order.Passenger.Email,
               s.Order.Passenger.PhoneNumber,
               FlightId = s.Order.Ticket.FlightId.ToString(),
               NumberTicket = s.Order.Ticket.NumberTicket.ToString(),
               s.Order.Ticket.Flight.NameRoute,
               s.Order.Ticket.Flight.NumberFlight,
               s.Order.Ticket.Flight.Route.FromWhere,
               s.Order.Ticket.Flight.Route.Where,
               s.Order.Ticket.Flight.Route.Departure,
               s.Order.Ticket.Flight.Route.Incoming,
               s.Order.Ticket.Flight.AirlinePlane.SendingAirline,
               s.Order.Ticket.Price
           })
           .AsEnumerable()
           .Select(s => new PassengerOrder()
           {
               NumberSeats = s.NumberSeats,
               OrderId = s.OrderId,
               AirplaneName = s.Model,
               AirplaneType = s.TypeAirplane,
               CashierId = s.CashierId,
               CashierName = s.CashierName,
               Name = s.PassengerName,
               Surname = s.Surname,
               Patronymic = s.Patronymic,
               Gender = s.Gender,
               Age = s.Age,
               PassengerId = s.PassengerId,
               Email = s.Email,
               Phone = s.PhoneNumber,
               FlightID = s.FlightId,
               NumberTicket = s.NumberTicket,
               FlightName = s.NameRoute,
               FromWhere = s.FromWhere,
               Where = s.Where,
               Departure = $"{s.Departure.Day}.{s.Departure.Month}.{s.Departure.Year} {s.Departure.Hour}:{s.Departure.Minute}",
               Incoming = $"{s.Incoming.Day}.{s.Incoming.Month}.{s.Incoming.Year} {s.Incoming.Hour}:{s.Incoming.Minute}",
               Sender = s.SendingAirline,
               Price = s.Price,
           })
           .FirstOrDefault()!;
           return passengerOrder;
        }
    }
}
