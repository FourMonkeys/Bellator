using System;
namespace Bellator.Services
{
    public class ClassService
    {
        public ClassService()
        {
        }

        public int GetStartingXPForLevel(int CurrentLevel)
        {
            int xp = 0;

            if(CurrentLevel == 1)
            {
                xp = 0;
            }
            else if(CurrentLevel == 2)
            {
                xp = 300;
            }
            else if (CurrentLevel == 3)
            {
                xp = 900;
            }
            else if (CurrentLevel == 4)
            {
                xp = 2700;
            }
            else if (CurrentLevel == 5)
            {
                xp = 6500;
            }
            else if (CurrentLevel == 6)
            {
                xp = 14000;
            }
            else if (CurrentLevel == 7)
            {
                xp = 23000;
            }
            else if (CurrentLevel == 8)
            {
                xp = 34000;
            }
            else if (CurrentLevel == 9)
            {
                xp = 48000;
            }
            else if (CurrentLevel == 10)
            {
                xp = 64000;
            }
            else if (CurrentLevel == 11)
            {
                xp = 85000;
            }
            else if (CurrentLevel == 12)
            {
                xp = 100000;
            }
            else if (CurrentLevel == 13)
            {
                xp = 120000;
            }
            else if (CurrentLevel == 14)
            {
                xp = 140000;
            }
            else if (CurrentLevel == 15)
            {
                xp = 165000;
            }
            else if (CurrentLevel == 16)
            {
                xp = 195000;
            }
            else if (CurrentLevel == 17)
            {
                xp = 225000;
            }
            else if (CurrentLevel == 18)
            {
                xp = 265000;
            }
            else if (CurrentLevel == 19)
            {
                xp = 305000;
            }
            else
            {
                xp = 355000;
            }




            return xp;
        }
        public int GetLevelFromXP(int CurrentXP)
        {
            int CurrentLevel = 0;

            if (CurrentXP < 300)
            {
                CurrentLevel = 1;
            }
            else if (CurrentXP >= 300 && CurrentXP < 900)
            {
                CurrentLevel = 2;
            }
            else if (CurrentXP >= 900 && CurrentXP < 2700)
            {
                CurrentLevel = 3;
            }
            else if (CurrentXP >= 2700 && CurrentXP < 6500)
            {
                CurrentLevel = 4;
            }
            else if (CurrentXP >= 6500 && CurrentXP < 14000)
            {
                CurrentLevel = 5;
            }
            else if (CurrentXP >= 14000 && CurrentXP < 23000)
            {
                CurrentLevel = 6;
            }
            else if (CurrentXP >= 23000 && CurrentXP < 34000)
            {
                CurrentLevel = 7;
            }
            else if (CurrentXP >= 34000 && CurrentXP < 48000)
            {
                CurrentLevel = 8;
            }
            else if (CurrentXP >= 48000 && CurrentXP < 64000)
            {
                CurrentLevel = 9;
            }
            else if (CurrentXP >= 64000 && CurrentXP < 85000)
            {
                CurrentLevel = 10;
            }
            else if (CurrentXP >= 85000 && CurrentXP < 100000)
            {
                CurrentLevel = 11;
            }
            else if (CurrentXP >= 100000 && CurrentXP < 120000)
            {
                CurrentLevel = 12;
            }
            else if (CurrentXP >= 120000 && CurrentXP < 140000)
            {
                CurrentLevel = 13;
            }
            else if (CurrentXP >= 140000 && CurrentXP < 165000)
            {
                CurrentLevel = 14;
            }
            else if (CurrentXP >= 165000 && CurrentXP < 195000)
            {
                CurrentLevel = 15;
            }
            else if (CurrentXP >= 195000 && CurrentXP < 225000)
            {
                CurrentLevel = 16;
            }
            else if (CurrentXP >= 225000 && CurrentXP < 265000)
            {
                CurrentLevel = 17;
            }
            else if (CurrentXP >= 265000 && CurrentXP < 305000)
            {
                CurrentLevel = 18;
            }
            else if (CurrentXP >= 305000 && CurrentXP < 355000)
            {
                CurrentLevel = 19;
            }
            else{
                CurrentLevel = 20;
            }



            return CurrentLevel;
        }
    }
}
