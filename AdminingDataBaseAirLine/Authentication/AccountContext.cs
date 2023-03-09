using DataBaseModel.Entities.Accounts;
using System.Data.Entity;
using DataBaseModel;
using DataBaseModel.Entities.AirlinePlanes;
using DataBaseModel.Entities.RouteAndFlight;
using DataBaseModel.Entities.TicketAndOrders;

namespace AdminingDataBaseAirLine.Authentication
{
    public class AirlineContext : DbContext
    {
        public DbSet<Cashier> Cashiers { get; set; }
        public DbSet<Account> Accounts { get; set; }
        public DbSet<Passenger> Passengers { get; set; }

        public DbSet<Airline> Airlines { get; set; }
        public DbSet<AirlinePlane> AirlinePlanes { get; set; }
        public DbSet<Airplane> Airplanes { get; set; }

        public DbSet<Flight> Flights { get; set; }
        public DbSet<Route> Routes { get; set; }

        public DbSet<Orders> Orders { get; set; }
        public DbSet<Ticket> Tickets { get; set; }

        public AirlineContext(string connectionString) : base(connectionString)
        {

        }
        protected override void OnModelCreating(DbModelBuilder modelBuilder)
        {
            modelBuilder.ConfigureAirlinePlanes();
            modelBuilder.ConfigureRouteAndFlight();
            modelBuilder.ConfigureAccounts();
            modelBuilder.ConfigureTicketAndOrders();

            modelBuilder.ConfigureRelatedAirlinePlane();
            modelBuilder.ConfigureRelatedRouteFlight();
            modelBuilder.ConfigureRelatedAccounts();
            modelBuilder.ConfigureRelatedOrdersTicket();
        }

    }
}
