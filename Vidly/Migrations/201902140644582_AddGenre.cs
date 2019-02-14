namespace Vidly.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class AddGenre : DbMigration
    {
        public override void Up()
        {
            CreateTable(
                "dbo.Genres",
                c => new
                    {
                        ID = c.Int(nullable: false, identity: true),
                        Name = c.String(nullable: false, maxLength: 255),
                    })
                .PrimaryKey(t => t.ID);

            Sql("INSERT INTO Genres VALUES ('Romantic')");
            Sql("INSERT INTO Genres VALUES ('Thriller')");
            Sql("INSERT INTO Genres VALUES ('Horror')");
            Sql("INSERT INTO Genres VALUES ('Comedy')");
            
        }
        
        public override void Down()
        {
            DropTable("dbo.Genres");
        }
    }
}
