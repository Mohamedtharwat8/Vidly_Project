namespace Vidly_Project.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class firstchangesinitial : DbMigration
    {
        public override void Up()
        {
            DropIndex("dbo.Customers", new[] { "MemberShipTypeId" });
            AddColumn("dbo.Customers", "IsSubscribedToNewsletter", c => c.Boolean(nullable: false));
            AddColumn("dbo.MemberShipTypes", "DurationInMonths", c => c.Byte(nullable: false));
            AlterColumn("dbo.MemberShipTypes", "Name", c => c.String(nullable: false));
            CreateIndex("dbo.Customers", "MembershipTypeId");
            DropColumn("dbo.Customers", "IsSubscribedNewslatter");
            DropColumn("dbo.MemberShipTypes", "DurationsInMonths");
        }
        
        public override void Down()
        {
            AddColumn("dbo.MemberShipTypes", "DurationsInMonths", c => c.Byte(nullable: false));
            AddColumn("dbo.Customers", "IsSubscribedNewslatter", c => c.Boolean(nullable: false));
            DropIndex("dbo.Customers", new[] { "MembershipTypeId" });
            AlterColumn("dbo.MemberShipTypes", "Name", c => c.String());
            DropColumn("dbo.MemberShipTypes", "DurationInMonths");
            DropColumn("dbo.Customers", "IsSubscribedToNewsletter");
            CreateIndex("dbo.Customers", "MemberShipTypeId");
        }
    }
}
