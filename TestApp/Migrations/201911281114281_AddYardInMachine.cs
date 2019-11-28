namespace TestApp.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class AddYardInMachine : DbMigration
    {
        public override void Up()
        {
            RenameTable(name: "dbo.YardProducts", newName: "ProductYards");
            DropPrimaryKey("dbo.ProductYards");
            AddColumn("dbo.Machines", "Yard_Id", c => c.Int());
            AddPrimaryKey("dbo.ProductYards", new[] { "Product_Id", "Yard_Id" });
            CreateIndex("dbo.Machines", "Yard_Id");
            AddForeignKey("dbo.Machines", "Yard_Id", "dbo.Yards", "Id");
        }
        
        public override void Down()
        {
            DropForeignKey("dbo.Machines", "Yard_Id", "dbo.Yards");
            DropIndex("dbo.Machines", new[] { "Yard_Id" });
            DropPrimaryKey("dbo.ProductYards");
            DropColumn("dbo.Machines", "Yard_Id");
            AddPrimaryKey("dbo.ProductYards", new[] { "Yard_Id", "Product_Id" });
            RenameTable(name: "dbo.ProductYards", newName: "YardProducts");
        }
    }
}
