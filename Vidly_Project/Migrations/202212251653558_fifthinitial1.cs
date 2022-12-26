namespace Vidly_Project.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class fifthinitial1 : DbMigration
    {
        public override void Up()
        {
            AddColumn("dbo.MemberShipTypes", "Name", c => c.String());
        }
        
        public override void Down()
        {
            DropColumn("dbo.MemberShipTypes", "Name");
        }
    }
}
