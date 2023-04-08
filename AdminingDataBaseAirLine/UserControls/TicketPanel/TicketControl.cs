using AdminingDataBaseAirLine.Themes;
using AdminingDataBaseAirLine.UserControls.Config;
using AdminingDataBaseAirLine.UserControls.Data;


namespace AdminingDataBaseAirLine.UserControls
{
    public partial class TicketControl : UserControl
    {

        private bool IsLight = true;
        private readonly ControlConfiguration config;
        private ControlsTheme theme;
        private Action<DataTicketControl> _binder;
        private DataTicketControl _dataTicket;
        internal ControlsTheme Theme { get => theme; set => theme = value; }
        public Action<DataTicketControl> Binder { get => _binder; set => _binder += value; }

        public TicketControl(bool isLight, ControlConfiguration configuration, DataTicketControl control)
        {
            InitializeComponent();
            IsLight = isLight;
            config = configuration;
            theme = new ControlsTheme(config,this);
            _dataTicket = control;
        }

       

        private void Ticket_Load(object sender, EventArgs e)
        {
            if (!IsLight)
            {
                theme.ChangeToDarkTheme(ref IsLight);
            }
            DataTicketBinder.BindTicketData(this,_dataTicket);
        }

      

       

        private void Ticket_MouseClick(object sender, MouseEventArgs e)
        {
            DataTicketControl dataTicket = DataTicketBinder.GetDataTicket(this);   
            _binder.Invoke(dataTicket);
        }
    }
}
