namespace TestApp.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class DeleteFieldsFromproduct : DbMigration
    {
        public override void Up()
        {
            DropForeignKey("dbo.Products", "Supplier_Id", "dbo.Companies");
            DropForeignKey("dbo.ProductQuantities", "Supply_Id", "dbo.Supplies");
            DropForeignKey("dbo.Products", "Supply_Id", "dbo.Supplies");
            DropIndex("dbo.ProductQuantities", new[] { "Supply_Id" });
            DropIndex("dbo.Products", new[] { "Supplier_Id" });
            DropIndex("dbo.Products", new[] { "Supply_Id" });
            AddColumn("dbo.Products", "Articul", c => c.String());
            DropColumn("dbo.ProductQuantities", "Supply_Id");
            DropColumn("dbo.Products", "Cost");
            DropColumn("dbo.Products", "Supplier_Id");
            DropColumn("dbo.Products", "Supply_Id");
        }
        
        public override void Down()
        {
            AddColumn("dbo.Products", "Supply_Id", c => c.Int());
            AddColumn("dbo.Products", "Supplier_Id", c => c.Int());
            AddColumn("dbo.Products", "Cost", c => c.Decimal(nullable: false, precision: 18, scale: 2));
            AddColumn("dbo.ProductQuantities", "Supply_Id", c => c.Int());
            DropColumn("dbo.Products", "Articul");
            CreateIndex("dbo.Products", "Supply_Id");
            CreateIndex("dbo.Products", "Supplier_Id");
            CreateIndex("dbo.ProductQuantities", "Supply_Id");
            AddForeignKey("dbo.Products", "Supply_Id", "dbo.Supplies", "Id");
            AddForeignKey("dbo.ProductQuantities", "Supply_Id", "dbo.Supplies", "Id");
            AddForeignKey("dbo.Products", "Supplier_Id", "dbo.Companies", "Id");
        }
    }
}
