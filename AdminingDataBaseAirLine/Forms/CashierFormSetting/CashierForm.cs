using AdminingDataBaseAirLine.Authentication;
using AdminingDataBaseAirLine.Forms.CashierFormSetting.ButtonSettings;
using AdminingDataBaseAirLine.Themes;
using AdminingDataBaseAirLine.UserControls;
using AdminingDataBaseAirLine.UserControls.ControlConfigs;
using DataBaseModel.Entities.RouteAndFlight;
using System.Windows.Forms;

namespace AdminingDataBaseAirLine.Forms.CashierFormSetting
{

  
    public partial class CashierForm : Form
    {
        #region Fields  
        
        private Dictionary<string, ButtonProperty> _buttonResourse;
        private ButtonChanges _buttonChanges;
        private bool _ligthMode = true;       
        private AirlineContext _airlineContext;
        private bool _isAdedItem;
        private CashierFormTheme _cashierFormTheme;
        private ControlsTheme _ticketControlsTheme;

        private object obj = new object();

        #endregion


        private Action _closingFrom;
        public Action ClosingFrom { get => _closingFrom; set => _closingFrom = value; }



        public CashierForm(AirlineContext airlineContext)
        {
            InitializeComponent();
            _buttonResourse = GetButtonProperties();
            _buttonChanges = new ButtonChanges(_buttonResourse);
            _airlineContext = airlineContext;
            _cashierFormTheme = new CashierFormTheme(this,_buttonResourse,GetFormConfiguration());
            _ticketControlsTheme = new ControlsTheme(GetConfiguration());
        }     
        private void CashierForm_Load(object sender, EventArgs e)
        {

        }

        #region MethodsRelatedToTheForm


        private async void TicketButton_Click(object sender, EventArgs e)
        {
            _buttonChanges.ChangeButtonProperties("ticketButtonOpen", _ligthMode);
            ticketDataLoad.Visible = true;
            var config =  GetConfiguration();


            if (!_isAdedItem)
            {
                _isAdedItem = true;
                var data = await Task.Run(() => GetDataTicketControl());
                
                ticketDataLoad.Visible = false;
                for (int i = 0; i < data.Count; i++)
                {
                    Ticket ticket = new Ticket(_ligthMode, config, data[i]);
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
            _buttonChanges.ChangeButtonProperties("accountButtonOpen",_ligthMode);
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
                _ticketControlsTheme.ChangeThemeControlInFlowPanel(ref _ligthMode,FlowTicketPanel);
                return;
            }
            _cashierFormTheme.ChangeToLightTheme(ref _ligthMode);
            _ticketControlsTheme.ChangeThemeControlInFlowPanel(ref _ligthMode, FlowTicketPanel);
        }
            
      

        public void BindDataForBoxFormTicket(DataTicketControl dataTicket)
        {
            numberTicketBox.Text = dataTicket.NumberTicket.ToString();
            priceTicketBox.Text = dataTicket.PriceTicket.ToString();
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

        
    }
}
