using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace RubiksCube
{
    internal class Cube
    {
        public char[][] WhiteSide { get; set; }
        public char[][] YellowSide { get; set; }
        public char[][] GreenSide { get; set; }
        public char[][] BlueSide { get; set; }
        public char[][] RedSide { get; set; }
        public char[][] OrangeSide { get; set; }
        public Cube()
        {
            WhiteSide = new char[3][] { new char[] {'w','w','w'}, new char[] { 'w', 'w', 'w' }, new char[] { 'w', 'w', 'w' } };
            YellowSide = new char[3][] { new char[] { 'y', 'y', 'y' }, new char[] { 'y', 'y', 'y' }, new char[] { 'y', 'y', 'y' } };
            GreenSide = new char[3][] { new char[] { 'g', 'g', 'g' }, new char[] { 'g', 'g', 'g' }, new char[] { 'g', 'g', 'g' } };
            BlueSide = new char[3][] { new char[] { 'b', 'b', 'b' }, new char[] { 'b', 'b', 'b' }, new char[] { 'b', 'b', 'b' } };
            RedSide = new char[3][] { new char[] { 'r', 'r', 'r' }, new char[] { 'r', 'r', 'r' }, new char[] { 'r', 'r', 'r' } };
            OrangeSide = new char[3][] { new char[] { 'o', 'o', 'o' }, new char[] { 'o', 'o', 'o' }, new char[] { 'o', 'o', 'o' } };
        }

        

        //public void TurnUReverse()
        //{
        //    char[] tempGreen = { GreenSide[0][0], GreenSide[0][1], GreenSide[0][2] },
        //        tempOrange = { OrangeSide[2][2], OrangeSide[1][2], OrangeSide[0][2] },
        //        tempBlue = { BlueSide[2][0], BlueSide[2][1], BlueSide[2][2] },
        //        tempRed = { RedSide[2][0], RedSide[1][0], RedSide[0][0] };

        //    for (int i = 0; i < 3; i++)
        //    {
        //        BlueSide[2][i] = tempRed[i];
        //        RedSide[i][0] = tempGreen[i];
        //        GreenSide[0][i] = tempOrange[i];
        //        OrangeSide[i][2] = tempBlue[i];
        //    }

        //}
        //public void TurnD()
        //{
        //    char[] tempGreen = { GreenSide[2][0], GreenSide[2][1], GreenSide[2][2] }, 
        //        tempOrange = { OrangeSide[0][0], OrangeSide[1][0], OrangeSide[2][0] },
        //        tempBlue = { BlueSide[0][0], BlueSide[0][1], BlueSide[0][2] }, 
        //        tempRed = { RedSide[0][2], RedSide[1][2], RedSide[2][2] };
        //    for (int i = 0; i < 3; i++)
        //    {
        //        BlueSide[0][i] = tempRed[i];
        //        RedSide[i][2] = tempGreen[i];
        //        GreenSide[2][i] = tempOrange[i];
        //        OrangeSide[i][0] = tempBlue[i];
        //    }
        //}

        //public void TurnDReverse()
        //{
        //    char[] tempGreen = { GreenSide[2][0], GreenSide[2][1], GreenSide[2][2] },
        //        tempOrange = { OrangeSide[0][0], OrangeSide[1][0], OrangeSide[2][0] },
        //        tempBlue = { BlueSide[0][0], BlueSide[0][1], BlueSide[0][2] },
        //        tempRed = { RedSide[0][2], RedSide[1][2], RedSide[2][2] };
        //    for (int i = 0; i < 3; i++)
        //    {
        //        GreenSide[2][i] = tempRed[i];
        //        OrangeSide[i][0] = tempGreen[i];
        //        BlueSide[0][i] = tempOrange[i];
        //        RedSide[i][2] = tempBlue[i];
        //    }
        //}

        
        //public void TurnRReverse()
        //{
        //    char[] tempGreen = { GreenSide[0][2], GreenSide[1][2], GreenSide[2][2] },
        //        tempWhite = { WhiteSide[0][2], WhiteSide[1][2], WhiteSide[2][2] },
        //        tempBlue = { BlueSide[0][2], BlueSide[1][2], BlueSide[2][2] },
        //        tempYellow = { YellowSide[0][0], YellowSide[1][0], YellowSide[2][0] };
        //    for (int i = 0; i < 3; i++)
        //    {
        //        BlueSide[i][2] = tempYellow[i];
        //        YellowSide[i][0] = tempGreen[i];
        //        GreenSide[i][2] = tempWhite[i];
        //        WhiteSide[i][2] = tempBlue[i];
        //    }
        //}
        //public void TurnL()
        //{
        //    char[] tempGreen = { GreenSide[0][0], GreenSide[1][0], GreenSide[2][0] },
        //        tempWhite = { WhiteSide[0][0], WhiteSide[1][0], WhiteSide[2][0] },
        //        tempBlue = { BlueSide[0][0], BlueSide[1][0], BlueSide[2][0] },
        //        tempYellow = { YellowSide[0][2], YellowSide[1][2], YellowSide[2][2] };
        //    for (int i = 0; i < 3; i++)
        //    {
        //        GreenSide[i][0] = tempWhite[i];
        //        WhiteSide[i][0] = tempBlue[i];
        //        BlueSide[i][0] = tempYellow[i];
        //        YellowSide[i][2] = tempGreen[i];
        //    }
        //}

        //public void TurnLReverse()
        //{
        //    char[] tempGreen = { GreenSide[0][0], GreenSide[1][0], GreenSide[2][0] },
        //        tempWhite = { WhiteSide[0][0], WhiteSide[1][0], WhiteSide[2][0] },
        //        tempBlue = { BlueSide[0][0], BlueSide[1][0], BlueSide[2][0] },
        //        tempYellow = { YellowSide[0][2], YellowSide[1][2], YellowSide[2][2] };
        //    for (int i = 0; i < 3; i++)
        //    {
        //        GreenSide[i][0] = tempYellow[i];
        //        WhiteSide[i][0] = tempGreen[i];
        //        BlueSide[i][0] = tempWhite[i];
        //        YellowSide[i][2] = tempBlue[i];
        //    }
        //}


    }
}
