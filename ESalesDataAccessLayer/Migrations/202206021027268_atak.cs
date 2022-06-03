namespace ESalesDataAccessLayer.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class atak : DbMigration
    {
        public override void Up()
        {
            DropIndex("dbo.Products", new[] { "Category_ID1" });
            DropIndex("dbo.Products", new[] { "Supplier_ID1" });
            DropIndex("dbo.OrderDetails", new[] { "Order_ID1" });
            DropIndex("dbo.OrderDetails", new[] { "Product_ID1" });
            DropIndex("dbo.Orders", new[] { "City_ID1" });
            DropIndex("dbo.Orders", new[] { "Customer_ID1" });
            DropIndex("dbo.Customers", new[] { "City_ID1" });
            DropColumn("dbo.Products", "Category_ID");
            DropColumn("dbo.Products", "Supplier_ID");
            DropColumn("dbo.OrderDetails", "Product_ID");
            DropColumn("dbo.OrderDetails", "Order_ID");
            DropColumn("dbo.Orders", "City_ID");
            DropColumn("dbo.Orders", "Customer_ID");
            DropColumn("dbo.Customers", "City_ID");
            RenameColumn(table: "dbo.Products", name: "Category_ID1", newName: "Category_ID");
            RenameColumn(table: "dbo.OrderDetails", name: "Product_ID1", newName: "Product_ID");
            RenameColumn(table: "dbo.Products", name: "Supplier_ID1", newName: "Supplier_ID");
            RenameColumn(table: "dbo.OrderDetails", name: "Order_ID1", newName: "Order_ID");
            RenameColumn(table: "dbo.Orders", name: "City_ID1", newName: "City_ID");
            RenameColumn(table: "dbo.Orders", name: "Customer_ID1", newName: "Customer_ID");
            RenameColumn(table: "dbo.Customers", name: "City_ID1", newName: "City_ID");
            AlterColumn("dbo.Products", "Supplier_ID", c => c.Int());
            AlterColumn("dbo.Products", "Category_ID", c => c.Int());
            AlterColumn("dbo.OrderDetails", "Product_ID", c => c.Int());
            AlterColumn("dbo.OrderDetails", "Order_ID", c => c.Int());
            AlterColumn("dbo.Orders", "City_ID", c => c.Int());
            AlterColumn("dbo.Orders", "Customer_ID", c => c.Int());
            AlterColumn("dbo.Customers", "City_ID", c => c.Int());
            CreateIndex("dbo.Products", "Supplier_ID");
            CreateIndex("dbo.Products", "Category_ID");
            CreateIndex("dbo.OrderDetails", "Product_ID");
            CreateIndex("dbo.OrderDetails", "Order_ID");
            CreateIndex("dbo.Orders", "City_ID");
            CreateIndex("dbo.Orders", "Customer_ID");
            CreateIndex("dbo.Customers", "City_ID");
        }
        
        public override void Down()
        {
            DropIndex("dbo.Customers", new[] { "City_ID" });
            DropIndex("dbo.Orders", new[] { "Customer_ID" });
            DropIndex("dbo.Orders", new[] { "City_ID" });
            DropIndex("dbo.OrderDetails", new[] { "Order_ID" });
            DropIndex("dbo.OrderDetails", new[] { "Product_ID" });
            DropIndex("dbo.Products", new[] { "Category_ID" });
            DropIndex("dbo.Products", new[] { "Supplier_ID" });
            AlterColumn("dbo.Customers", "City_ID", c => c.Int(nullable: false));
            AlterColumn("dbo.Orders", "Customer_ID", c => c.Int(nullable: false));
            AlterColumn("dbo.Orders", "City_ID", c => c.Int(nullable: false));
            AlterColumn("dbo.OrderDetails", "Order_ID", c => c.Int(nullable: false));
            AlterColumn("dbo.OrderDetails", "Product_ID", c => c.Int(nullable: false));
            AlterColumn("dbo.Products", "Category_ID", c => c.Int(nullable: false));
            AlterColumn("dbo.Products", "Supplier_ID", c => c.Int(nullable: false));
            RenameColumn(table: "dbo.Customers", name: "City_ID", newName: "City_ID1");
            RenameColumn(table: "dbo.Orders", name: "Customer_ID", newName: "Customer_ID1");
            RenameColumn(table: "dbo.Orders", name: "City_ID", newName: "City_ID1");
            RenameColumn(table: "dbo.OrderDetails", name: "Order_ID", newName: "Order_ID1");
            RenameColumn(table: "dbo.Products", name: "Supplier_ID", newName: "Supplier_ID1");
            RenameColumn(table: "dbo.OrderDetails", name: "Product_ID", newName: "Product_ID1");
            RenameColumn(table: "dbo.Products", name: "Category_ID", newName: "Category_ID1");
            AddColumn("dbo.Customers", "City_ID", c => c.Int(nullable: false));
            AddColumn("dbo.Orders", "Customer_ID", c => c.Int(nullable: false));
            AddColumn("dbo.Orders", "City_ID", c => c.Int(nullable: false));
            AddColumn("dbo.OrderDetails", "Order_ID", c => c.Int(nullable: false));
            AddColumn("dbo.OrderDetails", "Product_ID", c => c.Int(nullable: false));
            AddColumn("dbo.Products", "Supplier_ID", c => c.Int(nullable: false));
            AddColumn("dbo.Products", "Category_ID", c => c.Int(nullable: false));
            CreateIndex("dbo.Customers", "City_ID1");
            CreateIndex("dbo.Orders", "Customer_ID1");
            CreateIndex("dbo.Orders", "City_ID1");
            CreateIndex("dbo.OrderDetails", "Product_ID1");
            CreateIndex("dbo.OrderDetails", "Order_ID1");
            CreateIndex("dbo.Products", "Supplier_ID1");
            CreateIndex("dbo.Products", "Category_ID1");
        }
    }
}
