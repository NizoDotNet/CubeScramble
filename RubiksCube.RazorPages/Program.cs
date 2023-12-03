using Microsoft.AspNetCore.Identity;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using RubiksCube.RazorPages.Areas.Identity.Data;
using RubiksCube.RazorPages.CubeServices;
using RubiksCube.RazorPages.Data;
using RubiksCube.RazorPages.Model.DTOModels;
using RubiksCube.RazorPages.Repositories;
var builder = WebApplication.CreateBuilder(args);
var connectionString = builder.Configuration.GetConnectionString("RubiksCubeRazorPagesContextConnection") ?? throw new InvalidOperationException("Connection string 'RubiksCubeRazorPagesContextConnection' not found.");

builder.Services.AddDbContext<RubiksCubeRazorPagesContext>(options => options.UseSqlite(connectionString));

builder.Services.AddDefaultIdentity<SpeedCuber>(options => options.SignIn.RequireConfirmedAccount = true).AddEntityFrameworkStores<RubiksCubeRazorPagesContext>();
builder.Services.AddHttpContextAccessor();
builder.Services.Configure<IdentityOptions>(options =>
{
    options.Password.RequireDigit = false;
    options.Password.RequireLowercase = false;
    options.Password.RequireNonAlphanumeric = false;
    options.Password.RequireUppercase = false;
    options.Password.RequiredLength = 6;
    options.Password.RequiredUniqueChars = 1;
});
// Add services to the container.
builder.Services.AddRazorPages();
builder.Services.AddAutoMapper(typeof(Program).Assembly);
builder.Services.AddScoped<CubeScrambler>();
builder.Services.AddScoped<IScrambleRepository, ScrambleRepository>();

var app = builder.Build();

// Configure the HTTP request pipeline.
if (!app.Environment.IsDevelopment())
{
    app.UseExceptionHandler("/Error");
    // The default HSTS value is 30 days. You may want to change this for production scenarios, see https://aka.ms/aspnetcore-hsts.
    app.UseHsts();
}

app.MapGet("/cube", (CubeScrambler scrambler) => 
{
    CubeAndScramble cube = new();
    cube = scrambler.GetCube();
    return cube;
});

app.MapPost("/cube", ([FromBody] ScrambleModelDTO scrambleModel, 
    IScrambleRepository repository) =>
{
    repository.AddScramble(scrambleModel);
});

app.UseHttpsRedirection();
app.UseStaticFiles();

app.UseRouting();

app.UseAuthorization();

app.MapRazorPages();



app.Run();
