using Microsoft.AspNetCore.Mvc;
using RocketseatAuctionNLW.API.Entities;
using RocketseatAuctionNLW.API.UseCases.Auctions.GetCurrent;

namespace RocketseatAuctionNLW.API.Controllers;

public class AuctionController : RocketseatAuctionNLWBaseController
{
    [HttpGet]
    [ProducesResponseType(typeof(Auction), StatusCodes.Status200OK)]
    [ProducesResponseType(StatusCodes.Status204NoContent)]
    public IActionResult GeyCurrentAuction([FromServices] GetCurrentAuctionUseCase useCase)
    {
        var result =  useCase.Execute();

        if (result == null)
            return NoContent();

        return Ok(result);
    }
}
