using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _59TheLambdaSieve
{
    public class Sieve
    {
        private Func<int, bool> _filter;

        public Sieve(Func<int, bool> filter)
        {
            _filter = filter;
        }
        public bool IsGood(int number)
        {
            return _filter(number);
        }
    }
}
