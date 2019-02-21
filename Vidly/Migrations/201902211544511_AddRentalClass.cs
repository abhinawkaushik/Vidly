namespace Vidly.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class AddRentalClass : DbMigration
    {
        public override void Up()
        {
            CreateTable(
                "dbo.Rentals",
                c => new
                    {
                        ID = c.Int(nullable: false, identity: true),
                        DateRented = c.DateTime(nullable: false),
                        DateReturned = c.DateTime(),
                        Customer_ID = c.Int(nullable: false),
                        Movie_ID = c.Int(),
                    })
                .PrimaryKey(t => t.ID)
                .ForeignKey("dbo.Customers", t => t.Customer_ID, cascadeDelete: true)
                .ForeignKey("dbo.Movies", t => t.Movie_ID)
                .Index(t => t.Customer_ID)
                .Index(t => t.Movie_ID);
            
        }
        
        public override void Down()
        {
            DropForeignKey("dbo.Rentals", "Movie_ID", "dbo.Movies");
            DropForeignKey("dbo.Rentals", "Customer_ID", "dbo.Customers");
            DropIndex("dbo.Rentals", new[] { "Movie_ID" });
            DropIndex("dbo.Rentals", new[] { "Customer_ID" });
            DropTable("dbo.Rentals");
        }
    }
}
