using SOLIDFizzBuzz;

namespace WindowsFormsUI.DividendRules
{
    internal class FizzBuzzRule : IDividendRule
    {
        public int Divisor => 15;
        public string Message => "FizzBuzz";
    }
}
