namespace DataAccessLayer.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class mig8 : DbMigration
    {
        public override void Up()
        {
            DropColumn("dbo.Blogs", "deneme");
        }
        
        public override void Down()
        {
            AddColumn("dbo.Blogs", "deneme", c => c.Int(nullable: false));
        }
    }
}
