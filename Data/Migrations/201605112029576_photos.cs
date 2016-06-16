namespace Data.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class photos : DbMigration
    {
        public override void Up()
        {
            AddColumn("dbo.Questions", "Photo", c => c.Binary());
        }
        
        public override void Down()
        {
            DropColumn("dbo.Questions", "Photo");
        }
    }
}
