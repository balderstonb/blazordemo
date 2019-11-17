using Microsoft.AspNetCore.Mvc.RazorPages;
using Microsoft.Extensions.Logging;
using System;
using System.Collections.Generic;

namespace BlazorDemo.Pages
{
    public class IndexModel : PageModel
    {
        private readonly ILogger<IndexModel> _logger;
        private SessionState _state;

        // In BDMS, would come User.FindFirst(ClaimTypes.NameIdentifier)?.Value
        public string UserId { get; set; } = "";

        /* In BDMS would come from:
         * 
         * var fileTypeId = ManageList.GetFileTypeId("Dirty Words");
         * FileStorage file = Generals.GetFileFromFileStorageByType(fileTypeId).FirstOrDefault();
         * 
         * DirtyWords = CSVUtility.LoadCSVFileToList(file?.FileBinary);
         */
        public List<string> AllDirtyWords => new List<string> { "Foo", "Bar" };

        public IndexModel(ILogger<IndexModel> logger, SessionState state)
        {
            _logger = logger;
            _state = state;
        }

        public void OnGet()
        {
        }

        public void OnPost()
        {
            var selectedDirtyWords = _state.GetDirtyWords(UserId);
        }
    }
}
