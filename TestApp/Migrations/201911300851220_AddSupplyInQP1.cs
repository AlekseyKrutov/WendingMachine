namespace TestApp.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class AddSupplyInQP1 : DbMigration
    {
        public override void Up()
        {
            AddColumn("dbo.ProductQuantities", "Cost", c => c.Decimal(nullable: false, precision: 18, scale: 2));
        }
        
        public override void Down()
        {
            DropColumn("dbo.ProductQuantities", "Cost");
        }
    }
}
