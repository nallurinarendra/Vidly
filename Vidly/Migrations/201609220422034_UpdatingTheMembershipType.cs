namespace Vidly.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class UpdatingTheMembershipType : DbMigration
    {
        public override void Up()
        {
            AddColumn("dbo.MembershipTypes", "MembershipTypeName", c => c.String());
            DropColumn("dbo.Customers", "MembershipTypeName");
            DropColumn("dbo.MembershipTypes", "DiscountRate");
        }
        
        public override void Down()
        {
            AddColumn("dbo.MembershipTypes", "DiscountRate", c => c.Byte(nullable: false));
            AddColumn("dbo.Customers", "MembershipTypeName", c => c.String());
            DropColumn("dbo.MembershipTypes", "MembershipTypeName");
        }
    }
}
