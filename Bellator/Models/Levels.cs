using System;
using System.Collections.Generic;

namespace Bellator.Models
{
    public class Levels
    {
        public List<Level> ListofLevels { get; set; }

        public Level LevelOne = new Level(1, 0, 0);
        public Level LevelTwo = new Level(2, 300, 4);
        public Level LevelThree = new Level(3, 900, 8);
        public Level LevelFour = new Level(4, 2700, 12);
        public Level LevelFive = new Level(5, 6500, 16);
        public Level LevelSix = new Level(6, 14000, 24);
        public Level LevelSeven = new Level(7, 23000, 32);
        public Level LevelEight = new Level(8, 34000, 40);
        public Level LevelNine = new Level(9, 48000, 48);
        public Level LevelTen = new Level(10, 64000, 56); 
        public Level LevelEleven = new Level(11, 85000, 64);
        public Level LevelTwelve = new Level(12, 100000, 72);
        public Level LevelThirteen = new Level(13, 120000, 80);
        public Level LevelFourteen = new Level(14, 140000, 88);
        public Level LevelFifteen = new Level(15, 165000, 96);
        public Level LevelSixteen = new Level(16, 195000, 104);
        public Level LevelSeventeen = new Level(17, 225000, 112);
        public Level LevelEighteen = new Level(18, 265000, 120);
        public Level LevelNineteen = new Level(19, 305000, 128);
        public Level LevelTwenty = new Level(20, 355000, 136);
        public Level LevelTwentyPlus = new Level(1, 355001, 137);


        public Levels()
        {
            ListofLevels = new List<Level>();
            ListofLevels.Add(LevelOne);
            ListofLevels.Add(LevelTwo);
            ListofLevels.Add(LevelThree);
            ListofLevels.Add(LevelFour);
            ListofLevels.Add(LevelFive);
            ListofLevels.Add(LevelSix);
            ListofLevels.Add(LevelSeven);
            ListofLevels.Add(LevelEight);
            ListofLevels.Add(LevelNine);
            ListofLevels.Add(LevelTen);
            ListofLevels.Add(LevelEleven);
            ListofLevels.Add(LevelTwelve);
            ListofLevels.Add(LevelThirteen);
            ListofLevels.Add(LevelFourteen);
            ListofLevels.Add(LevelFifteen);
            ListofLevels.Add(LevelSixteen);
            ListofLevels.Add(LevelSeventeen);
            ListofLevels.Add(LevelEighteen);
            ListofLevels.Add(LevelNineteen);
            ListofLevels.Add(LevelTwenty);
        }


    }
}
