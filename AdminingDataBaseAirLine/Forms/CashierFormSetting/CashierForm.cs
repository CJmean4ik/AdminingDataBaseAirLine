using AdminingDataBaseAirLine.Forms.CashierFormSetting.ButtonSettings;
using AdminingDataBaseAirLine.UserControls;
using AdminingDataBaseAirLine.UserControls.AirlineplanePanel;
using AdminingDataBaseAirLine.UserControls.Config;
using AdminingDataBaseAirLine.UserControls.FlightPanel;
using AdminingDataBaseAirLine.UserControls.OrdersPanel;
using AdminingDataBaseAirLine.UserControls.PassangerPanel;
using AdminingDataBaseAirLine.UserControls.ReservedSeatsPanel;
using AirlineDataBase.DataBaseContext;

namespace AdminingDataBaseAirLine.Forms.CashierFormSetting
{


    public partial class CashierForm : Form
    {
        #region Fields  

        private Dictionary<string, ButtonProperty> _buttonResourse;
        private List<Control> _controls;

        private ButtonChanges _buttonChanges;
        private AirCompanyContext _airlineContext;
        private ControlConfiguration _controlConfig;
        private TicketPanelControl ticketPanel;

        private int _cashierId;

        private bool _ligthMode = true;
        private bool _isAddedTicket;
        private bool _isAddedFlight;
        private bool _isAddedPassenger;
        private bool _isAddedAirline;
        private bool _isAddedOrders;
        private Point _panelPosition = new Point(208, 43);
        #endregion


        private Action _closingFrom;
        private bool _reservedSeatsIsAded;

        public Action ClosingFrom { get => _closingFrom; set => _closingFrom = value; }



        public CashierForm(AirCompanyContext airlineContext, int cashierId)
        {
            _airlineContext = airlineContext;
            InitializeComponent();
            InitializeModule();
            _cashierId = cashierId;
        }
        private void CashierForm_Load(object sender, EventArgs e)
        {

        }

        private void InitializeModule()
        {
            _buttonResourse = GetButtonProperties();
            _buttonChanges = new ButtonChanges(_buttonResourse);
            _controlConfig = GetConfiguration();
            _controls = new List<Control>();

        }


        #region MethodsRelatedToTheForm


        private async void TicketButton_Click(object sender, EventArgs e)
        {
            _buttonChanges.ChangeButtonProperties("ticketButtonOpen", _ligthMode);
           
            ChangeClickedPanel("TicketPanelControl");

            if (!_isAddedTicket)
            {
                DataLoad.Visible = true;
                ticketPanel = new TicketPanelControl(_airlineContext, _ligthMode, _controlConfig);
                ticketPanel.Location = _panelPosition;
                await ticketPanel.InsertDataToFlowPanel();

                _isAddedTicket = true;               

                this.Controls.Add(ticketPanel);
                _controls.Add(ticketPanel);
                DataLoad.Visible = false;
            }
          

        }
        private async void FlightButton_Click(object sender, EventArgs e)
        {
            _buttonChanges.ChangeButtonProperties("flightButtonOpen", _ligthMode);
           
            ChangeClickedPanel("FlightPanelControl");

            if (!_isAddedFlight)
            {
                DataLoad.Visible = true;
                FlightPanelControl flightPanel = new FlightPanelControl(_airlineContext);
                flightPanel.Location = _panelPosition;
                await Task.Run(() => flightPanel.InsertDataToDataGrigview());

                _isAddedFlight = true;

                this.Controls.Add(flightPanel);
                _controls.Add(flightPanel);
                DataLoad.Visible = false;
            }
          
        }
        private async void PassengerButton_Click(object sender, EventArgs e)
        {
            _buttonChanges.ChangeButtonProperties("passengerButtonOpen", _ligthMode);
          
            ChangeClickedPanel("PassangerPanelControl");

            if (!_isAddedPassenger)
            {
                DataLoad.Visible = true;
                PassangerPanelControl passangerPanel = new PassangerPanelControl(_airlineContext);
                passangerPanel.Location = _panelPosition;

                await Task.Run(() => passangerPanel.AddPassengerToDataGrid());
              
                _isAddedPassenger = true;

                this.Controls.Add(passangerPanel);
                _controls.Add(passangerPanel);

                DataLoad.Visible = false;
            }
           
        }
        private async void OrdersButton_Click(object sender, EventArgs e)
        {
            _buttonChanges.ChangeButtonProperties("ordersButtonOpen", _ligthMode);

            ChangeClickedPanel("OrderPanelControl");

            if (!_isAddedOrders)
            {
                DataLoad.Visible = true;
                OrderPanelControl orderPanel = new OrderPanelControl(_airlineContext, _cashierId);
                orderPanel.Location = _panelPosition;

                await Task.Run(() => orderPanel.BindDataGridView());
                await Task.Run(() => orderPanel.LoadDataInLocalCashAsync());

                _isAddedOrders = true;

                this.Controls.Add(orderPanel);
                _controls.Add(orderPanel);

                DataLoad.Visible = false;
            }

        }
        private async void AirplaneButton_Click(object sender, EventArgs e)
        {
            _buttonChanges.ChangeButtonProperties("airplaneButtonOpen", _ligthMode);

            ChangeClickedPanel("ReservedSeatsPanelControl");

            if (!_reservedSeatsIsAded)
            {
                DataLoad.Visible = true;

                ReservedSeatsPanelControl reservedSeatsPanel = new ReservedSeatsPanelControl(_airlineContext);
                reservedSeatsPanel.Location = _panelPosition;

                await Task.Run(() => reservedSeatsPanel.LoadAirPlaneData());
                await Task.Run(() => reservedSeatsPanel.LoadDataToLocalCash());  
                reservedSeatsPanel.CreateReservedSeatsControls();

                _reservedSeatsIsAded = true;

                this.Controls.Add(reservedSeatsPanel);
                _controls.Add(reservedSeatsPanel);

                DataLoad.Visible = false;
            }

        }
        private void AccountButton_Click(object sender, EventArgs e)
        {
            _buttonChanges.ChangeButtonProperties("accountButtonOpen", _ligthMode);
        }
        private async void AirlineButton_Click(object sender, EventArgs e)
        {
            _buttonChanges.ChangeButtonProperties("airlineButtonOpen", _ligthMode);
            ChangeClickedPanel("AirlineplaneControl");

            if (!_isAddedAirline)
            {
                DataLoad.Visible = true;

                AirlineplaneControl airlineplane = new AirlineplaneControl(_airlineContext);
                airlineplane.Location = new Point(222, 53);

                await Task.Run(() => airlineplane.AddItemToDataGridView());

                _isAddedAirline = true;

                this.Controls.Add(airlineplane);
                _controls.Add(airlineplane);

                DataLoad.Visible = false;
            }
           
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
            

        }
        private void flowTicketPanel_Paint(object sender, PaintEventArgs e)
        {

        }

        private void ChangeClickedPanel(string enablePanel)
        {
            foreach (var control in _controls)
            {               
                if (control != null && control.Visible)              
                    control.Visible = false;                  
 
                if (control.Name == enablePanel)
                    control.Visible = true;
            }
        }

        private void orderPanelControl1_Load(object sender, EventArgs e)
        {

        }
    }
}
