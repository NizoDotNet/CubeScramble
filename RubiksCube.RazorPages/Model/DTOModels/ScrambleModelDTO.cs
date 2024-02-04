using RubiksCube.RazorPages.Areas.Identity.Data;

namespace RubiksCube.RazorPages.Model.DTOModels;

public class ScrambleModelDTO
{
    public string Scramble { get; set; } = null!;
    public string Time { get; set; } = null!;
    public string CubeJson { get; set; } = null!;
    public string? SpeedCuberId { get; set; }
}
