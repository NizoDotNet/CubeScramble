﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace RubiksCube
{
    internal class Cube2 : Cube
    {
        private const int TEMP_LENGTH = 3;
        
        public Cube2()
        {
            
        }

        public void TurnU()
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

            for (int i = 0; i < TEMP_LENGTH; i++)
            {
                WhiteSide[0][i] = upperTemp4[TEMP_LENGTH-i-1];
                WhiteSide[i][2] = upperTemp1[i];
                WhiteSide[2][i] = upperTemp2[TEMP_LENGTH - i - 1];
                WhiteSide[i][0] = upperTemp3[i];

                GreenSide[0][i] = redTemp[i];
                OrangeSide[0][i] = greenTemp[i];
                BlueSide[0][i] = orangeTemp[i];
                RedSide[0][i] = blueTemp[i];
            }
        }
        public void TurnReverseU()
        {
            char[] upperTemp1 = new char[TEMP_LENGTH], upperTemp2 = new char[TEMP_LENGTH],
                upperTemp3 = new char[TEMP_LENGTH], upperTemp4 = new char[TEMP_LENGTH];

            char[] greenTemp = new char[TEMP_LENGTH], orangeTemp = new char[TEMP_LENGTH],
                blueTemp = new char[TEMP_LENGTH], redTemp = new char[TEMP_LENGTH];

            for (int i = 0; i < TEMP_LENGTH; i++)
            {
                upperTemp1[i] = WhiteSide[0][i];
                upperTemp2[i] = WhiteSide[i][2];
                upperTemp3[i] = WhiteSide[2][i];
                upperTemp4[i] = WhiteSide[i][0];

                greenTemp[i] = GreenSide[0][i];
                orangeTemp[i] = OrangeSide[0][i];
                blueTemp[i] = BlueSide[0][i];
                redTemp[i] = RedSide[0][i];
            }

            for (int i = 0; i < TEMP_LENGTH; i++)
            {
                WhiteSide[0][i] = upperTemp2[i];
                WhiteSide[i][0] = upperTemp1[TEMP_LENGTH - i -  1];
                WhiteSide[2][i] = upperTemp4[i];
                WhiteSide[i][2] = upperTemp3[TEMP_LENGTH - i - 1];

                GreenSide[0][i] = orangeTemp[i];
                OrangeSide[0][i] = blueTemp[i];
                BlueSide[0][i] = redTemp[i];
                RedSide[0][i] = greenTemp[i];
            }
        }
        public void TurnR()
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
        public void TurnReverseR()
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
        public void TurnD()
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
        public void TurnReverseD()
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
        public void TurnL()
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

        public void TurnReverseL()
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
}