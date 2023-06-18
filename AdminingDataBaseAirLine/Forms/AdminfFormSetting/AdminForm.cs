using AdminingDataBaseAirLine.Forms.CashierFormSetting.ButtonSettings;
using AdminingDataBaseAirLine.UserControls.AirlineplanePanel;
using AdminingDataBaseAirLine.UserControls.CashierPanel;
using AdminingDataBaseAirLine.UserControls.FlightPanel;
using AdminingDataBaseAirLine.UserControls.RoutsPanel;
using AirlineDataBase;

namespace AdminingDataBaseAirLine.Forms.AdminfFormSetting
{
    public partial class AdminForm : Form
    {
        public Action ClosingFrom { get => _closingFrom; set => _closingFrom = value; }

        private Dictionary<string, ButtonProperty> _buttonResourse;
        private List<Control> _controls;

        private ButtonChanges _buttonChanges;
        private AirCompanyContext _airlineContext;

        private bool _isAddedAirline;
        private bool _isAddedFlight;
        private bool _isAddedCashier;

        private bool isAdmin;
        private Action _closingFrom;
        private bool _isAddedRouts;
        private readonly Point _panelPosition = new Point(208, 43);

        public AdminForm()
        {
            InitializeComponent();
        }

        public AdminForm(AirCompanyContext airlineContext, bool isAdmin) : this()
        {
            _airlineContext = airlineContext;
            this.isAdmin = isAdmin;
            _buttonResourse = GetButtonProperties();
            _buttonChanges = new ButtonChanges(_buttonResourse);
            _controls = new List<Control>();
        }

        private void BackPanel_Paint(object sender, PaintEventArgs e)
        {

        }

        private void AdminForm_Load(object sender, EventArgs e)
        {

        }

        private async void routeButton_Click(object sender, EventArgs e)
        {
            _buttonChanges.ChangeButtonProperties("routeButton", true);

            ChangeClickedPanel("RoutsControlPanel");

            if (!_isAddedRouts)
            {
                DataLoad.Visible = true;
                RoutsControlPanel routs = new RoutsControlPanel(_airlineContext);
                routs.Location = _panelPosition;
                await Task.Run(() => routs.InsertDataToDataGrigview());

                _isAddedRouts = true;

                this.Controls.Add(routs);
                _controls.Add(routs);
                DataLoad.Visible = false;
            }

        }

        private async void flightButton_Click(object sender, EventArgs e)
        {
            _buttonChanges.ChangeButtonProperties("flightButton", true);

            ChangeClickedPanel("FlightPanelControl");

            if (!_isAddedFlight)
            {
                DataLoad.Visible = true;
                FlightPanelControl flightPanel = new FlightPanelControl(_airlineContext, isAdmin);
                flightPanel.Location = _panelPosition;
                await Task.Run(() => flightPanel.InsertDataToDataGrigview());

                _isAddedFlight = true;

                this.Controls.Add(flightPanel);
                _controls.Add(flightPanel);
                DataLoad.Visible = false;
            }

        }

        private async void cashierButton_Click(object sender, EventArgs e)
        {
            _buttonChanges.ChangeButtonProperties("cashierButton", true);

            ChangeClickedPanel("CashierPanelControl");

            if (!_isAddedCashier)
            {
                DataLoad.Visible = true;

                CashierPanelControl cashierPanel = new CashierPanelControl(_airlineContext);
                cashierPanel.Location = new Point(222, 53);

                 await Task.Run(() => cashierPanel.InsertDataToDataGrigview());

                _isAddedCashier = true;

                this.Controls.Add(cashierPanel);
                _controls.Add(cashierPanel);
                DataLoad.Visible = false;
            }
        }

        private async void airlineButton_Click(object sender, EventArgs e)
        {
            _buttonChanges.ChangeButtonProperties("airlineButton", true);

            ChangeClickedPanel("AirlineplaneControl");

            if (!_isAddedAirline)
            {
                DataLoad.Visible = true;

                AirlineplaneControl airlineplane = new AirlineplaneControl(_airlineContext, isAdmin);
                airlineplane.Location = new Point(222, 53);

                await Task.Run(() => airlineplane.AddItemToDataGridView());

                _isAddedAirline = true;

                this.Controls.Add(airlineplane);
                _controls.Add(airlineplane);

                DataLoad.Visible = false;
            }

        }

        private void airplaneButton_Click(object sender, EventArgs e)
        {
            _buttonChanges.ChangeButtonProperties("airplaneButton", true);
        }

        private void exelButton_Click(object sender, EventArgs e)
        {
            _buttonChanges.ChangeButtonProperties("exelButton", true);
        }

        private void button2_Click(object sender, EventArgs e)
        {
            _closingFrom.Invoke();
        }

        private void button3_Click(object sender, EventArgs e)
        {
            this.WindowState = FormWindowState.Minimized;
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
    }
}
