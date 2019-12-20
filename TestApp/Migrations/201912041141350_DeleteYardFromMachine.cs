namespace TestApp.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class DeleteYardFromMachine : DbMigration
    {
        public override void Up()
        {
            DropForeignKey("dbo.Machines", "Yard_Id", "dbo.Yards");
            DropIndex("dbo.Machines", new[] { "Yard_Id" });
            DropColumn("dbo.Machines", "Yard_Id");
        }
        
        public override void Down()
        {
            AddColumn("dbo.Machines", "Yard_Id", c => c.Int());
            CreateIndex("dbo.Machines", "Yard_Id");
            AddForeignKey("dbo.Machines", "Yard_Id", "dbo.Yards", "Id");
        }
    }
}
