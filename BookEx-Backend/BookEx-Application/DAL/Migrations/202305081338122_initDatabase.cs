namespace DAL.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class initDatabase : DbMigration
    {
        public override void Up()
        {
            CreateTable(
                "dbo.Admins",
                c => new
                    {
                        AdminId = c.Int(nullable: false, identity: true),
                        FirstName = c.String(nullable: false, maxLength: 25),
                        LastName = c.String(nullable: false, maxLength: 25),
                        Username = c.String(nullable: false, maxLength: 25),
                        Phone = c.String(nullable: false, maxLength: 14),
                        PresentAddress = c.String(nullable: false, maxLength: 25),
                        PermanentAddress = c.String(nullable: false, maxLength: 25),
                        NID = c.String(nullable: false, maxLength: 10),
                        Email = c.String(nullable: false, maxLength: 25),
                        Password = c.String(nullable: false, maxLength: 8),
                        ConfirmPassword = c.String(nullable: false),
                    })
                .PrimaryKey(t => t.AdminId);
            
            CreateTable(
                "dbo.Books",
                c => new
                    {
                        BookId = c.Int(nullable: false, identity: true),
                        Title = c.String(nullable: false, maxLength: 100),
                        Author = c.String(nullable: false, maxLength: 100),
                        Description = c.String(nullable: false, maxLength: 500),
                        Price = c.Decimal(nullable: false, precision: 18, scale: 2),
                        Quantity = c.Int(nullable: false),
                        CategoryId = c.Int(nullable: false),
                    })
                .PrimaryKey(t => t.BookId)
                .ForeignKey("dbo.Categories", t => t.CategoryId, cascadeDelete: true)
                .Index(t => t.CategoryId);
            
            CreateTable(
                "dbo.Categories",
                c => new
                    {
                        CategoryId = c.Int(nullable: false, identity: true),
                        CategoryName = c.String(nullable: false, maxLength: 25),
                    })
                .PrimaryKey(t => t.CategoryId);
            
            CreateTable(
                "dbo.Customers",
                c => new
                    {
                        CustomerId = c.Int(nullable: false, identity: true),
                        FirstName = c.String(nullable: false, maxLength: 25),
                        LastName = c.String(nullable: false, maxLength: 25),
                        Username = c.String(nullable: false, maxLength: 25),
                        Email = c.String(nullable: false, maxLength: 25),
                        Password = c.String(nullable: false, maxLength: 8),
                        ConfirmPassword = c.String(nullable: false),
                    })
                .PrimaryKey(t => t.CustomerId);
            
            CreateTable(
                "dbo.Orders",
                c => new
                    {
                        OrderId = c.Int(nullable: false, identity: true),
                        OrderDate = c.DateTime(nullable: false),
                        TotalPrice = c.Decimal(nullable: false, precision: 18, scale: 2),
                        CustomerId = c.Int(nullable: false),
                    })
                .PrimaryKey(t => t.OrderId)
                .ForeignKey("dbo.Customers", t => t.CustomerId, cascadeDelete: true)
                .Index(t => t.CustomerId);
            
            CreateTable(
                "dbo.OrderItems",
                c => new
                    {
                        OrderItemId = c.Int(nullable: false, identity: true),
                        Quantity = c.Int(nullable: false),
                        OrderId = c.Int(nullable: false),
                    })
                .PrimaryKey(t => t.OrderItemId)
                .ForeignKey("dbo.Orders", t => t.OrderId, cascadeDelete: true)
                .Index(t => t.OrderId);
            
            CreateTable(
                "dbo.Employees",
                c => new
                    {
                        EmployeeId = c.Int(nullable: false, identity: true),
                        FirstName = c.String(nullable: false, maxLength: 25),
                        LastName = c.String(nullable: false, maxLength: 25),
                        Username = c.String(nullable: false, maxLength: 25),
                        Phone = c.String(nullable: false, maxLength: 14),
                        PresentAddress = c.String(nullable: false, maxLength: 25),
                        PermanentAddress = c.String(nullable: false, maxLength: 25),
                        NID = c.String(nullable: false, maxLength: 10),
                        Education = c.String(nullable: false, maxLength: 25),
                        Email = c.String(nullable: false, maxLength: 25),
                        Password = c.String(nullable: false, maxLength: 8),
                        ConfirmPassword = c.String(nullable: false),
                    })
                .PrimaryKey(t => t.EmployeeId);
            
            CreateTable(
                "dbo.Users",
                c => new
                    {
                        UserId = c.Int(nullable: false, identity: true),
                        UserType = c.String(nullable: false),
                    })
                .PrimaryKey(t => t.UserId);
            
        }
        
        public override void Down()
        {
            DropForeignKey("dbo.OrderItems", "OrderId", "dbo.Orders");
            DropForeignKey("dbo.Orders", "CustomerId", "dbo.Customers");
            DropForeignKey("dbo.Books", "CategoryId", "dbo.Categories");
            DropIndex("dbo.OrderItems", new[] { "OrderId" });
            DropIndex("dbo.Orders", new[] { "CustomerId" });
            DropIndex("dbo.Books", new[] { "CategoryId" });
            DropTable("dbo.Users");
            DropTable("dbo.Employees");
            DropTable("dbo.OrderItems");
            DropTable("dbo.Orders");
            DropTable("dbo.Customers");
            DropTable("dbo.Categories");
            DropTable("dbo.Books");
            DropTable("dbo.Admins");
        }
    }
}
