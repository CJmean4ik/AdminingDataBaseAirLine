using AdminingDataBaseAirLine.Authentication;
using AdminingDataBaseAirLine.Forms.CashierFormSetting.ButtonSettings;
using AdminingDataBaseAirLine.Properties;
using AdminingDataBaseAirLine.Themes;
using AdminingDataBaseAirLine.UserControls.Config;
using AdminingDataBaseAirLine.UserControls.Data;
using DataBaseModel.Entities.RouteAndFlight;
using System.Data.Entity;
using Ticket = DataBaseModel.Entities.TicketAndOrders.Ticket;
using TicketControl = AdminingDataBaseAirLine.UserControls.Ticket;

namespace AdminingDataBaseAirLine.Forms.CashierFormSetting
{


    public partial class CashierForm : Form
    {
        #region Fields  

        private Dictionary<string, ButtonProperty> _buttonResourse;

        private readonly ButtonChanges _buttonChanges;
        private AirlineContext _airlineContext;
        private readonly CashierFormTheme _cashierFormTheme;
        private readonly ControlsTheme _ticketControlsTheme;

        private bool _ligthMode = true;
        private bool _isAdedItem;
        private bool _isNowAdded;
        private bool _isLocal;
        private readonly ControlConfiguration _controlConfig;
        #endregion


        private Action _closingFrom;
        public Action ClosingFrom { get => _closingFrom; set => _closingFrom = value; }



        public CashierForm(AirlineContext airlineContext)
        {
            InitializeComponent();
            _buttonResourse = GetButtonProperties();
            _buttonChanges = new ButtonChanges(_buttonResourse);
            _airlineContext = airlineContext;
            _cashierFormTheme = new CashierFormTheme(this, _buttonResourse, GetFormConfiguration());
            _ticketControlsTheme = new ControlsTheme(GetConfiguration());
            _controlConfig = GetConfiguration();
        }
        private void CashierForm_Load(object sender, EventArgs e)
        {

        }

        #region MethodsRelatedToTheForm


        private async void TicketButton_Click(object sender, EventArgs e)
        {
            _buttonChanges.ChangeButtonProperties("ticketButtonOpen", _ligthMode);
            ticketDataLoad.Visible = true;

            if (!_isAdedItem)
            {


                _isAdedItem = true;

                var data = await Task.Run(() => GetDataTicketControl());
                airplaneTicketBox.Items.AddRange(_airlineContext.Airplanes.Select(s => s.Model).ToArray());
                senderTicketBox.Items.AddRange(_airlineContext.AirlinePlanes.Select(s => s.SendingAirline).ToArray());

                ticketDataLoad.Visible = false;
                for (int i = 0; i < data.Count; i++)
                {
                    TicketControl ticket = new TicketControl(_ligthMode, _controlConfig, data[i]);
                    ticket.Binder += BindDataForBoxFormTicket;
                    flowTicketPanel.Controls.Add(ticket);
                }
                ticketPanel.Visible = true;
                flowTicketPanel.Visible = true;


            }
            ticketPanel.Visible = true;
        }
        private void FlightButton_Click(object sender, EventArgs e)
        {
            _buttonChanges.ChangeButtonProperties("flightButtonOpen", _ligthMode);
        }
        private void PassengerButton_Click(object sender, EventArgs e)
        {
            _buttonChanges.ChangeButtonProperties("passengerButtonOpen", _ligthMode);
        }
        private void OrdersButton_Click(object sender, EventArgs e)
        {
            _buttonChanges.ChangeButtonProperties("ordersButtonOpen", _ligthMode);

        }
        private void AccountButton_Click(object sender, EventArgs e)
        {
            _buttonChanges.ChangeButtonProperties("accountButtonOpen", _ligthMode);
        }


        private void closeButton_Click(object sender, EventArgs e)
        {
            this.Hide();
            this.Close();

            if (_closingFrom != null)
            {
                _closingFrom.Invoke();
                this.Dispose();
            }
        }
        private void collapseButton_Click(object sender, EventArgs e)
        {
            this.WindowState = FormWindowState.Minimized;
        }

        #endregion

        private void ChangeTheme(object sender, EventArgs e)
        {
            if (_ligthMode)
            {
                _cashierFormTheme.ChangeToDarkTheme(ref _ligthMode);
                _ticketControlsTheme.ChangeThemeControlInFlowPanel(ref _ligthMode, FlowTicketPanel);
                return;
            }
            _cashierFormTheme.ChangeToLightTheme(ref _ligthMode);
            _ticketControlsTheme.ChangeThemeControlInFlowPanel(ref _ligthMode, FlowTicketPanel);
        }



        public void BindDataForBoxFormTicket(DataTicketControl dataTicket)
        {
            numberTicketBox.Text = dataTicket.NumberTicket.ToString();
            priceTicketBox.Text = dataTicket.PriceTicket.ToString();
            fromWhereTicketBox.Text = dataTicket.FromWhereTicket;
            whereTicketBox.Text = dataTicket.WhereTicket;
            departTicketBox.Text = dataTicket.DepartmentTicket.ToString();
            arivalTicketBox.Text = dataTicket.ArrivalTicket.ToString();
            airplaneTicketBox.Text = dataTicket.ModelAirplane.ToString();
            senderTicketBox.Text = dataTicket.SenderTicket.ToString();

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
                NumberTicket = s.numberTicket,
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


        private async void AddButton_Click(object sender, EventArgs e)
        {

            if (!_isNowAdded)
            {
                numberTicketBox.Text = "";
                priceTicketBox.Text = "";
                fromWhereTicketBox.Text = "";
                whereTicketBox.Text = "";
                departTicketBox.Text = "";
                arivalTicketBox.Text = "";
                airplaneTicketBox.Text = "";
                senderTicketBox.Text = "";

                numberTicketBox.Enabled = false;
                AddButton.Image = Resources.checkmark__1_;
                AddButton.Text = "Додати!";
                _isNowAdded = true;

                return;
            }

            #region Load data to Local Cash
            if (!_isLocal)
            {

                await _airlineContext.Routes.LoadAsync();
                await _airlineContext.AirlinePlanes.LoadAsync();
                _isLocal = true;
            }

            #endregion


            //Валидация
            //Сделать валидацию для TextBox,которые принимают значаение для добалвния нового билета 




            DataTicketControl dataTicket = new DataTicketControl();
            dataTicket.PriceTicket = decimal.Parse(priceTicketBox.Text);

            dataTicket.FromWhereTicket = fromWhereTicketBox.Text;
            dataTicket.WhereTicket = whereTicketBox.Text;
            dataTicket.DepartmentTicket = DateTime.Parse(departTicketBox.Text);
            dataTicket.ArrivalTicket = DateTime.Parse(arivalTicketBox.Text);

            dataTicket.ModelAirplane = airplaneTicketBox.Text;
            dataTicket.SenderTicket = senderTicketBox.Text;



            Ticket ticketEntity = new Ticket();
            ticketEntity.Price = dataTicket.PriceTicket;
            ticketEntity.DataSales = DateTime.Now;

            int? idRoute = _airlineContext.Routes.Local
                 .Where(wr =>
                 wr.FromWhere == dataTicket.FromWhereTicket &&
                 wr.Where == dataTicket.WhereTicket &&
                 wr.Departure == dataTicket.DepartmentTicket &&
                 wr.Incoming == dataTicket.ArrivalTicket
                 )
                 .Select(s => s.ID)
                 .FirstOrDefault();

            if (idRoute != null)
            {
                warningExistLabel.Visible = true;
                return;
            }

            Route route = new Route();
            route.FromWhere = dataTicket.FromWhereTicket;
            route.Where = dataTicket.WhereTicket;
            route.Incoming = dataTicket.ArrivalTicket;
            route.Departure = dataTicket.DepartmentTicket;

            var routeAdded = _airlineContext.Routes.Add(route);

            Flight flight = new Flight();

            flight.AirlinePlaneId = _airlineContext.AirlinePlanes
                .Where(s => s.AirLine.Name == dataTicket.SenderTicket && s.Airplane.Model == dataTicket.ModelAirplane)
                .Select(s => s.AirplaneId)
                .FirstOrDefault();
            flight.RouteId = routeAdded.ID;

            var flightAdded = _airlineContext.Flights.Add(flight);

            ticketEntity.FlightId = flightAdded.NumberFlight;


            _airlineContext.SaveChanges();


            TicketControl ticket = new TicketControl(_ligthMode, _controlConfig, dataTicket);
            flowTicketPanel.Controls.Add(ticket);
        }


        private void departTicketBox_DoubleClick(object sender, EventArgs e)
        {
            departTicketBox.Text = DateTime.Now.ToString();

        }

        private void arivalTicketBox_DoubleClick(object sender, EventArgs e)
        {

            arivalTicketBox.Text = DateTime.Now.ToString();
        }


    }
}
