namespace Data.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class photosfix : DbMigration
    {
        public override void Up()
        {
            AddColumn("dbo.Questions", "PhotoString", c => c.String());
        }
        
        public override void Down()
        {
            DropColumn("dbo.Questions", "PhotoString");
        }
    }
}
