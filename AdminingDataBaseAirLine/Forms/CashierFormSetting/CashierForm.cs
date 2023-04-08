using AdminingDataBaseAirLine.Authentication;
using AdminingDataBaseAirLine.Forms.CashierFormSetting.ButtonSettings;
using AdminingDataBaseAirLine.Forms.CashierFormSetting.CRUD;
using AdminingDataBaseAirLine.Properties;
using AdminingDataBaseAirLine.Themes;
using AdminingDataBaseAirLine.UserControls;
using AdminingDataBaseAirLine.UserControls.Config;
using AdminingDataBaseAirLine.UserControls.Data;
using DataBaseModel.Entities.TicketAndOrders;
using System.Data.Entity;

using TicketControl = AdminingDataBaseAirLine.UserControls.TicketControl;

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
       

        private bool _ligthMode = true;
        private bool _isAdedItem;
        private bool _isExpand = true;
        private bool _sortPanelIsExpand;
        private bool _filterPanelIsExpand;
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
            
        }


        #region MethodsRelatedToTheForm


        private async void TicketButton_Click(object sender, EventArgs e)
        {
            _buttonChanges.ChangeButtonProperties("ticketButtonOpen", _ligthMode);
            ticketDataLoad.Visible = true;

            if (!_isAdedItem)
            {
                _isAdedItem = true;

                TicketPanelControl ticketPanel = new TicketPanelControl(_airlineContext,_ligthMode,_controlConfig,_ticketControlsTheme);
                ticketPanel.Visible = false;
                ticketPanel.Location = new Point(109, 53);
                await ticketPanel.InsertDataToFlowPanel();
                ThemeButton.Click += new EventHandler(ticketPanel.ChangeTheme!);

                if (ticketPanel.DataIsLoad)
                {
                    ticketPanel.Visible = true;
                    ticketPanel.Show();
                }

                this.Controls.Add(ticketPanel);
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
                return;
            }
            _cashierFormTheme.ChangeToLightTheme(ref _ligthMode);
           
        } 
        private void flowTicketPanel_Paint(object sender, PaintEventArgs e)
        {

        }
    }
}
