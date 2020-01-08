namespace Anticafe.Model.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class InitialCreate : DbMigration
    {
        public override void Up()
        {
            CreateTable(
                "dbo.AdministratorInfo",
                c => new
                    {
                        ID = c.Int(nullable: false, identity: true),
                        Login = c.String(),
                        Password = c.String(),
                        NumberCard = c.String(),
                        FirstName = c.String(),
                        SecondName = c.String(),
                        MiddleName = c.String(),
                        BDay = c.DateTime(nullable: false),
                        Email = c.String(),
                        Phone = c.String(),
                    })
                .PrimaryKey(t => t.ID);
            
            CreateTable(
                "dbo.GuestInfo",
                c => new
                    {
                        ID = c.Int(nullable: false, identity: true),
                        NumberCard = c.String(),
                        SecondName = c.String(),
                        FirstName = c.String(),
                        MiddleName = c.String(),
                        Discount = c.Int(nullable: false),
                        BDay = c.DateTime(nullable: false),
                        Email = c.String(),
                        Phone = c.String(),
                    })
                .PrimaryKey(t => t.ID);
            
            CreateTable(
                "dbo.Guest",
                c => new
                    {
                        ID = c.Int(nullable: false, identity: true),
                        Last_Input = c.DateTime(nullable: false),
                        Last_Output = c.DateTime(nullable: false),
                        GuestInfoID = c.Int(nullable: false),
                    })
                .PrimaryKey(t => t.ID)
                .ForeignKey("dbo.GuestInfo", t => t.GuestInfoID, cascadeDelete: true)
                .Index(t => t.GuestInfoID);
            
            CreateTable(
                "dbo.Visits",
                c => new
                    {
                        ID = c.Int(nullable: false, identity: true),
                        Input = c.DateTime(nullable: false),
                        Output = c.DateTime(nullable: false),
                    })
                .PrimaryKey(t => t.ID);
            
        }
        
        public override void Down()
        {
            DropForeignKey("dbo.Guest", "GuestInfoID", "dbo.GuestInfo");
            DropIndex("dbo.Guest", new[] { "GuestInfoID" });
            DropTable("dbo.Visits");
            DropTable("dbo.Guest");
            DropTable("dbo.GuestInfo");
            DropTable("dbo.AdministratorInfo");
        }
    }
}
