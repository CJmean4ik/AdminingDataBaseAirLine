 
namespace AdminingDataBaseAirLine
{
    public partial class MainForm : Form
    {      
        public MainForm()
        {
            InitializeComponent();
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

        private void LogInBtn_Click(object sender, EventArgs e)
        {
          
        }
    }
}