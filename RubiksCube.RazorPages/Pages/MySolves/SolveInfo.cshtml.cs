using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;
using RubiksCube.RazorPages.Model;
using RubiksCube.RazorPages.Repositories;

namespace RubiksCube.RazorPages.Pages.MySolves
{
    public class SolveInfoModel : PageModel
    {
        private readonly IScrambleRepository repository;

        public SolveInfoModel(IScrambleRepository repository)
        {
            this.repository = repository;
        }
        [BindProperty]
        public ScrambleModel ScrambleModel { get; set; }
        public IActionResult OnGet([FromRoute] int id)
        {
            ScrambleModel = repository.GetScramble(id);
            if(ScrambleModel == null)
            {
                return RedirectToPage($"/MySolves/{nameof(Index)}");
            }
            return Page();
        }
    }
}
