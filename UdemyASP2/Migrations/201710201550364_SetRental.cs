namespace UdemyASP2.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class SetRental : DbMigration
    {
        public override void Up()
        {
            AlterColumn("dbo.Rentals", "DateReturned", c => c.DateTime(precision: 7, storeType: "datetime2"));
        }
        
        public override void Down()
        {
            AlterColumn("dbo.Rentals", "DateReturned", c => c.DateTime(nullable: false, precision: 7, storeType: "datetime2"));
        }
    }
}
