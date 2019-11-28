namespace TestApp.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class AddProductQuantityTable : DbMigration
    {
        public override void Up()
        {
            CreateTable(
                "dbo.ProductQuantities",
                c => new
                    {
                        Id = c.Int(nullable: false),
                        Quantity = c.Int(nullable: false),
                    })
                .PrimaryKey(t => t.Id)
                .ForeignKey("dbo.Products", t => t.Id)
                .Index(t => t.Id);
            
            DropColumn("dbo.Products", "Quantity");
        }
        
        public override void Down()
        {
            AddColumn("dbo.Products", "Quantity", c => c.Int(nullable: false));
            DropForeignKey("dbo.ProductQuantities", "Id", "dbo.Products");
            DropIndex("dbo.ProductQuantities", new[] { "Id" });
            DropTable("dbo.ProductQuantities");
        }
    }
}
