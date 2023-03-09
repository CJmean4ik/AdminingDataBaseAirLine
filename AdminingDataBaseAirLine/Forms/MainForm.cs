
using AdminingDataBaseAirLine.Authentication;

namespace AdminingDataBaseAirLine
{
    public partial class MainForm : Form
    {      
        private Loginer _loginer;
        private string _connectString;
        private readonly string path = @"C:\Users\Стас\source\repos\AdminingDataBaseAirLine\AdminingDataBaseAirLine\Configurations.json";
        public MainForm()
        {
            InitializeComponent();
        }

        private void panel1_Paint(object sender, PaintEventArgs e)
        {

        }

        private async void Form1_Load(object sender, EventArgs e)
        {
            _connectString = await JsonConfiguration.GetConnectionString(path);
            _loginer = new Loginer(new AirlineContext(_connectString));
        }

        private void linkLabel1_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            WarningMessageForm warningMessage = new WarningMessageForm(this);
            warningMessage.Show();
            this.Enabled = false;    
        }

        private async void LogInBtn_Click(object sender, EventArgs e)
        {
            string name = UserNameBox.Text;
            string password = PasswordBox.Text;

            LogInBtn.Text = "Обробка...";
            LogInBtn.ForeColor = Color.Orange;
            var resultChecked = await Task.Run(() => _loginer.CheckingAccount(name, password));
            if (!resultChecked.complete)
            {
                LogInBtn.Text = "Помилка!";
                LogInBtn.ForeColor = Color.Red;
            }
            else
            {
                LogInBtn.Text = "Успішно!";
                LogInBtn.ForeColor = Color.White;
            }
        }
    }
}