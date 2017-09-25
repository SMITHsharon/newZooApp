namespace newZooApp.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class initialState : DbMigration
    {
        public override void Up()
        {
            CreateTable(
                "dbo.Animals",
                c => new
                    {
                        AnimalId = c.Int(nullable: false, identity: true),
                        AnimalType = c.String(nullable: false),
                        SpeciesType = c.Int(nullable: false),
                        CountryOfOrigin = c.String(),
                        ZooKeeperId = c.Int(nullable: false),
                        Environment_EnclosureId = c.Int(),
                    })
                .PrimaryKey(t => t.AnimalId)
                .ForeignKey("dbo.Environments", t => t.Environment_EnclosureId)
                .ForeignKey("dbo.ZooKeepers", t => t.ZooKeeperId, cascadeDelete: true)
                .Index(t => t.ZooKeeperId)
                .Index(t => t.Environment_EnclosureId);
            
            CreateTable(
                "dbo.Environments",
                c => new
                    {
                        EnclosureId = c.Int(nullable: false, identity: true),
                        EnclosureType = c.Int(nullable: false),
                        IndoorEnsloure = c.Boolean(nullable: false),
                        sqFeet = c.Int(nullable: false),
                    })
                .PrimaryKey(t => t.EnclosureId);
            
            CreateTable(
                "dbo.ZooKeepers",
                c => new
                    {
                        ZooKeeperId = c.Int(nullable: false, identity: true),
                        FirstName = c.String(nullable: false),
                        LastName = c.String(nullable: false),
                        FullTime = c.Boolean(nullable: false),
                        StartDate = c.DateTime(nullable: false),
                    })
                .PrimaryKey(t => t.ZooKeeperId);
            
        }
        
        public override void Down()
        {
            DropForeignKey("dbo.Animals", "ZooKeeperId", "dbo.ZooKeepers");
            DropForeignKey("dbo.Animals", "Environment_EnclosureId", "dbo.Environments");
            DropIndex("dbo.Animals", new[] { "Environment_EnclosureId" });
            DropIndex("dbo.Animals", new[] { "ZooKeeperId" });
            DropTable("dbo.ZooKeepers");
            DropTable("dbo.Environments");
            DropTable("dbo.Animals");
        }
    }
}
