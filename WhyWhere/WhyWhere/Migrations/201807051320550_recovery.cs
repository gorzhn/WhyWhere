namespace WhyWhere.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class recovery : DbMigration
    {
        public override void Up()
        {
            AddColumn("dbo.Locations", "User", c => c.Int(nullable: false));
            DropColumn("dbo.Locations", "UserId");
        }
        
        public override void Down()
        {
            AddColumn("dbo.Locations", "UserId", c => c.Int(nullable: false));
            DropColumn("dbo.Locations", "User");
        }
    }
}
