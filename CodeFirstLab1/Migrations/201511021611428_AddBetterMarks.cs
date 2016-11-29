namespace CodeFirstLab1.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class AddBetterMarks : DbMigration
    {
        public override void Up()
        {
            AddColumn("dbo.Blogs", "Marks", c => c.Double(nullable: false));
            AddColumn("dbo.Blogs", "AmountOfMarks", c => c.Int(nullable: false));
            DropColumn("dbo.Blogs", "Mark");
        }
        
        public override void Down()
        {
            AddColumn("dbo.Blogs", "Mark", c => c.Double(nullable: false));
            DropColumn("dbo.Blogs", "AmountOfMarks");
            DropColumn("dbo.Blogs", "Marks");
        }
    }
}
