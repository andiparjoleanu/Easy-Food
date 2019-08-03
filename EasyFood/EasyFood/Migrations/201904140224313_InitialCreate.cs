namespace EasyFood.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class InitialCreate : DbMigration
    {
        public override void Up()
        {
            CreateTable(
                "dbo.Administratori",
                c => new
                    {
                        AngajatID = c.Int(nullable: false),
                        NumeUtilizator = c.String(nullable: false),
                        Parola = c.String(nullable: false),
                    })
                .PrimaryKey(t => t.AngajatID)
                .ForeignKey("dbo.Angajati", t => t.AngajatID)
                .Index(t => t.AngajatID);
            
            CreateTable(
                "dbo.Angajati",
                c => new
                    {
                        ID = c.Int(nullable: false, identity: true),
                        Nume = c.String(nullable: false),
                        Prenume = c.String(nullable: false),
                    })
                .PrimaryKey(t => t.ID);
            
            CreateTable(
                "dbo.Bucatari",
                c => new
                    {
                        AngajatID = c.Int(nullable: false),
                        Pregatire = c.String(nullable: false),
                        Specializare = c.String(nullable: false),
                        Rating = c.Single(nullable: false),
                        LinkPoza = c.String(nullable: false),
                    })
                .PrimaryKey(t => t.AngajatID)
                .ForeignKey("dbo.Angajati", t => t.AngajatID)
                .Index(t => t.AngajatID);
            
            CreateTable(
                "dbo.Retete",
                c => new
                    {
                        RetetaID = c.Int(nullable: false, identity: true),
                        Denumire = c.String(nullable: false),
                        Descriere = c.String(nullable: false),
                        Stoc = c.Int(nullable: false),
                        Pret = c.Single(nullable: false),
                        Nuuu = c.Single(nullable: false),
                        LinkImaginePrezentare = c.String(nullable: false),
                        NivelDificultate = c.Int(nullable: false),
                        TimpPreparare = c.Int(nullable: false),
                        Categorie = c.String(nullable: false),
                        LinkVideo = c.String(),
                        Bucatar_AngajatID = c.Int(),
                    })
                .PrimaryKey(t => t.RetetaID)
                .ForeignKey("dbo.Bucatari", t => t.Bucatar_AngajatID)
                .Index(t => t.Bucatar_AngajatID);
            
            CreateTable(
                "dbo.Comenzi",
                c => new
                    {
                        ComandaID = c.Int(nullable: false, identity: true),
                        DataComanda = c.DateTime(nullable: false),
                        DataLivrare = c.DateTime(nullable: false),
                        ModalitatePlata = c.Int(nullable: false),
                        Client_ID = c.Int(),
                    })
                .PrimaryKey(t => t.ComandaID)
                .ForeignKey("dbo.Clienti", t => t.Client_ID)
                .Index(t => t.Client_ID);
            
            CreateTable(
                "dbo.Clienti",
                c => new
                    {
                        ID = c.Int(nullable: false, identity: true),
                        Nume = c.String(nullable: false),
                        Prenume = c.String(nullable: false),
                        Email = c.String(nullable: false),
                        DataNasterii = c.DateTime(nullable: false),
                        Parola = c.String(nullable: false),
                        LinkPoza = c.String(),
                    })
                .PrimaryKey(t => t.ID);
            
            CreateTable(
                "dbo.Carduri",
                c => new
                    {
                        ID = c.Int(nullable: false, identity: true),
                        NumarCard = c.String(nullable: false),
                        DataExpirare = c.DateTime(nullable: false),
                        CVV = c.String(nullable: false),
                        Posesor = c.String(nullable: false),
                        Client_ID = c.Int(),
                    })
                .PrimaryKey(t => t.ID)
                .ForeignKey("dbo.Clienti", t => t.Client_ID)
                .Index(t => t.Client_ID);
            
            CreateTable(
                "dbo.Produse",
                c => new
                    {
                        ID = c.Int(nullable: false, identity: true),
                        Denumire = c.String(nullable: false),
                        Furnizor = c.String(nullable: false),
                        Stoc = c.Single(nullable: false),
                        UnitateMasura = c.String(nullable: false),
                    })
                .PrimaryKey(t => t.ID);
            
            CreateTable(
                "dbo.ComandaReteta",
                c => new
                    {
                        ComandaID = c.Int(nullable: false),
                        RetetaID = c.Int(nullable: false),
                    })
                .PrimaryKey(t => new { t.ComandaID, t.RetetaID })
                .ForeignKey("dbo.Comenzi", t => t.ComandaID, cascadeDelete: true)
                .ForeignKey("dbo.Retete", t => t.RetetaID, cascadeDelete: true)
                .Index(t => t.ComandaID)
                .Index(t => t.RetetaID);
            
        }
        
        public override void Down()
        {
            DropForeignKey("dbo.Administratori", "AngajatID", "dbo.Angajati");
            DropForeignKey("dbo.ComandaReteta", "RetetaID", "dbo.Retete");
            DropForeignKey("dbo.ComandaReteta", "ComandaID", "dbo.Comenzi");
            DropForeignKey("dbo.Comenzi", "Client_ID", "dbo.Clienti");
            DropForeignKey("dbo.Carduri", "Client_ID", "dbo.Clienti");
            DropForeignKey("dbo.Retete", "Bucatar_AngajatID", "dbo.Bucatari");
            DropForeignKey("dbo.Bucatari", "AngajatID", "dbo.Angajati");
            DropIndex("dbo.ComandaReteta", new[] { "RetetaID" });
            DropIndex("dbo.ComandaReteta", new[] { "ComandaID" });
            DropIndex("dbo.Carduri", new[] { "Client_ID" });
            DropIndex("dbo.Comenzi", new[] { "Client_ID" });
            DropIndex("dbo.Retete", new[] { "Bucatar_AngajatID" });
            DropIndex("dbo.Bucatari", new[] { "AngajatID" });
            DropIndex("dbo.Administratori", new[] { "AngajatID" });
            DropTable("dbo.ComandaReteta");
            DropTable("dbo.Produse");
            DropTable("dbo.Carduri");
            DropTable("dbo.Clienti");
            DropTable("dbo.Comenzi");
            DropTable("dbo.Retete");
            DropTable("dbo.Bucatari");
            DropTable("dbo.Angajati");
            DropTable("dbo.Administratori");
        }
    }
}
