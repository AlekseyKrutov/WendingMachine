namespace TestApp.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class DeleteProductQuantityTable : DbMigration
    {
        public override void Up()
        {
            DropForeignKey("dbo.ProductQuantities", "Id", "dbo.Products");
            DropIndex("dbo.ProductQuantities", new[] { "Id" });
            DropTable("dbo.ProductQuantities");
        }
        
        public override void Down()
        {
            CreateTable(
                "dbo.ProductQuantities",
                c => new
                    {
                        Id = c.Int(nullable: false),
                        Quantity = c.Int(nullable: false),
                    })
                .PrimaryKey(t => t.Id);
            
            CreateIndex("dbo.ProductQuantities", "Id");
            AddForeignKey("dbo.ProductQuantities", "Id", "dbo.Products", "Id");
        }
    }
}
