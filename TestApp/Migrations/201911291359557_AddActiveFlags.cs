namespace TestApp.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class AddActiveFlags : DbMigration
    {
        public override void Up()
        {
            AddColumn("dbo.Companies", "ActiveFlag", c => c.Boolean(nullable: false));
            AddColumn("dbo.Yards", "ActiveFlag", c => c.Boolean(nullable: false));
            AddColumn("dbo.ProductTypes", "ActiveFlag", c => c.Boolean(nullable: false));
        }
        
        public override void Down()
        {
            DropColumn("dbo.ProductTypes", "ActiveFlag");
            DropColumn("dbo.Yards", "ActiveFlag");
            DropColumn("dbo.Companies", "ActiveFlag");
        }
    }
}
