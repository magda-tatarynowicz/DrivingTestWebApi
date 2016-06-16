namespace Data.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class AdvancedQuestionFix : DbMigration
    {
        public override void Up()
        {
            DropForeignKey("dbo.AdvancedQuestionAnswers", "AdvancedQuestion_Id", "dbo.Questions");
            DropIndex("dbo.AdvancedQuestionAnswers", new[] { "AdvancedQuestion_Id" });
            RenameColumn(table: "dbo.AdvancedQuestionAnswers", name: "AdvancedQuestion_Id", newName: "AdvancedQuestionId");
            AlterColumn("dbo.AdvancedQuestionAnswers", "AdvancedQuestionId", c => c.Int(nullable: false));
            CreateIndex("dbo.AdvancedQuestionAnswers", "AdvancedQuestionId");
            AddForeignKey("dbo.AdvancedQuestionAnswers", "AdvancedQuestionId", "dbo.Questions", "Id", cascadeDelete: true);
        }
        
        public override void Down()
        {
            DropForeignKey("dbo.AdvancedQuestionAnswers", "AdvancedQuestionId", "dbo.Questions");
            DropIndex("dbo.AdvancedQuestionAnswers", new[] { "AdvancedQuestionId" });
            AlterColumn("dbo.AdvancedQuestionAnswers", "AdvancedQuestionId", c => c.Int());
            RenameColumn(table: "dbo.AdvancedQuestionAnswers", name: "AdvancedQuestionId", newName: "AdvancedQuestion_Id");
            CreateIndex("dbo.AdvancedQuestionAnswers", "AdvancedQuestion_Id");
            AddForeignKey("dbo.AdvancedQuestionAnswers", "AdvancedQuestion_Id", "dbo.Questions", "Id");
        }
    }
}
