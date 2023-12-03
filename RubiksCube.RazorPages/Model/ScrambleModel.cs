using RubiksCube.RazorPages.Areas.Identity.Data;

namespace RubiksCube.RazorPages.Model
{
    public class ScrambleModel
    {
        public int Id { get; set; }
        public string Time { get; set; } = null!;
        public string Scramble { get; set; } = null!;
        public string CubeJson { get; set; } = null!;
        public SpeedCuber SpeedCuber { get; set; }
        public string SpeedCuberId { get; set; } = null!;
    }
}
