namespace CodeFirstLab1.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class AddMark : DbMigration
    {
        public override void Up()
        {
            AddColumn("dbo.Blogs", "Mark", c => c.Double(nullable: false));
        }
        
        public override void Down()
        {
            DropColumn("dbo.Blogs", "Mark");
        }
    }
}
