namespace WebApplication1.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class Dodaniepoladostepnosc : DbMigration
    {
        public override void Up()
        {
            AddColumn("dbo.Cars", "Dostepnosc", c => c.String());
        }
        
        public override void Down()
        {
            DropColumn("dbo.Cars", "Dostepnosc");
        }
    }
}
