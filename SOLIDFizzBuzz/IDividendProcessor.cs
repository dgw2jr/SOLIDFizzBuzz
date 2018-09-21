using System.Collections.Generic;

namespace SOLIDFizzBuzz
{
    public interface IDividendProcessor
    {
        string Process(int i);
        
        void Register(params IDividendRule[] newRules);
    }
}