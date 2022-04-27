using Eleventh.Models;
using Eleventh.Services;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;

namespace Eleventh.Pages
{
    public class MonsterModel : PageModel
    {
        private Random _random = new Random();
        private const string KEY = "AMAZINGADVENTURE";
        private readonly ISessionStorage<GameState> _ss;
        private readonly ILocationProvider _lp;
        public Room ReturnRoom { get; set; }

        public Location Location { get; set; }
        public List<Connection> Connections { get; set; }
        public GameState State { get; set; }
        public void OnGet()
        {
        }

        public void OnGetResult(Room returnRoom)
        {
            // return RedirectToPage(ReturnRoom);
        }
    }
}
