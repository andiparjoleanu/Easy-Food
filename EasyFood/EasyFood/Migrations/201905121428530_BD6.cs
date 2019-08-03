namespace EasyFood.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class BD6 : DbMigration
    {
        public override void Up()
        {
            AddColumn("dbo.Produse", "Carbohidrati", c => c.Int(nullable: false));
            AddColumn("dbo.Produse", "Proteine", c => c.Int(nullable: false));
            AddColumn("dbo.Produse", "Grasimi", c => c.Int(nullable: false));
            AddColumn("dbo.Produse", "Calorii", c => c.Int(nullable: false));
            DropColumn("dbo.Ingrediente", "Carbohidrati");
            DropColumn("dbo.Ingrediente", "Proteine");
            DropColumn("dbo.Ingrediente", "Grasimi");
            DropColumn("dbo.Ingrediente", "Calorii");
        }
        
        public override void Down()
        {
            AddColumn("dbo.Ingrediente", "Calorii", c => c.Int(nullable: false));
            AddColumn("dbo.Ingrediente", "Grasimi", c => c.Int(nullable: false));
            AddColumn("dbo.Ingrediente", "Proteine", c => c.Int(nullable: false));
            AddColumn("dbo.Ingrediente", "Carbohidrati", c => c.Int(nullable: false));
            DropColumn("dbo.Produse", "Calorii");
            DropColumn("dbo.Produse", "Grasimi");
            DropColumn("dbo.Produse", "Proteine");
            DropColumn("dbo.Produse", "Carbohidrati");
        }
    }
}
