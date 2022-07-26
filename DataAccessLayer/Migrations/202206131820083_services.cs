namespace DataAccessLayer.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class services : DbMigration
    {
        public override void Up()
        {
            CreateTable(
                "dbo.Services",
                c => new
                    {
                        ServicesID = c.Int(nullable: false, identity: true),
                        Title = c.String(maxLength: 200),
                    })
                .PrimaryKey(t => t.ServicesID);
            
        }
        
        public override void Down()
        {
            DropTable("dbo.Services");
        }
    }
}
