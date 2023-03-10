using AdminingDataBaseAirLine.Properties;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace AdminingDataBaseAirLine.Forms
{
    public partial class CashierForm : Form
    {
        private Dictionary<string, ButtonProperty> _buttonResourse;
        private ComponentResourceManager _component;

        public CashierForm()
        {
            InitializeComponent();
            _buttonResourse = new Dictionary<string, ButtonProperty>()
            {
                ["ticketButtonOpen"] = new ButtonProperty(false, TicketButton,Resources.ticket_white,Resources.ticket_blue),
                ["flightButtonOpen"] = new ButtonProperty(false, FlightButton,Resources.flight_white,Resources.flight_blue),
                ["passengerButtonOpen"] = new ButtonProperty(false, PassengerButton,Resources.pass_white,Resources.passenger_blue),
                ["ordersButtonOpen"] = new ButtonProperty(false, OrdersButton,Resources.order_white,Resources.receipt_blue),
                ["accountButtonOpen"] = new ButtonProperty(false, AccountButton,Resources.profile_white,Resources.receipt_blue)
            };
            _component = new ComponentResourceManager(typeof(CashierForm));
        }
        private void CashierForm_Load(object sender, EventArgs e)
        {
            
        }
        private void panel1_Paint(object sender, PaintEventArgs e)
        {

        }

        private void TicketButton_Click(object sender, EventArgs e)
        {
            string butnName = "ticketButtonOpen";
            _buttonResourse[butnName].IsOpen = true;
            ButtonColorChangingOpen(TicketButton);
            TicketButton.Image = _buttonResourse[butnName].BlueImage;
            ChekingButtonOpen(butnName);
        }
      
        private void FlightButton_Click(object sender, EventArgs e)
        {
            string butnName = "flightButtonOpen";
            _buttonResourse[butnName].IsOpen = true;
            ButtonColorChangingOpen(FlightButton);
            TicketButton.Image = _buttonResourse[butnName].BlueImage;
            ChekingButtonOpen(butnName);
        }

        private void PassengerButton_Click(object sender, EventArgs e)
        {
            string butnName = "passengerButtonOpen";
            _buttonResourse[butnName].IsOpen = true;
            ButtonColorChangingOpen(PassengerButton);
            TicketButton.Image = _buttonResourse[butnName].BlueImage;
            ChekingButtonOpen(butnName);
        }

        private void OrdersButton_Click(object sender, EventArgs e)
        {
            string butnName = "ordersButtonOpen";
            _buttonResourse[butnName].IsOpen = true;
            ButtonColorChangingOpen(OrdersButton);
            TicketButton.Image = _buttonResourse[butnName].BlueImage;
            ChekingButtonOpen(butnName);
        }

        private void AccountButton_Click(object sender, EventArgs e)
        {
            string butnName = "accountButtonOpen";
            _buttonResourse[butnName].IsOpen = true;
            ButtonColorChangingOpen(AccountButton);
            TicketButton.Image = _buttonResourse[butnName].BlueImage;
            ChekingButtonOpen(butnName);
        }

        private void ButtonColorChangingOpen(Button button)
        {
            button.ForeColor = Color.FromArgb(10, 126, 245);
            button.BackColor = Color.FromName("Control");
        }
        private void ButtonColorChangingDeffault(Button button)
        {           
            button.ForeColor = Color.FromName("Control");
            button.BackColor = Color.FromArgb(10, 126, 245);
        }
        private void ChekingButtonOpen(string scipName)
        {
            foreach (var item in _buttonResourse)
            {
                if (item.Key == scipName) continue;

                if (!item.Value.IsOpen) continue;

                    _buttonResourse[item.Key].IsOpen = false;
                    ButtonColorChangingDeffault(item.Value.Button);
                     item.Value.Button.Image = _buttonResourse[item.Key].WhiteImage;

            }
        }
       

    }
}
