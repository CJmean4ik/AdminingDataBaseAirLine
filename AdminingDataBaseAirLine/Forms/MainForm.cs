
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
        private bool _haveEror;
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

            string name = string.Empty;
            string password = string.Empty;
            string nameMistake = string.Empty;


            if (!ValidationUserAccount.IsNotEmptyBoxField(UserNameBox, ref name))            
                ValidationUserAccount.EmptyFieldErorHandling(this.nameMistake);
            

            if (!ValidationUserAccount.IsNotEmptyBoxField(PasswordBox, ref password))
                ValidationUserAccount.EmptyFieldErorHandling(this.passwordMistake);

            _haveEror = name == "" || password == "" ? true : false;
            if (_haveEror) return;          

                      
            LogInBtn.Enabled = false;

            var resultChecked = await Task.Run(() => _loginer.CheckingAccount(name, password,ref nameMistake));

            if (resultChecked.complete)
            {                                           
                if (!resultChecked.isAdmin)
                {
                    this.Hide();
                    CashierForm cashierForm = new CashierForm(_airlineContext);
                    cashierForm.ClosingFrom = CloseForm;
                    cashierForm.Show();
                    return;
                }
                //Инициализация формы AdminForm..
            }
            else
            {
                ValidationUserAccount.ErrorHandling(nameMistake,this);
                _haveEror = true;
            }

        }
        private void PasswordBox_TextChanged(object sender, EventArgs e)
        {
            if (!_haveEror) return;

            panelPass.BackColor = Color.FromArgb(10, 126, 245);
            panelPass2.BackColor = Color.FromArgb(10, 126, 245);
            PasswordBox.ForeColor = Color.FromArgb(10, 126, 245);
            this.passwordMistake.Visible = false;
        }

        private void UserNameBox_TextChanged(object sender, EventArgs e)
        {

            if (!_haveEror) return;
            
                panelName.BackColor = Color.FromArgb(10, 126, 245);
                panelName2.BackColor = Color.FromArgb(10, 126, 245);
                UserNameBox.ForeColor = Color.FromArgb(10, 126, 245);
                this.nameMistake.Visible = false;
            

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
        private void closeButton_Click(object sender, EventArgs e)
        {
            CloseForm();
        }


        public void CloseForm()
        {
            this.Close();
            this.Dispose();
        }

    }
}