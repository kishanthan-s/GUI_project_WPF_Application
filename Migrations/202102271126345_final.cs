namespace Online_Food_Order_Software.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class final : DbMigration
    {
        public override void Up()
        {
            CreateTable(
                "dbo.promoes",
                c => new
                    {
                        customerID = c.String(nullable: false, maxLength: 128),
                        itemID = c.String(),
                        itemPrice = c.String(),
                        discount = c.String(),
                    })
                .PrimaryKey(t => t.customerID);
            
        }
        
        public override void Down()
        {
            DropTable("dbo.promoes");
        }
    }
}
