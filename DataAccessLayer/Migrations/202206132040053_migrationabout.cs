namespace DataAccessLayer.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class migrationabout : DbMigration
    {
        public override void Up()
        {
            AlterColumn("dbo.Authors", "AuthorAbout", c => c.String(maxLength: 1000));
        }
        
        public override void Down()
        {
            AlterColumn("dbo.Authors", "AuthorAbout", c => c.String(maxLength: 250));
        }
    }
}
