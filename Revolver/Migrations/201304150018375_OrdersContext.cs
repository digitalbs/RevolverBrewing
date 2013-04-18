namespace Revolver.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class OrdersContext : DbMigration
    {
        public override void Up()
        {
            AddColumn("dbo.Products", "ImageUrl", c => c.String());
            DropColumn("dbo.Products", "Url");
        }
        
        public override void Down()
        {
            AddColumn("dbo.Products", "Url", c => c.String());
            DropColumn("dbo.Products", "ImageUrl");
        }
    }
}
