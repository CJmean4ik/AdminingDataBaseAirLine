using DataBaseModel.Entities.Accounts;
using DataBaseModel.Entities.AirlinePlanes;
using DataBaseModel.Entities.RouteAndFlight;
using DataBaseModel.Entities.TicketAndOrders;
using System.ComponentModel.DataAnnotations.Schema;
using System.Data.Entity;


namespace DataBaseModel
{
    public static class ModelBuilderExtensions
    {      
        public static void ConfigureAirlinePlanes(this DbModelBuilder mb)
        {
            mb.Entity<Airline>()
                .ToTable("Airline")
                .HasKey(k => k.ID)
                .Property(p => p.ID)
                .HasDatabaseGeneratedOption(DatabaseGeneratedOption.Identity);

            mb.Entity<Airplane>()
                .ToTable("Airplane")
                .HasKey(k => k.ID)
                .Property(p => p.ID)
                .HasDatabaseGeneratedOption(DatabaseGeneratedOption.Identity);

            mb.Entity<AirlinePlane>()
                  .ToTable("AirlinePlane")
                  .HasKey(k => k.ID)
                  .Property(p => p.ID)
                  .HasDatabaseGeneratedOption(DatabaseGeneratedOption.Identity);

        }
        public static void ConfigureRouteAndFlight(this DbModelBuilder mb)
        {
            mb.Entity<Flight>()
                .HasKey(k => k.NumberFlight)
                .Property(p => p.NumberFlight)
                .HasDatabaseGeneratedOption(DatabaseGeneratedOption.Identity);

            mb.Entity<Route>()
              .HasKey(k => k.ID)
              .Property(p => p.ID)
              .HasDatabaseGeneratedOption(DatabaseGeneratedOption.Identity);
        }
        public static void ConfigureAccounts(this DbModelBuilder mb)
        {
            mb.Entity<Cashier>()
               .ToTable("Cahier")
               .HasKey(k => k.ID)
               .Property(p => p.ID)
               .HasDatabaseGeneratedOption(DatabaseGeneratedOption.Identity);

            mb.Entity<Account>()
               .HasKey(k => k.ID)
               .Property(p => p.ID)
               .HasDatabaseGeneratedOption(DatabaseGeneratedOption.Identity);

            mb.Entity<Account>()
            .Property(k => k.Email)
            .IsOptional();

            mb.Entity<Passenger>()
             .HasKey(k => k.ID)
             .Property(p => p.ID)
             .HasDatabaseGeneratedOption(DatabaseGeneratedOption.Identity);
        }
        public static void ConfigureTicketAndOrders(this DbModelBuilder mb)
        {
            mb.Entity<Orders>()
               .HasKey(k => k.ID)
               .Property(p => p.ID)
               .HasDatabaseGeneratedOption(DatabaseGeneratedOption.Identity);

            mb.Entity<Ticket>()
               .HasKey(k => k.NumberTicket)
               .Property(p => p.NumberTicket)
               .HasDatabaseGeneratedOption(DatabaseGeneratedOption.Identity);
        }

        public static void ConfigureRelatedAirlinePlane(this DbModelBuilder mb)
        {
            mb.Entity<AirlinePlane>()
                .HasRequired(p => p.Airplane)
                .WithMany(w => w.AirlinePlane)
                .HasForeignKey(fk => fk.AirplaneId);

            mb.Entity<AirlinePlane>()
                .HasRequired(m => m.AirLine)
                .WithMany(w => w.AirlinePlanes)
                .HasForeignKey(fk => fk.AirLineId);

        }
        public static void ConfigureRelatedRouteFlight(this DbModelBuilder mb)
        {
            mb.Entity<Flight>()
                .HasRequired(h => h.Route)
                .WithMany(w => w.Flights)
                .HasForeignKey(fk => fk.RouteId);

            mb.Entity<Flight>()
                .HasRequired(h => h.AirlinePlane)
                .WithMany(w => w.Flights)
                .HasForeignKey(fk => fk.AirlinePlaneId);

        }
        public static void ConfigureRelatedAccounts(this DbModelBuilder mb)
        {
            mb.Entity<Account>()
                .HasOptional(h => h.Cashier)
                .WithOptionalDependent()
                .Map(m => m.MapKey("CashierId"));
        }
        public static void ConfigureRelatedOrdersTicket(this DbModelBuilder mb)
        {
            mb.Entity<Orders>()
                .HasRequired(h => h.Cashier)
                .WithMany(w => w.Orders)
                .HasForeignKey(fk => fk.CashierId);

            mb.Entity<Orders>()
              .HasRequired(h => h.Ticket)
              .WithMany(w => w.Orders)
              .HasForeignKey(fk => fk.TicketId);

            mb.Entity<Orders>()
              .HasRequired(h => h.Passenger)
              .WithMany(w => w.Orders)
              .HasForeignKey(fk => fk.PassengerId);

            mb.Entity<Ticket>()
               .HasRequired(h => h.Flight)
               .WithMany(w => w.Tickets)
               .HasForeignKey(fk => fk.FlightId);
        }

    }
}
