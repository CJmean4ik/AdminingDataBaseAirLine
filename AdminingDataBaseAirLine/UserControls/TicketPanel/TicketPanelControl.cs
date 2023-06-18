using AdminingDataBaseAirLine.Properties;
using AdminingDataBaseAirLine.UserControls.TicketPanel.CRUD;
using AdminingDataBaseAirLine.UserControls.TicketPanel.Data;
using System.Data.Entity;
using AirlineDataBase;
using AirlineDataBase.Entityes.TicketAndOrders;
using AdminingDataBaseAirLine.ControlConfigs;

namespace AdminingDataBaseAirLine.UserControls
{
    public partial class TicketPanelControl : UserControl
    {
        private List<TicketControl> ticketControls;

        private AirCompanyContext _airlineContext;
        private ControlConfiguration config;
        private AddingTicket _addTicket;
        private UpdatingTicket _updateTicket;
        private RemovingTicket _removeTicket;

        private bool _isNowAdded;
        private bool _isLocal;
        private bool light;
        private bool _sortPanelIsExpand;
        private bool _isExpand;
        private bool _filterPanelIsExpand;

        public bool DataIsLoad { get; set; }


        public TicketPanelControl()
        {
            InitializeComponent();

        }

        public TicketPanelControl(AirCompanyContext airlineContext, bool light, ControlConfiguration config)
            : this()
        {
            _airlineContext = airlineContext;
            this.light = light;
            this.config = config;
            ticketControls = new List<TicketControl>();
            _addTicket = new AddingTicket(this, airlineContext);
            _updateTicket = new UpdatingTicket(this, airlineContext);
            _removeTicket = new RemovingTicket(this,airlineContext);

        }


        private void TicketPanelControl_Load(object sender, EventArgs e)
        {
           
        }
        private void clearButton_Click(object sender, EventArgs e)
        {
            numberTicketBox.Text = "";
            priceTicketBox.Text = "";
            fromWhereTicketBox.Text = "";
            whereTicketBox.Text = "";
            airplaneTicketBox.Text = "";
            senderTicketBox.Text = "";
        }
        private async void addButton_Click(object sender, EventArgs e)
        {
            _addTicket.ErorHandling();
            if (!_isNowAdded)
            {
                _addTicket.PreperingForAddingTicket();
                _isNowAdded = true;
                cancelOperationBtn.Enabled = true;
                return;

            }

            if (!_isLocal) _isLocal = await _addTicket.LoadDataToLocalCash();


            //Сделать валидацию для TextBox,которые принимают значаение для добалвния нового билета 
            //Валидация




            DataTicketControl dataTicket = _addTicket.GetDataTicketControl();

            //Проверка на существование маршрута 


            var route = _airlineContext.Routes.Local
                 .Where(w => w.FromWhere == dataTicket.FromWhereTicket && w.Where == dataTicket.WhereTicket)
                 .Select(S => new { id = S.ID, incom = S.Incoming, depar = S.Departure })
                 .FirstOrDefault();

            if (route == null)
            {
                erorLabel.Text = "Даного маршруту не існує.\nПеревірте порядок введених даних";
                erorLabel.Visible = true;
                _addTicket.ErorIsActive = true;

                return;
            }

            dataTicket.ArrivalTicket = route.incom;
            dataTicket.DepartmentTicket = route.depar;

            //Проверка на существование рейса с введённой авиакомпании 


            var airlineplane = _airlineContext.AirlinePlanes.Local
                .Where(w => w.SendingAirline == dataTicket.SenderTicket && w.Airplane.Model == dataTicket.ModelAirplane)
                .Select(s => s.ID)
                .FirstOrDefault();

            if (airlineplane == 0)
            {
                erorLabel.Text = "Данна компанія не володіє таким літаком\nПеревірте правильність написання";
                erorLabel.Visible = true;
                _addTicket.ErorIsActive = true;
                return;
            }


            var flight = _airlineContext.Flights.Local
                .Where(w => w.AirlinePlane.ID == airlineplane && w.Route.ID == route.id)
                .Select(s => s.NumberFlight)
                .FirstOrDefault();

            if (flight == 0)
            {
                erorLabel.Text = "Данного рейса не існує\nЗверніться до адміністратора";
                erorLabel.Visible = true;
                _addTicket.ErorIsActive = true;

                _addTicket.ReturnState();
                addButton.Image = Resources.add;
                updateButton.Enabled = true;
                removeButton.Enabled = true;
                cancelOperationBtn.Enabled = false;
                return;
            }

            //Проверка на сущетсвование билета с таким рейсом 

            var tickt = _airlineContext.Tickets.Local
                .Where(w => w.Flight.NumberFlight == flight)
                .Select(s => s.NumberTicket)
                 .FirstOrDefault();

            if (tickt != 0)
            {
                erorLabel.Text = "Даний квиток існує";
                erorLabel.Visible = true;
                _addTicket.ErorIsActive = true;
                return;
            }

            Ticket ticket = new Ticket();
            ticket.Price = dataTicket.PriceTicket;
            ticket.DataSales = DateTime.Now;
            ticket.FlightId = flight;

            _airlineContext.Tickets.Add(ticket);
            await _airlineContext.SaveChangesAsync();
            dataTicket.NumberTicket = ticket.NumberTicket.ToString();

            TicketControl ticketControl = new TicketControl(light, config, dataTicket);
            ticketControl.Binder = BindDataForBoxFormTicket;
            flowTicketPanel.Controls.Add(ticketControl);
            numberTicketBox.Enabled = true;

            _addTicket.ReturnState();
            addButton.Image = Resources.add;
            updateButton.Enabled = true;
            removeButton.Enabled = true;
            cancelOperationBtn.Enabled = false;

        }
        public async Task InsertDataToFlowPanel()
        {
            var data = await Task.Run(() => GetDataTicketControl());
            await _airlineContext.Routes.LoadAsync();

            airplaneTicketBox.Items.AddRange(_airlineContext.Airplanes.Select(s => s.Model).ToArray());
            senderTicketBox.Items.AddRange(_airlineContext.AirlinePlanes.Select(s => s.SendingAirline).ToArray());

            foreach (var route in _airlineContext.Routes.Local)
            {
                fromWhereTicketBox.Items.Add(route.FromWhere);              
                whereTicketBox.Items.Add(route.Where);               
            }

            foreach (var dataTicket in data)
            {
                TicketControl ticket = new TicketControl(light, config, dataTicket);
                ticket.Binder += BindDataForBoxFormTicket;
                flowTicketPanel.Controls.Add(ticket);
                ticketControls.Add(ticket);
            }

            DataIsLoad = true;
        }
        private List<DataTicketControl> GetDataTicketControl()
        {

            var Flights = _airlineContext.Tickets.Select(s => new
            {
                numberTicket = s.NumberTicket,
                price = s.Price,
                fromWhere = s.Flight.Route.FromWhere,
                where = s.Flight.Route.Where,
                departure = s.Flight.Route.Departure,
                arrival = s.Flight.Route.Incoming,
                modelAirplane = s.Flight.AirlinePlane.Airplane.Model,
                sender = s.Flight.AirlinePlane.SendingAirline

            })
            .AsEnumerable()
            .Select(s => new DataTicketControl
            {
                NumberTicket = s.numberTicket.ToString(),
                PriceTicket = s.price,
                FromWhereTicket = s.fromWhere,
                WhereTicket = s.where,
                DepartmentTicket = s.departure,
                ArrivalTicket = s.arrival,
                ModelAirplane = s.modelAirplane,
                SenderTicket = s.sender
            })
            .ToList();

            return Flights;
        }
        public void BindDataForBoxFormTicket(DataTicketControl dataTicket)
        {
            numberTicketBox.Text = dataTicket.NumberTicket.ToString();
            priceTicketBox.Text = dataTicket.PriceTicket.ToString();
            fromWhereTicketBox.Text = dataTicket.FromWhereTicket;
            whereTicketBox.Text = dataTicket.WhereTicket;
            airplaneTicketBox.Text = dataTicket.ModelAirplane.ToString();
            senderTicketBox.Text = dataTicket.SenderTicket.ToString();

        }
        private void erorLabel_Click(object sender, EventArgs e)
        {

        }
        private async void updateButton_Click(object sender, EventArgs e)
        {
            if (_updateTicket.ErorIsActive)
            {
                erorLabel.Visible = false;
                _updateTicket.ErorIsActive = false;

                return;
            }

            if (!_updateTicket.IsNowUpdate)
            {
                _updateTicket.PreperingUpdateTicket();
                _updateTicket.IsNowUpdate = true;
                cancelOperationBtn.Enabled = true;
                return;
            }

            if (!_updateTicket.ChekingOnNotEmptryPriceAndNumber(priceTicketBox.Text, numberTicketBox.Text)) return;


            var priceTicket = _updateTicket.GetTicketPriceById(int.Parse(numberTicketBox.Text));

            if (!_updateTicket.ChekingOnNotOldValuePrice(priceTicket)) return;



            Ticket ticket = new Ticket()
            {
                NumberTicket = int.Parse(numberTicketBox.Text),
            };



            if (!_updateTicket.EntryTicket.ContainsKey(ticket.NumberTicket))
            {
                _updateTicket.EntryTicket.Add(ticket.NumberTicket, true);
                _airlineContext.Tickets.Attach(ticket);
            }
            else
            {
                ticket = _airlineContext.Tickets
                    .Where(w => w.NumberTicket == ticket.NumberTicket)
                    .FirstOrDefault()!;
            }
            ticket.Price = decimal.Parse(priceTicketBox.Text);
            _airlineContext.Entry(ticket).Property(p => p.Price).IsModified = true;

            foreach (UserControls.TicketControl ticketControl in flowTicketPanel.Controls)
            {
                if (ticketControl.FlightField.Text == numberTicketBox.Text)
                {
                    ticketControl.PriceField.Text = priceTicketBox.Text;
                    break;
                }
            }

            await _airlineContext.SaveChangesAsync();
            erorLabel.Visible = false;
            _updateTicket.ReturnState();
            _updateTicket.IsNowUpdate = false;
            updateButton.Image = Resources.update;
            addButton.Enabled = true;
            removeButton.Enabled = true;
            cancelOperationBtn.Enabled = false;
        }
        private void panel4_Paint(object sender, PaintEventArgs e)
        {

        }
        private async void removeButton_Click(object sender, EventArgs e)
        {
            if (_removeTicket.ErorIsActive)
            {
                erorLabel.Visible = false;
                _removeTicket.ErorIsActive = false;

                return;
            }

            if (!_removeTicket.IsNowRemove)
            {
                _removeTicket.PreperingDeleteTicket();
                _removeTicket.IsNowRemove = true;
                cancelOperationBtn.Enabled = true;
                return;
            }
            if (!_removeTicket.ChekingOnNotEmptryIdTicket(numberTicketBox.Text)) return;

            if (!_removeTicket.ContainsEntityById(int.Parse(numberTicketBox.Text), out Ticket ticket)) return;


            var orders = _airlineContext.Orders.Where(w => w.TicketId == ticket.NumberTicket).ToList();
            var reservedSeats = _airlineContext.ReservedSeats.Where(w => w.Order.TicketId == ticket.NumberTicket).ToList();

            _airlineContext.ReservedSeats.RemoveRange(reservedSeats);
            _airlineContext.Orders.RemoveRange(orders);
            _airlineContext.Tickets.Remove(ticket);

            await _airlineContext.SaveChangesAsync();

           
         

            foreach (UserControls.TicketControl ticketControl in flowTicketPanel.Controls)
            {
                if (ticketControl.FlightField.Text == numberTicketBox.Text)
                {
                    flowTicketPanel.Controls.Remove(ticketControl);
                    break;
                }
            }
            _removeTicket.ReturnState();
            removeButton.Image = Resources.remove;
            UpdateButton.Enabled = true;
            AddButton.Enabled = true;
            cancelOperationBtn.Enabled = false;
        }

        private void sortButton_Click(object sender, EventArgs e)
        {
            slideSortButtonPanel.Start();
        }
        private void filterButton_Click(object sender, EventArgs e)
        {
            slideFilterButtonPanel.Start();
        }

        private void slideSortButtonPanel_Tick(object sender, EventArgs e)
        {
            if (!slideSortPanel.Visible)
                slideSortPanel.Visible = true;

            if (!_sortPanelIsExpand)
            {
                slideSortPanel.Height += 20;
                if (slideSortPanel.Height == slideSortPanel.MaximumSize.Height)
                {
                    slideSortButtonPanel.Stop();
                    _sortPanelIsExpand = true;
                    return;
                }
            }
            if (_sortPanelIsExpand)
            {
                slideSortPanel.Height -= 20;
                if (slideSortPanel.Height == slideSortPanel.MinimumSize.Height)
                {
                    slideSortButtonPanel.Stop();
                    _sortPanelIsExpand = false;
                    return;
                }
            }
        }
        private void slideFilterButtonPanel_Tick(object sender, EventArgs e)
        {
            if (!slideFilterPanel.Visible)
                slideFilterPanel.Visible = true;

            if (!_filterPanelIsExpand)
            {
                slideFilterPanel.Height += 40;
                if (slideFilterPanel.Height == slideFilterPanel.MaximumSize.Height)
                {
                    slideFilterButtonPanel.Stop();
                    _filterPanelIsExpand = true;
                    return;
                }
            }
            if (_filterPanelIsExpand)
            {
                slideFilterPanel.Height -= 40;
                if (slideFilterPanel.Height == slideFilterPanel.MinimumSize.Height)
                {
                    slideFilterButtonPanel.Stop();
                    _filterPanelIsExpand = false;
                    return;
                }
            }
        }

        private void slideControlsPanel_Tick(object sender, EventArgs e)
        {
            if (!_isExpand)
            {
                panelControlsTicket.Height += 20;
                if (panelControlsTicket.Height == panelControlsTicket.MaximumSize.Height)
                {
                    slideControlsPanel.Stop();
                    _isExpand = true;
                    buttonSlide.Image = Resources.angle_small_up;
                    return;
                }
            }
            if (_isExpand)
            {
                panelControlsTicket.Height -= 20;
                if (panelControlsTicket.Height == panelControlsTicket.MinimumSize.Height)
                {
                    slideControlsPanel.Stop();
                    _isExpand = false;
                    buttonSlide.Image = Resources.angle_small_down;
                    return;
                }
            }
        }

        private void buttonSlide_Click(object sender, EventArgs e)
        {
            slideControlsPanel.Start();
        }

        private void acceptFilterBtn_Click(object sender, EventArgs e)
        {

            bool firstFilter = priceFromBox.Text != "" && priceToBox.Text != "" ? true : false;
            bool secondFilter = fromWhereBox.Text != "" || whereToBox.Text != "" ? true : false;

            if (firstFilter)
            {
                var filterPrice = ticketControls
                    .Where(w => decimal.Parse(w.PriceField.Text) >= decimal.Parse(priceFromBox.Text)
                    && decimal.Parse(w.PriceField.Text) <= decimal.Parse(priceToBox.Text))
                    .ToList();
                BinControlsToFlowTicketPanel(filterPrice);
                return;
            }
            if (secondFilter)
            {
                var filterRoute = ticketControls
                   .Where(w => w.FromWField.Text == fromWhereBox.Text || w.WhereField.Text == whereToBox.Text)
                   .ToList();
                BinControlsToFlowTicketPanel(filterRoute);
                return;
            }
            if (firstFilter && secondFilter)
            {
                var filtePriceAndRoute = ticketControls
                    .Where(w => decimal.Parse(w.PriceField.Text) >= decimal.Parse(priceFromBox.Text)
                    && decimal.Parse(w.PriceField.Text) <= decimal.Parse(priceToBox.Text))
                    .Where(w => w.FromWField.Text == fromWhereBox.Text || w.WhereField.Text == whereToBox.Text)
                    .ToList();
                BinControlsToFlowTicketPanel(filtePriceAndRoute);
                return;
            }
            if (SenderBox.Text != "")
            {
                var senderFilter = ticketControls
                   .Where(w => w.SenderField.Text == SenderBox.Text)                 
                   .ToList();
                BinControlsToFlowTicketPanel(senderFilter);
                return;
            }
        }
        private void BinControlsToFlowTicketPanel(List<TicketControl> sourse)
        {
            flowTicketPanel.Controls.Clear();
            foreach (var ticket in sourse)
            {
                flowTicketPanel.Controls.Add(ticket);
            }
        }
        private void priceButtonUp_Click(object sender, EventArgs e)
        {
            var sortedUp = ticketControls.OrderBy(f => decimal.Parse(f.PriceField.Text)).ToList();

            BinControlsToFlowTicketPanel(sortedUp);
        }
        private void priceButtonDown_Click(object sender, EventArgs e)
        {
            var sortedDown = ticketControls.OrderByDescending(f => decimal.Parse(f.PriceField.Text)).ToList();

            BinControlsToFlowTicketPanel(sortedDown);
        }
        public  void ChangeTheme(object sender, EventArgs e)
        {
           
        }
        private void nameButtonUp_Click(object sender, EventArgs e)
        {
            var sortedUp = ticketControls.OrderBy(f => f.FromWField.Text).ToList();
            BinControlsToFlowTicketPanel(sortedUp);
        }

        private void nameButtonDown_Click(object sender, EventArgs e)
        {
            var sortedDown = ticketControls.OrderByDescending(f => f.FromWField.Text).ToList();
            BinControlsToFlowTicketPanel(sortedDown);
        }

        private void panelControlsTicket_Paint(object sender, PaintEventArgs e)
        {

        }

        private void flowTicketPanel_Paint(object sender, PaintEventArgs e)
        {

        }

        private void cancelOperationBtn_Click(object sender, EventArgs e)
        {
            erorLabel.Visible = false;

            if (_isNowAdded)
            {
                _addTicket.ReturnState();
                addButton.Image = Resources.add;
                updateButton.Enabled = true;
                removeButton.Enabled = true;              
                _isNowAdded = false;
                return;
            }
            if (_updateTicket.IsNowUpdate)
            {               
                _updateTicket.ReturnState();
                updateButton.Image = Resources.update;
                addButton.Enabled = true;
                removeButton.Enabled = true;
                _updateTicket.IsNowUpdate = false;
                return;
            }
            if (_removeTicket.IsNowRemove)
            {              
                _removeTicket.ReturnState();
                removeButton.Image = Resources.remove;
                removeButton.Enabled = true;
                removeButton.Enabled = true;
                _removeTicket.IsNowRemove = false;
                return;
            }
        }

        private void dropFilter_Click(object sender, EventArgs e)
        {
            BinControlsToFlowTicketPanel(ticketControls);  
        }
    }
}
