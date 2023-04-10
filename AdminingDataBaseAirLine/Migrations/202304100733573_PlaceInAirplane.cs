namespace AdminingDataBaseAirLine.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class PlaceInAirplane : DbMigration
    {
        public override void Up()
        {
            CreateTable(
                "dbo.Accounts",
                c => new
                    {
                        ID = c.Guid(nullable: false, identity: true),
                        Name = c.String(),
                        Email = c.String(),
                        Password = c.String(),
                        IsAdmin = c.Boolean(nullable: false),
                        CashierId = c.Int(),
                    })
                .PrimaryKey(t => t.ID)
                .ForeignKey("dbo.Cahier", t => t.CashierId)
                .Index(t => t.CashierId);
            
            CreateTable(
                "dbo.Cahier",
                c => new
                    {
                        ID = c.Int(nullable: false, identity: true),
                        Name = c.String(),
                        Surname = c.String(),
                        Patronymic = c.String(),
                    })
                .PrimaryKey(t => t.ID);
            
            CreateTable(
                "dbo.Orders",
                c => new
                    {
                        ID = c.Guid(nullable: false, identity: true),
                        PassengerId = c.Int(nullable: false),
                        TicketId = c.Int(nullable: false),
                        CashierId = c.Int(nullable: false),
                    })
                .PrimaryKey(t => t.ID)
                .ForeignKey("dbo.Cahier", t => t.CashierId, cascadeDelete: true)
                .ForeignKey("dbo.Passengers", t => t.PassengerId, cascadeDelete: true)
                .ForeignKey("dbo.Tickets", t => t.TicketId, cascadeDelete: true)
                .Index(t => t.PassengerId)
                .Index(t => t.TicketId)
                .Index(t => t.CashierId);
            
            CreateTable(
                "dbo.Passengers",
                c => new
                    {
                        ID = c.Int(nullable: false, identity: true),
                        Name = c.String(),
                        Surname = c.String(),
                        Patronymic = c.String(),
                        Age = c.Int(nullable: false),
                        Gender = c.Int(nullable: false),
                        PhoneNumber = c.String(),
                        Email = c.String(),
                    })
                .PrimaryKey(t => t.ID);
            
            CreateTable(
                "dbo.Tickets",
                c => new
                    {
                        NumberTicket = c.Int(nullable: false, identity: true),
                        Price = c.Decimal(nullable: false, precision: 18, scale: 2),
                        DataSales = c.DateTime(nullable: false),
                        FlightId = c.Int(nullable: false),
                    })
                .PrimaryKey(t => t.NumberTicket)
                .ForeignKey("dbo.Flights", t => t.FlightId, cascadeDelete: true)
                .Index(t => t.FlightId);
            
            CreateTable(
                "dbo.Flights",
                c => new
                    {
                        NumberFlight = c.Int(nullable: false, identity: true),
                        RouteId = c.Int(nullable: false),
                        AirlinePlaneId = c.Int(nullable: false),
                    })
                .PrimaryKey(t => t.NumberFlight)
                .ForeignKey("dbo.AirlinePlane", t => t.AirlinePlaneId, cascadeDelete: true)
                .ForeignKey("dbo.Routes", t => t.RouteId, cascadeDelete: true)
                .Index(t => t.RouteId)
                .Index(t => t.AirlinePlaneId);
            
            CreateTable(
                "dbo.AirlinePlane",
                c => new
                    {
                        ID = c.Int(nullable: false, identity: true),
                        SendingAirline = c.String(),
                        AirLineId = c.Int(nullable: false),
                        AirplaneId = c.Int(nullable: false),
                        InRaise = c.Boolean(nullable: false),
                    })
                .PrimaryKey(t => t.ID)
                .ForeignKey("dbo.Airline", t => t.AirLineId, cascadeDelete: true)
                .ForeignKey("dbo.Airplane", t => t.AirplaneId, cascadeDelete: true)
                .Index(t => t.AirLineId)
                .Index(t => t.AirplaneId);
            
            CreateTable(
                "dbo.Airline",
                c => new
                    {
                        ID = c.Int(nullable: false, identity: true),
                        Name = c.String(),
                        Owner = c.String(),
                    })
                .PrimaryKey(t => t.ID);
            
            CreateTable(
                "dbo.Airplane",
                c => new
                    {
                        ID = c.Int(nullable: false, identity: true),
                        TypeAirplane = c.String(),
                        Model = c.String(),
                        Capacity = c.Int(nullable: false),
                    })
                .PrimaryKey(t => t.ID);
            
            CreateTable(
                "dbo.Routes",
                c => new
                    {
                        ID = c.Int(nullable: false, identity: true),
                        FromWhere = c.String(),
                        Where = c.String(),
                        Departure = c.DateTime(nullable: false),
                        Incoming = c.DateTime(nullable: false),
                    })
                .PrimaryKey(t => t.ID);
            
        }
        
        public override void Down()
        {
            DropForeignKey("dbo.Accounts", "CashierId", "dbo.Cahier");
            DropForeignKey("dbo.Orders", "TicketId", "dbo.Tickets");
            DropForeignKey("dbo.Tickets", "FlightId", "dbo.Flights");
            DropForeignKey("dbo.Flights", "RouteId", "dbo.Routes");
            DropForeignKey("dbo.Flights", "AirlinePlaneId", "dbo.AirlinePlane");
            DropForeignKey("dbo.AirlinePlane", "AirplaneId", "dbo.Airplane");
            DropForeignKey("dbo.AirlinePlane", "AirLineId", "dbo.Airline");
            DropForeignKey("dbo.Orders", "PassengerId", "dbo.Passengers");
            DropForeignKey("dbo.Orders", "CashierId", "dbo.Cahier");
            DropIndex("dbo.AirlinePlane", new[] { "AirplaneId" });
            DropIndex("dbo.AirlinePlane", new[] { "AirLineId" });
            DropIndex("dbo.Flights", new[] { "AirlinePlaneId" });
            DropIndex("dbo.Flights", new[] { "RouteId" });
            DropIndex("dbo.Tickets", new[] { "FlightId" });
            DropIndex("dbo.Orders", new[] { "CashierId" });
            DropIndex("dbo.Orders", new[] { "TicketId" });
            DropIndex("dbo.Orders", new[] { "PassengerId" });
            DropIndex("dbo.Accounts", new[] { "CashierId" });
            DropTable("dbo.Routes");
            DropTable("dbo.Airplane");
            DropTable("dbo.Airline");
            DropTable("dbo.AirlinePlane");
            DropTable("dbo.Flights");
            DropTable("dbo.Tickets");
            DropTable("dbo.Passengers");
            DropTable("dbo.Orders");
            DropTable("dbo.Cahier");
            DropTable("dbo.Accounts");
        }
    }
}
