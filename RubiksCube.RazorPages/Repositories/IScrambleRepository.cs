using RubiksCube.RazorPages.Model;
using RubiksCube.RazorPages.Model.DTOModels;

namespace RubiksCube.RazorPages.Repositories;

public interface IScrambleRepository
{
    ScrambleModel GetScramble(int id);
    List<ScrambleModel> GetScrambles();
    void DeleteScramble(int id);
    void AddScramble(ScrambleModelDTO scrambleModel);
    void UpdateScramble(ScrambleModelDTO scrambleModel, int id);
}
