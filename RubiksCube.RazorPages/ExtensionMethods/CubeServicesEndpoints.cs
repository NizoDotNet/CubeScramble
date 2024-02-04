using Microsoft.AspNetCore.Mvc;
using RubiksCube.RazorPages.CubeServices;
using RubiksCube.RazorPages.Model.DTOModels;
using RubiksCube.RazorPages.Repositories;

namespace RubiksCube.RazorPages.ExtensionMethods
{
    public static class CubeServicesEndpoints
    {
        public static void CubeEndpoints(this IEndpointRouteBuilder route)
        {
            route.MapGet("/cube", (CubeScrambler scrambler) =>
            {
                CubeAndScramble cube = new();
                cube = scrambler.GetCube();
                return cube;
            });

            route.MapPost("/cube", ([FromBody] ScrambleModelDTO scrambleModel,
                IScrambleRepository repository) =>
            {
                repository.AddScramble(scrambleModel);
            });

        }
    }
}
