﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MatchmakingSystem
{
    internal interface IMatchmakingStrategy
    {
        public void MakeMatch(Individual individual);

    }
}
