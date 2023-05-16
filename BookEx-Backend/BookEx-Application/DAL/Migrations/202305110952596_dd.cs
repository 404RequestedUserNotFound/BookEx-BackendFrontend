namespace DAL.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class dd : DbMigration
    {
        public override void Up()
        {
            AlterColumn("dbo.Books", "Title", c => c.String(nullable: false, maxLength: 100));
            AlterColumn("dbo.Books", "Author", c => c.String(nullable: false, maxLength: 100));
            AlterColumn("dbo.Books", "Description", c => c.String(nullable: false, maxLength: 500));
        }
        
        public override void Down()
        {
            AlterColumn("dbo.Books", "Description", c => c.String(nullable: false, maxLength: 14));
            AlterColumn("dbo.Books", "Author", c => c.String(nullable: false, maxLength: 14));
            AlterColumn("dbo.Books", "Title", c => c.String(nullable: false, maxLength: 14));
        }
    }
}
