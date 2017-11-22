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
                        RepresentantId = c.Int(),
                    })
                .PrimaryKey(t => t.AthleteId)
                .ForeignKey("dbo.Representant", t => t.RepresentantId)
                .ForeignKey("dbo.Sport", t => t.SportId, cascadeDelete: true)
                .Index(t => t.SportId)
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
            
            CreateTable(
                "dbo.Sport",
                c => new
                    {
                        SportId = c.Int(nullable: false, identity: true),
                        Name = c.String(nullable: false, maxLength: 100),
                    })
                .PrimaryKey(t => t.SportId);
            
            CreateTable(
                "dbo.AppUser",
                c => new
                    {
                        Id = c.String(nullable: false, maxLength: 128),
                        Email = c.String(),
                        EmailConfirmed = c.Boolean(nullable: false),
                        PasswordHash = c.String(),
                        SecurityStamp = c.String(),
                        PhoneNumber = c.String(),
                        PhoneNumberConfirmed = c.Boolean(nullable: false),
                        TwoFactorEnabled = c.Boolean(nullable: false),
                        LockoutEndDateUtc = c.DateTime(),
                        LockoutEnabled = c.Boolean(nullable: false),
                        AccessFailedCount = c.Int(nullable: false),
                        UserName = c.String(),
                    })
                .PrimaryKey(t => t.Id);
            
            CreateTable(
                "dbo.IdentityUserClaim",
                c => new
                    {
                        Id = c.Int(nullable: false, identity: true),
                        UserId = c.String(),
                        ClaimType = c.String(),
                        ClaimValue = c.String(),
                        AppUser_Id = c.String(maxLength: 128),
                    })
                .PrimaryKey(t => t.Id)
                .ForeignKey("dbo.AppUser", t => t.AppUser_Id)
                .Index(t => t.AppUser_Id);
            
            CreateTable(
                "dbo.IdentityUserLogin",
                c => new
                    {
                        UserId = c.String(nullable: false, maxLength: 128),
                        LoginProvider = c.String(),
                        ProviderKey = c.String(),
                        AppUser_Id = c.String(maxLength: 128),
                    })
                .PrimaryKey(t => t.UserId)
                .ForeignKey("dbo.AppUser", t => t.AppUser_Id)
                .Index(t => t.AppUser_Id);
            
            CreateTable(
                "dbo.IdentityUserRole",
                c => new
                    {
                        RoleId = c.String(nullable: false, maxLength: 128),
                        UserId = c.String(nullable: false, maxLength: 128),
                        IdentityRole_Id = c.String(maxLength: 128),
                        AppUser_Id = c.String(maxLength: 128),
                    })
                .PrimaryKey(t => new { t.RoleId, t.UserId })
                .ForeignKey("dbo.IdentityRole", t => t.IdentityRole_Id)
                .ForeignKey("dbo.AppUser", t => t.AppUser_Id)
                .Index(t => t.IdentityRole_Id)
                .Index(t => t.AppUser_Id);
            
            CreateTable(
                "dbo.IdentityRole",
                c => new
                    {
                        Id = c.String(nullable: false, maxLength: 128),
                        Name = c.String(),
                    })
                .PrimaryKey(t => t.Id);
            
            CreateTable(
                "dbo.Coach",
                c => new
                    {
                        Id = c.String(nullable: false, maxLength: 128),
                        SportId = c.Int(nullable: false),
                        Name = c.String(nullable: false, maxLength: 100),
                        LatName = c.String(nullable: false, maxLength: 100),
                        CI = c.Int(nullable: false),
                        HomeTown = c.String(nullable: false),
                    })
                .PrimaryKey(t => t.Id)
                .ForeignKey("dbo.AppUser", t => t.Id)
                .ForeignKey("dbo.Sport", t => t.SportId, cascadeDelete: true)
                .Index(t => t.Id)
                .Index(t => t.SportId);
            
            CreateTable(
                "dbo.Worker",
                c => new
                    {
                        Id = c.String(nullable: false, maxLength: 128),
                        IsGay = c.Boolean(nullable: false),
                    })
                .PrimaryKey(t => t.Id)
                .ForeignKey("dbo.AppUser", t => t.Id)
                .Index(t => t.Id);
            
        }
        
        public override void Down()
        {
            DropForeignKey("dbo.Worker", "Id", "dbo.AppUser");
            DropForeignKey("dbo.Coach", "SportId", "dbo.Sport");
            DropForeignKey("dbo.Coach", "Id", "dbo.AppUser");
            DropForeignKey("dbo.IdentityUserRole", "AppUser_Id", "dbo.AppUser");
            DropForeignKey("dbo.IdentityUserLogin", "AppUser_Id", "dbo.AppUser");
            DropForeignKey("dbo.IdentityUserClaim", "AppUser_Id", "dbo.AppUser");
            DropForeignKey("dbo.IdentityUserRole", "IdentityRole_Id", "dbo.IdentityRole");
            DropForeignKey("dbo.Athlete", "SportId", "dbo.Sport");
            DropForeignKey("dbo.Athlete", "RepresentantId", "dbo.Representant");
            DropIndex("dbo.Worker", new[] { "Id" });
            DropIndex("dbo.Coach", new[] { "SportId" });
            DropIndex("dbo.Coach", new[] { "Id" });
            DropIndex("dbo.IdentityUserRole", new[] { "AppUser_Id" });
            DropIndex("dbo.IdentityUserRole", new[] { "IdentityRole_Id" });
            DropIndex("dbo.IdentityUserLogin", new[] { "AppUser_Id" });
            DropIndex("dbo.IdentityUserClaim", new[] { "AppUser_Id" });
            DropIndex("dbo.Athlete", new[] { "RepresentantId" });
            DropIndex("dbo.Athlete", new[] { "SportId" });
            DropTable("dbo.Worker");
            DropTable("dbo.Coach");
            DropTable("dbo.IdentityRole");
            DropTable("dbo.IdentityUserRole");
            DropTable("dbo.IdentityUserLogin");
            DropTable("dbo.IdentityUserClaim");
            DropTable("dbo.AppUser");
            DropTable("dbo.Sport");
            DropTable("dbo.Representant");
            DropTable("dbo.Athlete");
        }
    }
}
