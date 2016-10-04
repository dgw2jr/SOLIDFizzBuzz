using System;
using System.Collections.Generic;
using System.Linq;

namespace SOLIDFizzBuzz
{
    public class DividendProcessor : IDividendProcessor
    {
        private IEnumerable<IDividendRule> rules;

        public DividendProcessor(IEnumerable<IDividendRule> rules)
        {
            this.rules = rules.OrderByDescending(r => r.Divisor);
        }

        public string Process(int i)
        {
            if (i == 0)
            {
                return i.ToString();
            }

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

        public void Register(IDividendRule newRule)
        {
            var temp = new List<IDividendRule> { newRule };
            this.Register(temp);
        }

        public void Register(IEnumerable<IDividendRule> newRules)
        {
            var temp = this.rules.Concat(newRules);
            this.rules = temp.OrderByDescending(r => r.Divisor);
        }
    }
}
