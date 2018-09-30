using System;
namespace Bellator.Models
{
    public class Level
    {
        public Level(int LvlNo, int xp, int acp)
        {
            this.LevelNumber = LvlNo;
            this.XP = xp;
            this.ACP = acp;
        }

        public int LevelNumber { get; set; }
        public int XP { get; set; }
        public int ACP { get; set; }
    }
}
