using SOLIDFizzBuzz;

namespace WindowsFormsUI.DividendRules
{
    internal class FizzRule : IDividendRule
    {
        public int Divisor => 3;

        public string Message => "Fizz";
    }
}
