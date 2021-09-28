using Esourcing.Sourcing.Data.Interface;
using Esourcing.Sourcing.Entities;
using MongoDB.Driver;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Esourcing.Sourcing.Repositories.Interfaces
{
    //Auctions Business Layers
    public class AuctionRepository:IAuctionRepository
    {
        private readonly ISourcingContext _context;
        public AuctionRepository(ISourcingContext context)
        {
            _context = context;
        }
        public async Task Create(Auction auction)
        {
            await _context.Auctions.InsertOneAsync(auction);
        }

        public async Task<bool> Delete(string id)
        {
            var filter = Builders<Auction>.Filter.Eq(m => m.Id, id);
            DeleteResult deleteResult = await _context.Auctions.DeleteOneAsync(filter);
            return deleteResult.IsAcknowledged && deleteResult.DeletedCount > 0;
        }

        public async Task<Auction> GetAuction(string id)
        {
            return await _context.Auctions.Find(p => p.Id == id).FirstOrDefaultAsync();
        }

        public async Task<Auction> GetAuctionByName(string name)
        {
            var filter = Builders<Auction>.Filter.ElemMatch(p => p.Name, name);
            return await _context.Auctions.Find(filter).FirstOrDefaultAsync();
        }

        public async Task<IEnumerable<Auction>> GetAuctions()
        {
            return await _context.Auctions.Find(p => true).ToListAsync();
        }

        public async Task<bool> Update(Auction auction)
        {
            var updateResult = await _context.Auctions.ReplaceOneAsync(filter: g => g.Id == auction.Id, replacement: auction);
            return updateResult.IsAcknowledged && updateResult.ModifiedCount > 0;
        }
    }
}
