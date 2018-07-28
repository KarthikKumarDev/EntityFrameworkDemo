namespace CodeFirstExistingDBDemo.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class AddCategoryColumnToCoursesTable : DbMigration
    {
        public override void Up()
        {
            AddColumn("dbo.Courses", "Category_CategoryId", c => c.Int());
            CreateIndex("dbo.Courses", "Category_CategoryId");
            AddForeignKey("dbo.Courses", "Category_CategoryId", "dbo.Categories", "CategoryId");
            Sql("UPDATE Courses SET Category_CategoryId = 1");
        }
        
        public override void Down()
        {
            DropForeignKey("dbo.Courses", "Category_CategoryId", "dbo.Categories");
            DropIndex("dbo.Courses", new[] { "Category_CategoryId" });
            DropColumn("dbo.Courses", "Category_CategoryId");
        }
    }
}
