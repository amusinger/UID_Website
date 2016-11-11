namespace Charity.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class NeedHelp : DbMigration
    {
        public override void Up()
        {
            CreateTable(
                "dbo.NeedHelps",
                c => new
                    {
                        NeedHelpId = c.Int(nullable: false, identity: true),
                        FirstName = c.String(nullable: false),
                        LastName = c.String(nullable: false),
                        Phone = c.String(nullable: false),
                        Message = c.String(nullable: false),
                    })
                .PrimaryKey(t => t.NeedHelpId);
            
        }
        
        public override void Down()
        {
            DropTable("dbo.NeedHelps");
        }
    }
}
