namespace nLauncher.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class v6 : DbMigration
    {
        public override void Up()
        {
            AddColumn("dbo.AppEntries", "Screenshot1", c => c.Binary());
            AddColumn("dbo.AppEntries", "Screenshot2", c => c.Binary());
            AddColumn("dbo.AppEntries", "Screenshot3", c => c.Binary());
        }
        
        public override void Down()
        {
            DropColumn("dbo.AppEntries", "Screenshot3");
            DropColumn("dbo.AppEntries", "Screenshot2");
            DropColumn("dbo.AppEntries", "Screenshot1");
        }
    }
}
