using AdminingDataBaseAirLine.UserControls.Config;
using AdminingDataBaseAirLine.UserControls.TicketPanel.Data;

namespace AdminingDataBaseAirLine.UserControls
{
    public partial class TicketControl : UserControl
    {

        private bool IsLight = true;
        private readonly ControlConfiguration config;
        private Action<DataTicketControl> _binder;
        private DataTicketControl _dataTicket;
        public Action<DataTicketControl> Binder { get => _binder; set => _binder += value; }

        public TicketControl(bool isLight, ControlConfiguration configuration, DataTicketControl control)
        {
            InitializeComponent();
            IsLight = isLight;
            config = configuration;

            _dataTicket = control;
        }
        private void Ticket_Load(object sender, EventArgs e)
        {
            flightField.Text = _dataTicket.NumberTicket;
            priceField.Text = _dataTicket.PriceTicket.ToString();
            fromWField.Text = _dataTicket.FromWhereTicket;
            whereField.Text = _dataTicket.WhereTicket;
            deparField.Text = string.Format($"{_dataTicket.DepartmentTicket.Hour}:{_dataTicket.DepartmentTicket.Minute}");
            arrivalField.Text = string.Format($"{_dataTicket.ArrivalTicket.Hour}:{_dataTicket.ArrivalTicket.Minute}");
            modelAirPlaneField.Text = _dataTicket.ModelAirplane;
            senderField.Text = _dataTicket.SenderTicket;
        }
        private void Ticket_MouseClick(object sender, MouseEventArgs e)
        {
            DataTicketControl dataTicket = DataTicketBinder.GetDataTicket(this);
            _binder.Invoke(dataTicket);
        }
    }
}
