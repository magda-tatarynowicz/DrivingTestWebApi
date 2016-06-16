namespace Data.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class AdvancedQuestionFix1 : DbMigration
    {
        public override void Up()
        {
            DropForeignKey("dbo.AdvancedQuestionAnswers", "AdvancedQuestionId", "dbo.Questions");
            DropIndex("dbo.AdvancedQuestionAnswers", new[] { "AdvancedQuestionId" });
            AddColumn("dbo.Questions", "Theory", c => c.String());
            AddColumn("dbo.Questions", "AnswerA", c => c.String());
            AddColumn("dbo.Questions", "AnswerB", c => c.String());
            AddColumn("dbo.Questions", "AnswerC", c => c.String());
            DropTable("dbo.AdvancedQuestionAnswers");
        }
        
        public override void Down()
        {
            CreateTable(
                "dbo.AdvancedQuestionAnswers",
                c => new
                    {
                        Id = c.Int(nullable: false, identity: true),
                        Answer = c.String(),
                        IsCorrect = c.Boolean(nullable: false),
                        AdvancedQuestionId = c.Int(nullable: false),
                    })
                .PrimaryKey(t => t.Id);
            
            DropColumn("dbo.Questions", "AnswerC");
            DropColumn("dbo.Questions", "AnswerB");
            DropColumn("dbo.Questions", "AnswerA");
            DropColumn("dbo.Questions", "Theory");
            CreateIndex("dbo.AdvancedQuestionAnswers", "AdvancedQuestionId");
            AddForeignKey("dbo.AdvancedQuestionAnswers", "AdvancedQuestionId", "dbo.Questions", "Id", cascadeDelete: true);
        }
    }
}
