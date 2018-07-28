namespace CodeFirstExistingDBDemo.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class PopulateAuthorTable : DbMigration
    {
        public override void Up()
        {
            Sql("INSERT INTO dbo.Authors VALUES ('Karthik')");
        }
        
        public override void Down()
        {
            Sql("DELETE FROM dbo.Authors WHERE Name='Karthik'");
        }
    }
}
