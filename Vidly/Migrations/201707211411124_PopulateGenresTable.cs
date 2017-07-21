namespace Vidly.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class PopulateGenresTable : DbMigration
    {
        public override void Up()
        {
            Sql("INSERT INTO Genres (Name) VALUES ('Horror')");
            Sql("INSERT INTO Genres (Name) VALUES ('Documentary')");
            Sql("INSERT INTO Genres (Name) VALUES ('Action')");
        }
        
        public override void Down()
        {
        }
    }
}
