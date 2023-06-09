using AirlineDataBase.DataBaseContext;
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
    public partial class ReservedSeatsTableControl : UserControl
    {
        private AirCompanyContext context;

        public ReservedSeatsTableControl()
        {
            InitializeComponent();
        }

        public void BindCellContentClick(Action<object?, DataGridViewCellEventArgs?> viewCellEventArgs)
        {
            dataGridView1.CellContentClick += new DataGridViewCellEventHandler(viewCellEventArgs);
        }

        public ReservedSeatsTableControl(AirCompanyContext context) : this()
        {
            this.context = context;
        }

        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void ReservedSeatsTableControl_Load(object sender, EventArgs e)
        {

        }
        public void LoadDataToDataGrigView()
        {
            var bookSeats = context.ReservedSeats.
                Select(s => new 
                {
                    s.Id,
                    s.Order.Ticket.Flight.Route.FromWhere,
                    s.Order.Ticket.Flight.Route.Where,
                    s.Order.Passenger.Name,
                    s.Order.Passenger.Surname,
                    s.Order.Ticket.Flight.AirlinePlane.Airplane.Model,
                    s.Order.Ticket.Flight.NameRoute,
                   s.BookSeats
                })
                .ToList();

            if (bookSeats.Count == 0 || bookSeats == null) return;
            

            

            dataGridView1.Rows.Add(bookSeats.Count);

            for (int i = 0; i < bookSeats.Count; i++)
            {
                dataGridView1.Rows[i].Cells[0].Value = bookSeats[i].Id;
                dataGridView1.Rows[i].Cells[1].Value = bookSeats[i].FromWhere;
                dataGridView1.Rows[i].Cells[2].Value = bookSeats[i].Where;
                dataGridView1.Rows[i].Cells[3].Value = bookSeats[i].Name;
                dataGridView1.Rows[i].Cells[4].Value = bookSeats[i].Surname;
                dataGridView1.Rows[i].Cells[5].Value = bookSeats[i].Model;
                dataGridView1.Rows[i].Cells[6].Value = bookSeats[i].NameRoute;
                dataGridView1.Rows[i].Cells[7].Value = bookSeats[i].BookSeats;
            }

        }

        
    }
}
