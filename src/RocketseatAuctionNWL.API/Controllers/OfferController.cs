using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using RocketseatAuctionNLW.API.Communication.Requests;
using RocketseatAuctionNLW.API.Filters;
using RocketseatAuctionNLW.API.UseCases.Offers.CreateOffer;

namespace RocketseatAuctionNLW.API.Controllers;

[ServiceFilter(typeof(AuthenticationUserAttibute))]
public class OfferController : RocketseatAuctionNLWBaseController
{
    [HttpPost]
    [Route("{itemId}")]

    public IActionResult CreateOffer(
        [FromRoute] int itemId,
        [FromBody] RequestCreateOfferJson request,
        [FromServices] CreateOfferUseCase useCase)
    {
       var id = useCase.Execute(itemId, request);

        return Created(string.Empty, id);
    }
}
