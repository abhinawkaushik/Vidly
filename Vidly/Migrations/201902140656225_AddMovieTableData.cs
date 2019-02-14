namespace Vidly.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class AddMovieTableData : DbMigration
    {
        public override void Up()
        {
            Sql("INSERT INTO Movies VALUES('Hangover','01-01-1980',GetDate(),100,1)");
            Sql("INSERT INTO Movies VALUES('Hulk','01-01-1980',GetDate(),60,2)");
            Sql("INSERT INTO Movies VALUES('Transporter','01-01-1980',GetDate(),400,3)");
            Sql("INSERT INTO Movies VALUES('Jumangi','01-01-1980',GetDate(),10,4)");
            Sql("INSERT INTO Movies VALUES('Tata','01-01-1980',GetDate(),40,1)");
        }
        
        public override void Down()
        {
            Sql("TRUNCATE TABLE Movies");
        }
    }
}
