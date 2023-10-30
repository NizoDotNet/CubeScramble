using RubiksCube;


string[] scramble = new[] {"U2", "R'", "D2", "L2", "U2"};
Cube2 cube = new Cube2();
CubeRender render = new(cube);

foreach (var item in scramble)
{
    if(item.Length > 1)
    {
        bool reverse = item[1] == '\'';
        if (item[0] == 'U')
        {
            if (reverse)
                cube.TurnReverseU();
            else
            {
                cube.TurnU();
                cube.TurnU();
            }
        }
        else if (item[0] == 'R')
        {
            if (reverse)
                cube.TurnReverseR();
            else
            {
                cube.TurnR();

                cube.TurnR();
            }
        }
        else if (item[0] == 'L')
        {
            if (reverse)
                cube.TurnReverseL();
            else
            {
                cube.TurnL();
                cube.TurnL();

            }
        }
        else if (item[0] == 'D')
        {
            if (reverse)
                cube.TurnReverseD();
            else
            {
                cube.TurnD();
                cube.TurnD();

            }
        }
        /*else if (item[0] == 'B')
        {
            if (reverse)
                cube.TurnReverseB();
            else
                cube.TurnB();
        }*/
    }
    else
    {
        if (item == "U")
        {
            cube.TurnU();
        }
        else if (item == "R")
        {
           cube.TurnR();
        }
        else if (item == "L")
        {
           cube.TurnL();
        }
        else if (item == "D")
        {
           cube.TurnD();
        }
    }

}



render.Render();