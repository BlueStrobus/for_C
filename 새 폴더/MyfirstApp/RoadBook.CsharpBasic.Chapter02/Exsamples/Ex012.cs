 using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
namespace RoadBook.CsharpBasic.Chapter02.Exsamples
{
    internal class Ex012
    {
        public void BeginBuild(Microsoft.Build.Execution.BuildParameters parameters, System.Collections.Generic.IEnumerable<Microsoft.Build.Execution.BuildManager.DeferredBuildMessage> deferredBuildMessages);

        const float pieValue = 3.14f;

        public void Run()
        {
            const float pieValue = 3.14f;
            Console.WriteLine("파이는 {0}", pieValue);
        }
    }
}
