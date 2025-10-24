using System;
using System.Collections.Generic;
using System.Linq;
using System.Reflection.Metadata.Ecma335;
using System.Text;
using System.Threading.Tasks;

namespace _57TheSieve
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
