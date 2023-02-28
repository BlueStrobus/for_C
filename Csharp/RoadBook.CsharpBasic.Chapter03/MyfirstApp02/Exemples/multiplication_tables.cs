using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MyfirstApp02.Exemples
{ 

    public class multiplication_tables
    {
        public void Run()
        {
            Console.WriteLine("구구단을 외자!\n구구단을 외자!\n몇단을 외어 볼까요?");
            int number = Convert.ToInt32(Console.ReadLine());
            int i = 1;
            while (i <10 ) {
                int multiplicationTables = number * i;
                Console.WriteLine("{0} 곱하기 {1}은 {2}!", number, i, multiplicationTables);
                i = i + 1;
             }

            //Console.WriteLine("{0} 곱하기 1은 {1}\n{0} 곱하기 2는 {2}\n{0} 곱하기 3은 {1}\n\n\n\n\n\n\n\n{0}단 끝!")
        }
    }
}
