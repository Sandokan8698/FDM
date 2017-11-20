namespace Data.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class InitialMigration : DbMigration
    {
        public override void Up()
        {
            CreateTable(
                "dbo.Athlete",
                c => new
                    {
                        AthleteId = c.Int(nullable: false, identity: true),
                        Name = c.String(nullable: false, maxLength: 100),
                        FatherSurName = c.String(nullable: false, maxLength: 50),
                        MotherSurName = c.String(nullable: false, maxLength: 50),
                        Sexo = c.Int(nullable: false),
                        BirthDate = c.DateTime(nullable: false, storeType: "date"),
                        CI = c.Int(nullable: false),
                        SportId = c.Int(nullable: false),
                        HomeTown = c.String(nullable: false, maxLength: 100),
                        Address = c.String(maxLength: 100),
                        HomePhone = c.String(),
                        CelularPhone = c.String(),
                        EducativeUnit = c.String(maxLength: 100),
                        Year = c.String(maxLength: 50),
                        Pararell = c.String(maxLength: 50),
                        Rector = c.String(maxLength: 100),
                        Weight = c.Decimal(nullable: false, precision: 18, scale: 2),
                        Height = c.Decimal(nullable: false, precision: 18, scale: 2),
                        BeginDate = c.DateTime(nullable: false, storeType: "date"),
                        RepresentantId = c.Int(nullable: false),
                    })
                .PrimaryKey(t => t.AthleteId)
                .ForeignKey("dbo.Representant", t => t.RepresentantId, cascadeDelete: true)
                .Index(t => t.RepresentantId);
            
            CreateTable(
                "dbo.Representant",
                c => new
                    {
                        RepresentantId = c.Int(nullable: false, identity: true),
                        Name = c.String(),
                        CI = c.Int(nullable: false),
                        Phone = c.String(),
                        Email = c.String(),
                    })
                .PrimaryKey(t => t.RepresentantId);
            
        }
        
        public override void Down()
        {
            DropForeignKey("dbo.Athlete", "RepresentantId", "dbo.Representant");
            DropIndex("dbo.Athlete", new[] { "RepresentantId" });
            DropTable("dbo.Representant");
            DropTable("dbo.Athlete");
        }
    }
}
