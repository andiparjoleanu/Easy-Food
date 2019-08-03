namespace EasyFood.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class BazaDeDateProba : DbMigration
    {
        public override void Up()
        {
            AddColumn("dbo.Clienti", "Adresa", c => c.String(nullable: false));
            AlterColumn("dbo.Comenzi", "ModalitatePlata", c => c.String(nullable: false));
            DropColumn("dbo.Retete", "Nuuu");
        }
        
        public override void Down()
        {
            AddColumn("dbo.Retete", "Nuuu", c => c.Single(nullable: false));
            AlterColumn("dbo.Comenzi", "ModalitatePlata", c => c.Int(nullable: false));
            DropColumn("dbo.Clienti", "Adresa");
        }
    }
}
