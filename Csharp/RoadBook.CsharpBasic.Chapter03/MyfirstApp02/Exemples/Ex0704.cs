using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MyfirstApp02.Exemples
{
    public class Ex0704
    {
        public void Run()
        {
            Console.Write("숫자를 입력 하세요 : ");

            try
            {
                int number = Convert.ToInt32(Console.ReadLine());

                Console.WriteLine("입력 된 숫자는 {0}", number);
            }
            catch (Exception e)  //  Exception e는 예외 상황에 대한 정보를 담음
            {
                Console.WriteLine("예외 상황 발생, 관리자에게 문의하세요");
                Console.WriteLine("에러 코드 : {0}", e.HResult);  //특정 예외에 할당된 코드화된 숫자 값인 Hash 값
                Console.WriteLine("에러 메시지 : {0}", e.Message);  //예외상황을 설명하는 메시지
            }
        }
    }
}
