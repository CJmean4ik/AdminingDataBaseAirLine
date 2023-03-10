using AdminingDataBaseAirLine.Forms.ButtonSettings;
using AdminingDataBaseAirLine.Properties;
using System.ComponentModel;



namespace AdminingDataBaseAirLine.Forms
{
    public partial class CashierForm : Form
    {
        private Dictionary<string, ButtonProperty> _buttonResourse;
        private ComponentResourceManager _component;
        private ButtonChanges _buttonChanges;
        private bool _ligthMode = true;
        public CashierForm()
        {
            InitializeComponent();
            _buttonResourse = new Dictionary<string, ButtonProperty>()
            {
                ["ticketButtonOpen"] = new ButtonProperty(false, TicketButton, Resources.ticket_white, Resources.ticket_blue),
                ["flightButtonOpen"] = new ButtonProperty(false, FlightButton, Resources.flight_white, Resources.flight_blue),
                ["passengerButtonOpen"] = new ButtonProperty(false, PassengerButton, Resources.pass_white, Resources.passenger_blue),
                ["ordersButtonOpen"] = new ButtonProperty(false, OrdersButton, Resources.order_white, Resources.receipt_blue),
                ["accountButtonOpen"] = new ButtonProperty(false, AccountButton, Resources.profile_white, Resources.profile_blue)
            };
            _buttonChanges = new ButtonChanges(_buttonResourse);
            _component = new ComponentResourceManager(typeof(CashierForm));
        }
        private void CashierForm_Load(object sender, EventArgs e)
        {

        }
        private void TicketButton_Click(object sender, EventArgs e)
        {
            _buttonChanges.ChangeButtonProperties("ticketButtonOpen");

        }

        private void FlightButton_Click(object sender, EventArgs e)
        {
            _buttonChanges.ChangeButtonProperties("flightButtonOpen");

        }

        private void PassengerButton_Click(object sender, EventArgs e)
        {
            _buttonChanges.ChangeButtonProperties("passengerButtonOpen");

        }

        private void OrdersButton_Click(object sender, EventArgs e)
        {
            _buttonChanges.ChangeButtonProperties("ordersButtonOpen");

        }

        private void AccountButton_Click(object sender, EventArgs e)
        {
            _buttonChanges.ChangeButtonProperties("accountButtonOpen");

        }

        private void ChangeTheme(object sender, EventArgs e)
        {
            if (_ligthMode)
            {
                BackColor = Color.FromArgb(20, 21, 23);
                BackPanel.BackColor = Color.FromArgb(30, 31, 36);
                panel1.BackColor = Color.FromArgb(30, 31, 36);
                ThemeButton.Image = Resources.night_mode;
                _ligthMode = false;
                return;
            }
            if (!_ligthMode)
            {
                this.BackColor = Color.FromName("Control");
                BackPanel.BackColor = Color.FromArgb(10, 126, 245);
                panel1.BackColor = Color.FromArgb(10, 126, 245);
                ThemeButton.Image = Resources.lightmode;
                _ligthMode = true;
                return;
            }
        }


    }
}
