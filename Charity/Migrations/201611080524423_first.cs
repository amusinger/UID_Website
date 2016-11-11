namespace Charity.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class first : DbMigration
    {
        public override void Up()
        {
            AlterColumn("dbo.CanHelps", "FirstName", c => c.String());
            AlterColumn("dbo.CanHelps", "LastName", c => c.String());
        }
        
        public override void Down()
        {
            AlterColumn("dbo.CanHelps", "LastName", c => c.String(nullable: false));
            AlterColumn("dbo.CanHelps", "FirstName", c => c.String(nullable: false));
        }
    }
}
