
using AdminingDataBaseAirLine.Authentication;
using AdminingDataBaseAirLine.Forms;
using DataBaseModel.Entities.Accounts;
using System.Data.Entity;

namespace AdminingDataBaseAirLine
{
    public partial class MainForm : Form
    {
        private Loginer _loginer;
        private string _connectString;
        private AirlineContext _airlineContext;
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

            _airlineContext = new AirlineContext(_connectString);
            _loginer = new Loginer(_airlineContext);
         
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
            LogInBtn.Enabled = false;
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
                this.Hide();
                CashierForm cashierForm = new CashierForm();
                cashierForm.Show();
            }
        }

        private async Task<List<Account>> LoadDataForLoginerAsync(string connection)
        {
            AirlineContext context = new AirlineContext(connection);
            await context.Accounts
                .AsNoTracking()
                .LoadAsync();

            return context.Accounts.Local.ToList();
        }


        private void UserNameBox_TextChanged(object sender, EventArgs e)
        {

        }
    }
}