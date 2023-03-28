using AdminingDataBaseAirLine.Authentication;
using AdminingDataBaseAirLine.Forms.CashierFormSetting.ButtonSettings;
using AdminingDataBaseAirLine.Forms.CashierFormSetting.CRUD;
using AdminingDataBaseAirLine.Themes;
using AdminingDataBaseAirLine.UserControls.Config;
using AdminingDataBaseAirLine.UserControls.Data;
using System.Data.Entity;
using TicketControl = AdminingDataBaseAirLine.UserControls.Ticket;

namespace AdminingDataBaseAirLine.Forms.CashierFormSetting
{


    public partial class CashierForm : Form
    {
        #region Fields  

        private Dictionary<string, ButtonProperty> _buttonResourse;

        private ButtonChanges _buttonChanges;
        private AirlineContext _airlineContext;
        private CashierFormTheme _cashierFormTheme;
        private ControlsTheme _ticketControlsTheme;
        private ControlConfiguration _controlConfig;
        private AddingTicket _addTicket;

        private bool _ligthMode = true;
        private bool _isAdedItem;
        private bool _isNowAdded;
        private bool _isLocal;
        #endregion


        private Action _closingFrom;
        public Action ClosingFrom { get => _closingFrom; set => _closingFrom = value; }



        public CashierForm(AirlineContext airlineContext)
        {
            _airlineContext = airlineContext;
            InitializeComponent();
            InitializeRelatedClass();
        }
        private void CashierForm_Load(object sender, EventArgs e)
        {

        }

        private void InitializeRelatedClass()
        {
            _buttonResourse = GetButtonProperties();
            _buttonChanges = new ButtonChanges(_buttonResourse);        
            _cashierFormTheme = new CashierFormTheme(this, _buttonResourse, GetFormConfiguration());
            _ticketControlsTheme = new ControlsTheme(GetConfiguration());
            _controlConfig = GetConfiguration();
            _addTicket = new AddingTicket(this,_airlineContext);
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
                await _airlineContext.Routes.LoadAsync();
                airplaneTicketBox.Items.AddRange(_airlineContext.Airplanes.Select(s => s.Model).ToArray());
                senderTicketBox.Items.AddRange(_airlineContext.AirlinePlanes.Select(s => s.SendingAirline).ToArray());

                foreach (var route in _airlineContext.Routes.Local)
                {
                    arivalTicketBox.Items.Add(route.Incoming);
                    departTicketBox.Items.Add(route.Departure);
                    fromWhereTicketBox.Items.Add(route.FromWhere);
                    fromWhereTicketBox.Items.Add(route.Where);
                    whereTicketBox.Items.Add(route.Where);
                    whereTicketBox.Items.Add(route.FromWhere);
                }



                for (int i = 0; i < data.Count; i++)
                {
                    TicketControl ticket = new TicketControl(_ligthMode, _controlConfig, data[i]);
                    ticket.Binder += BindDataForBoxFormTicket;
                    flowTicketPanel.Controls.Add(ticket);
                }
                ticketPanel.Visible = true;
                ticketDataLoad.Visible = false;
            }
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
        private void AirlineButton_Click(object sender, EventArgs e)
        {
            _buttonChanges.ChangeButtonProperties("airlineButtonOpen", _ligthMode);
        }
        private void AirplaneButton_Click(object sender, EventArgs e)
        {
            _buttonChanges.ChangeButtonProperties("airplaneButtonOpen", _ligthMode);
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
                _addTicket.PreperingForAddingTicket();
                _isNowAdded = true;
                return;
            }

            if (!_isLocal) _isLocal = await _addTicket.LoadDataToLocalCash();


            //Валидация
            //Сделать валидацию для TextBox,которые принимают значаение для добалвния нового билета 

            DataTicketControl dataTicket = _addTicket.GetDataTicketControl();

            //Проверка на существование маршрута 

            //Проверка на существование рейса с введённой авиакомпании 

            //Проверка на сущетсвование билета с таким рейсом 



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
