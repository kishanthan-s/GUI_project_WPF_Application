namespace Online_Food_Order_Software.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class feed : DbMigration
    {
        public override void Up()
        {
            CreateTable(
                "dbo.Feedbacks",
                c => new
                    {
                        ID = c.String(nullable: false, maxLength: 128),
                        Name = c.String(),
                        Email = c.String(),
                        Phone_number = c.String(),
                        Subject = c.String(),
                        Message = c.String(),
                    })
                .PrimaryKey(t => t.ID);
            
        }
        
        public override void Down()
        {
            DropTable("dbo.Feedbacks");
        }
    }
}
