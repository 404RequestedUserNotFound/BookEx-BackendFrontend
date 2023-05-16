namespace DAL.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class authorvalidation : DbMigration
    {
        public override void Up()
        {
            AlterColumn("dbo.Authors", "AuthorName", c => c.String(nullable: false, maxLength: 25));
        }
        
        public override void Down()
        {
            AlterColumn("dbo.Authors", "AuthorName", c => c.String());
        }
    }
}
