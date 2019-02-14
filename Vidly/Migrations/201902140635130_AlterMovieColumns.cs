namespace Vidly.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class AlterMovieColumns : DbMigration
    {
        public override void Up()
        {
            AddColumn("dbo.Movies","Genre",c=>c.Int(nullable:true));
            AddColumn("dbo.Movies","ReleaseDate",c=>c.DateTime(nullable:true));
            AddColumn("dbo.Movies","DateAdded",c=>c.DateTime(nullable:true));
            AddColumn("dbo.Movies","NumberInStock",c=>c.Int(nullable:true));

        }
        
        public override void Down()
        {
        }
    }
}
