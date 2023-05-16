namespace DAL.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class alldbinit : DbMigration
    {
        public override void Up()
        {
            CreateTable(
                "dbo.Authors",
                c => new
                    {
                        AuthorId = c.Int(nullable: false, identity: true),
                        AuthorName = c.String(),
                        AuthorBio = c.String(nullable: false, maxLength: 25),
                        PresentAddress = c.String(nullable: false, maxLength: 25),
                        AuthorEmail = c.String(nullable: false, maxLength: 25),
                        Password = c.String(nullable: false, maxLength: 8),
                        ConfirmPassword = c.String(nullable: false),
                    })
                .PrimaryKey(t => t.AuthorId);
            
            CreateTable(
                "dbo.Receipts",
                c => new
                    {
                        ReceiptId = c.Int(nullable: false, identity: true),
                        ReceiptNumber = c.String(nullable: false, maxLength: 10),
                        ReceiptDescription = c.String(),
                        CustomerId = c.Int(nullable: false),
                    })
                .PrimaryKey(t => t.ReceiptId)
                .ForeignKey("dbo.Customers", t => t.CustomerId, cascadeDelete: true)
                .Index(t => t.CustomerId);
            
            AlterColumn("dbo.Books", "Title", c => c.String(nullable: false, maxLength: 14));
            AlterColumn("dbo.Books", "Author", c => c.String(nullable: false, maxLength: 14));
            AlterColumn("dbo.Books", "Description", c => c.String(nullable: false, maxLength: 14));
        }
        
        public override void Down()
        {
            DropForeignKey("dbo.Receipts", "CustomerId", "dbo.Customers");
            DropIndex("dbo.Receipts", new[] { "CustomerId" });
            AlterColumn("dbo.Books", "Description", c => c.String(nullable: false, maxLength: 500));
            AlterColumn("dbo.Books", "Author", c => c.String(nullable: false, maxLength: 100));
            AlterColumn("dbo.Books", "Title", c => c.String(nullable: false, maxLength: 100));
            DropTable("dbo.Receipts");
            DropTable("dbo.Authors");
        }
    }
}
