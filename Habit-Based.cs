using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MatchmakingSystem
{
    internal class Habit_Based : IMatchmakingStrategy
    {
        //興趣先決(Habit-Based)：配對與自己興趣擁有最大交集量的對象（興趣交集量相同則選擇編號較小的那位）。

        public void MakeMatch(Individual individual)
        {
            throw new NotImplementedException();
        }
    }
}
