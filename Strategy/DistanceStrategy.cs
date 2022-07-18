using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MatchmakingSystem
{
    internal class DistanceStrategy : IMatchmakingStrategy
    {
        private bool isReverse = false;
        public DistanceStrategy()
        {
            
        }

        //**距離先決(Distance-Based)：**配對與自己距離最近的對象（距離相同則選擇編號較小的那位）。
        public List<Individual> MakeMatch(List<Individual> pairList)
        {
            Individual target = pairList[0];
            pairList.RemoveAt(0);

            var bestPair = pairList.OrderBy(individual => individual.Coord.Distance(target.Coord)).First();

            Console.WriteLine($"Distance: {Math.Round(bestPair.Coord.Distance(target.Coord),2)}");

            List<Individual> pairResult = new List<Individual>();
            pairResult.Add(target);
            pairResult.Add(bestPair);

            return pairResult;
        }
    }

}
