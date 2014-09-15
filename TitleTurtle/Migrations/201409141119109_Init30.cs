namespace TitleTurtle.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class Init30 : DbMigration
    {
        public override void Up()
        {
            AddColumn("dbo.Articles", "Sex", c => c.String());
            AddColumn("dbo.Articles", "Hight", c => c.String());
            AddColumn("dbo.Articles", "Place", c => c.String());
            AddColumn("dbo.Articles", "Rama", c => c.String());
            AddColumn("dbo.Articles", "MasaRovera", c => c.String());
            AddColumn("dbo.Articles", "Amortizator", c => c.String());
            AddColumn("dbo.Articles", "Speeds", c => c.String());
        }
        
        public override void Down()
        {
            DropColumn("dbo.Articles", "Speeds");
            DropColumn("dbo.Articles", "Amortizator");
            DropColumn("dbo.Articles", "MasaRovera");
            DropColumn("dbo.Articles", "Rama");
            DropColumn("dbo.Articles", "Place");
            DropColumn("dbo.Articles", "Hight");
            DropColumn("dbo.Articles", "Sex");
        }
    }
}
