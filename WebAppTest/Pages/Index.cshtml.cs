using System;
using Microsoft.AspNetCore.Mvc.RazorPages;
using Microsoft.Extensions.Logging;

namespace WebAppTest.Pages
{
    public class IndexModel : PageModel
    {
        private readonly ILogger<IndexModel> _logger;

        public IndexModel(ILogger<IndexModel> logger)
        {
            _logger = logger;
        }
        public string Time { get; set; }
        public void OnGet()
        {
            Time = DateTime.Today.ToShortTimeString();
        }

        public string Create { get; set; }
    }
}
