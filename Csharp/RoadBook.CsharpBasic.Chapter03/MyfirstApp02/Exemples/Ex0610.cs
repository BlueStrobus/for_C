using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MyfirstApp02.Exemples
{
    public class Ex0610
    {
        //Stack
        public void Run()
        {
            Stack stk = new Stack();
           ///////////////////////////////////////////////////////
            
            
            Console.WriteLine("* 시 작 점");
            for (int idx = 1; idx < 11; idx++)
            {
                Console.WriteLine("{0}번 선수 도착", idx);
                stk.Push(string.Format("{0}번 선수", idx));
                ////////////////////////////////////////////////////////////////////////////
            }
            Console.WriteLine("=====");
            Console.WriteLine("5~10등 선수는 탈락합니다.");
            for (int idx = 0; idx < 6; idx++)
            {
                stk.Pop();
                /////////////////////////
            }
            Console.WriteLine("=====");

            Console.WriteLine("* 올림픽 대표선수 명단");
            foreach (object obj in stk) //이걸 몰라
            {
                Console.WriteLine(obj.ToString());
            }
        }
    }
}
