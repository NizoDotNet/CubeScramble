using RubiksCube;


string sc = "B2 R F2 R2 D2 L2 D2 L U2 F2 L2 U' R2 D' R B' U F2 R' F' L";
string[] scramble = sc.Split(" ");
Cube cube = new();
CubeRender render = new(cube);
Scrambler scrambler = new(cube);

scrambler.Scramble(sc);
render.Render();
Console.WriteLine("End");
