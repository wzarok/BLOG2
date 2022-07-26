namespace DataAccessLayer.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class migrationdesc : DbMigration
    {
        public override void Up()
        {
            AddColumn("dbo.Categories", "CategoryDetails", c => c.String(maxLength: 100));
        }
        
        public override void Down()
        {
            DropColumn("dbo.Categories", "CategoryDetails");
        }
    }
}
