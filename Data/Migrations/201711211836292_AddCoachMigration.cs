namespace Data.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class AddCoachMigration : DbMigration
    {
        public override void Up()
        {
            CreateTable(
                "dbo.Coach",
                c => new
                    {
                        CoachId = c.Int(nullable: false, identity: true),
                        Name = c.String(nullable: false, maxLength: 100),
                        LatName = c.String(nullable: false, maxLength: 100),
                        CI = c.Int(nullable: false),
                        HomeTown = c.String(nullable: false),
                        Sport_SportId = c.Int(),
                        SportId_SportId = c.Int(),
                    })
                .PrimaryKey(t => t.CoachId)
                .ForeignKey("dbo.Sport", t => t.Sport_SportId)
                .ForeignKey("dbo.Sport", t => t.SportId_SportId)
                .Index(t => t.Sport_SportId)
                .Index(t => t.SportId_SportId);
            
        }
        
        public override void Down()
        {
            DropForeignKey("dbo.Coach", "SportId_SportId", "dbo.Sport");
            DropForeignKey("dbo.Coach", "Sport_SportId", "dbo.Sport");
            DropIndex("dbo.Coach", new[] { "SportId_SportId" });
            DropIndex("dbo.Coach", new[] { "Sport_SportId" });
            DropTable("dbo.Coach");
        }
    }
}
