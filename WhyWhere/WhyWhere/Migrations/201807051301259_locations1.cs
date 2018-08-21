namespace WhyWhere.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class locations1 : DbMigration
    {
        public override void Up()
        {
            CreateTable(
                "dbo.Locations",
                c => new
                    {
                        Id = c.Int(nullable: false, identity: true),
                        City = c.String(nullable: false),
                        ImgUrl = c.String(nullable: false),
                        Name = c.String(nullable: false),
                        Description = c.String(),
                        UserId = c.Int(nullable: false),
                        UserRating = c.Int(nullable: false),
                    })
                .PrimaryKey(t => t.Id);
            
        }
        
        public override void Down()
        {
            DropTable("dbo.Locations");
        }
    }
}
