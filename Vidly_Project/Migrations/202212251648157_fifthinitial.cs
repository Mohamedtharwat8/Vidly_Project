namespace Vidly_Project.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class fifthinitial : DbMigration
    {
        public override void Up()
        {
            AddColumn("dbo.Movies", "GennreId", c => c.Byte(nullable: false));
            AddColumn("dbo.Movies", "DateAdded", c => c.DateTime(nullable: false));
            AddColumn("dbo.Movies", "releaseDate", c => c.DateTime(nullable: false));
            AddColumn("dbo.Movies", "Numberinstock", c => c.DateTime(nullable: false));
            AlterColumn("dbo.Movies", "name", c => c.String(nullable: false, maxLength: 255));
        }
        
        public override void Down()
        {
            AlterColumn("dbo.Movies", "name", c => c.String());
            DropColumn("dbo.Movies", "Numberinstock");
            DropColumn("dbo.Movies", "releaseDate");
            DropColumn("dbo.Movies", "DateAdded");
            DropColumn("dbo.Movies", "GennreId");
        }
    }
}
