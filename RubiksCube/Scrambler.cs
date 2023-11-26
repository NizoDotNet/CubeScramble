using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace RubiksCube
{
    internal class Scrambler
    {
        private readonly Cube cube;
        private CubeRender cubeRender;
        public Scrambler(Cube cube)
        {
            this.cube = cube;
            cubeRender = new(cube);
        }

        public void Scramble(string[] scramble)
        {
            foreach (var s in scramble)
            {
                bool reverse = false;
                bool doubleTurn = false;
                if (s[0] == 'U')
                {
                    if (s.Length == 2 && s[1] == '\'') reverse = true;
                    else if (s.Length == 2 && s[1] == '2') doubleTurn = true;
                    if (doubleTurn)
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
        }

        public void Scramble(string sc)
        {
            string[] scramble = sc.Split();
            Scramble(scramble);
        }
    }
}
