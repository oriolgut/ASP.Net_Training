namespace WebApplication1.Migrations
{
    using Models;
    using System.Collections.Generic;
    using System.Data.Entity.Migrations;

    internal sealed class Configuration : DbMigrationsConfiguration<DAL.ProductsContext>
    {
        public Configuration()
        {
            AutomaticMigrationsEnabled = false;
        }

        protected override void Seed(DAL.ProductsContext context)
        {
            var products = new List<Product>()
            {
                new Product() { Name = "Apfel gr�n", Price = 2.40M, ExpiryDate = "01.02.2017", Description = "Gr�ne �pfel" },
                new Product() { Name = "Apfel gelb", Price = 1.25M, ExpiryDate = "02.02.2017", Description = "Gelbe �pfel" },
                new Product() { Name = "Apfel rot", Price = 3.00M, ExpiryDate = "03.02.2017", Description = "Rote �pfel" },
                new Product() { Name = "Banane", Price = 0.95M, ExpiryDate = "01.03.2017", Description = "Bananen aus S�dafrika" },
                new Product() { Name = "Honig", Price = 12.00M, ExpiryDate = "01.03.2022", Description = "S�sser Bienenhonig" },
                new Product() { Name = "Haribo Gummib�rchen", Price = 1.75M, ExpiryDate = "01.02.2022", Description = "S�ssigkeiten" },
                new Product() { Name = "Saurezungen", Price = 3.95M, ExpiryDate = "01.02.2018", Description = "S�ssigkeiten - schlecht f�r die Z�hne;)" },
                new Product() { Name = "Caotina", Price = 4.60M, ExpiryDate = "01.02.2022", Description = "Schokopulver f�r in die Milch - kalt oder warm" },
                new Product() { Name = "Vollmilch", Price = 1.20M, ExpiryDate = "18.01.2017", Description = "Vollmilch von der Kuh - Bio" },
                new Product() { Name = "Himbeerjoguhrt", Price = 1.80M, ExpiryDate = "22.01.2017", Description = "Joghurt aus Kuhmilch mit Himbeeraroma" },
                new Product() { Name = "Orange", Price = 1.65M, ExpiryDate = "02.03.2017", Description = "Orangen aus S�dafrika" }
            };
            products.ForEach(p => context.Products.AddOrUpdate(p));
            context.SaveChanges();
        }
    }
}
