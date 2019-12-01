namespace TestApp.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class DeleteProductPKInQuantity : DbMigration
    {
        public override void Up()
        {
            DropForeignKey("dbo.ProductQuantities", "Id", "dbo.Products");
            DropForeignKey("dbo.ProductQuantityYards", "ProductQuantity_Id", "dbo.ProductQuantities");
            DropIndex("dbo.ProductQuantities", new[] { "Id" });
            DropPrimaryKey("dbo.ProductQuantities");
            AddColumn("dbo.ProductQuantities", "Product_Id", c => c.Int());
            AlterColumn("dbo.ProductQuantities", "Id", c => c.Int(nullable: false, identity: true));
            AddPrimaryKey("dbo.ProductQuantities", "Id");
            CreateIndex("dbo.ProductQuantities", "Product_Id");
            AddForeignKey("dbo.ProductQuantities", "Product_Id", "dbo.Products", "Id");
            AddForeignKey("dbo.ProductQuantityYards", "ProductQuantity_Id", "dbo.ProductQuantities", "Id", cascadeDelete: true);
        }
        
        public override void Down()
        {
            DropForeignKey("dbo.ProductQuantityYards", "ProductQuantity_Id", "dbo.ProductQuantities");
            DropForeignKey("dbo.ProductQuantities", "Product_Id", "dbo.Products");
            DropIndex("dbo.ProductQuantities", new[] { "Product_Id" });
            DropPrimaryKey("dbo.ProductQuantities");
            AlterColumn("dbo.ProductQuantities", "Id", c => c.Int(nullable: false));
            DropColumn("dbo.ProductQuantities", "Product_Id");
            AddPrimaryKey("dbo.ProductQuantities", "Id");
            CreateIndex("dbo.ProductQuantities", "Id");
            AddForeignKey("dbo.ProductQuantityYards", "ProductQuantity_Id", "dbo.ProductQuantities", "Id", cascadeDelete: true);
            AddForeignKey("dbo.ProductQuantities", "Id", "dbo.Products", "Id");
        }
    }
}
