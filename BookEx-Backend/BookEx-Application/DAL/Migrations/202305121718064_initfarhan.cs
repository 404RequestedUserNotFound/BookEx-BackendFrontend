namespace DAL.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class initfarhan : DbMigration
    {
        public override void Up()
        {
            CreateTable(
                "dbo.Borrows",
                c => new
                    {
                        Id = c.Int(nullable: false, identity: true),
                        UserId = c.Int(nullable: false),
                        BookId = c.Int(nullable: false),
                        BorrowDate = c.DateTime(nullable: false),
                        DueDate = c.DateTime(nullable: false),
                        ReturnDate = c.DateTime(nullable: false),
                        Status = c.String(nullable: false),
                        Fine = c.Double(nullable: false),
                    })
                .PrimaryKey(t => t.Id)
                .ForeignKey("dbo.Books", t => t.BookId, cascadeDelete: true)
                .ForeignKey("dbo.Users", t => t.UserId, cascadeDelete: true)
                .Index(t => t.UserId)
                .Index(t => t.BookId);
            
            CreateTable(
                "dbo.Publishers",
                c => new
                    {
                        Id = c.Int(nullable: false, identity: true),
                        FirstName = c.String(nullable: false, maxLength: 50),
                        LastName = c.String(nullable: false, maxLength: 50),
                        Username = c.String(nullable: false, maxLength: 50),
                        Email = c.String(nullable: false, maxLength: 50),
                        Password = c.String(nullable: false, maxLength: 50),
                        Website = c.String(),
                    })
                .PrimaryKey(t => t.Id);
            
            CreateTable(
                "dbo.Reservations",
                c => new
                    {
                        Id = c.Int(nullable: false, identity: true),
                        BookId = c.Int(nullable: false),
                        UserId = c.Int(nullable: false),
                        ReservationDate = c.DateTime(nullable: false),
                        Status = c.String(),
                    })
                .PrimaryKey(t => t.Id)
                .ForeignKey("dbo.Books", t => t.BookId, cascadeDelete: true)
                .ForeignKey("dbo.Users", t => t.UserId, cascadeDelete: true)
                .Index(t => t.BookId)
                .Index(t => t.UserId);
            
            AddColumn("dbo.Books", "Publisher_Id", c => c.Int());
            CreateIndex("dbo.Books", "Publisher_Id");
            AddForeignKey("dbo.Books", "Publisher_Id", "dbo.Publishers", "Id");
        }
        
        public override void Down()
        {
            DropForeignKey("dbo.Reservations", "UserId", "dbo.Users");
            DropForeignKey("dbo.Reservations", "BookId", "dbo.Books");
            DropForeignKey("dbo.Books", "Publisher_Id", "dbo.Publishers");
            DropForeignKey("dbo.Borrows", "UserId", "dbo.Users");
            DropForeignKey("dbo.Borrows", "BookId", "dbo.Books");
            DropIndex("dbo.Reservations", new[] { "UserId" });
            DropIndex("dbo.Reservations", new[] { "BookId" });
            DropIndex("dbo.Borrows", new[] { "BookId" });
            DropIndex("dbo.Borrows", new[] { "UserId" });
            DropIndex("dbo.Books", new[] { "Publisher_Id" });
            DropColumn("dbo.Books", "Publisher_Id");
            DropTable("dbo.Reservations");
            DropTable("dbo.Publishers");
            DropTable("dbo.Borrows");
        }
    }
}
