using System.Collections.Generic;
using System.Linq;

namespace SOLIDFizzBuzz
{
    public sealed class DividendProcessor : IDividendProcessor
    {
        private IEnumerable<IDividendRule> _rules;

        public DividendProcessor(IEnumerable<IDividendRule> rules)
        {
            _rules = rules.OrderByDescending(r => r.Divisor);
        }

        public string Process(int i)
        {
            return i == 0 ? i.ToString() : _rules
                .Where(r => r.Divisor != 0)
                .FirstOrDefault(r => i % r.Divisor == 0)?
                .Message ?? i.ToString();
        }
        
        public void Register(params IDividendRule[] newRules)
        {
            var temp = _rules.Concat(newRules);
            _rules = temp.OrderByDescending(r => r.Divisor);
        }
    }
}
