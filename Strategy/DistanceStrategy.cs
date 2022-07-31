using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MatchmakingSystem
{
    internal class DistanceStrategy : IMatchmakingStrategy
    {
        GameMessage message = new GameMessage();
        private bool _isReverse = false;
        public DistanceStrategy()
        {
            _isReverse = message.SetReverse();
        }

        //**距離先決(Distance-Based)：**配對與自己距離最近的對象（距離相同則選擇編號較小的那位）。
        public List<Individual> MakeMatch(List<Individual> pairList)
        {
            Individual target = pairList[0];
            pairList.RemoveAt(0);

            pairList = pairList.OrderBy(individual => individual.Coord.Distance(target.Coord)).ToList();
            Individual bestPair = _isReverse ? pairList.Last() : pairList.First();

            List<Individual> pairResult = new List<Individual>();
            pairResult.Add(target);
            pairResult.Add(bestPair);

            message.PrintDistance(bestPair, target);
            message.PrintData("Distance", pairResult);
            return pairResult;
        }

    }

}
