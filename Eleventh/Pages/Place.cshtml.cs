using Eleventh.Models;
using Eleventh.Services;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;

namespace Eleventh.Pages
{
    public class PlaceModel : PageModel
    {
        private const string KEY = "AMAZINGADVENTURE";
        private readonly ISessionStorage<GameState> _ss;
        private readonly ILocationProvider _lp;

        public Location Location { get; set; }
        public List<Connection> Connections { get; set; }
        public GameState State { get; set; }

        public PlaceModel(ISessionStorage<GameState> ss, ILocationProvider lp)
        {
            _ss = ss;
            _lp = lp;
        }

        public IActionResult OnGet(Room id)
        {
            State = _ss.LoadOrCreate(KEY);
            if (State.HP <= 0) return RedirectToPage("GameOver");
            State.Location = id;
            _ss.Save(KEY, State);
            Location = _lp.GetLocation(id);
            Connections = _lp.GetConnectionsFrom(id);
            return Page();
        }
    }
}
