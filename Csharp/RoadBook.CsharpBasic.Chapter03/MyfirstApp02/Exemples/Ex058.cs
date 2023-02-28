using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MyfirstApp02.Exemples
{
    public class Ex058
    {
        public void Run()
        {
            GasolineCar008 gasolineCar = new GasolineCar008();
            gasolineCar.Color = "검정";
            gasolineCar.Size = "SUV";
            ElectronicCar008 electronicCar = new ElectronicCar008();
            electronicCar.Color = "초록";
            electronicCar.Size = "경차";

            Console.WriteLine("{0}색 {1}가", gasolineCar.Color, gasolineCar.Size);
            gasolineCar.Go(); //Car008 에서 상속받은 Go
            Console.WriteLine("{0}색 {1}가", electronicCar.Color, electronicCar.Size);
            electronicCar.Left(); //Car008 에서 상속받은 Leht
        }
    }

    class Car008
    {
        public string Color { get; set; }
        public string Size { get; set; }

        public void Engine_on()
        {
            Console.WriteLine("시동을 켭니다.");
        }

        public void Engine_off()
        {
            Console.WriteLine("시동을 끕니다.");
        }

        public void Go()
        {
            Console.WriteLine("전진합니다.");
        }

        public void Back()
        {
            Console.WriteLine("후진합니다.");
        }

        public void Left()
        {
            Console.WriteLine("좌회전합니다.");
        }

        public void Right()
        {
            Console.WriteLine("우회전합니다.");
        }
    }


    // class  자식 : 부모클래스
    class GasolineCar008 : Car008 { }  // 상속
    class ElectronicCar008 : Car008 { } // 상속
}
