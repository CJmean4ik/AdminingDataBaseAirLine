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
        private Dictionary<string, ButtonProperty> _buttonsOpen;

        public CashierForm()
        {
            InitializeComponent();
        }
        private void CashierForm_Load(object sender, EventArgs e)
        {
            _buttonsOpen = new Dictionary<string, ButtonProperty>()
            {
                ["ticketButtonOpen"] = new ButtonProperty(false, TicketButton),
                ["flightButtonOpen"] = new ButtonProperty(false,FlightButton),
                ["passengerButtonOpen"] = new ButtonProperty(false,PassengerButton),
                ["ordersButtonOpen"] = new ButtonProperty(false, OrdersButton),
                ["accountButtonOpen"] = new ButtonProperty(false,AccountButton)
            };
        }
        private void panel1_Paint(object sender, PaintEventArgs e)
        {

        }

        private void TicketButton_Click(object sender, EventArgs e)
        {
            _buttonsOpen["ticketButtonOpen"].IsOpen = true;
            ButtonColorChangingOpen(TicketButton);
            ChekingButtonOpen();
        }
      
        private void FlightButton_Click(object sender, EventArgs e)
        {
            _buttonsOpen["flightButtonOpen"].IsOpen = true;
            ButtonColorChangingOpen(TicketButton);
            ChekingButtonOpen();
        }

        private void PassengerButton_Click(object sender, EventArgs e)
        {
            _buttonsOpen["passengerButtonOpen"].IsOpen = true;
            ButtonColorChangingOpen(TicketButton);
            ChekingButtonOpen();
        }

        private void OrdersButton_Click(object sender, EventArgs e)
        {
            _buttonsOpen["ordersButtonOpen"].IsOpen = true;
            ButtonColorChangingOpen(TicketButton);
            ChekingButtonOpen();
        }

        private void AccountButton_Click(object sender, EventArgs e)
        {
            _buttonsOpen["accountButtonOpen"].IsOpen = true;
            ButtonColorChangingOpen(TicketButton);
            ChekingButtonOpen();
        }

        private void ButtonColorChangingOpen(Button button)
        {
            button.ForeColor = Color.FromArgb(10, 126, 245);
            button.BackColor = Color.FromArgb(255, 255, 255);
        }
        private void ButtonColorChangingDeffault(Button button)
        {           
            button.ForeColor = Color.FromArgb(255, 255, 255);
            button.BackColor = Color.FromArgb(10, 126, 245);
        }
        private void ChekingButtonOpen()
        {
            foreach (var item in _buttonsOpen)
            {
                if (!item.Value.IsOpen) continue;
                
                    _buttonsOpen[item.Key].IsOpen = false;
                    ButtonColorChangingDeffault(item.Value.Button);             
            }
        }
       
    }
}
