using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MyfirstApp02.Exemples
{
    public class Ex067
    {
        /// <summary>
        /// ArrayList 수정 명령어
        /// 추가 :  리스트명.Add(변수);    
        ///   예)  for (int idx = 0; idx < 10; idx++)
        ///          {
        ///               aList.Add(idx); 
        ///           }
        ///          
        /// 삽입 :  리스트명.Insert(위치, 변수);
        /// 삭제 :  리스트명.RemoveAt(위치); 
        /// </summary>





        public void Run()
        { //ArrayList  -  배열의 크기가 정해져 있지 않은 자료구조, 모든 타입의 변수 이용가능
            // 배열처럼 인덱스 이용하여 할당된 값불러올 수 있음. 값을 할당할 수 있음, 배열과는 달리 크기지정X, 값을 추가, 삭제하면 자동으로 
            //      C# 에서 자료구조를 표현하는 컬랙션: 배열, 스텍, 큐 등
            ArrayList aList = new ArrayList();

            for (int idx = 0; idx < 10; idx++)
            {
                aList.Add(idx); // 정수(int)형 변수
            }

            for (int idx = 10; idx < 15; idx++)
            {
                aList.Add(idx.ToString()); // 문자(string)형 변수
            }

            //////////// 중간에 삽입///////////////////
            aList.Insert(5, "100"); // aList [5]에 100을 삽입
            ////////////////////////////// ==>결과 : 변수 위치[5]의 값이 100으로 바뀌고, [5]에 있던 값(5)부터 다음 자리로 한칸씩 밀려난다.
            ///
            for (int idx = 0; idx < aList.Count; idx++)
            {
                Console.WriteLine("Value: {0} / Type: {1}",
                    aList[idx], aList[idx].GetType()
                );
            }
        }
    }
}
