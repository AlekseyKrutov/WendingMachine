namespace TestApp.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class DrlrtrmanymanyYardProd : DbMigration
    {
        public override void Up()
        {
            DropForeignKey("dbo.ProductYards", "Product_Id", "dbo.Products");
            DropForeignKey("dbo.ProductYards", "Yard_Id", "dbo.Yards");
            DropIndex("dbo.ProductYards", new[] { "Product_Id" });
            DropIndex("dbo.ProductYards", new[] { "Yard_Id" });
            DropTable("dbo.ProductYards");
        }
        
        public override void Down()
        {
            CreateTable(
                "dbo.ProductYards",
                c => new
                    {
                        Product_Id = c.Int(nullable: false),
                        Yard_Id = c.Int(nullable: false),
                    })
                .PrimaryKey(t => new { t.Product_Id, t.Yard_Id });
            
            CreateIndex("dbo.ProductYards", "Yard_Id");
            CreateIndex("dbo.ProductYards", "Product_Id");
            AddForeignKey("dbo.ProductYards", "Yard_Id", "dbo.Yards", "Id", cascadeDelete: true);
            AddForeignKey("dbo.ProductYards", "Product_Id", "dbo.Products", "Id", cascadeDelete: true);
        }
    }
}
