namespace TestApp.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class DeletePqYardTable : DbMigration
    {
        public override void Up()
        {
            DropForeignKey("dbo.ProductQuantityYards", "Yard_Id", "dbo.Yards");
            DropForeignKey("dbo.ProductQuantityYards", "ProductQuantity_Id", "dbo.ProductQuantities");
            DropIndex("dbo.ProductQuantityYards", new[] { "Yard_Id", "ProductQuantity_Id" });
            DropTable("dbo.ProductQuantityYards");
        }
        
        public override void Down()
        {
        }
    }
}
