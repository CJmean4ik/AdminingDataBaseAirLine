using AdminingDataBaseAirLine.Themes;

namespace AdminingDataBaseAirLine.UserControls
{
    public partial class Ticket : UserControl
    {

        private bool IsLight = true;
        private readonly ControlConfiguration config;
        private ControlsTheme theme;
        private Action<DataTicketControl> _binder;
        private DataTicketControl _dataTicket;
        internal ControlsTheme Theme { get => theme; set => theme = value; }
        public Action<DataTicketControl> Binder { get => _binder; set => _binder += value; }

        public Ticket(bool isLight, ControlConfiguration configuration, DataTicketControl control)
        {
            InitializeComponent();
            IsLight = isLight;
            config = configuration;
            theme = new ControlsTheme(config,this);
            _dataTicket = control;
        }

        private void label4_Click(object sender, EventArgs e)
        {

        }

        private void Ticket_Load(object sender, EventArgs e)
        {
            if (!IsLight)
            {
                theme.ChangeToDarkTheme(ref IsLight);
            }
            DataTicketBinder.BindTicketData(this,_dataTicket);
        }

        private void panel1_Paint(object sender, PaintEventArgs e)
        {

        }

       

        private void Ticket_MouseClick(object sender, MouseEventArgs e)
        {

            DataTicketControl dataTicket = new DataTicketControl();
            dataTicket.NumberTicket = int.Parse(flightField.Text);
            dataTicket.PriceTicket = decimal.Parse(priceField.Text);         
            dataTicket.FromWhereTicket = fromWField.Text;
            dataTicket.WhereTicket = whereField.Text;
            dataTicket.DepartmentTicket = Convert.ToDateTime(deparField.Text);
            dataTicket.ArrivalTicket = Convert.ToDateTime(arrivalField.Text);
            dataTicket.ModelAirplane = modelAirPlaneField.Text;
            dataTicket.SenderTicket = senderField.Text;          
            _binder.Invoke(dataTicket);
        }
    }
}
