using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MatchmakingSystem
{
    internal class MatchSystem
    {
        private List<Individual> _individualList;
        private IMatchmakingStrategy _matchmakingStrategy;

        public MatchSystem(List<Individual> individualList, IMatchmakingStrategy matchmakingStrategy)
        {
            this._individualList = individualList;
            this._matchmakingStrategy = matchmakingStrategy;
        }

    }
}
