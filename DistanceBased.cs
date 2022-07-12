using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MatchmakingSystem
{
    internal class DistanceBased : IMatchmakingStrategy
    {
        public DistanceBased()
        {
            
        }

        //**距離先決(Distance-Based)：**配對與自己距離最近的對象（距離相同則選擇編號較小的那位）。
        //1. 假設自己的座標為 $(x, y)$ 而對象的座標為$(x^\prime, y^\prime)$，則距離公式為：
        public bool MakeMatch(List<Individual> individuals)
        {
            if (individuals.Count == 0)
            {
                throw new ArgumentNullException();
            }

            Console.WriteLine($"測試距離配對，共{individuals.Count}人");
            return true;
        }
    }
    
}
