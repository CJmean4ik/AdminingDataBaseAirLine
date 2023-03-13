using AdminingDataBaseAirLine.Authentication;
using AdminingDataBaseAirLine.Configs;
using AdminingDataBaseAirLine.Forms.CashierFormSetting;
using AdminingDataBaseAirLine.Properties;

namespace AdminingDataBaseAirLine
{
    public partial class MainForm : Form
    {
        private Loginer _loginer;
        private string _connectString;
        private AirlineContext _airlineContext;
        private readonly string path = @"C:\Users\Стас\source\repos\AdminingDataBaseAirLine\AdminingDataBaseAirLine\Configs\Configurations.json";
       
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
            string Path = await JsonConfiguration.GetPathToJsonAccount(path);
            _airlineContext = new AirlineContext(_connectString);
            _loginer = new Loginer(_airlineContext, Path);
            
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
                if (!resultChecked.isAdmin)
                {
                    this.Hide();
                    CashierForm cashierForm = new CashierForm(_airlineContext);
                    cashierForm.ClosingFrom = CloseForm;
                    cashierForm.Show();
                }
                //Инициализация формы AdminForm..
            }
        }
        private void UserNameBox_TextChanged(object sender, EventArgs e)
        {

        }

        private void closeButton_Click(object sender, EventArgs e)
        {
            CloseForm();
        }
        public void CloseForm()
        {
            this.Close();
            this.Dispose();
        }

        private void ShowPasswordBtn_Click(object sender, EventArgs e)
        {
            if (PasswordBox.UseSystemPasswordChar)
            {               
                PasswordBox.UseSystemPasswordChar = false;           
                ShowPasswordBtn.Image = Resources.eye_show;
                return;
            }
            PasswordBox.UseSystemPasswordChar = true;
            ShowPasswordBtn.Image = Resources.eye_crossed;

        }
    }
}