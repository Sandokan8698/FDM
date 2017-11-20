namespace Data.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class ChangeAthlete : DbMigration
    {
        public override void Up()
        {
            DropForeignKey("dbo.Athlete", "RepresentantId", "dbo.Representant");
            DropIndex("dbo.Athlete", new[] { "RepresentantId" });
            AlterColumn("dbo.Athlete", "RepresentantId", c => c.Int());
            CreateIndex("dbo.Athlete", "RepresentantId");
            AddForeignKey("dbo.Athlete", "RepresentantId", "dbo.Representant", "RepresentantId");
        }
        
        public override void Down()
        {
            DropForeignKey("dbo.Athlete", "RepresentantId", "dbo.Representant");
            DropIndex("dbo.Athlete", new[] { "RepresentantId" });
            AlterColumn("dbo.Athlete", "RepresentantId", c => c.Int(nullable: false));
            CreateIndex("dbo.Athlete", "RepresentantId");
            AddForeignKey("dbo.Athlete", "RepresentantId", "dbo.Representant", "RepresentantId", cascadeDelete: true);
        }
    }
}
