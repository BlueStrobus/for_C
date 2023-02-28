using System;

namespace RoadBook.CsharpBasic.Chapter02.Examples
{
    public class Ex001
    {
        public void Run()
        { // ""나 ''는 숫자말고 문자형데이터에만 사용
            //정수
            sbyte shortByteNumber = 127;  // 변수타입 변수명 = 데이터;    sbyte 타입을 가진 변수의 이름을 shortByteNumbrt로 지정해주었습니다.
            byte byteNumber = 0;
            short shortNumber = 32767;
            int intNumber = 20000;
            long longNumber = 50000;
            //실수
            float floatNumber = 3.14f;
            double doubleNumber = 1.5;
            decimal decimalNumber = 5.5m;

            Console.WriteLine("정수 : {0}, {1}, {2}, {3}, {4}",
                shortByteNumber,
                byteNumber,
                shortNumber,
                intNumber,
                longNumber
            );

            Console.WriteLine("실수 : {0}, {1}, {2}",
                floatNumber,
                doubleNumber,
                decimalNumber
            );

        }
    }
}
