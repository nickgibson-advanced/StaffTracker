namespace StaffTracker.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class RegistrationDetails : DbMigration
    {
        public override void Up()
        {
            AddColumn("dbo.AspNetUsers", "Mobile_No", c => c.String());
            AddColumn("dbo.AspNetUsers", "Medical_Conditions", c => c.String());
            AddColumn("dbo.AspNetUsers", "DBS_No", c => c.String());
            AddColumn("dbo.AspNetUsers", "DBS_Clearance_Date", c => c.DateTime(nullable: false));
            AddColumn("dbo.AspNetUsers", "Lifeguard_Qualification_Expiry_Date", c => c.DateTime(nullable: false));
            AddColumn("dbo.AspNetUsers", "Teaching_Qualification", c => c.String());
            AddColumn("dbo.AspNetUsers", "Teaching_Qualification_Date", c => c.DateTime(nullable: false));
            AddColumn("dbo.AspNetUsers", "Address", c => c.String());
        }
        
        public override void Down()
        {
            DropColumn("dbo.AspNetUsers", "Address");
            DropColumn("dbo.AspNetUsers", "Teaching_Qualification_Date");
            DropColumn("dbo.AspNetUsers", "Teaching_Qualification");
            DropColumn("dbo.AspNetUsers", "Lifeguard_Qualification_Expiry_Date");
            DropColumn("dbo.AspNetUsers", "DBS_Clearance_Date");
            DropColumn("dbo.AspNetUsers", "DBS_No");
            DropColumn("dbo.AspNetUsers", "Medical_Conditions");
            DropColumn("dbo.AspNetUsers", "Mobile_No");
        }
    }
}
