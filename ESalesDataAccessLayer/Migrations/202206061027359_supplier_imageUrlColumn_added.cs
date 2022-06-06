namespace ESalesDataAccessLayer.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class supplier_imageUrlColumn_added : DbMigration
    {
        public override void Up()
        {
            AddColumn("dbo.Suppliers", "ImageUrl", c => c.String());
        }
        
        public override void Down()
        {
            DropColumn("dbo.Suppliers", "ImageUrl");
        }
    }
}
