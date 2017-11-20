namespace Data.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class InitSport : DbMigration
    {
        public override void Up()
        {
            CreateTable(
                "dbo.Sport",
                c => new
                    {
                        SportId = c.Int(nullable: false, identity: true),
                        Name = c.String(nullable: false, maxLength: 100),
                    })
                .PrimaryKey(t => t.SportId);
            
            CreateIndex("dbo.Athlete", "SportId");
            AddForeignKey("dbo.Athlete", "SportId", "dbo.Sport", "SportId", cascadeDelete: true);
        }
        
        public override void Down()
        {
            DropForeignKey("dbo.Athlete", "SportId", "dbo.Sport");
            DropIndex("dbo.Athlete", new[] { "SportId" });
            DropTable("dbo.Sport");
        }
    }
}
