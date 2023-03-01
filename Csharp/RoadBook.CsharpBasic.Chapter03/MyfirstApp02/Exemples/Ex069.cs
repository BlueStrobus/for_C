using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MyfirstApp02.Exemples
{
    public class Ex069
    {
        public void Run()
        {/////////////////////////////
         //큐 Queue
            ///  변수명.Enqueue(String.Format("{0}번 승객", idx));  //Enqueue:대기열에 넣다
            ///      변수명.Enqueue("새로운승객");
            ///  변수명.Dequeue();  // Dequeue : 댁; 
            ///  큐의 출력을 의미하기도 하지만, Double-ended Queue의 준말이기도 하다.
            //즉, Dequeue(덱)은 양쪽에서 넣고 빼고가 가능한 특이한 큐를 의미한다.
            //pushBack, pushFront로 뒤/ 앞으로 넣을 수 있고, popBack, popFront로 뒤/ 앞에서 뺄 수 있다.
            //덱은 스택과 큐를 합쳐놓은것과 같은데, pushFront + popBack 혹은 pushBack +popFront는 큐
            // pushFront + popFront 혹은 pushBack +popBack은 스택과 동일하게 기능한다. (이해 쉽다)
            ///
            ///


            ////////////////////////////
            Queue que = new Queue();
            ///////////////////////////////////////////////////
            for (int idx = 1; idx < 11; idx++)
            {
                que.Enqueue(String.Format("{0}번 승객", idx));  //Enqueue:대기열에 넣다
            }

            Console.WriteLine("* 정류장 승객 현황");
            foreach (object obj in que)
            {
                Console.WriteLine(obj.ToString());
            }
            Console.WriteLine("==========================");
            Console.WriteLine("버스가 도착했습니다. (6명 승차 가능)");

            for (int i = 0; i < 6; i++)
            {
                que.Dequeue();
            }

            Console.WriteLine("버스가 출발했습니다.");
            Console.WriteLine("==========================");

            Console.WriteLine("새로운 승객이 줄을 섭니다.");
            que.Enqueue("새로운승객");

            Console.WriteLine("* 정류장 승객 현황");
            foreach (object obj in que)
            {
                Console.WriteLine(obj.ToString());
            }
            Console.WriteLine("==========================");
        }
    }
}
