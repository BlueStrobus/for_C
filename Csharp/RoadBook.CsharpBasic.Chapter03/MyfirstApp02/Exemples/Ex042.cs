using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MyfirstApp02.Exemples
{
    public class Ex042
    {
        public void Run()
        {
            const int number = 2;

            for (int index = 1; ;)
            {
                Console.WriteLine("{0} * {1} = {2}", number, index, number * index);

                if (index == 9)
                {
                    break;
                }

                index = index + 1;
            }
        }
    }
}
