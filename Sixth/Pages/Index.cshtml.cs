using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;
using Sixth.Services;

namespace Sixth.Pages
{
    public class IndexModel : PageModel
    {
        private readonly ILogger<IndexModel> _logger;
        private readonly IRoller _sd;

        public IndexModel(ILogger<IndexModel> logger, IRoller sd)
        {
            _logger = logger;
            _sd = sd;
        }
        public int RollResult { get; set; }

        public void OnGet()
        {
            RollResult = _sd.Roll();
        }
    }
}