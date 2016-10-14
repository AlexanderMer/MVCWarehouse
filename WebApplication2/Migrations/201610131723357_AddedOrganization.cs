namespace WebApplication2.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class AddedOrganization : DbMigration
    {
        public override void Up()
        {
            AddColumn("dbo.AspNetUsers", "Organization", c => c.String());
        }
        
        public override void Down()
        {
            DropColumn("dbo.AspNetUsers", "Organization");
        }
    }
}
