using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace RoadBook.CsharpBasic.Chapter02.Exsamples
{
    public class Ex005
    {
        public void Run()
        {
            object objHello = "Hello world";
            var vHello = "Hello world";
            dynamic dHello = "Hello world";

            bool isContainsWorld01 = objHello.ToString().Contains("Hello");
            bool isContainsWorld02 = vHello.ToString().Contains("Hello");
            bool isContainsWorld03 = dHello.ToString().Contains("Hello");

            Console.WriteLine("object 변수에 Hello가 포함되어 있다. ? {0}", isContainsWorld01);
            Console.WriteLine("var 변수에 Hello 가 포함되어 있다. ? {0}", isContainsWorld02);
            Console.WriteLine("dynamic 변수에 Hello가 포함되어 있다. ?  {0}", isContainsWorld03);
        }
    }
}
