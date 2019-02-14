namespace Vidly.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class DropColumnGenre : DbMigration
    {
        public override void Up()
        {
            DropColumn("dbo.Movies","Genre");
        }
        
        public override void Down()
        {
        }
    }
}
