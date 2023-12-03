using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;
using RubiksCube.RazorPages.Repositories;

namespace RubiksCube.RazorPages.Pages.MySolves
{
    [Authorize]
    public class DeleteModel : PageModel
    {
        private readonly IScrambleRepository repository;

        public DeleteModel(IScrambleRepository repository)
        {
            this.repository = repository;
        }
        public IActionResult OnGet(int id)
        {
            repository.DeleteScramble(id);
            return RedirectToPage(nameof(Index));
        }
    }
}
