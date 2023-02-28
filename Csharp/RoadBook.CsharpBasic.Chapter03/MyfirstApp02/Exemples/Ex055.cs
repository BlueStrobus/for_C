using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MyfirstApp02.Exemples
{
    public class Ex055
    {
        public void Run()
        {
            Sum(1, 1);
            Sum(2, 2);
            Sum(3, 3);
            Sum(8, 32);
        }

        private void Sum(int x, int y)
        {
            Console.WriteLine("{0} + {1} = {2}", x, y, x + y);
        }
    }
}
