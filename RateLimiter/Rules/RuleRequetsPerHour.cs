﻿using RuleEngine;
using RateLimiter.Model;

namespace RateLimiter.Rules
{
    public class RuleRequetsPerHour : IRule
    {
        public string Name => "RuleRequetsPerHour";

        private const int hitLimit = 100;

        public void Execute(IRuleEnvironment environment)
        {
            var result = environment.GetFact<RuleResult>("result");
            if (!result.Allow)
                return;
            TokenInfo tokenInfo = environment.GetFact<TokenInfo>("tokenInfo");

            if (tokenInfo.NoOfTimesCalledInLastHour >= hitLimit)
            {
                result.Allow = false;
                result.Message = "X requests per hour reached.";
            }
        }
    }
}
