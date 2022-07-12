using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MatchmakingSystem
{
    internal class HabitBased : IMatchmakingStrategy
    {
        public HabitBased()
        {

        }

        //興趣先決(Habit-Based)：配對與自己興趣擁有最大交集量的對象（興趣交集量相同則選擇編號較小的那位）。
        public bool MakeMatch(List<Individual> individuals)
        {
            if (individuals.Count == 0)
            {
                throw new ArgumentNullException();
            }

            Console.WriteLine($"測試興趣配對，共{individuals.Count}人");
            return true;
        }
    }
}
