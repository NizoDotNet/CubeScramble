using RubiksCube;



ScrambleGenerator generator = new();

var res = generator.GenerateScramble(20);

Cube cube = new();
CubeRender render = new(cube);
Scrambler scrambler = new(cube);
scrambler.Scramble(res);
render.Render();
Console.WriteLine();
foreach (var item in res)
{
    Console.Write($"{item} ");   
}
Console.ReadKey();