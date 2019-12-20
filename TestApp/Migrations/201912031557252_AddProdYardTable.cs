namespace TestApp.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class AddProdYardTable : DbMigration
    {
        public override void Up()
        {
            CreateTable(
                "dbo.ProductYards",
                c => new
                    {
                        Id = c.Int(nullable: false, identity: true),
                        Quantity = c.Int(nullable: false),
                        Supply_Id = c.Int(),
                        Product_Id = c.Int(nullable: false),
                        Yard_Id = c.Int(nullable: false),
                    })
                .PrimaryKey(t => new { t.Product_Id, t.Yard_Id })
                .ForeignKey("dbo.Supplies", t => t.Supply_Id)
                .ForeignKey("dbo.Products", t => t.Product_Id)
                .ForeignKey("dbo.Yards", t => t.Yard_Id)
                .Index(t => t.Supply_Id)
                .Index(t => t.Product_Id)
                .Index(t => t.Yard_Id);
            
        }
        
        public override void Down()
        {
            DropForeignKey("dbo.ProductYards", "Yard_Id", "dbo.Yards");
            DropForeignKey("dbo.ProductYards", "Product_Id", "dbo.Products");
            DropForeignKey("dbo.ProductYards", "Supply_Id", "dbo.Supplies");
            DropIndex("dbo.ProductYards", new[] { "Yard_Id" });
            DropIndex("dbo.ProductYards", new[] { "Product_Id" });
            DropIndex("dbo.ProductYards", new[] { "Supply_Id" });
            DropTable("dbo.ProductYards");
        }
    }
}
