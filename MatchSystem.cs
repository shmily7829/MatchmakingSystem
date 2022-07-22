using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MatchmakingSystem
{
    internal class MatchSystem
    {
        public List<Individual> PairResult;

        //private IMatchmakingStrategy _matchmakingStrategy;

        public MatchSystem(IMatchmakingStrategy matchmakingStrategy, List<Individual> individuals)
        {        
            PairResult = matchmakingStrategy.MakeMatch(individuals);
        }
    }
}
