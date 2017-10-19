namespace UdemyASP2.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class DelPhoneNumberToCustomer : DbMigration
    {
        public override void Up()
        {
            DropColumn("dbo.Customers", "PhoneNumber");
        }
        
        public override void Down()
        {
            AddColumn("dbo.Customers", "PhoneNumber", c => c.String(nullable: false, maxLength: 50));
        }
    }
}
