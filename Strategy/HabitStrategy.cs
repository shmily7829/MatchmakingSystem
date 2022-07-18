using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MatchmakingSystem
{
    internal class HabitStrategy : IMatchmakingStrategy
    {
        private bool isReverse = false;
        public HabitStrategy()
        {

        }

        //興趣先決(Habit-Based)：配對與自己興趣擁有最大交集量的對象（興趣交集量相同則選擇編號較小的那位）。
        public List<Individual> MakeMatch(List<Individual> individuals)
        {
            List<Individual> pairList = new List<Individual>();

            if (isReverse)
            {
                pairList = MakeReverseBestPair(individuals);
            }
            else
            {
                pairList = MakeBestPair(individuals);
            }

            return pairList;
        }

        private List<Individual> MakeBestPair(List<Individual> pairList)
        {
            List<Individual> pairResult = new List<Individual>();

            Individual target = pairList.Where(c => c.Id == 1).First();
            pairList.Remove(target);

            Individual bestPair =pairList.OrderByDescending(otherIndividual => otherIndividual.Habits.Intersect(target.Habits).Count()).First();


            pairResult.Add(target);
            pairResult.Add(bestPair);

            return pairResult;
        }

        private List<Individual> MakeReverseBestPair(List<Individual> individuals)
        {
            return individuals;
        }
    }
}
