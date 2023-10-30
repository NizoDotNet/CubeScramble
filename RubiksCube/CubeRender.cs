using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace RubiksCube
{
    internal class CubeRender
    {
        private Cube cube;
        private int origRow = Console.CursorTop, origCol = Console.CursorLeft;
        private const int CHARACTER_DIF = 2;
        private readonly ConsoleColor currentColor;
        public CubeRender(Cube cube)
        {
            this.cube = cube;
            currentColor = Console.ForegroundColor;
        }

        public void Render()
        {
            Console.Clear();
            Console.ForegroundColor = ConsoleColor.Black;
            for (int i = 0; i < cube.BlueSide.Length; i++)
            {
                for (int j = 0; j < cube.BlueSide[i].Length; j++)
                {
                    WriteAt(cube.WhiteSide[i][j], CHARACTER_DIF * (3 + j), i);
                    WriteAt(cube.OrangeSide[i][j], CHARACTER_DIF * (0 + j), 3 + i);
                    WriteAt(cube.GreenSide[i][j], CHARACTER_DIF * (3 + j), 3 + i);
                    WriteAt(cube.RedSide[i][j], CHARACTER_DIF * (6 + j), 3 + i);
                    WriteAt(cube.BlueSide[i][j], CHARACTER_DIF * (9 + j), 3 + i);
                    WriteAt(cube.YellowSide[i][j], CHARACTER_DIF * (3 + j), 6 + i);


                }
            }
            Console.ForegroundColor = currentColor;

        }

        private void WriteAt(char color, int x, int y)
        {
            switch(color)
            {
                case 'w':
                    Console.BackgroundColor = ConsoleColor.White; break;
                case 'b':
                    Console.BackgroundColor = ConsoleColor.Blue; break;
                case 'g':
                    Console.BackgroundColor = ConsoleColor.Green; break;
                case 'y':
                    Console.BackgroundColor = ConsoleColor.Yellow; break;
                case 'o':
                    Console.BackgroundColor = ConsoleColor.Magenta; break;
                case 'r':
                    Console.BackgroundColor = ConsoleColor.Red; break;
            }
            Console.SetCursorPosition(origRow + x, origCol + y);
            Console.Write(color);
            Console.BackgroundColor = ConsoleColor.Black;
        }
    }
}
