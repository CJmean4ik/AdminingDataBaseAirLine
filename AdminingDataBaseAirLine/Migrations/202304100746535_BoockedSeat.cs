namespace AdminingDataBaseAirLine.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class BoockedSeat : DbMigration
    {
        public override void Up()
        {
            AddColumn("dbo.Orders", "BoockedSeat", c => c.Int(nullable: false));
        }
        
        public override void Down()
        {
            DropColumn("dbo.Orders", "BoockedSeat");
        }
    }
}
