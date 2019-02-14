namespace Vidly.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class AddNameValueToMembership : DbMigration
    {
        public override void Up()
        {
            Sql("UPDATE MembershipTypes SET Name = (CASE WHEN ID=1 THEN 'Pay as You Go' WHEN ID=2 THEN 'Monthly' WHEN ID=3 THEN 'Quarterly' WHEN ID=4 THEN 'Yearly' END)");
        }
        
        public override void Down()
        {
            Sql("UPDATE MembershipTypes SET Name = NULL");
        }
    }
}
