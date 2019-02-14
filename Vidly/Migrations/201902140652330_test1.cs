namespace Vidly.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class test1 : DbMigration
    {
        public override void Up()
        {
            AddColumn("dbo.Movies", "GenreID", c => c.Int(nullable: false));
            CreateIndex("dbo.Movies", "GenreID");
            //AddForeignKey("dbo.Movies", "GenreID", "dbo.Genres", "ID", cascadeDelete: true);
        }
        
        public override void Down()
        {
            DropForeignKey("dbo.Movies", "GenreID", "dbo.Genres");
            DropIndex("dbo.Movies", new[] { "GenreID" });
            DropColumn("dbo.Movies", "GenreID");
        }
    }
}
