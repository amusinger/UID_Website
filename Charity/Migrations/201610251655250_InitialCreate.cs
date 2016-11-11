namespace Charity.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class InitialCreate : DbMigration
    {
        public override void Up()
        {
            CreateTable(
                "dbo.CanHelps",
                c => new
                    {
                        CanHelpId = c.Int(nullable: false, identity: true),
                        FirstName = c.String(nullable: false),
                        LastName = c.String(nullable: false),
                        Email = c.String(nullable: false),
                        CreditCard = c.String(nullable: false),
                        CV = c.Int(nullable: false),
                        Amount = c.Int(nullable: false),
                    })
                .PrimaryKey(t => t.CanHelpId);
            
        }
        
        public override void Down()
        {
            DropTable("dbo.CanHelps");
        }
    }
}
