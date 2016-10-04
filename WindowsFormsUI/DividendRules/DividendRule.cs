using SOLIDFizzBuzz;

namespace WindowsFormsUI.DividendRules
{
    public class DividendRule : IDividendRule
    {
        public DividendRule()
        {
            
        }
        public DividendRule(int divisor, string message)
        {
            Divisor = divisor;
            Message = message;
        }

        public int Divisor { get; }
        public string Message { get; }
    }
}
