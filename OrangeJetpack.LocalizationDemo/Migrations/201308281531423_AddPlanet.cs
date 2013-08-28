namespace OrangeJetpack.LocalizationDemo.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class AddPlanet : DbMigration
    {
        public override void Up()
        {
            CreateTable(
                "dbo.Planets",
                c => new
                    {
                        PlanetId = c.Int(nullable: false, identity: true),
                        Name = c.String(nullable: false),
                    })
                .PrimaryKey(t => t.PlanetId);
            
        }
        
        public override void Down()
        {
            DropTable("dbo.Planets");
        }
    }
}
