using Microsoft.AspNetCore.Mvc.RazorPages;
using Microsoft.Extensions.Logging;
using System;

namespace BlazorDemo.Pages
{
    public class IndexModel : PageModel
    {
        private readonly ILogger<IndexModel> _logger;
        private SessionState _state;

        public string UserId { get; set; } = "";

        public IndexModel(ILogger<IndexModel> logger, SessionState state)
        {
            _logger = logger;
            _state = state;
        }

        public void OnGet()
        {
        }

        public async void OnPost()
        {
        }
    }
}
