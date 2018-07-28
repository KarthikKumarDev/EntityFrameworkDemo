namespace CodeFirstExistingDBDemo.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class RenameTitleToNameInCoursesTable : DbMigration
    {
        public override void Up()
        {
            RenameColumn("dbo.Courses", "Title", "Name");
            AlterColumn("dbo.Courses", "Name", c => c.String(nullable: false));
        }
        
        public override void Down()
        {
            RenameColumn("dbo.Courses", "Name", "Title");
            AlterColumn("dbo.Courses", "Title", c => c.String(nullable: true));
        }
    }
}
