using Microsoft.EntityFrameworkCore;
using RocketseatAuctionNLW.API.Entities;

namespace RocketseatAuctionNLW.API.Repositories;

public class RocketseatAuctionNLWDbContext : DbContext
{
    public RocketseatAuctionNLWDbContext(DbContextOptions options) : base(options) { }
    public DbSet<Auction> Auctions { get; set; }
    public DbSet<User> Users { get; set; }
    public DbSet<Offer> Offers { get; set; }
}
