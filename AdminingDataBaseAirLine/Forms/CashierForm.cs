using AdminingDataBaseAirLine.Authentication;
using AdminingDataBaseAirLine.Forms.ButtonSettings;
using AdminingDataBaseAirLine.UserControls;
using AdminingDataBaseAirLine.UserControls.ControlConfigs;


namespace AdminingDataBaseAirLine.Forms
{
    public partial class CashierForm : Form
    {
        private Dictionary<string, ButtonProperty> _buttonResourse;
        private ButtonChanges _buttonChanges;
        private bool _ligthMode = true;
        private  Action _closingFrom;
        private AirlineContext _airlineContext;
        private bool _isAdedItem;
        public Action ClosingFrom { get => _closingFrom; set => _closingFrom = value; }

        public CashierForm(AirlineContext airlineContext)
        {
            InitializeComponent();
            _buttonResourse = GetButtonProperties();
            _buttonChanges = new ButtonChanges(_buttonResourse);
            _airlineContext = airlineContext;
        }
      

        private void CashierForm_Load(object sender, EventArgs e)
        {

        }
        private void TicketButton_Click(object sender, EventArgs e)
        {
            _buttonChanges.ChangeButtonProperties("ticketButtonOpen", _ligthMode);

            var config = GetConfiguration();
            if (!_isAdedItem)
            {
                for (int i = 0; i < 7; i++)
                {
                    flowTicketPanel.Controls.Add(new Ticket());
                }
                flowTicketPanel.Visible = true;
                _isAdedItem = true;
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
            _buttonChanges.ChangeButtonProperties("accountButtonOpen",_ligthMode);
        }
        private void ChangeTheme(object sender, EventArgs e)
        {
            CashierFormTheme.ChangeCashierFormTheme(ref _ligthMode,this,_buttonResourse);
           
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
        public ControlConfiguration GetConfiguration()
        {
            return new ControlConfigurationBuilder()
                .SetPanelColor(Color.FromArgb(80, 81, 249), Color.FromArgb(10, 126, 245))
                .SetControlColor(Color.FromArgb(41, 41, 51), Color.FromName("Control"))
                .SetLabelFColor(Color.FromArgb(80, 81, 249), Color.FromArgb(10, 126, 245))
                .SetLabelSColor(Color.Black,Color.FromArgb(95, 99, 136))
                .Build();
        }

        private void BackPanel_Paint(object sender, PaintEventArgs e)
        {

        }
    }
}
