namespace TestApp.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class CorrectSupply : DbMigration
    {
        public override void Up()
        {
            AddColumn("dbo.ProductQuantities", "Supply_Id", c => c.Int());
            CreateIndex("dbo.ProductQuantities", "Supply_Id");
        }
        
        public override void Down()
        {
            DropIndex("dbo.ProductQuantities", new[] { "Supply_Id" });
            DropColumn("dbo.ProductQuantities", "Supply_Id");
        }
    }
}
