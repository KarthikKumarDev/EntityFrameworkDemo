namespace CodeFirstExistingDBDemo.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class RenamedCategoryIdColumnInCategoryTable : DbMigration
    {
        public override void Up()
        {
            DropForeignKey("dbo.Courses", "Category_CategoryId", "dbo.Categories");
            RenameColumn(table: "dbo.Courses", name: "Category_CategoryId", newName: "Category_Id");
            RenameIndex(table: "dbo.Courses", name: "IX_Category_CategoryId", newName: "IX_Category_Id");
            DropPrimaryKey("dbo.Categories");
            DropColumn("dbo.Categories", "CategoryId");
            AddColumn("dbo.Categories", "Id", c => c.Int(nullable: false, identity: true));
            AddPrimaryKey("dbo.Categories", "Id");
            AddForeignKey("dbo.Courses", "Category_Id", "dbo.Categories", "Id");            
        }
        
        public override void Down()
        {
            AddColumn("dbo.Categories", "CategoryId", c => c.Int(nullable: false, identity: true));
            DropForeignKey("dbo.Courses", "Category_Id", "dbo.Categories");
            DropPrimaryKey("dbo.Categories");
            DropColumn("dbo.Categories", "Id");
            AddPrimaryKey("dbo.Categories", "CategoryId");
            RenameIndex(table: "dbo.Courses", name: "IX_Category_Id", newName: "IX_Category_CategoryId");
            RenameColumn(table: "dbo.Courses", name: "Category_Id", newName: "Category_CategoryId");
            AddForeignKey("dbo.Courses", "Category_CategoryId", "dbo.Categories", "CategoryId");
        }
    }
}
