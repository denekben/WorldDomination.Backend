﻿using Shared.Exceptions;

namespace Shared.Domain
{
    public abstract class ValueObject
    {
        protected void CheckRule(IBusinessRule rule)
        {
            if (rule.IsBroken())
            {
                throw new WorldDominationBusinessRuleException(rule.Message);
            }
        }
    }
}
