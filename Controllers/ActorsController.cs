using eTickets.Data;
using eTickets.Data.Services;
using Microsoft.AspNetCore.Mvc;

namespace eTickets.Controllers
{
    public class ActorsController : Controller
    {
        private IActorService _actorService;

        public ActorsController(IActorService actorService)
        {
            _actorService = actorService;
        }

        public async Task<IActionResult> Index()
        {
            var actorsData = await _actorService.GetAllAsync();

            return View(actorsData);
        }
    }
}
