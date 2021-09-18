namespace Online_Food_Order_Software.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class all : DbMigration
    {
        public override void Up()
        {
            CreateTable(
                "dbo.Class1",
                c => new
                    {
                        Cart_ID1 = c.Int(nullable: false, identity: true),
                        Customer_Name = c.String(),
                        Item_ID = c.String(),
                        Item_Name = c.String(),
                        Item_Prize = c.Int(nullable: false),
                        Quantity = c.Int(nullable: false),
                        Total_prize = c.Int(nullable: false),
                        Buy_Scussess = c.Int(nullable: false),
                    })
                .PrimaryKey(t => t.Cart_ID1);
            
            CreateTable(
                "dbo.Delivery1",
                c => new
                    {
                        Delivery_ID1 = c.Int(nullable: false, identity: true),
                        User_name = c.String(),
                        Customer_ID = c.String(),
                        Customer_Name = c.String(),
                        Email = c.String(),
                        Door_No = c.String(),
                        Apartment_Name = c.String(),
                        Street_name = c.String(),
                        Landmark = c.String(),
                        City = c.String(),
                        Province = c.String(),
                        Place = c.String(),
                    })
                .PrimaryKey(t => t.Delivery_ID1);
            
            CreateTable(
                "dbo.Payments",
                c => new
                    {
                        Payment_ID = c.Int(nullable: false, identity: true),
                        User_Name = c.String(),
                        Card_Holder_Name = c.String(),
                        Payment_Method = c.String(),
                        Card_Type = c.String(),
                        Card_Number = c.String(),
                        Expire_Month = c.String(),
                        Expire_Year = c.String(),
                        Security_Code = c.String(),
                        Payment_Date = c.String(),
                    })
                .PrimaryKey(t => t.Payment_ID);
            
            CreateTable(
                "dbo.Supliers",
                c => new
                    {
                        Suplier_ID = c.Int(nullable: false),
                        Name = c.String(),
                        Contact_No = c.String(),
                        Vehical_No = c.String(),
                        Province = c.String(),
                    })
                .PrimaryKey(t => t.Suplier_ID);
            
        }
        
        public override void Down()
        {
            DropTable("dbo.Supliers");
            DropTable("dbo.Payments");
            DropTable("dbo.Delivery1");
            DropTable("dbo.Class1");
        }
    }
}
