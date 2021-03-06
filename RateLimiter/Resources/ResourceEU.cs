﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using RateLimiter.Model;
using RateLimiter.Repository;
using RateLimiter.Rules;
using RuleEngine;

namespace RateLimiter.Resources
{
    public class ResourceEU : ResourceBase
    {
        public ResourceEU(string token, RuleEngine.IRulesEngine rulesEngine, IRetrieveTokenInfo retrieveTokenInfo) : base(token, rulesEngine, retrieveTokenInfo)
        {
        }

        public override void DoWork()
        {
            if (!CanContinue())
                Console.WriteLine("Failed Validation.");

            Console.WriteLine("Process Request.");
        }

    }
}
