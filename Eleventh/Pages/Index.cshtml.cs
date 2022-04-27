using Eleventh.Models;
using Eleventh.Services;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;

namespace Eleventh.Pages
{
    public class IndexModel : PageModel
    {
        private readonly ILogger<IndexModel> _logger;
        private const string KEY = "AMAZINGADVENTURE";
        private readonly ISessionStorage<GameState> _ss;
        //private readonly ILocationProvider _lp;
        public GameState State { get; set; }

        public IndexModel(ILogger<IndexModel> logger, ISessionStorage<GameState> ss)
        {
            _logger = logger;
            _ss = ss;
        }

        public void OnGet()
        {
            State = new GameState { HP = 3 };
            _ss.Save(KEY, State);
        }
    }
}