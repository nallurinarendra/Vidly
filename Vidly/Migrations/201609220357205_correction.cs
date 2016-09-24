namespace Vidly.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class correction : DbMigration
    {
        public override void Up()
        {
            AddColumn("dbo.Customers", "IsSubscribedtonewsLetter", c => c.Boolean(nullable: false));
            DropColumn("dbo.Customers", "IsSubscibedtonewsLetter");
        }
        
        public override void Down()
        {
            AddColumn("dbo.Customers", "IsSubscibedtonewsLetter", c => c.Boolean(nullable: false));
            DropColumn("dbo.Customers", "IsSubscribedtonewsLetter");
        }
    }
}
