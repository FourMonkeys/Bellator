using System;
using Bellator.Models;

namespace Bellator.Services
{
    public class ConversionService
    {
        public int CurrentXP { get; set; }
        public int CurrentLevel { get; set; }
        public int StartingXPForCurrentLevel { get; set; }
        public int NextLevelNumber { get; set; }
        public int StartingXPForNextLevel { get; set; }
        public int ACPNeededForNextLevel { get; set; }
        public bool RoundUp { get; set; }
        public bool SlowProgression { get; set; }
        public int TotalACPEarned { get; set; }
        public int NextLevelRequiredACP { get; set; }

        private int ACP;
       
        public ConversionService(int CurrLevel, int CurrXP, bool RoundUp, 
                                 bool SlowProgression)
        {
            ClassService classService = new ClassService();
            this.CurrentLevel = CurrLevel;
            this.CurrentXP = CurrXP;
            this.RoundUp = RoundUp;
            this.SlowProgression = SlowProgression;
            this.StartingXPForNextLevel = 
                classService.GetStartingXPForLevel(this.CurrentLevel+1);

        }

        public int GetACPForCurrentLevel()
        {
            Levels levels = new Levels();
            Level CurrLevel = null;
            //Get the stats for the next level
            foreach (Level level in levels.ListofLevels)
            {

                if (level.LevelNumber == CurrentLevel)
                {
                    CurrLevel = level;
                }

            }
            return CurrLevel.ACP;

        }

        public int ConvertXPToACP()
        {
            ClassService classService = new ClassService();


            if (this.CurrentLevel == 20)
            {
                //If the character has reached the max level
                //no need to continue
                return 136;
            }

            try
            {
                /*
                 * (A) Current XP
                 */
                var currentXP = this.CurrentXP;

                /*
                 * (B) Current Level
                 */
                var currentLevel = this.CurrentLevel;

                /*
                 * (C) Starting XP for Current Level
                 */
                var currentLevelStartingXP = classService.GetStartingXPForLevel(
                    this.CurrentLevel);

                /*
                 * (D) Next Level
                 */
                var nextLevel = currentLevel + 1;

                /*
                 * (E)Starting XP for next level 
                 */
                var nextLevelStartingXP = classService.GetStartingXPForLevel(nextLevel);

                /*
                 * (F) ACP Needed for next level
                 */
                var acpNeededForNextLevel = 4;


                if (nextLevel >= 5)
                    acpNeededForNextLevel = 8;

                NextLevelRequiredACP = acpNeededForNextLevel;

                /*
                 * (G) Current XP - Starting XP of Current level
                 */
                var XPAboveCurrentLevel = currentXP - currentLevelStartingXP;

                /*
                 * (H) E - C XP Remaining to advance to next level
                 */
                var xpRemainingToAdvanceToNextLevel = nextLevelStartingXP
                    - currentLevelStartingXP;

                /*
                 * (I) G / H - How close are they to advancing to the next level?
                 */
                double percentageToNextLevel =
                    Convert.ToDouble(XPAboveCurrentLevel)
                          / Convert.ToDouble(xpRemainingToAdvanceToNextLevel);

                /*
                 * (J) I * F
                 */
                var acpUnrounded = percentageToNextLevel * acpNeededForNextLevel;

                if (this.SlowProgression)
                {
                    acpUnrounded = acpUnrounded / 2;
                }
                /*
                 * Round ACP up or down, depending on 
                 */
                if (this.RoundUp)
                {
                    this.ACP = (int)Math.Ceiling(Convert.ToDouble(acpUnrounded));
                }
                else
                {
                    this.ACP = (int)Math.Floor(Convert.ToDouble(acpUnrounded));
                }



                ACPNeededForNextLevel = acpNeededForNextLevel - this.ACP;
            }
            catch (Exception exc){
                var e = exc.Message;
            }
            return ACP;
        }
    }
}
