namespace MovieLibrary.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class R3 : DbMigration
    {
        public override void Up()
        {
            AddColumn("dbo.TvSeries", "Rating", c => c.String());
        }
        
        public override void Down()
        {
            DropColumn("dbo.TvSeries", "Rating");
        }
    }
}
