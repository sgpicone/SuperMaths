using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SuperMath
{
    public enum Difficulty
    {
        EASY, NORMAL, HARD, VERY_HARD, IMPOSSIBLE
    }

    public static class DifficultyExtensions
    {
        public static string DifficultyToString(this Difficulty diff, bool adult)
        {
            if (!adult)
            {
                switch (diff)
                {
                    case Difficulty.EASY:
                        return "Easy";
                    case Difficulty.NORMAL:
                        return "Normal";
                    case Difficulty.HARD:
                        return "Hard";
                    case Difficulty.VERY_HARD:
                        return "Very Hard";
                    case Difficulty.IMPOSSIBLE:
                        return "Impossible";
                    default:
                        return "ERROR";
                }
            }
            else
            {
                switch (diff)
                {
                    case Difficulty.EASY:
                        return "SOFT";
                    case Difficulty.NORMAL:
                        return "SEMI";
                    case Difficulty.HARD:
                        return "HARD";
                    case Difficulty.VERY_HARD:
                        return "RAGING";
                    case Difficulty.IMPOSSIBLE:
                        return "SHOVEL";
                    default:
                        return "FUCK!";
                }
            }
        }
    }
}
