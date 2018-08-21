namespace WhyWhere.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class nullable : DbMigration
    {
        public override void Up()
        {
            AddColumn("dbo.Locations", "UserId", c => c.Int());
            AlterColumn("dbo.Locations", "UserRating", c => c.Int());
            DropColumn("dbo.Locations", "User");
        }
        
        public override void Down()
        {
            AddColumn("dbo.Locations", "User", c => c.Int(nullable: false));
            AlterColumn("dbo.Locations", "UserRating", c => c.Int(nullable: false));
            DropColumn("dbo.Locations", "UserId");
        }
    }
}
