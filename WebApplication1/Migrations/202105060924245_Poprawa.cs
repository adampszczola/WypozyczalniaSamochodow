namespace WebApplication1.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class Poprawa : DbMigration
    {
        public override void Up()
        {
            DropColumn("dbo.Cars", "Dostepnosc");
        }
        
        public override void Down()
        {
            AddColumn("dbo.Cars", "Dostepnosc", c => c.String());
        }
    }
}
