namespace TestApp.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class AddSupplyFromPQ : DbMigration
    {
        public override void Up()
        {
            AddColumn("dbo.ProductQuantities", "Supply_Id", c => c.Int());
            CreateIndex("dbo.ProductQuantities", "Supply_Id");
            AddForeignKey("dbo.ProductQuantities", "Supply_Id", "dbo.Supplies", "Id");
        }
        
        public override void Down()
        {
            DropForeignKey("dbo.ProductQuantities", "Supply_Id", "dbo.Supplies");
            DropIndex("dbo.ProductQuantities", new[] { "Supply_Id" });
            DropColumn("dbo.ProductQuantities", "Supply_Id");
        }
    }
}
