using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;
using Tenth.Model;
using Tenth.Services;

namespace Tenth.Pages
{
    public class IndexModel : PageModel
    {
        private readonly ILogger<IndexModel> _logger;
        private readonly IHttpContextAccessor _hca;
        private readonly SessionStorage<Student> _ssss;
        private ISession _session => _hca.HttpContext.Session;
        private const string ValueSessionId = "X";
        public string Name { get; set; } = "";
        public Student Student { get; set; }

        public IndexModel(ILogger<IndexModel> logger, IHttpContextAccessor hca, SessionStorage<Student> ssss)
        {
            _logger = logger;
            _hca = hca;
            _ssss = ssss;
        }

        public void OnGet(string name)
        {
            /*
            //_session.SetString(ValueSessionId, "AAAAA");
            if (!String.IsNullOrEmpty(name))
                _session.SetString(ValueSessionId, name); // nastavíme hodnotu Session
            Name = _session.GetString(ValueSessionId);
            */
            if (!String.IsNullOrEmpty(name))
                _ssss.Save(ValueSessionId, new Student { FirstName = name}); // nastavíme hodnotu Session
            Student = _ssss.LoadOrCreate(ValueSessionId);
            
        }
    }
}