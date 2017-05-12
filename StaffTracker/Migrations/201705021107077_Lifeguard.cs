namespace StaffTracker.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class Lifeguard : DbMigration
    {
        public override void Up()
        {
            AddColumn("dbo.AspNetUsers", "Lifeguard_Qualification", c => c.String());
        }
        
        public override void Down()
        {
            DropColumn("dbo.AspNetUsers", "Lifeguard_Qualification");
        }
    }
}
