namespace EasyFood.Migrations
{
    using EasyFood.Models;
    using System;
    using System.Collections.Generic;
    using System.Data.Entity;
    using System.Data.Entity.Migrations;
    using System.Linq;

    internal sealed class Configuration : DbMigrationsConfiguration<EasyFood.DAL.EasyFoodContext>
    {
        public Configuration()
        {
            AutomaticMigrationsEnabled = true;
        }

        protected override void Seed(EasyFood.DAL.EasyFoodContext context)
        {
            var produse = new List<Produs>
            {
                new Produs
                {
                    Denumire = "Făină",
                    Furnizor = "Baneasa",
                    Stoc = 10F,
                    UnitateMasura = "Kg"
                },
                new Produs
                {
                    Denumire = "Lapte",
                    Furnizor = "Danone",
                    Stoc = 12F,
                    UnitateMasura = "L"
                },
                new Produs
                {
                    Denumire = "Ou",
                    Furnizor = "Slovenski Izdlek",
                    Stoc = 100F,
                    UnitateMasura = "Buc"
                },
                new Produs
                {
                    Denumire = "Cartof Dulce",
                    Furnizor = "Nedefinit",
                    Stoc = 300F,
                    UnitateMasura = "Buc",
                    Calorii = 182,
                    Proteine = 2,
                    Grasimi = 8,
                    Carbohidrati = 35
                },
                new Produs
                {
                    Denumire = "Păstârnac",
                    Furnizor = "Nedefinit",
                    Stoc = 100F,
                    UnitateMasura = "Buc",
                    Proteine = 1,
                    Grasimi = 0,
                    Carbohidrati = 17,
                    Calorii = 75
                },
                new Produs
                {
                    Denumire = "Cartof Alb",
                    Furnizor = "Nedefinit",
                    Stoc = 100F,
                    UnitateMasura = "Buc",
                    Proteine = 2,
                    Grasimi = 0,
                    Carbohidrati = 17,
                    Calorii = 7
                },
                new Produs
                {
                    Denumire = "Pătrunjel",
                    Furnizor = "Nedefinit",
                    Stoc = 100F,
                    UnitateMasura = "Buc",
                    Proteine = 2,
                    Grasimi = 0,
                    Carbohidrati = 6,
                    Calorii = 36
                },
                new Produs
                {
                    Denumire = "Morcov",
                    Furnizor = "Nedefinit",
                    Stoc = 150F,
                    UnitateMasura = "Buc",
                    Proteine = 0,
                    Grasimi = 0,
                    Carbohidrati = 9,
                    Calorii = 41
                },
                new Produs
                {
                    Denumire = "Somon",
                    Furnizor = "Nedefinit",
                    Stoc = 50F,
                    UnitateMasura = "Kg",
                    Proteine = 19,
                    Grasimi = 6,
                    Carbohidrati = 0,
                    Calorii = 142
                },
                new Produs
                {
                    Denumire = "Smântână",
                    Furnizor = "Napolact",
                    Stoc = 150F,
                    UnitateMasura = "Kg",
                    Proteine = 2,
                    Grasimi = 19,
                    Carbohidrati = 4,
                    Calorii = 198
                },
                new Produs
                {
                    Denumire = "Tăiței",
                    Furnizor = "Vitasia",
                    Stoc = 100F,
                    UnitateMasura = "Kg",
                    Proteine = 14,
                    Grasimi = 4,
                    Carbohidrati = 71,
                    Calorii = 384
                },
                new Produs
                {
                    Denumire = "Piept de pui",
                    Furnizor = "Agricola",
                    Stoc = 130F,
                    UnitateMasura = "Kg",
                    Proteine = 29,
                    Grasimi = 7,
                    Carbohidrati = 0,
                    Calorii = 197
                },
                new Produs
                {
                    Denumire = "Sos de soia",
                    Furnizor = "Vegeta",
                    Stoc = 100F,
                    UnitateMasura = "Kg",
                    Proteine = 8,
                    Grasimi = 0,
                    Carbohidrati = 4,
                    Calorii = 53
                },
                new Produs
                {
                    Denumire = "Căței de usturoi",
                    Furnizor = "Nedefinit",
                    Stoc = 120F,
                    UnitateMasura = "Buc",
                    Proteine = 6,
                    Grasimi = 0,
                    Carbohidrati = 33,
                    Calorii = 149
                }
            };

            produse.ForEach(p => context.Produse.AddOrUpdate(x => x.Denumire, p));
            context.SaveChanges();

            var angajati = new List<Angajat>
            {
                new Angajat
                {
                    Nume = "Dumitrescu",
                    Prenume = "Florin"
                },
                new Angajat
                {
                    Nume = "Bondar",
                    Prenume = "Alin"
                },
                new Angajat
                {
                    Nume = "Constantin",
                    Prenume = "Mihai"
                }
            };

            angajati.ForEach(a => context.Angajati.AddOrUpdate(x => x.Nume, a));
            context.SaveChanges();

            var bucatari = new List<Bucatar>
            {
                new Bucatar
                {
                    AngajatID = angajati.Single(a => a.Nume == "Dumitrescu").ID,
                    Pregatire = "Școala Internațională de Bucătari din Amsterdam",
                    Specializare = "desert",
                    LinkPoza = "https://www.click.ro/sites/default/files/styles/articol/public/medias/2014/09/25/chef-florin-dumitrescu.jpg?itok=Gq4NnmBG"
                },
                new Bucatar
                {
                    AngajatID = angajati.Single(a => a.Nume == "Bondar").ID,
                    Pregatire = "Școala Internațională de Bucătari din Londra",
                    Specializare = "burgeri",
                    LinkPoza = "https://3kyfma1tr3gd273qz5237tyv-wpengine.netdna-ssl.com/wp-content/uploads/2017/08/P18-DIPLOMA-IN-PROFESSIONAL-CHEF.jpg"
                }
            };

            bucatari.ForEach(b => context.Bucatari.AddOrUpdate(b));
            context.SaveChanges();

            var administratori = new List<Administrator>
            {
                new Administrator
                {
                   AngajatID = angajati.Single(a => a.Nume == "Constantin").ID,
                   NumeUtilizator = "costi_admin",
                   Parola = "admin"
                }
            };

            administratori.ForEach(a => context.Administratori.AddOrUpdate(x => x.NumeUtilizator, a));
            context.SaveChanges();

            var retete = new List<Reteta>
            {
                new Reteta
                {
                    Denumire = "Noodles cu pui și legume",
                    Descriere = "Descriere: Noodles cu pui și legume",
                    Stoc = 3,
                    Pret = 100,
                    LinkImaginePrezentare = "/Fisiere/noodles-pui-legume.JPG",
                    NivelDificultate = 4,
                    TimpPreparare = 10,
                    Categorie = "mâncare asiatică",
                    LinkVideo = "https://www.youtube.com/embed/oWo0z1h35u4"
                },
                new Reteta
                {
                    Denumire = "Somon la grătar cu legume gratinate",
                    Descriere = "Descriere: Somon la grătar cu legume gratinate",
                    Stoc = 5,
                    Pret = 130,
                    LinkImaginePrezentare = "/Fisiere/somon-la-gratar.JPG",
                    //LinkImaginePrezentare = "http://easyfoodro.azurewebsites.net/Fisiere/somon-la-gratar.JPG",
                    NivelDificultate = 3,
                    TimpPreparare = 60,
                    Categorie = "bucătărie internațională",
                    LinkVideo = "https://www.youtube.com/embed/s2T6xWDmqbk"
                }
            };

            retete.ForEach(r => context.Retete.AddOrUpdate(x => x.Denumire, r));
            context.SaveChanges();

            var ingrediente = new List<Ingredient>
            {
                new Ingredient
                {
                    ProdusID = produse.Single(p => p.Denumire == "Cartof Dulce").ID,
                    RetetaID = retete.Single(r => r.Denumire == "Somon la grătar cu legume gratinate").RetetaID,
                    Cantitate = 150
                },
                new Ingredient
                {
                    ProdusID = produse.Single(p => p.Denumire == "Păstârnac").ID,
                    RetetaID = retete.Single(r => r.Denumire == "Somon la grătar cu legume gratinate").RetetaID,
                    Cantitate = 30
                },
                new Ingredient
                {
                    ProdusID = produse.Single(p => p.Denumire == "Cartof Alb").ID,
                    RetetaID = retete.Single(r => r.Denumire == "Somon la grătar cu legume gratinate").RetetaID,
                    Cantitate = 130
                },
                new Ingredient
                {
                    ProdusID = produse.Single(p => p.Denumire == "Pătrunjel").ID,
                    RetetaID = retete.Single(r => r.Denumire == "Somon la grătar cu legume gratinate").RetetaID,
                    Cantitate = 15
                },
                new Ingredient
                {
                    ProdusID = produse.Single(p => p.Denumire == "Morcov").ID,
                    RetetaID = retete.Single(r => r.Denumire == "Somon la grătar cu legume gratinate").RetetaID,
                    Cantitate = 90
                },
                new Ingredient
                {
                    ProdusID = produse.Single(p => p.Denumire == "Somon").ID,
                    RetetaID = retete.Single(r => r.Denumire == "Somon la grătar cu legume gratinate").RetetaID,
                    Cantitate = 500
                },
                new Ingredient
                {
                    ProdusID = produse.Single(p => p.Denumire == "Smântână").ID,
                    RetetaID = retete.Single(r => r.Denumire == "Somon la grătar cu legume gratinate").RetetaID,
                    Cantitate = 300
                },
                new Ingredient
                {
                    ProdusID = produse.Single(p => p.Denumire == "Tăiței").ID,
                    RetetaID = retete.Single(r => r.Denumire == "Noodles cu pui și legume").RetetaID,
                    Cantitate = 250
                },
                new Ingredient
                {
                    ProdusID = produse.Single(p => p.Denumire == "Piept de pui").ID,
                    RetetaID = retete.Single(r => r.Denumire == "Noodles cu pui și legume").RetetaID,
                    Cantitate = 300
                },
                new Ingredient
                {
                    ProdusID = produse.Single(p => p.Denumire == "Sos de soia").ID,
                    RetetaID = retete.Single(r => r.Denumire == "Noodles cu pui și legume").RetetaID,
                    Cantitate = 12
                },
                new Ingredient
                {
                    ProdusID = produse.Single(p => p.Denumire == "Căței de usturoi").ID,
                    RetetaID = retete.Single(r => r.Denumire == "Noodles cu pui și legume").RetetaID,
                    Cantitate = 10
                }
            };

            ingrediente.ForEach(c => context.Ingrediente.AddOrUpdate(x => x.IngredientID, c));
            context.SaveChanges();

            var clienti = new List<Client>
            {
                new Client
                {
                    Nume = "Tocană",
                    Prenume = "Mihaela",
                    Email = "tocanamihaela@gmail.com",
                    DataNasterii = new DateTime(1995, 01, 12),
                    Adresa = "Strada Valea Călugărească, Nr. 12, Bloc Brașov, Scara 2, Ap. 30",
                    Parola = "Mihaela-123",
                    LinkPoza = "/Fisiere/mihaela-tocana.JPG"
                },
                new Client
                {
                    Nume = "Radu",
                    Prenume = "Raluca",
                    Email = "raduraluca@gmail.com",
                    DataNasterii = new DateTime(1997, 06, 27),
                    Adresa = "Strada Ceahlăul, Nr. 21, Bloc A1, Scara 1, Ap. 19",
                    Parola = "Raluca-123",
                    LinkPoza = "/Fisiere/radu-raluca.jpg"
                }
            };

            clienti.ForEach(c => context.Clienti.AddOrUpdate(x => x.Nume, c));
            context.SaveChanges();

            var comenzi = new List<Comanda>
            {
                new Comanda
                {
                    DataComanda = new DateTime(2019, 4, 12, 15, 12, 0),
                    DataLivrare = new DateTime(2019, 4, 12, 16, 30, 0),
                    ModalitatePlata = "Card"
                },
                new Comanda
                {
                    DataComanda = new DateTime(2019, 4, 13, 12, 3, 0),
                    DataLivrare = new DateTime(2019, 4, 13, 14, 0, 0),
                    ModalitatePlata = "Cash"
                },
                new Comanda
                {
                    DataComanda = new DateTime(2019, 4, 13, 20, 15, 0),
                    DataLivrare = new DateTime(2019, 4, 13, 21, 0, 0),
                    ModalitatePlata = "Card"
                }
            };

            comenzi.ForEach(c => context.Comenzi.AddOrUpdate(c));
            context.SaveChanges();


            var carduri = new List<Card>
            {
                new Card
                {
                    NumarCard = "5238801032609491",
                    DataExpirare = new DateTime(2021, 5, 8),
                    CVV = "241",
                    Posesor = "Tocană Mihaela"
                },
                new Card
                {
                    NumarCard = "4101710435139021",
                    DataExpirare = new DateTime(2022, 11, 9),
                    CVV = "123",
                    Posesor = "Radu Raluca"
                }
            };

            carduri.ForEach(c => context.Carduri.AddOrUpdate(x => x.NumarCard, c));
            context.SaveChanges();
        }
    }
}
