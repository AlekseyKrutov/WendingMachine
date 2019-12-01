namespace TestApp.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class AddLoginInAccount : DbMigration
    {
        public override void Up()
        {
            AddColumn("dbo.Accounts", "Login", c => c.String(nullable:false));
        }
        
        public override void Down()
        {
            DropColumn("dbo.Accounts", "Login");
        }
    }
}
