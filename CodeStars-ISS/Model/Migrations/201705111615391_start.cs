namespace Model.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class start : DbMigration
    {
        public override void Up()
        {
            CreateTable(
                "dbo.User_Conferences",
                c => new
                    {
                        Id = c.Int(nullable: false, identity: true),
                        Role = c.Int(nullable: false),
                        ConferenceId = c.Int(nullable: false),
                        UserId = c.Int(nullable: false),
                    })
                .PrimaryKey(t => t.Id)
                .ForeignKey("dbo.Conferences", t => t.ConferenceId)
                .ForeignKey("dbo.Users", t => t.UserId)
                .Index(t => t.ConferenceId)
                .Index(t => t.UserId);
            
            CreateTable(
                "dbo.Conferences",
                c => new
                    {
                        Id = c.Int(nullable: false, identity: true),
                        Name = c.String(),
                        StartDate = c.DateTime(nullable: false),
                        EndDate = c.DateTime(nullable: false),
                        Domain = c.String(),
                    })
                .PrimaryKey(t => t.Id);
            
            CreateTable(
                "dbo.Users",
                c => new
                    {
                        Id = c.Int(nullable: false, identity: true),
                        Username = c.String(),
                        Password = c.String(),
                        FirstName = c.String(),
                        LastName = c.String(),
                        Email = c.String(),
                        WebPage = c.String(),
                        Admin = c.Boolean(nullable: false),
                    })
                .PrimaryKey(t => t.Id);
            
        }
        
        public override void Down()
        {
            DropForeignKey("dbo.User_Conferences", "UserId", "dbo.Users");
            DropForeignKey("dbo.User_Conferences", "ConferenceId", "dbo.Conferences");
            DropIndex("dbo.User_Conferences", new[] { "UserId" });
            DropIndex("dbo.User_Conferences", new[] { "ConferenceId" });
            DropTable("dbo.Users");
            DropTable("dbo.Conferences");
            DropTable("dbo.User_Conferences");
        }
    }
}
