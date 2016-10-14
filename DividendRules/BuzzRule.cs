using SOLIDFizzBuzz;

namespace DividendRules
{
    internal class BuzzRule : IDividendRule
    {
        public int Divisor => 5;
        public string Message => "Buzz";
    }
}
