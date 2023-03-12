using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace AdminingDataBaseAirLine.UserControls
{
    public partial class Ticket : UserControl
    {

        private bool IsLight = true;
        private ControlConfiguration config;
        private ControlsTheme theme;
        internal ControlsTheme Theme { get => theme; set => theme = value; }

        public Ticket(bool isLight, ControlConfiguration configuration)
        {
            InitializeComponent();
            IsLight = isLight;
            config = configuration;
            theme = new ControlsTheme(config);
        }

        private void label4_Click(object sender, EventArgs e)
        {

        }

        private void Ticket_Load(object sender, EventArgs e)
        {
            if (!IsLight)
            {
                theme.ChangeToDarkTheme(ref IsLight, this);
            }
        }

        private void panel1_Paint(object sender, PaintEventArgs e)
        {

        }
    }
}
