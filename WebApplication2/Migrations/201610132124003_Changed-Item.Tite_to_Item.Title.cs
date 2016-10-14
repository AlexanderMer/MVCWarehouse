namespace WebApplication2.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class ChangedItemTite_to_ItemTitle : DbMigration
    {
        public override void Up()
        {
            AddColumn("dbo.Items", "Title", c => c.String(nullable: false));
            DropColumn("dbo.Items", "Tite");
        }
        
        public override void Down()
        {
            AddColumn("dbo.Items", "Tite", c => c.String(nullable: false));
            DropColumn("dbo.Items", "Title");
        }
    }
}
