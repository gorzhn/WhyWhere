namespace WhyWhere.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class newest1 : DbMigration
    {
        public override void Up()
        {
            DropColumn("dbo.UserReviews", "postId");
        }
        
        public override void Down()
        {
            AddColumn("dbo.UserReviews", "postId", c => c.Int(nullable: false));
        }
    }
}
