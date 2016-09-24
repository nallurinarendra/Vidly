namespace Vidly.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class UpdatingtheDatainMembershiptypes : DbMigration
    {
        public override void Up()
        {
            Sql("update MembershipTypes SET MembershipTypeName='Monthly' WHERE Id =1 ");
            Sql("update MembershipTypes SET MembershipTypeName='Yearly' WHERE Id =2 ");
            Sql("update MembershipTypes SET MembershipTypeName='Daily' WHERE Id =3 ");
            Sql("update MembershipTypes SET MembershipTypeName='Monthly' WHERE Id =4 ");
        }

        public override void Down()
        {
        }
    }
}
