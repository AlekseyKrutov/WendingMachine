namespace TestApp.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class Supplier : DbMigration
    {
        public override void Up()
        {
            AddColumn("dbo.Companies", "Director_Id", c => c.Int());
            CreateIndex("dbo.Companies", "Director_Id");
            AddForeignKey("dbo.Companies", "Director_Id", "dbo.Employees", "Id");
            DropColumn("dbo.Companies", "Director1");
        }
        
        public override void Down()
        {
            AddColumn("dbo.Companies", "Director1", c => c.String());
            DropForeignKey("dbo.Companies", "Director_Id", "dbo.Employees");
            DropIndex("dbo.Companies", new[] { "Director_Id" });
            DropColumn("dbo.Companies", "Director_Id");
        }
    }
}
