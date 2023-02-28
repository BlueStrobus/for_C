using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace RoadBook.CsharpBasic.Chapter02.Exsamples
{
    public class Self01
    {
        public void Run()
        {
            #region >> 과목별 점수(~는 ~점)            
            object objKorean = "국어 100점";
            object objEngglish = "영어 100점";
            object objSuhack = "수학 98";
            object objSports = "체육 97점";
            #endregion

            Console.WriteLine("{0}, {1}, {2}, {3}의 평균을 구하여라", objKorean, objEngglish, objSuhack, objSports );

            #region >> 점수-숫자만
            int inKorean = 100;
            int inEngglish = 100;
            int inMath = 98;
            int inSports = 97;


            int inAll = inKorean + inEngglish + inMath + inSports;
            #endregion
            

            Console.WriteLine("평균 점수는 {0}점", (double)inAll / 4);


        }
    }
}
