namespace WhyWhere.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class justendmealready : DbMigration
    {
        public override void Up()
        {
            CreateTable(
                "dbo.AddUserToRoles",
                c => new
                    {
                        Id = c.Int(nullable: false, identity: true),
                        IdFortaking = c.Int(nullable: false),
                        Email = c.String(),
                        selectedRole = c.String(),
                    })
                .PrimaryKey(t => t.Id);
            
        }
        
        public override void Down()
        {
            DropTable("dbo.AddUserToRoles");
        }
    }
}
