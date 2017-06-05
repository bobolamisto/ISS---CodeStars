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
                        MainDescription = c.String(),
                        Edition = c.Int(nullable: false),
                        Price = c.Single(nullable: false),
                        AbstractDeadline = c.DateTime(nullable: false),
                        FullPaperDeadline = c.DateTime(nullable: false),
                        State = c.Int(nullable: false),
                    })
                .PrimaryKey(t => t.Id);
            
            CreateTable(
                "dbo.Sections",
                c => new
                    {
                        Id = c.Int(nullable: false, identity: true),
                        Title = c.String(),
                        StartDate = c.DateTime(nullable: false),
                        EndDate = c.DateTime(nullable: false),
                        ChairId = c.Int(nullable: false),
                        ConferenceId = c.Int(nullable: false),
                    })
                .PrimaryKey(t => t.Id)
                .ForeignKey("dbo.Users", t => t.ChairId)
                .ForeignKey("dbo.Conferences", t => t.ConferenceId)
                .Index(t => t.ChairId)
                .Index(t => t.ConferenceId);
            
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
                        Validation = c.Int(nullable: false),
                    })
                .PrimaryKey(t => t.Id);
            
            CreateTable(
                "dbo.Proposals",
                c => new
                    {
                        Id = c.Int(nullable: false, identity: true),
                        Title = c.String(),
                        Subject = c.String(),
                        Abstract = c.String(),
                        FullPaper = c.String(),
                        Keywords = c.String(),
                        Collaborators = c.String(),
                        ParticipationId = c.Int(nullable: false),
                        SectionId = c.Int(),
                        ProposalState = c.Int(nullable: false),
                    })
                .PrimaryKey(t => t.Id)
                .ForeignKey("dbo.User_Conferences", t => t.ParticipationId)
                .ForeignKey("dbo.Sections", t => t.SectionId)
                .Index(t => t.ParticipationId)
                .Index(t => t.SectionId);
            
            CreateTable(
                "dbo.Reviews",
                c => new
                    {
                        Id = c.Int(nullable: false, identity: true),
                        Mark = c.Int(nullable: false),
                        Recommendation = c.String(),
                        ProposalId = c.Int(nullable: false),
                        ReviewerId = c.Int(nullable: false),
                    })
                .PrimaryKey(t => t.Id)
                .ForeignKey("dbo.Proposals", t => t.ProposalId)
                .ForeignKey("dbo.Users", t => t.ReviewerId)
                .Index(t => t.ProposalId)
                .Index(t => t.ReviewerId);
            
        }
        
        public override void Down()
        {
            DropForeignKey("dbo.Reviews", "ReviewerId", "dbo.Users");
            DropForeignKey("dbo.Reviews", "ProposalId", "dbo.Proposals");
            DropForeignKey("dbo.User_Conferences", "UserId", "dbo.Users");
            DropForeignKey("dbo.Sections", "ConferenceId", "dbo.Conferences");
            DropForeignKey("dbo.Proposals", "SectionId", "dbo.Sections");
            DropForeignKey("dbo.Proposals", "ParticipationId", "dbo.User_Conferences");
            DropForeignKey("dbo.Sections", "ChairId", "dbo.Users");
            DropForeignKey("dbo.User_Conferences", "ConferenceId", "dbo.Conferences");
            DropIndex("dbo.Reviews", new[] { "ReviewerId" });
            DropIndex("dbo.Reviews", new[] { "ProposalId" });
            DropIndex("dbo.Proposals", new[] { "SectionId" });
            DropIndex("dbo.Proposals", new[] { "ParticipationId" });
            DropIndex("dbo.Sections", new[] { "ConferenceId" });
            DropIndex("dbo.Sections", new[] { "ChairId" });
            DropIndex("dbo.User_Conferences", new[] { "UserId" });
            DropIndex("dbo.User_Conferences", new[] { "ConferenceId" });
            DropTable("dbo.Reviews");
            DropTable("dbo.Proposals");
            DropTable("dbo.Users");
            DropTable("dbo.Sections");
            DropTable("dbo.Conferences");
            DropTable("dbo.User_Conferences");
        }
    }
}
