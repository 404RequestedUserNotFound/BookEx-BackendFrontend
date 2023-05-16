namespace DAL.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class ReceiptAmmountadded : DbMigration
    {
        public override void Up()
        {
            AddColumn("dbo.Receipts", "Ammount", c => c.Decimal(nullable: false, precision: 18, scale: 2));
        }
        
        public override void Down()
        {
            DropColumn("dbo.Receipts", "Ammount");
        }
    }
}
