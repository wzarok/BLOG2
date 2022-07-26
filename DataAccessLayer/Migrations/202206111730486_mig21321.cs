namespace DataAccessLayer.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class mig21321 : DbMigration
    {
        public override void Up()
        {
            AddColumn("dbo.Abouts", "Title1", c => c.String(maxLength: 100));
            AddColumn("dbo.Abouts", "Title2", c => c.String(maxLength: 100));
        }
        
        public override void Down()
        {
            DropColumn("dbo.Abouts", "Title2");
            DropColumn("dbo.Abouts", "Title1");
        }
    }
}
