using RubiksCube.RazorPages.CubeServices;
using RubiksCube.RazorPages.Repositories;

namespace RubiksCube.RazorPages.ExtensionMethods
{
    public static class CubeServiceRegister
    {
        public static void RegisterCubeServices(this IServiceCollection Services)
        {
            Services.AddScoped<CubeScrambler>();
            Services.AddScoped<IScrambleRepository, ScrambleRepository>();
        }

    }
}
