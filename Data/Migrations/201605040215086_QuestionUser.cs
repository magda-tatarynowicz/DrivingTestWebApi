namespace Data.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class QuestionUser : DbMigration
    {
        public override void Up()
        {
            RenameTable(name: "dbo.AdvancedQuestions", newName: "Questions");
            CreateTable(
                "dbo.QuestionUsers",
                c => new
                    {
                        Id = c.Int(nullable: false, identity: true),
                        UserId = c.String(),
                        IsAnswered = c.Boolean(nullable: false),
                        Question_Id = c.Int(),
                    })
                .PrimaryKey(t => t.Id)
                .ForeignKey("dbo.Questions", t => t.Question_Id)
                .Index(t => t.Question_Id);
            
            AddColumn("dbo.Questions", "IsCorrect", c => c.Boolean());
            AddColumn("dbo.Questions", "Discriminator", c => c.String(nullable: false, maxLength: 128));
            AlterColumn("dbo.Questions", "CorrectAnswer", c => c.Int());
            DropTable("dbo.BasicQuestions");
        }
        
        public override void Down()
        {
            CreateTable(
                "dbo.BasicQuestions",
                c => new
                    {
                        Id = c.Int(nullable: false, identity: true),
                        IsCorrect = c.Boolean(nullable: false),
                        QuestionString = c.String(),
                        Points = c.Int(nullable: false),
                        IsVerified = c.Boolean(nullable: false),
                    })
                .PrimaryKey(t => t.Id);
            
            DropForeignKey("dbo.QuestionUsers", "Question_Id", "dbo.Questions");
            DropIndex("dbo.QuestionUsers", new[] { "Question_Id" });
            AlterColumn("dbo.Questions", "CorrectAnswer", c => c.Int(nullable: false));
            DropColumn("dbo.Questions", "Discriminator");
            DropColumn("dbo.Questions", "IsCorrect");
            DropTable("dbo.QuestionUsers");
            RenameTable(name: "dbo.Questions", newName: "AdvancedQuestions");
        }
    }
}
