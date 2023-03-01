using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MyfirstApp02.makeDb
{
    public class Db003
    {
        private readonly string currentDirectory = Environment.CurrentDirectory;

        public void Run()
        {
            FileInfo fileInfo = new FileInfo(currentDirectory + @"\data\log.txt");

            Console.WriteLine("저장경로 : {0}", fileInfo.DirectoryName);
            Console.WriteLine("파일명 : {0}", fileInfo.Name);

            Console.WriteLine("=== 파일 내용 ===");
            using (StreamReader sr = new StreamReader(fileInfo.FullName))
            {
                string line = string.Empty;
                while ((line = sr.ReadLine()) != null)
                {
                    Console.WriteLine(line);
                }
            }
        }
    }
}
