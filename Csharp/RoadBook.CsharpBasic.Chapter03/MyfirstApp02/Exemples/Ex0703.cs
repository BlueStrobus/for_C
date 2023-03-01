using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MyfirstApp02.Exemples
{
    public class Ex0703
    {  /// <summary>
    /// try ~ catch
    /// 예외가 발생해도 지정한 동작(catch) 후 정상 작동
    /// </summary>
    
        public void Run()
        {
            Console.Write("숫자를 입력하세요 : ");

            try  //시도 해보고
            {
                int number = Convert.ToInt32(Console.ReadLine());

                Console.WriteLine("입력된 숫자는 {0}", number);
            }
            catch (Exception) //예외 발생 시 실행
            {
                Console.WriteLine("예외 상황 발생");
            }
        }
    }
}
