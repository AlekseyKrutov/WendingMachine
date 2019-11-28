namespace TestApp.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class InitialModel : DbMigration
    {
        public override void Up()
        {
            CreateTable(
                "dbo.Accounts",
                c => new
                    {
                        Id = c.Int(nullable: false),
                        Right = c.Int(nullable: false),
                        Password = c.String(),
                        ActiveFlag = c.Boolean(nullable: false),
                    })
                .PrimaryKey(t => t.Id)
                .ForeignKey("dbo.Employees", t => t.Id)
                .Index(t => t.Id);
            
            CreateTable(
                "dbo.Employees",
                c => new
                    {
                        Id = c.Int(nullable: false, identity: true),
                        Name = c.String(),
                        Inn = c.String(),
                        Post = c.Int(nullable: false),
                        ActiveFlag = c.Boolean(nullable: false),
                    })
                .PrimaryKey(t => t.Id);
            
            CreateTable(
                "dbo.Companies",
                c => new
                    {
                        Id = c.Int(nullable: false, identity: true),
                        CompanyName = c.String(),
                        Inn = c.String(),
                        Address = c.String(),
                        Director = c.String(),
                        Director1 = c.String(),
                        Discriminator = c.String(nullable: false, maxLength: 128),
                    })
                .PrimaryKey(t => t.Id);
            
            CreateTable(
                "dbo.Contracts",
                c => new
                    {
                        Id = c.Int(nullable: false, identity: true),
                        ConfirmDate = c.DateTime(nullable: false),
                        FinishDate = c.DateTime(nullable: false),
                        ActiveFlag = c.Boolean(nullable: false),
                        Supplier_Id = c.Int(),
                    })
                .PrimaryKey(t => t.Id)
                .ForeignKey("dbo.Companies", t => t.Supplier_Id)
                .Index(t => t.Supplier_Id);
            
            CreateTable(
                "dbo.Machines",
                c => new
                    {
                        Id = c.Int(nullable: false, identity: true),
                        Location = c.String(),
                        ActiveFlag = c.Boolean(nullable: false),
                        LastRepairDate = c.DateTime(nullable: false),
                        LastActivityDate = c.DateTime(nullable: false),
                        CashSum = c.Single(nullable: false),
                        LastOperator_Id = c.Int(),
                    })
                .PrimaryKey(t => t.Id)
                .ForeignKey("dbo.Employees", t => t.LastOperator_Id)
                .Index(t => t.LastOperator_Id);
            
            CreateTable(
                "dbo.Yards",
                c => new
                    {
                        Id = c.Int(nullable: false, identity: true),
                        Name = c.String(),
                        Address = c.String(),
                        Discriminator = c.String(nullable: false, maxLength: 128),
                        Machine_Id = c.Int(),
                    })
                .PrimaryKey(t => t.Id)
                .ForeignKey("dbo.Machines", t => t.Machine_Id)
                .Index(t => t.Machine_Id);
            
            CreateTable(
                "dbo.Products",
                c => new
                    {
                        Id = c.Int(nullable: false, identity: true),
                        ProductName = c.String(),
                        Cost = c.Decimal(nullable: false, precision: 18, scale: 2),
                        ActiveFlag = c.Boolean(nullable: false),
                        Quantity = c.Int(nullable: false),
                        ProductType_Id = c.Int(),
                        Supplier_Id = c.Int(),
                        Supply_Id = c.Int(),
                    })
                .PrimaryKey(t => t.Id)
                .ForeignKey("dbo.ProductTypes", t => t.ProductType_Id)
                .ForeignKey("dbo.Companies", t => t.Supplier_Id)
                .ForeignKey("dbo.Supplies", t => t.Supply_Id)
                .Index(t => t.ProductType_Id)
                .Index(t => t.Supplier_Id)
                .Index(t => t.Supply_Id);
            
            CreateTable(
                "dbo.ProductTypes",
                c => new
                    {
                        Id = c.Int(nullable: false, identity: true),
                        TypeName = c.Int(nullable: false),
                        ShiftLifeDays = c.Int(nullable: false),
                    })
                .PrimaryKey(t => t.Id);
            
            CreateTable(
                "dbo.Supplies",
                c => new
                    {
                        Id = c.Int(nullable: false, identity: true),
                        SupplyDate = c.DateTime(nullable: false),
                        ActiveFlag = c.Boolean(nullable: false),
                        StockMan_Id = c.Int(),
                        Supplier_Id = c.Int(),
                    })
                .PrimaryKey(t => t.Id)
                .ForeignKey("dbo.Employees", t => t.StockMan_Id)
                .ForeignKey("dbo.Companies", t => t.Supplier_Id)
                .Index(t => t.StockMan_Id)
                .Index(t => t.Supplier_Id);
            
            CreateTable(
                "dbo.YardProducts",
                c => new
                    {
                        Yard_Id = c.Int(nullable: false),
                        Product_Id = c.Int(nullable: false),
                    })
                .PrimaryKey(t => new { t.Yard_Id, t.Product_Id })
                .ForeignKey("dbo.Yards", t => t.Yard_Id, cascadeDelete: true)
                .ForeignKey("dbo.Products", t => t.Product_Id, cascadeDelete: true)
                .Index(t => t.Yard_Id)
                .Index(t => t.Product_Id);
            
        }
        
        public override void Down()
        {
            DropForeignKey("dbo.YardProducts", "Product_Id", "dbo.Products");
            DropForeignKey("dbo.YardProducts", "Yard_Id", "dbo.Yards");
            DropForeignKey("dbo.Supplies", "Supplier_Id", "dbo.Companies");
            DropForeignKey("dbo.Supplies", "StockMan_Id", "dbo.Employees");
            DropForeignKey("dbo.Products", "Supply_Id", "dbo.Supplies");
            DropForeignKey("dbo.Products", "Supplier_Id", "dbo.Companies");
            DropForeignKey("dbo.Products", "ProductType_Id", "dbo.ProductTypes");
            DropForeignKey("dbo.Yards", "Machine_Id", "dbo.Machines");
            DropForeignKey("dbo.Machines", "LastOperator_Id", "dbo.Employees");
            DropForeignKey("dbo.Contracts", "Supplier_Id", "dbo.Companies");
            DropForeignKey("dbo.Accounts", "Id", "dbo.Employees");
            DropIndex("dbo.YardProducts", new[] { "Product_Id" });
            DropIndex("dbo.YardProducts", new[] { "Yard_Id" });
            DropIndex("dbo.Supplies", new[] { "Supplier_Id" });
            DropIndex("dbo.Supplies", new[] { "StockMan_Id" });
            DropIndex("dbo.Products", new[] { "Supply_Id" });
            DropIndex("dbo.Products", new[] { "Supplier_Id" });
            DropIndex("dbo.Products", new[] { "ProductType_Id" });
            DropIndex("dbo.Yards", new[] { "Machine_Id" });
            DropIndex("dbo.Machines", new[] { "LastOperator_Id" });
            DropIndex("dbo.Contracts", new[] { "Supplier_Id" });
            DropIndex("dbo.Accounts", new[] { "Id" });
            DropTable("dbo.YardProducts");
            DropTable("dbo.Supplies");
            DropTable("dbo.ProductTypes");
            DropTable("dbo.Products");
            DropTable("dbo.Yards");
            DropTable("dbo.Machines");
            DropTable("dbo.Contracts");
            DropTable("dbo.Companies");
            DropTable("dbo.Employees");
            DropTable("dbo.Accounts");
        }
    }
}
