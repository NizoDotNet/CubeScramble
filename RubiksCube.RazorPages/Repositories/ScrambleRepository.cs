using AutoMapper;
using Microsoft.AspNetCore.Authorization;
using RubiksCube.RazorPages.Data;
using RubiksCube.RazorPages.Model;
using RubiksCube.RazorPages.Model.DTOModels;
using System.Security.Claims;

namespace RubiksCube.RazorPages.Repositories;
[Authorize]
public class ScrambleRepository : IScrambleRepository
{
    private readonly IMapper mapper;
    private readonly RubiksCubeRazorPagesContext db;
    private readonly IHttpContextAccessor httpContext;
    private string UserId;
    public ScrambleRepository(IMapper mapper, 
        RubiksCubeRazorPagesContext db, 
        IHttpContextAccessor httpContext)
    {
        this.mapper = mapper;
        this.db = db;
        this.httpContext = httpContext;
        this.UserId = httpContext.HttpContext!.User.FindFirstValue(ClaimTypes.NameIdentifier)!;
    }
    public void AddScramble(ScrambleModelDTO scrambleModel)
    {
        scrambleModel.SpeedCuberId = UserId;
        ScrambleModel scramble = mapper.Map<ScrambleModel>(scrambleModel);
        db.Scrambles.Add(scramble);
        db.SaveChanges();
    }

    public void DeleteScramble(int id)
    {
        var scrambleModel = db.Scrambles.FirstOrDefault(x => x.Id == id);
        if (scrambleModel != null 
            && UserId == scrambleModel.SpeedCuberId)
        {
            db.Remove(scrambleModel);
            db.SaveChanges();
        }
    }

    public ScrambleModel GetScramble(int id)
    {
        return db.Scrambles.FirstOrDefault(c => c.Id == id);
    }

    public List<ScrambleModel> GetScrambles()
    {
        return db.Scrambles
                    .Where(c => c.SpeedCuberId == UserId)
                    .Select(c => c)
                    .ToList();
    }

    public void UpdateScramble(ScrambleModelDTO scrambleModel, int id)
    {
        ScrambleModel oldModel = db.Scrambles.FirstOrDefault(c => c.Id == id);
        if (oldModel != null)
        {
            oldModel.Time = scrambleModel.Time;
        }
    }
}
