using RocketseatAuctionNLW.API.Entities;

namespace RocketseatAuctionNLW.API.Contracts;

public interface IAuctionRepository
{
    Auction? GetCurrent();
}
