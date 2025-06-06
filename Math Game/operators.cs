using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Math_Game
{
    public class operators
    {
        public int add(int x, int y)
        {
            return x + y;
        }

        public int subtract(int x, int y)
        { 
            return x - y;    
        }

        public int multiply(int x, int y)
        {
            return x * y;
        }
        public int divison(int x, int y)
        {
            if ( (x % y) == 0)
            {
                return x / y;
            }
            else
            {
                return 0;
            }
        }
    }
}
