using Esourcing.Sourcing.Entities;
using MongoDB.Driver;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Esourcing.Sourcing.Data
{
    public class SourcingContextSeed
    {
        public static void SeedData(IMongoCollection<Auction> auctionCollection)
        {
            bool exist = auctionCollection.Find(p => true).Any();
            if (!exist)
            {
                auctionCollection.InsertManyAsync(GetConfigureAuctions());
            }
        }
        private static IEnumerable<Auction> GetConfigureAuctions()
        {
            return new List<Auction>()
            {
               new Auction
                {
                    Name ="Auction 11",
                    Description=" AuctionAçıklamalar",
                    CreadtedAt = DateTime.Now,
                    StartedAt=DateTime.Now,
                    FinishedAt=DateTime.Now.AddDays(10),
                    ProductId = "",
                    IncludedSellers=new List<string>()
                    {
                        "IncludedSellers@test.com",
                        "IncludedSellers@test.com",
                        "IncludedSellers@test.com"
                    },
                    Quantity=5,
                    Status=(int)Status.Active
                },
               new Auction
                {
                    Name ="Auction 10",
                    Description=" AuctionAçıklamalar",
                    CreadtedAt = DateTime.Now,
                    StartedAt=DateTime.Now,
                    FinishedAt=DateTime.Now.AddDays(12),
                    ProductId = "",
                    IncludedSellers=new List<string>()
                    {
                        "IncludedSellers@test.com",
                        "IncludedSellers@test.com",
                        "IncludedSellers@test.com"
                    },
                    Quantity=2,
                    Status=(int)Status.Closed
                },
               new Auction
                {
                    Name ="Auction 3",
                    Description=" AuctionAçıklamalar",
                    CreadtedAt = DateTime.Now,
                    StartedAt=DateTime.Now,
                    FinishedAt=DateTime.Now.AddDays(5),
                    ProductId = "",
                    IncludedSellers=new List<string>()
                    {
                        "IncludedSellers@test.com",
                        "IncludedSellers@test.com",
                        "IncludedSellers@test.com"
                    },
                    Quantity=7,
                    Status=(int)Status.Active
                },
               new Auction
                {
                    Name ="Auction 67",
                    Description=" AuctionAçıklamalar",
                    CreadtedAt = DateTime.Now,
                    StartedAt=DateTime.Now,
                    FinishedAt=DateTime.Now.AddDays(4),
                    ProductId = "",
                    IncludedSellers=new List<string>()
                    {
                        "IncludedSellers@test.com",
                        "IncludedSellers@test.com",
                        "IncludedSellers@test.com"
                    },
                    Quantity=6,
                    Status=(int)Status.Closed
                },
               new Auction
                {
                    Name ="Auction 15",
                    Description=" AuctionAçıklamalar",
                    CreadtedAt = DateTime.Now,
                    StartedAt=DateTime.Now,
                    FinishedAt=DateTime.Now.AddDays(13),
                    ProductId = "",
                    IncludedSellers=new List<string>()
                    {
                        "IncludedSellers@test.com",
                        "IncludedSellers@test.com",
                        "IncludedSellers@test.com"
                    },
                    Quantity=9,
                    Status=(int)Status.Passive
                }
            };

        }
        
    }
}
