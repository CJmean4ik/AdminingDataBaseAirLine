using AirlineDataBase.Entityes.AirlinePlanes;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace AdminingDataBaseAirLine.UserControls.ReservedSeatsPanel
{
    public partial class ReservedSeatsControl : UserControl
    {
        public string AirplaneName { get; set; }
        public bool IsShow { get; set; }
        public int Capacity { get; set; }
        public int[] NumbersSeats { get; set; }

        private EventHandler _event;
        public EventHandler Event { get => _event; set => _event = value; }


        private SeterSizeSeats _seterSizeSeats;

        public ReservedSeatsControl()
        {
            InitializeComponent();
        }

        public ReservedSeatsControl(string airplaneName, int[] numberSeats) : this()
        {
            AirplaneName = airplaneName;
            NumbersSeats = numberSeats;
            _seterSizeSeats = new SeterSizeSeats(this, numberSeats);
        }

        private void ReservedSeatsControl_Load(object sender, EventArgs e)
        {
           
        }
        public void FillInFlowPanel()
        {
            if (Capacity == 0)
            {
                MessageBox.Show("У цього літака немає місць. Перевіте наявність місць у БД");
                return;
            }

            _seterSizeSeats.SetCapasity(Capacity);

            _seterSizeSeats.CalculateSizeFlowPanel();

            _seterSizeSeats.AddingItemToFlowPanel();
        }
       
        private void flowLayoutPanel1_Paint(object sender, PaintEventArgs e)
        {
            
           
        }
        public void ChangeSeats(int numberReservedSeats)
        {
            _seterSizeSeats.MakeSeatReserved(numberReservedSeats);
        }
        public void ChangeToDeffault(int oldNumberSeats)
        {
            _seterSizeSeats.SetDeffaultPropertyButton(oldNumberSeats);
        }
    }
}
