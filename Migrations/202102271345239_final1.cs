namespace Online_Food_Order_Software.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class final1 : DbMigration
    {
        public override void Up()
        {
            DropPrimaryKey("dbo.promoes");
            AlterColumn("dbo.promoes", "itemID", c => c.String(nullable: false, maxLength: 128));
            AddPrimaryKey("dbo.promoes", new[] { "customerID", "itemID" });
        }
        
        public override void Down()
        {
            DropPrimaryKey("dbo.promoes");
            AlterColumn("dbo.promoes", "itemID", c => c.String());
            AddPrimaryKey("dbo.promoes", "customerID");
        }
    }
}
