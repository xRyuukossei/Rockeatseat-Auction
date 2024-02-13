using RocketseatAuctionNLW.API.Entities;

namespace RocketseatAuctionNLW.API.Contracts;

public interface IOfferRepository
{
    void Add(Offer offer);
}
