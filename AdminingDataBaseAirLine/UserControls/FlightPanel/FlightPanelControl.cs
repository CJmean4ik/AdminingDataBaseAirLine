using AdminingDataBaseAirLine.Authentication;
using AirlineDataBase.DataBaseContext;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.Entity;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace AdminingDataBaseAirLine.UserControls.FlightPanel
{
    public partial class FlightPanelControl : UserControl
    {
        private AirCompanyContext _context;

        public FlightPanelControl()
        {
            InitializeComponent();
          
            
        }
        public FlightPanelControl(AirCompanyContext airlineContext) : this()
        {
            _context = airlineContext;


        }
        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void FlightPanelControl_Load(object sender, EventArgs e)
        {
           

        }

        public void InsertDataToDataGrigview()
        {
            var Flights = _context.Flights.Select(s => new
            {
               
                s.NumberFlight,
                s.Route.FromWhere,
                s.Route.Where,
                s.Route.Incoming,
                s.Route.Departure,
                s.AirlinePlane.SendingAirline,
                s.AirlinePlane.Airplane.Model,
                s.NameRoute
            }).ToList();

            int count = Flights.Count();
            dataGridView1.Rows.Add(count);

            for (int i = 0; i < count; i++)
            {
                dataGridView1.Rows[i].Cells[0].Value = Flights[i].NumberFlight;
                dataGridView1.Rows[i].Cells[1].Value = Flights[i].SendingAirline;
                dataGridView1.Rows[i].Cells[2].Value = Flights[i].FromWhere;
                dataGridView1.Rows[i].Cells[3].Value = Flights[i].Where;
                dataGridView1.Rows[i].Cells[4].Value = Flights[i].Departure;
                dataGridView1.Rows[i].Cells[5].Value = Flights[i].Incoming;
                dataGridView1.Rows[i].Cells[6].Value = Flights[i].Model;
                dataGridView1.Rows[i].Cells[7].Value = Flights[i].NameRoute;
            }
        }
    }
}
