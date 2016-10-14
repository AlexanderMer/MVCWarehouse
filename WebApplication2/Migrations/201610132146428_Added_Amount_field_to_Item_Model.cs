namespace WebApplication2.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class Added_Amount_field_to_Item_Model : DbMigration
    {
        public override void Up()
        {
            AddColumn("dbo.Items", "Amount", c => c.Int(nullable: false));
        }
        
        public override void Down()
        {
            DropColumn("dbo.Items", "Amount");
        }
    }
}
