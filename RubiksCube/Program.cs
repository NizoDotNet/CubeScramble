using RubiksCube;


string sc = "B2 R F2 R2 D2 L2 D2 L U2 F2 L2 U' R2 D' R B' U F2 R' F' L";
string[] scramble = sc.Split(" ");
Cube2 cube = new Cube2();
CubeRender render = new(cube);


foreach (var s in scramble)
{
    bool reverse = false;
    bool doubleTurn = false;
    if (s[0] == 'U')
    {
        if(s.Length == 2 && s[1] == '\'') reverse = true;
        else if(s.Length == 2 && s[1] == '2') doubleTurn = true; 
        if(doubleTurn)
        {
            cube.TurnU();
            cube.TurnU();
            continue;
        }
        cube.TurnU(reverse);
    }
    else if (s[0] == 'R')
    {
        if (s.Length == 2 && s[1] == '\'') reverse = true;
        else if (s.Length == 2 && s[1] == '2') doubleTurn = true;
        if (doubleTurn)
        {
            cube.TurnR();
            cube.TurnR();
            continue;
        }
        cube.TurnR(reverse);
    }
    else if (s[0] == 'L')
    {
        if (s.Length == 2 && s[1] == '\'') reverse = true;
        else if (s.Length == 2 && s[1] == '2') doubleTurn = true;
        if (doubleTurn)
        {
            cube.TurnL();
            cube.TurnL();
            continue;
        }
        cube.TurnL(reverse);
    }
    else if (s[0] == 'D')
    {
        if (s.Length == 2 && s[1] == '\'') reverse = true;
        else if (s.Length == 2 && s[1] == '2') doubleTurn = true;
        if (doubleTurn)
        {
            cube.TurnD();
            cube.TurnD();
            continue;
        }
        cube.TurnD(reverse);
    }
    else if (s[0] == 'F')
    {
        if (s.Length == 2 && s[1] == '\'') reverse = true;
        else if (s.Length == 2 && s[1] == '2') doubleTurn = true;
        if (doubleTurn)
        {
            cube.TurnF();
            cube.TurnF();
            continue;
        }
        cube.TurnF(reverse);
    }
    else if (s[0] == 'B')
    {
        if (s.Length == 2 && s[1] == '\'') reverse = true;
        else if (s.Length == 2 && s[1] == '2') doubleTurn = true;
        if (doubleTurn)
        {
            cube.TurnB();
            cube.TurnB();
            continue;
        }
        cube.TurnB(reverse);
    }
}

render.Render();
Console.WriteLine("End");
Console.ReadLine();