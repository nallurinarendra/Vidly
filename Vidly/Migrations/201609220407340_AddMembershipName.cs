namespace Vidly.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class AddMembershipName : DbMigration
    {
        public override void Up()
        {
            AddColumn("dbo.Customers", "MembershipTypeName", c => c.String());
        }
        
        public override void Down()
        {
            DropColumn("dbo.Customers", "MembershipTypeName");
        }
    }
}
