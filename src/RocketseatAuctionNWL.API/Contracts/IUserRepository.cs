using RocketseatAuctionNLW.API.Entities;

namespace RocketseatAuctionNLW.API.Contracts;

public interface IUserRepository
{
    bool ExistUserWithEmail(string email);
    User GetUserByEmail(string email);
}
