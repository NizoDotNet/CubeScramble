using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace RubiksCube
{
    internal class Cube
    {
        private const int TEMP_LENGTH = 3;
        public char[][] WhiteSide { get; set; }
        public char[][] YellowSide { get; set; }
        public char[][] GreenSide { get; set; }
        public char[][] BlueSide { get; set; }
        public char[][] RedSide { get; set; }
        public char[][] OrangeSide { get; set; }
        public Cube()
        {
            WhiteSide = new char[3][] { new char[] { 'w', 'w', 'w' }, new char[] { 'w', 'w', 'w' }, new char[] { 'w', 'w', 'w' } };
            YellowSide = new char[3][] { new char[] { 'y', 'y', 'y' }, new char[] { 'y', 'y', 'y' }, new char[] { 'y', 'y', 'y' } };
            GreenSide = new char[3][] { new char[] { 'g', 'g', 'g' }, new char[] { 'g', 'g', 'g' }, new char[] { 'g', 'g', 'g' } };
            BlueSide = new char[3][] { new char[] { 'b', 'b', 'b' }, new char[] { 'b', 'b', 'b' }, new char[] { 'b', 'b', 'b' } };
            RedSide = new char[3][] { new char[] { 'r', 'r', 'r' }, new char[] { 'r', 'r', 'r' }, new char[] { 'r', 'r', 'r' } };
            OrangeSide = new char[3][] { new char[] { 'o', 'o', 'o' }, new char[] { 'o', 'o', 'o' }, new char[] { 'o', 'o', 'o' } };
        }

        public void TurnU(bool reverse = false)
        {
            char[] upperTemp1 = new char[TEMP_LENGTH], upperTemp2 = new char[TEMP_LENGTH], 
                upperTemp3 = new char[TEMP_LENGTH], upperTemp4 = new char[TEMP_LENGTH];

            char[] greenTemp = new char[TEMP_LENGTH], orangeTemp = new char[TEMP_LENGTH],
                blueTemp = new char[TEMP_LENGTH], redTemp = new char[TEMP_LENGTH];
            
            for(int i = 0; i < TEMP_LENGTH; i++) 
            {
                upperTemp1[i] =  WhiteSide[0][i];
                upperTemp2[i] = WhiteSide[i][2];
                upperTemp3[i] = WhiteSide[2][i];
                upperTemp4[i] = WhiteSide[i][0];

                greenTemp[i] = GreenSide[0][i];
                orangeTemp[i] = OrangeSide[0][i];
                blueTemp[i] = BlueSide[0][i];
                redTemp[i] = RedSide[0][i];
            }


            if(!reverse)
            {
                for (int i = 0; i < TEMP_LENGTH; i++)
                {
                    WhiteSide[0][i] = upperTemp4[TEMP_LENGTH - i - 1];
                    WhiteSide[i][2] = upperTemp1[i];
                    WhiteSide[2][i] = upperTemp2[TEMP_LENGTH - i - 1];
                    WhiteSide[i][0] = upperTemp3[i];

                    GreenSide[0][i] = redTemp[i];
                    OrangeSide[0][i] = greenTemp[i];
                    BlueSide[0][i] = orangeTemp[i];
                    RedSide[0][i] = blueTemp[i];
                }
            }

            else
            {
                for (int i = 0; i < TEMP_LENGTH; i++)
                {
                    WhiteSide[0][i] = upperTemp2[i];
                    WhiteSide[i][0] = upperTemp1[TEMP_LENGTH - i - 1];
                    WhiteSide[2][i] = upperTemp4[i];
                    WhiteSide[i][2] = upperTemp3[TEMP_LENGTH - i - 1];

                    GreenSide[0][i] = orangeTemp[i];
                    OrangeSide[0][i] = blueTemp[i];
                    BlueSide[0][i] = redTemp[i];
                    RedSide[0][i] = greenTemp[i];
                }
            }
            
        }
        public void TurnR(bool reverse = false)
        {
            char[] upperTemp1 = new char[TEMP_LENGTH],
                upperTemp2 = new char[TEMP_LENGTH],
                upperTemp3 = new char[TEMP_LENGTH],
                upperTemp4 = new char[TEMP_LENGTH];

            char[] greenTemp = new char[TEMP_LENGTH], 
                whiteTemp = new char[TEMP_LENGTH], 
                blueTemp = new char[TEMP_LENGTH], 
                yellowTemp = new char[TEMP_LENGTH];
            for(int i = 0; i < TEMP_LENGTH; i++)
            {
                upperTemp1[i] = RedSide[0][i];
                upperTemp2[i] = RedSide[i][2];
                upperTemp3[i] = RedSide[2][i];
                upperTemp4[i] = RedSide[i][0];

                greenTemp[i] = GreenSide[i][2];
                yellowTemp[i] = YellowSide[i][2];
                whiteTemp[i] = WhiteSide[i][2];
                blueTemp[i] = BlueSide[i][0];
            }

            if(!reverse)
            {
                for (int i = 0; i < TEMP_LENGTH; i++)
                {
                    RedSide[0][i] = upperTemp4[TEMP_LENGTH - i - 1];
                    RedSide[i][2] = upperTemp1[i];
                    RedSide[2][i] = upperTemp2[TEMP_LENGTH - i - 1];
                    RedSide[i][0] = upperTemp3[i];

                    GreenSide[i][2] = yellowTemp[i];
                    WhiteSide[i][2] = greenTemp[i];
                    BlueSide[i][0] = whiteTemp[TEMP_LENGTH - i - 1];
                    YellowSide[i][2] = blueTemp[TEMP_LENGTH - i - 1];
                }
            }
            
            else
            {
                for (int i = 0; i < TEMP_LENGTH; i++)
                {
                    RedSide[0][i] = upperTemp2[i];
                    RedSide[i][2] = upperTemp3[TEMP_LENGTH - i - 1];
                    RedSide[2][i] = upperTemp4[i];
                    RedSide[i][0] = upperTemp1[TEMP_LENGTH - i - 1];

                    GreenSide[i][2] = whiteTemp[i];
                    WhiteSide[i][2] = blueTemp[TEMP_LENGTH - i - 1];
                    BlueSide[i][0] = yellowTemp[TEMP_LENGTH - i - 1];
                    YellowSide[i][2] = greenTemp[i];
                }
            }
            
        }
        public void TurnD(bool reverse = false)
        {
            char[] upperTemp1 = new char[TEMP_LENGTH], upperTemp2 = new char[TEMP_LENGTH],
               upperTemp3 = new char[TEMP_LENGTH], upperTemp4 = new char[TEMP_LENGTH];

            char[] greenTemp = new char[TEMP_LENGTH], orangeTemp = new char[TEMP_LENGTH],
                blueTemp = new char[TEMP_LENGTH], redTemp = new char[TEMP_LENGTH];

            for (int i = 0; i < TEMP_LENGTH; i++)
            {
                upperTemp1[i] = YellowSide[0][i];
                upperTemp2[i] = YellowSide[i][2];
                upperTemp3[i] = YellowSide[2][i];
                upperTemp4[i] = YellowSide[i][0];

                greenTemp[i] = GreenSide[2][i];
                orangeTemp[i] = OrangeSide[2][i];
                blueTemp[i] = BlueSide[2][i];
                redTemp[i] = RedSide[2][i];
            }

            if(!reverse)
            {
                for (int i = 0; i < TEMP_LENGTH; i++)
                {
                    YellowSide[0][i] = upperTemp4[TEMP_LENGTH - i - 1];
                    YellowSide[i][2] = upperTemp1[i];
                    YellowSide[2][i] = upperTemp2[TEMP_LENGTH - i - 1];
                    YellowSide[i][0] = upperTemp3[i];

                    GreenSide[2][i] = orangeTemp[i];
                    OrangeSide[2][i] = blueTemp[i];
                    BlueSide[2][i] = redTemp[i];
                    RedSide[2][i] = greenTemp[i];
                }
            }
            else
            {
                for (int i = 0; i < TEMP_LENGTH; i++)
                {
                    YellowSide[0][i] = upperTemp2[i];
                    YellowSide[i][2] = upperTemp3[TEMP_LENGTH - i - 1];
                    YellowSide[2][i] = upperTemp4[i];
                    YellowSide[i][0] = upperTemp1[TEMP_LENGTH - i - 1];

                    GreenSide[2][i] = redTemp[i];
                    OrangeSide[2][i] = greenTemp[i];
                    BlueSide[2][i] = orangeTemp[i];
                    RedSide[2][i] = blueTemp[i];
                }
            }
            
        }
    
        public void TurnL(bool reverse = false)
        {
            char[] upperTemp1 = new char[TEMP_LENGTH],
                upperTemp2 = new char[TEMP_LENGTH],
                upperTemp3 = new char[TEMP_LENGTH],
                upperTemp4 = new char[TEMP_LENGTH];

            char[] greenTemp = new char[TEMP_LENGTH],
                whiteTemp = new char[TEMP_LENGTH],
                blueTemp = new char[TEMP_LENGTH],
                yellowTemp = new char[TEMP_LENGTH];
            for (int i = 0; i < TEMP_LENGTH; i++)
            {
                upperTemp1[i] = OrangeSide[0][i];
                upperTemp2[i] = OrangeSide[i][2];
                upperTemp3[i] = OrangeSide[2][i];
                upperTemp4[i] = OrangeSide[i][0];

                greenTemp[i] = GreenSide[i][0];
                yellowTemp[i] = YellowSide[i][0];
                whiteTemp[i] = WhiteSide[i][0];
                blueTemp[i] = BlueSide[i][2];
            }

            if(!reverse)
            {
                for (int i = 0; i < TEMP_LENGTH; i++)
                {
                    OrangeSide[0][i] = upperTemp4[TEMP_LENGTH - i - 1];
                    OrangeSide[i][2] = upperTemp1[i];
                    OrangeSide[2][i] = upperTemp2[TEMP_LENGTH - i - 1];
                    OrangeSide[i][0] = upperTemp3[i];

                    GreenSide[i][0] = whiteTemp[i];
                    WhiteSide[i][0] = blueTemp[TEMP_LENGTH - i - 1];
                    BlueSide[i][2] = yellowTemp[TEMP_LENGTH - i - 1];
                    YellowSide[i][0] = greenTemp[i];
                }
            }
            else
            {
                for (int i = 0; i < TEMP_LENGTH; i++)
                {
                    OrangeSide[0][i] = upperTemp2[i];
                    OrangeSide[i][2] = upperTemp3[TEMP_LENGTH - i - 1];
                    OrangeSide[2][i] = upperTemp4[i];
                    OrangeSide[i][0] = upperTemp1[TEMP_LENGTH - i - 1];

                    GreenSide[i][0] = yellowTemp[i];
                    WhiteSide[i][0] = greenTemp[i];
                    BlueSide[i][2] = whiteTemp[TEMP_LENGTH - i - 1];
                    YellowSide[i][0] = blueTemp[TEMP_LENGTH - i - 1];
                }
            }
        }
        public void TurnF(bool reverse = false)
        {
            char[] upperTemp1 = new char[TEMP_LENGTH],
                upperTemp2 = new char[TEMP_LENGTH],
                upperTemp3 = new char[TEMP_LENGTH],
                upperTemp4 = new char[TEMP_LENGTH];

            char[] whiteTemp = new char[TEMP_LENGTH], 
                redTemp = new char[TEMP_LENGTH],
                yellowTemp = new char[TEMP_LENGTH],
                orangeTemp = new char[TEMP_LENGTH];
            for (int i = 0; i < TEMP_LENGTH; i++)
            {
                upperTemp1[i] = GreenSide[0][i];
                upperTemp2[i] = GreenSide[i][2];
                upperTemp3[i] = GreenSide[2][i];
                upperTemp4[i] = GreenSide[i][0];

                whiteTemp[i] = WhiteSide[2][i];
                redTemp[i] = RedSide[i][0];
                yellowTemp[i] = YellowSide[0][i];
                orangeTemp[i] = OrangeSide[i][2];

            }

            if(!reverse)
            {
                for (int i = 0; i < TEMP_LENGTH; i++)
                {
                    GreenSide[0][i] = upperTemp4[TEMP_LENGTH - i - 1];
                    GreenSide[i][2] = upperTemp1[i];
                    GreenSide[2][i] = upperTemp2[TEMP_LENGTH - i - 1];
                    GreenSide[i][0] = upperTemp3[i];

                    WhiteSide[2][i] = orangeTemp[TEMP_LENGTH - i - 1];
                    RedSide[i][0] = whiteTemp[i];
                    YellowSide[0][i] = redTemp[TEMP_LENGTH - i - 1];
                    OrangeSide[i][2] = yellowTemp[i];
                }
            }
            else
            {
                for (int i = 0; i < TEMP_LENGTH; i++)
                {
                    GreenSide[0][i] = upperTemp2[i];
                    GreenSide[i][2] = upperTemp3[TEMP_LENGTH - i - 1];
                    GreenSide[2][i] = upperTemp4[i];
                    GreenSide[i][0] = upperTemp1[TEMP_LENGTH - i - 1];

                    WhiteSide[2][i] = redTemp[i];
                    RedSide[i][0] = yellowTemp[TEMP_LENGTH - i - 1];
                    YellowSide[0][i] = orangeTemp[i];
                    OrangeSide[i][2] = whiteTemp[TEMP_LENGTH - i - 1];
                }
            }
            
        }
        public void TurnB(bool reverse = false)
        {
            char[] upperTemp1 = new char[TEMP_LENGTH],
                upperTemp2 = new char[TEMP_LENGTH],
                upperTemp3 = new char[TEMP_LENGTH],
                upperTemp4 = new char[TEMP_LENGTH];

            char[] whiteTemp = new char[TEMP_LENGTH],
                redTemp = new char[TEMP_LENGTH],
                yellowTemp = new char[TEMP_LENGTH],
                orangeTemp = new char[TEMP_LENGTH];

            for (int i = 0; i < TEMP_LENGTH; i++)
            {
                upperTemp1[i] = BlueSide[0][i];
                upperTemp2[i] = BlueSide[i][2];
                upperTemp3[i] = BlueSide[2][i];
                upperTemp4[i] = BlueSide[i][0];

                whiteTemp[i] = WhiteSide[0][i];
                redTemp[i] = RedSide[i][2];
                yellowTemp[i] = YellowSide[2][i];
                orangeTemp[i] = OrangeSide[i][0];
            }

            if(!reverse)
            {
                for (int i = 0; i < TEMP_LENGTH; i++)
                {
                    BlueSide[0][i] = upperTemp4[TEMP_LENGTH - i - 1];
                    BlueSide[i][2] = upperTemp1[i];
                    BlueSide[2][i] = upperTemp2[TEMP_LENGTH - i - 1];
                    BlueSide[i][0] = upperTemp3[i];

                    WhiteSide[0][i] = redTemp[i];
                    OrangeSide[i][0] = whiteTemp[TEMP_LENGTH - i - 1];
                    YellowSide[2][i] = orangeTemp[i];
                    RedSide[i][2] = yellowTemp[TEMP_LENGTH - i - 1];
                }
            }
            else
            {
                for (int i = 0; i < TEMP_LENGTH; i++)
                {
                    BlueSide[0][i] = upperTemp2[i];
                    BlueSide[i][2] = upperTemp3[TEMP_LENGTH - i - 1];
                    BlueSide[2][i] = upperTemp4[i];
                    BlueSide[i][0] = upperTemp1[TEMP_LENGTH - i - 1];

                    WhiteSide[0][i] = orangeTemp[TEMP_LENGTH - i - 1];
                    OrangeSide[i][0] = yellowTemp[i];
                    YellowSide[2][i] = redTemp[TEMP_LENGTH - i - 1];
                    RedSide[i][2] = whiteTemp[i];
                }
            }
            
        }
    }
}
