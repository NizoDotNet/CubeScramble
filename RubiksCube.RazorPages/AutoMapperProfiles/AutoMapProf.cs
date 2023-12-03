using AutoMapper;
using RubiksCube.RazorPages.Model;
using RubiksCube.RazorPages.Model.DTOModels;

namespace RubiksCube.RazorPages.AutoMapperProfilles
{
    public class AutoMapProf : Profile
    {
        public AutoMapProf()
        {
            CreateMap<CubeSides, Cube>().ReverseMap();
            CreateMap<ScrambleModelDTO, ScrambleModel>().ReverseMap();
        }
    }
}
