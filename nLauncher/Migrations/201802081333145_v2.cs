namespace nLauncher.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class v2 : DbMigration
    {
        public override void Up()
        {
            AddColumn("dbo.AppEntries", "Image2", c => c.Binary());
        }
        
        public override void Down()
        {
            DropColumn("dbo.AppEntries", "Image2");
        }
    }
}
