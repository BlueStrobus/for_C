using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MyfirstApp02.Exemples
{
    public class Ex0901
    {
        public void Run()
        {
            int[] numbers = new int[10] { 1, 2, 3, 4, 5, 6, 7, 8, 9, 10 };
            List<int> tmpNumbers = new List<int>(); //Temporary(일시적인, 임시적인)

            // 짝수찾기
            for (int idx = 0; idx < numbers.Length; idx++)
            {
                if (numbers[idx] % 2 == 0)
                {
                    tmpNumbers.Add(numbers[idx]);
                }
            }

            for (int idx = 0; idx < tmpNumbers.Count; idx++)
            {
                Console.WriteLine(tmpNumbers[idx]);
            }

            tmpNumbers.Clear();  //tmpNumber 비우기

            // 홀수 찾기
            tmpNumbers = numbers.Where(n => (n % 2) == 1).ToList();
                                                               //////////////////////////////???
            for (int idx = 0; idx < tmpNumbers.Count; idx++)
            {                                                                                                                                                                                                                                                                   
                Console.WriteLine(tmpNumbers[idx]);
            }
        }
    }
}
