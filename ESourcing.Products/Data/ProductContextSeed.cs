using ESourcing.Products.Entities;
using MongoDB.Driver;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace ESourcing.Products.Data
{
    public class ProductContextSeed
    {
        private static IEnumerable<Product> GetConfigureProducts() {
            return new List<Product>()
            {
                new Product
                {
                    Name ="Iphone 11",
                    Summary="Açıklamalar",
                    ImageFile = "p.png",
                    Price=4500,
                    Category="Mobile"
                },
                new Product
                {
                    Name ="Iphone 10",
                    Summary="Açıklamalar",
                    ImageFile = "p.png",
                    Price=3000,
                    Category="Mobile"
                },
                new Product
                {
                    Name ="Samsung 5s",
                    Summary="Açıklamalar",
                    ImageFile = "p.png",
                    Price=2500,
                    Category="Mobile"
                },
                new Product
                {
                    Name ="Oppo",
                    Summary="Açıklamalar",
                    ImageFile = "p.png",
                    Price=2000,
                    Category="Mobile"
                }
            };

        }

        public static void SeedData(IMongoCollection<Product> productCollection) {
            bool existProduct = productCollection.Find(p => true).Any();
            if (!existProduct)
            {
                productCollection.InsertManyAsync(GetConfigureProducts());
            }
        }
    }
}
