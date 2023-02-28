using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MyfirstApp02.Exemples
{
    public class Ex045
    {
        public void Run()
        {
            Console.WriteLine("팩토리를 구해봅시다!\n숫자를 입력하세요");

            int index = Convert.ToInt32(Console.ReadLine());

            Console.WriteLine("{0}의 팩토리를 구하자!", index);

            
            int fac042 = 1;

            for (; index > 0 ; index--)
            {
                fac042  *= index; // 여기에 int 적지마
            }
            Console.WriteLine(fac042);

                //for, index == 0되면 break

            
        }
    }
}
