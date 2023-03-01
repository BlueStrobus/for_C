using System;
using System.IO;
/// using구문(using System.IO;)을 사용하지 않을 경우
///     StreamWriter sw = new StreamWriter(currentDirectory + @"\data\db002.txt";
///     sw.WriteLine("프로그램 실행 시간: {0}", DateTime.Now);
///     sc.Close();
/// 를 써야함, Close 꼭 잊지말고
///
///



/*
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
*/

// 파일에 내용 입해보기
// 파일 실행시간 입력
namespace MyfirstApp02.makeDb
{
    public class Db002
    {
        private readonly string currentDirectory = Environment.CurrentDirectory;

        public void Run()
        {
            // System.IO.StreamWriter 클래스명 = new StreamWriter(파일경로, 덮어쓸지 여부)
            using (StreamWriter sw = new StreamWriter(currentDirectory + @"\data\log.txt", true))
            { // 엎어쓰기 여부에 'true'를 적었으니
                // 파일(Db002.cs  현재 파일) 실행할 때 마다 프로젝트 경로에 log.txt파일은 여러 줄로 계속해서 기록됨
                sw.WriteLine("프로그램 실행 시간: {0}", DateTime.Now);
            }
        }
    }
}
