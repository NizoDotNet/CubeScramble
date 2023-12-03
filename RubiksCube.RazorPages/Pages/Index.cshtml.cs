using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;
using Microsoft.EntityFrameworkCore;
using RubiksCube.RazorPages.CubeServices;
using RubiksCube.RazorPages.Data;
using RubiksCube.RazorPages.Model.DTOModels;

namespace RubiksCube.RazorPages.Pages
{
    [Authorize]
    public class IndexModel : PageModel
    {
        private readonly ILogger<IndexModel> _logger;

        public IndexModel(ILogger<IndexModel> logger) 
        {
            _logger = logger;
        }

        public void OnGet()
        {

        }
    }
}
