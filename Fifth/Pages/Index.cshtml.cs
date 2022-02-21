using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;
using System.ComponentModel.DataAnnotations;

namespace Fifth.Pages
{
    public class IndexModel : PageModel
    {
        private readonly ILogger<IndexModel> _logger;

        [BindProperty] // anotace - annotation, dekorace - decoration, atribut
        [Required(ErrorMessage = "Email musí být vyplněn, jinak ti vybouchne hlava")]
        [MinLength(7, ErrorMessage = "Email musí mít aspoň 7 znaků")]
        public string Email { get; set; } = "x@x.x";

        public IndexModel(ILogger<IndexModel> logger)
        {
            _logger = logger;
        }

        public void OnGet()
        {
            Email = "b.b@b.b";
        }

        public ActionResult OnPost(/*string email*/)
        {
            // Email = Request.Form["email"];
            // Email = email;
            // return RedirectToPage("./Privacy");
            if (!ModelState.IsValid)
            {
                return Page();
            }
            return RedirectToPage("./Privacy");
        }
    }
}