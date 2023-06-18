
using AdminingDataBaseAirLine.Authentication;
using AdminingDataBaseAirLine.Configs;
using AdminingDataBaseAirLine.Forms.AdminfFormSetting;
using AdminingDataBaseAirLine.Forms.CashierFormSetting;
using AdminingDataBaseAirLine.Properties;
using AirlineDataBase;

namespace AdminingDataBaseAirLine
{
    public partial class MainForm : Form
    {
        private Loginer _loginer;
        private string _connectString;
        private AirCompanyContext _airlineContext;
        private readonly string path = @"C:\Users\Стас\source\repos\AdminingDataBaseAirLine\AdminingDataBaseAirLine\Configs\Configurations.json";
        private bool _haveEror;
        private bool isMousePress;
        private Point _clickPoint;
        private Point _formStartPoint;

        public MainForm()
        {
            InitializeComponent();         
           

            _connectString = JsonConfiguration.GetConnectionString(path);
            string Path = JsonConfiguration.GetPathToJsonAccount(path);
            _airlineContext = new AirCompanyContext(_connectString);
            _loginer = new Loginer(_airlineContext, this);
            _loginer.Path = Path;

        }

        private void panel1_Paint(object sender, PaintEventArgs e)
        {

        }

        private void Form1_Load(object sender, EventArgs e)
        {
                    
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

            _loginer.Path = JsonConfiguration.GetPathToJsonAccount(path);
            var resultChecked = await Task.Run(() => _loginer.CheckingAccount(name, password,ref nameMistake));


            if (resultChecked.complete)
            {                                           
                if (!resultChecked.isAdmin)
                {
                    this.Hide();
                    CashierForm cashierForm = new CashierForm(_airlineContext, resultChecked.cashierId,resultChecked.isAdmin);
                    cashierForm.ClosingFrom = CloseForm;
                    cashierForm.Show();
                    return;
                }
                this.Hide();
                AdminForm adminForm = new AdminForm(_airlineContext, resultChecked.isAdmin);
                adminForm.ClosingFrom = CloseForm;
                adminForm.Show();
                return;
            }
                 ValidationUserAccount.ErrorHandling(nameMistake,this);
                _haveEror = true;
           
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
        private void panel1_Paint_1(object sender, PaintEventArgs e)
        {

        }

        private void MainForm_MouseDown(object sender, MouseEventArgs e)
        {
            isMousePress = true;
            _clickPoint = Cursor.Position;
            _formStartPoint = Location;
        }

        private void MainForm_MouseMove(object sender, MouseEventArgs e)
        {
            if (isMousePress)
            {
                var cursorOffsetPoint = new Point(
                    Cursor.Position.X - _clickPoint.X,
                    Cursor.Position.Y - _clickPoint.Y);

                Location = new Point(
                    _formStartPoint.X + cursorOffsetPoint.X,
                    _formStartPoint.Y + cursorOffsetPoint.Y);
            }
        }

        private void MainForm_MouseUp(object sender, MouseEventArgs e)
        {
            isMousePress = false;
            _clickPoint = Point.Empty;
        }
    }
}