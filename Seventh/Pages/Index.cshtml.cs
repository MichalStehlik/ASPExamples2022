using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;
using Seventh.Services;

namespace Seventh.Pages
{
    public class IndexModel : PageModel
    {
        private readonly ILogger<IndexModel> _logger;
        private readonly Dice _dice1;
        private readonly Dice _dice2;
        public int Number1 { get; set; }
        public int Number2 { get; set; }

        public IndexModel(ILogger<IndexModel> logger, Dice dice1, Dice dice2)
        {
            _logger = logger;
            _dice1 = dice1;
            _dice2 = dice2;
        }

        public void OnGet()
        {
            Number1 = _dice1.Value;
            Number2 = _dice2.Value;
        }
    }
}