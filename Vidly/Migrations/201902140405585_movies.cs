namespace Vidly.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class movies : DbMigration
    {
        public override void Up()
        {
            Sql("INSERT INTO Movies VALUES('Hangover')");
            Sql("INSERT INTO Movies VALUES('Hulk')");
            Sql("INSERT INTO Movies VALUES('Transporter')");
            Sql("INSERT INTO Movies VALUES('Jumangi')");
            Sql("INSERT INTO Movies VALUES('Tata')");
        }
        
        public override void Down()
        {
        }
    }
}
