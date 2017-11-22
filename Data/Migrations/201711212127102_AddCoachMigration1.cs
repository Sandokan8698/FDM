namespace Data.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class AddCoachMigration1 : DbMigration
    {
        public override void Up()
        {
            DropForeignKey("dbo.Coach", "SportId_SportId", "dbo.Sport");
            DropForeignKey("dbo.Coach", "Sport_SportId", "dbo.Sport");
            DropIndex("dbo.Coach", new[] { "Sport_SportId" });
            DropIndex("dbo.Coach", new[] { "SportId_SportId" });
            RenameColumn(table: "dbo.Coach", name: "Sport_SportId", newName: "SportId");
            AlterColumn("dbo.Coach", "SportId", c => c.Int(nullable: false));
            CreateIndex("dbo.Coach", "SportId");
            AddForeignKey("dbo.Coach", "SportId", "dbo.Sport", "SportId", cascadeDelete: true);
            DropColumn("dbo.Coach", "SportId_SportId");
        }
        
        public override void Down()
        {
            AddColumn("dbo.Coach", "SportId_SportId", c => c.Int());
            DropForeignKey("dbo.Coach", "SportId", "dbo.Sport");
            DropIndex("dbo.Coach", new[] { "SportId" });
            AlterColumn("dbo.Coach", "SportId", c => c.Int());
            RenameColumn(table: "dbo.Coach", name: "SportId", newName: "Sport_SportId");
            CreateIndex("dbo.Coach", "SportId_SportId");
            CreateIndex("dbo.Coach", "Sport_SportId");
            AddForeignKey("dbo.Coach", "Sport_SportId", "dbo.Sport", "SportId");
            AddForeignKey("dbo.Coach", "SportId_SportId", "dbo.Sport", "SportId");
        }
    }
}
