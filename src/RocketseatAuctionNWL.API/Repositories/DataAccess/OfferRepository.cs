using RocketseatAuctionNLW.API.Contracts;
using RocketseatAuctionNLW.API.Entities;
using System;

namespace RocketseatAuctionNLW.API.Repositories.DataAccess;

public class OfferRepository : IOfferRepository
{
    private readonly RocketseatAuctionNLWDbContext _dbContext;
    public OfferRepository(RocketseatAuctionNLWDbContext context) => _dbContext = context;
    public void Add(Offer offer)
    {
        _dbContext.Offers.Add(offer);

        _dbContext.SaveChanges();
    }
}
