namespace TestApp.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class AddPaymentTable : DbMigration
    {
        public override void Up()
        {
            CreateTable(
                "dbo.Payments",
                c => new
                    {
                        Id = c.Int(nullable: false, identity: true),
                        TotalSum = c.Decimal(nullable: false, precision: 18, scale: 2),
                        PaymentDate = c.DateTime(nullable: false),
                        Operator_Id = c.Int(nullable: false),
                        Supply_Id = c.Int(),
                    })
                .PrimaryKey(t => t.Id)
                .ForeignKey("dbo.Employees", t => t.Operator_Id)
                .ForeignKey("dbo.Supplies", t => t.Supply_Id)
                .Index(t => t.Operator_Id)
                .Index(t => t.Supply_Id);
            
        }
        
        public override void Down()
        {
            DropForeignKey("dbo.Payments", "Supply_Id", "dbo.Supplies");
            DropForeignKey("dbo.Payments", "Operator_Id", "dbo.Employees");
            DropIndex("dbo.Payments", new[] { "Supply_Id" });
            DropIndex("dbo.Payments", new[] { "Operator_Id" });
            DropTable("dbo.Payments");
        }
    }
}
