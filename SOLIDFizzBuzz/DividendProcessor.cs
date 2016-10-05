using System.Collections.Generic;
using System.Linq;

namespace SOLIDFizzBuzz
{
    public sealed class DividendProcessor : IDividendProcessor
    {
        private IEnumerable<IDividendRule> rules;

        public DividendProcessor(IEnumerable<IDividendRule> rules)
        {
            this.rules = rules.OrderByDescending(r => r.Divisor);
        }

        public string Process(int i)
        {
            return i == 0 ? i.ToString() : rules
                .Where(r => r.Divisor != 0)
                .FirstOrDefault(r => i % r.Divisor == 0)?
                .Message ?? i.ToString();
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
