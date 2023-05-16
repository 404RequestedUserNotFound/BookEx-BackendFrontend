namespace DAL.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class ReceiptAmmountaddedmremove : DbMigration
    {
        public override void Up()
        {
            AddColumn("dbo.Receipts", "Amount", c => c.Decimal(nullable: false, precision: 18, scale: 2));
            DropColumn("dbo.Receipts", "Ammount");
        }
        
        public override void Down()
        {
            AddColumn("dbo.Receipts", "Ammount", c => c.Decimal(nullable: false, precision: 18, scale: 2));
            DropColumn("dbo.Receipts", "Amount");
        }
    }
}
