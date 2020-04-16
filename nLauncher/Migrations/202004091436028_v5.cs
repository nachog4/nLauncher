namespace nLauncher.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class v5 : DbMigration
    {
        public override void Up()
        {
            AddColumn("dbo.AppEntries", "Category", c => c.String());
        }
        
        public override void Down()
        {
            DropColumn("dbo.AppEntries", "Category");
        }
    }
}
