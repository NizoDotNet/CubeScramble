using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Identity;
using Microsoft.Extensions.Hosting;
using RubiksCube.RazorPages.Model;

namespace RubiksCube.RazorPages.Areas.Identity.Data;

// Add profile data for application users by adding properties to the SpeedCuber class
public class SpeedCuber : IdentityUser
{
    public ICollection<ScrambleModel> Scrambles { get; set; } = new List<ScrambleModel>();
}

