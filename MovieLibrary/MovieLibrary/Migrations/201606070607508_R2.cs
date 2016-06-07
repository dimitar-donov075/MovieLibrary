namespace MovieLibrary.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class R2 : DbMigration
    {
        public override void Up()
        {
            AddColumn("dbo.Animes", "Rating", c => c.String());
        }
        
        public override void Down()
        {
            DropColumn("dbo.Animes", "Rating");
        }
    }
}
