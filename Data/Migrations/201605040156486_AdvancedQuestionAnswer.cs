namespace Data.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class AdvancedQuestionAnswer : DbMigration
    {
        public override void Up()
        {
            CreateTable(
                "dbo.AdvancedQuestionAnswers",
                c => new
                    {
                        Id = c.Int(nullable: false, identity: true),
                        Answer = c.String(),
                        IsCorrect = c.Boolean(nullable: false),
                        AdvancedQuestion_Id = c.Int(),
                    })
                .PrimaryKey(t => t.Id)
                .ForeignKey("dbo.AdvancedQuestions", t => t.AdvancedQuestion_Id)
                .Index(t => t.AdvancedQuestion_Id);
            
        }
        
        public override void Down()
        {
            DropForeignKey("dbo.AdvancedQuestionAnswers", "AdvancedQuestion_Id", "dbo.AdvancedQuestions");
            DropIndex("dbo.AdvancedQuestionAnswers", new[] { "AdvancedQuestion_Id" });
            DropTable("dbo.AdvancedQuestionAnswers");
        }
    }
}
