namespace WhyWhere.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class newest : DbMigration
    {
        public override void Up()
        {
            AddColumn("dbo.UserReviews", "Name", c => c.String());
        }
        
        public override void Down()
        {
            DropColumn("dbo.UserReviews", "Name");
        }
    }
}
