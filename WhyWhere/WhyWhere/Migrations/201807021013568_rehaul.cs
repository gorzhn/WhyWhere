namespace WhyWhere.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class rehaul : DbMigration
    {
        public override void Up()
        {
            DropTable("dbo.AlCities");
            DropTable("dbo.BgCities");
            DropTable("dbo.EnCities");
            DropTable("dbo.GrCities");
            DropTable("dbo.MkCities");
            DropTable("dbo.SrbCities");
        }
        
        public override void Down()
        {
            CreateTable(
                "dbo.SrbCities",
                c => new
                    {
                        Id = c.Int(nullable: false, identity: true),
                        ImgUrl = c.String(),
                        Name = c.String(),
                        selectedCity = c.String(),
                    })
                .PrimaryKey(t => t.Id);
            
            CreateTable(
                "dbo.MkCities",
                c => new
                    {
                        Id = c.Int(nullable: false, identity: true),
                        ImgUrl = c.String(),
                        Name = c.String(),
                        selectedCity = c.String(),
                    })
                .PrimaryKey(t => t.Id);
            
            CreateTable(
                "dbo.GrCities",
                c => new
                    {
                        Id = c.Int(nullable: false, identity: true),
                        ImgUrl = c.String(),
                        Name = c.String(),
                        selectedCity = c.String(),
                    })
                .PrimaryKey(t => t.Id);
            
            CreateTable(
                "dbo.EnCities",
                c => new
                    {
                        Id = c.Int(nullable: false, identity: true),
                        ImgUrl = c.String(),
                        Name = c.String(),
                        selectedCity = c.String(),
                    })
                .PrimaryKey(t => t.Id);
            
            CreateTable(
                "dbo.BgCities",
                c => new
                    {
                        Id = c.Int(nullable: false, identity: true),
                        ImgUrl = c.String(),
                        Name = c.String(),
                        selectedCity = c.String(),
                    })
                .PrimaryKey(t => t.Id);
            
            CreateTable(
                "dbo.AlCities",
                c => new
                    {
                        Id = c.Int(nullable: false, identity: true),
                        ImgUrl = c.String(),
                        Name = c.String(),
                        selectedCity = c.String(),
                    })
                .PrimaryKey(t => t.Id);
            
        }
    }
}
