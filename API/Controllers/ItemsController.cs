using Application.Items;
using Domain;
using Microsoft.AspNetCore.Mvc;

namespace API.Controllers
{
    public class ItemsController : BaseApiController
    {
        [HttpGet] //api/items
        public async Task<ActionResult<List<Item>>> GetActivities(CancellationToken ct){
            return await Mediator.Send(new List.Query());
        }
    }
}