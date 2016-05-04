namespace Data.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class VerifiedQuestion : DbMigration
    {
        public override void Up()
        {
            AddColumn("dbo.AdvancedQuestions", "IsVerified", c => c.Boolean(nullable: false));
            AddColumn("dbo.BasicQuestions", "IsVerified", c => c.Boolean(nullable: false));
        }
        
        public override void Down()
        {
            DropColumn("dbo.BasicQuestions", "IsVerified");
            DropColumn("dbo.AdvancedQuestions", "IsVerified");
        }
    }
}
