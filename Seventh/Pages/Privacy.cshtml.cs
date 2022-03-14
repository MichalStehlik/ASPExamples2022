using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;
using Seventh.Services;

namespace Seventh.Pages
{
    public class PrivacyModel : PageModel
    {
        private readonly ILogger<PrivacyModel> _logger;
        private readonly Dice _dice;

        public int Number { get; set; }

        public PrivacyModel(ILogger<PrivacyModel> logger, Dice dice)
        {
            _logger = logger;
            _dice = dice;
        }

        public void OnGet()
        {
            Number = _dice.Value;
        }
    }
}