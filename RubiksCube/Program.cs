using RubiksCube;


string sc = Console.ReadLine();
string[] scramble = sc.Split(" ");
Cube cube = new();
CubeRender render = new(cube);
Scrambler scrambler = new(cube);

scrambler.Scramble(sc);
render.Render();
Console.WriteLine("End");
