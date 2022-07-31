using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MatchmakingSystem
{
    internal class HabitStrategy : IMatchmakingStrategy
    {
        GameMessage message = new GameMessage();
        private bool _isReverse = false;

        public HabitStrategy()
        {
            _isReverse = message.SetReverse();
        }

        //興趣先決(Habit-Based)：配對與自己興趣擁有最大交集量的對象（興趣交集量相同則選擇編號較小的那位）。
        public List<Individual> MakeMatch(List<Individual> pairList)
        {
            return MakeBestPair(pairList);
        }

        private List<Individual> MakeBestPair(List<Individual> pairList)
        {
            Individual target = pairList.Where(c => c.Id == 1).First();
            pairList.Remove(target);

            pairList = pairList.OrderByDescending(otherIndividual => otherIndividual.Habits.Intersect(target.Habits).Count()).ToList();
            Individual bestPair = _isReverse ? pairList.Last() : pairList.First();

            List<Individual> pairResult = new();
            pairResult.Add(target);
            pairResult.Add(bestPair);


            message.PrintData("Result", pairResult);
            return pairResult;
        }
    }
}
