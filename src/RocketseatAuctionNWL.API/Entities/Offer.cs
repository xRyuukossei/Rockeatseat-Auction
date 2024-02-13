namespace RocketseatAuctionNLW.API.Entities;

public class Offer
{
    public int Id { get; set; }
    public DateTime CreatedOn { get; set; }
    public Decimal Price { get; set; }
    public int ItemId { get; set; }
    public int UserId { get; set; }
}
