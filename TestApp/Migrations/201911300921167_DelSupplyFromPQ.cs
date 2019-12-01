namespace TestApp.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class DelSupplyFromPQ : DbMigration
    {
        public override void Up()
        {
            DropForeignKey("dbo.ProductQuantities", "Supply_Id", "dbo.Supplies");
            DropIndex("dbo.ProductQuantities", new[] { "Supply_Id" });
            DropColumn("dbo.ProductQuantities", "Supply_Id");
        }
        
        public override void Down()
        {
            AddColumn("dbo.ProductQuantities", "Supply_Id", c => c.Int());
            CreateIndex("dbo.ProductQuantities", "Supply_Id");
            AddForeignKey("dbo.ProductQuantities", "Supply_Id", "dbo.Supplies", "Id");
        }
    }
}
