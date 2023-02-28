using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MyfirstApp02.Exemples
{
    public class Ex0011
    {
        public void Run() {
            Console.WriteLine("숫자를 입력하세요");
            int number = Convert.ToInt32(Console.ReadLine()); //입력값 읽기 : Console.ReadLine

            if (number == 0)
            {
                Console.WriteLine("입력된 숫자는 0입니다.");
            }

            else if(number > 0)
            {
                Console.WriteLine("입력된 숫자는 양수 입니다.");
            }
            else
            {
                Console.WriteLine("입력된 숫자는 음수 입니다.");
            }


            if (number %2 == 1)
            {
                Console.WriteLine("입력된 숫자는 홀수 입니다.");
            }



            else { Console.WriteLine("입력된 숫자는 짝수 입니다."); }
           
        }
        

    }
}
