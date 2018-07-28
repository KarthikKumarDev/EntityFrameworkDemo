namespace CodeFirstExistingDBDemo.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class AddCategoriesTable : DbMigration
    {
        public override void Up()
        {
            CreateTable(
                "dbo.Categories",
                c => new
                    {
                        CategoryId = c.Int(nullable: false, identity: true),
                        Name = c.String(),
                    })
                .PrimaryKey(t => t.CategoryId);
            Sql("INSERT INTO Categories (Name) VALUES ('Web Development')");
            Sql("INSERT INTO Categories (Name) VALUES ('BigData')");
        }
        
        public override void Down()
        {
            DropTable("dbo.Categories");
        }
    }
}
