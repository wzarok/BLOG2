namespace DataAccessLayer.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class newmig : DbMigration
    {
        public override void Up()
        {
            AddColumn("dbo.Abouts", "Phone", c => c.String(maxLength: 50));
            AddColumn("dbo.Abouts", "Mail", c => c.String(maxLength: 50));
        }
        
        public override void Down()
        {
            DropColumn("dbo.Abouts", "Mail");
            DropColumn("dbo.Abouts", "Phone");
        }
    }
}
