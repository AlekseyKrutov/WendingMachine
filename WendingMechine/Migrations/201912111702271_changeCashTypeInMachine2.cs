namespace WendingMechine.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class changeCashTypeInMachine2 : DbMigration
    {
        public override void Up()
        {
            AlterColumn("dbo.Machines", "CashSum", c => c.Double(nullable: false));
        }
        
        public override void Down()
        {
            AlterColumn("dbo.Machines", "CashSum", c => c.Single(nullable: false));
        }
    }
}
