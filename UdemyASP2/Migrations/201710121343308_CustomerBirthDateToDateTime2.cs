namespace UdemyASP2.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class CustomerBirthDateToDateTime2 : DbMigration
    {
        public override void Up()
        {
            AlterColumn("dbo.Customers", "BirthDate", c => c.DateTime(precision: 7, storeType: "datetime2"));
        }
        
        public override void Down()
        {
            AlterColumn("dbo.Customers", "BirthDate", c => c.DateTime());
        }
    }
}
