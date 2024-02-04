using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace RubiksCube;

public class ScrambleGenerator
{
    public int scrambleLength = 2;
    public ScrambleGenerator() { }
    public ScrambleGenerator(int scrambleLength)
    {
        this.scrambleLength = scrambleLength;
    }
    private string[] turns = { "R", "L", "U", "D", "F", "B", 
                               "R'", "L'", "U'", "D'", "F'", "B'", 
                               "R2", "L2", "U2", "D2", "F2", "B2" };
    private Dictionary<string, string[]> allowedTurns = new() 
    {
        {"R", new[] { "L", "U", "D", "F", "B", "L'", "U'", "D'", "F'", "B'", "L2", "U2", "D2", "F2", "B2" } },
        {"L", new[] { "R", "U", "D", "F", "B", "R'", "U'", "D'", "F'", "B'", "R2", "U2", "D2", "F2", "B2" } },
        {"U", new[] { "R", "L", "D", "F", "B", "R'", "L'", "D'", "F'", "B'", "R2", "L2", "D2", "F2", "B2" } },
        {"D", new[] { "R", "L", "U", "F", "B", "R'", "L'", "U'", "F'", "B'", "R2", "L2", "U2", "F2", "B2" } },
        {"F", new[] { "R", "L", "U", "D", "B", "R'", "L'", "U'", "D'", "B'", "R2", "L2", "U2", "D2", "B2" } },
        {"B", new[] { "R", "L", "U", "D", "F", "R'", "L'", "U'", "D'", "F'", "R2", "L2", "U2", "D2", "F2" } },
        {"RL",new[] {"U", "D", "F", "B", "U'", "D'", "F'", "B'", "U2", "D2", "F2", "B2"}},
        {"UD",new[] { "R", "L", "F", "B", "R'", "L'", "F'", "B'", "R2", "L2", "F2", "B2" }},
        {"FB",new[] { "R", "L", "U", "D", "R'", "L'", "U'", "D'", "R2", "L2", "U2", "D2" }},
    };

    public string[] GenerateScramble()
    {
        if (scrambleLength < 2) throw new Exception("Scramble Length cannot be less than 2");
        Random rand = new Random();
        string[] res = new string[scrambleLength];
        res[0] = turns[rand.Next(turns.Length)];
        res[1] = allowedTurns[res[0][0].ToString()][rand.Next(allowedTurns[res[0][0].ToString()].Length)];
        for (int i = 2; i < scrambleLength; i++)
        {
            string key1 = $"{res[i - 1][0]}{res[i - 2][0]}";
            string key2 = $"{res[i - 2][0]}{res[i - 1][0]}";
            if (allowedTurns.ContainsKey(key1))
            {
                res[i] = allowedTurns[key1][rand.Next(allowedTurns[key1].Length)];
                continue;
            }
            else if (allowedTurns.ContainsKey(key2))
            {
                res[i] = allowedTurns[key2][rand.Next(allowedTurns[key2].Length)];
                continue;
            }
            else res[i] = allowedTurns[res[i - 1][0].ToString()][rand.Next(allowedTurns[res[i - 1][0].ToString()].Length)];
            
        }
        return res;
    }
}
