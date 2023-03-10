using AdminingDataBaseAirLine.Forms.ButtonSettings;
using AdminingDataBaseAirLine.Properties;
using System.ComponentModel;



namespace AdminingDataBaseAirLine.Forms
{
    public partial class CashierForm : Form
    {
        private Dictionary<string, ButtonProperty> _buttonResourse;
        private ButtonChanges _buttonChanges;
        private bool _ligthMode = true;

        public CashierForm()
        {
            InitializeComponent();
            _buttonResourse = GetButtonProperties();
            _buttonChanges = new ButtonChanges(_buttonResourse);
        }
        private void CashierForm_Load(object sender, EventArgs e)
        {

        }
        private void TicketButton_Click(object sender, EventArgs e)
        {
            _buttonChanges.ChangeButtonProperties("ticketButtonOpen", _ligthMode);

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


    }
}
