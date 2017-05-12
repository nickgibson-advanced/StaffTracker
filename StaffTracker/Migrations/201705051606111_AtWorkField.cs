namespace StaffTracker.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class AtWorkField : DbMigration
    {
        public override void Up()
        {
            AddColumn("dbo.AspNetUsers", "AtWork", c => c.Boolean(nullable: false));
        }
        
        public override void Down()
        {
            DropColumn("dbo.AspNetUsers", "AtWork");
        }
    }
}
