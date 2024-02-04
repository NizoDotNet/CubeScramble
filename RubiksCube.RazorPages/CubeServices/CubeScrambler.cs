using AutoMapper;
using Microsoft.Extensions.Options;
using RubiksCube.RazorPages.Configuration;
using RubiksCube.RazorPages.Model.DTOModels;

namespace RubiksCube.RazorPages.CubeServices
{
    public class CubeScrambler
    {
        private readonly IMapper mapper;
        private ScrambleGenerator generator;
        private Scrambler scrambler;
        public CubeScrambler(IMapper mapper, IOptions<CubeConfiguration> cubeConfigurations)
        {
            generator = new ScrambleGenerator(cubeConfigurations.Value.ScrambleLength);
            scrambler = new Scrambler();
            this.mapper = mapper;
        }

        public CubeAndScramble GetCube()
        {
            CubeAndScramble res = new();
            Cube cube = new();
            string[] scramble = generator.GenerateScramble();
            scrambler.cube = cube;
            scrambler.Scramble(scramble);
            res.Scramble = string.Join(' ', scramble);
            res.CubeSides = mapper.Map<CubeSides>(cube);
            return res;
        }
    }
}
