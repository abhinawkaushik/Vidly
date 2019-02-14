namespace Vidly.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class Customers : DbMigration
    {
        public override void Up()
        {
            Sql("INSERT INTO Customers VALUES('Abhinaw',1,0)");
            Sql("INSERT INTO Customers VALUES('Manoj',2,1)");
            Sql("INSERT INTO Customers VALUES('Ritesh',3,0)");
            Sql("INSERT INTO Customers VALUES('Sagar',4,1)");
        }
        
        public override void Down()
        {
            
        }
    }
}
