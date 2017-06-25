namespace StaffTracker.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class UserLogs : DbMigration
    {
        public override void Up()
        {
            CreateTable(
                "dbo.UserLogs",
                c => new
                    {
                        UserLogID = c.Guid(nullable: false),
                        DateTimeStamp = c.DateTime(nullable: false),
                        UserId = c.String(maxLength: 128),
                        Latitude = c.String(),
                        Longtitude = c.String(),
                    })
                .PrimaryKey(t => t.UserLogID)
                .ForeignKey("dbo.AspNetUsers", t => t.UserId)
                .Index(t => t.UserId);
            
        }
        
        public override void Down()
        {
            DropForeignKey("dbo.UserLogs", "UserId", "dbo.AspNetUsers");
            DropIndex("dbo.UserLogs", new[] { "UserId" });
            DropTable("dbo.UserLogs");
        }
    }
}
