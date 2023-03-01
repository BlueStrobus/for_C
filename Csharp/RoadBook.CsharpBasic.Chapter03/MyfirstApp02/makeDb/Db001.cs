using System;
using System.IO;
//using System.Collections.Generic;
//using System.Linq;
//using System.Text;
//using System.Threading.Tasks;

namespace MyfirstApp02.makeDb
{
    public class Db001
    {
        private readonly string currentDirectory = Environment.CurrentDirectory;

        public void Run()
        {
            DirectoryInfo directoryInfo = new DirectoryInfo(
                currentDirectory + @"\data"
            );

            if (!directoryInfo.Exists)
            {
                directoryInfo.Create();

                Console.WriteLine("디렉토리가 생성 되었습니다.");
            }

            Console.WriteLine("생성 경로 : {0}", directoryInfo.FullName);
        }
    }
}
