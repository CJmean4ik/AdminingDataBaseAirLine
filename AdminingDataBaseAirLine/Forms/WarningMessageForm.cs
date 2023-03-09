using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace AdminingDataBaseAirLine
{
    public partial class WarningMessageForm : Form
    {
        private MainForm _mainForm;
        public WarningMessageForm(MainForm mainForm)
        {
            InitializeComponent();
            _mainForm = mainForm;
        }

        private void warningMessage1_Load(object sender, EventArgs e)
        {

        }

        private async void button1_Click(object sender, EventArgs e)
        {
            this.Close();
            if (_mainForm != null)
            {
                _mainForm.Enabled = true;
            }
            await Task.Run(() => this.Dispose());
        }
    }
}
