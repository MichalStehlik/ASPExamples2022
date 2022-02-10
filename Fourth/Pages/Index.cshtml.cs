using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;
using Microsoft.Extensions.Logging;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Fourth.Pages
{
    public class IndexModel : PageModel
    {
        private readonly ILogger<IndexModel> _logger;
        public int Value { get; set; }

        public IndexModel(ILogger<IndexModel> logger)
        {
            _logger = logger;
        }

        public void OnGet(int value)
        {
            Value = value;
            //return Page();
        }

        /*
        public async Task OnGetAsync()
        {
            Value = 10;
            return;
        }
        */
        public void OnGetInc(int value)
        {
            Value = value + 1;
        }
        public void OnGetDec(int value)
        {
            Value = value - 1;
        }

        public void OnPost(int value)
        {
            Value = value;
        }
    }
}
