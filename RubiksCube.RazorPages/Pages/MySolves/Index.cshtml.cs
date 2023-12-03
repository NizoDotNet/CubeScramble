using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;
using RubiksCube.RazorPages.Model;
using RubiksCube.RazorPages.Repositories;

namespace RubiksCube.RazorPages.Pages.MySolves
{
    public class IndexModel : PageModel
    {
        private readonly IScrambleRepository repository;

        public IndexModel(IScrambleRepository repository)
        {
            this.repository = repository;
        }
        [BindProperty]
        public List<ScrambleModel> Scrambles { get; set; }
        public void OnGet()
        {
            Scrambles = repository.GetScrambles();
        }

        public IActionResult OnGetCubepartial()
        {
            string sc = @"{test: 'TEST'}";
            return Partial("_CubePartial", sc);
        }
    }
}
