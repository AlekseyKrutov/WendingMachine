namespace TestApp.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class InitialModel1 : DbMigration
    {
        public override void Up()
        {
            AddColumn("dbo.Machines", "Columns", c => c.Int(nullable: false));
            AddColumn("dbo.Machines", "Rows", c => c.Int(nullable: false));
            AddColumn("dbo.Machines", "Firm", c => c.String());
            AddColumn("dbo.Machines", "Model", c => c.String());
            AddColumn("dbo.Machines", "SerialNumber", c => c.String());
        }
        
        public override void Down()
        {
            DropColumn("dbo.Machines", "SerialNumber");
            DropColumn("dbo.Machines", "Model");
            DropColumn("dbo.Machines", "Firm");
            DropColumn("dbo.Machines", "Rows");
            DropColumn("dbo.Machines", "Columns");
        }
    }
}
