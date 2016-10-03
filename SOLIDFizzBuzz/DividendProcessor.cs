using System;
using System.Collections.Generic;
using System.Linq;

namespace SOLIDFizzBuzz
{
    public class DividendProcessor : IDividendProcessor
    {
        private readonly IEnumerable<IDividendRule> rules;

        public DividendProcessor(IEnumerable<IDividendRule> rules)
        {
            this.rules = rules.OrderByDescending(r => r.Divisor);
        }

        public string Process(int i)
        {
            foreach (var rule in this.rules)
            {
                if (rule.Divisor == 0)
                {
                    return i.ToString();
                }

                if (i % rule.Divisor == 0)
                {
                    return rule.Message;
                }
            }

            return i.ToString();
        }
    }
}
