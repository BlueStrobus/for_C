using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MyfirstApp02.Exemples
{
    public class Ex068
    {
        public void Run()
        {
            ArrayList aList = new ArrayList();

            for (int idx = 0; idx < 10; idx++)
            {
                aList.Add(idx);
            }

            for (int idx = 10; idx < 15; idx++)
            {
                aList.Add(idx.ToString());
            }

            aList.Insert(5, "100");

            for (int idx = 0; idx < aList.Count; idx++)
            {
                Console.WriteLine("Value: {0} / Type: {1}",
                    aList[idx], aList[idx].GetType()
                );
            }

            aList.RemoveAt(5);
            
            for (int idx = 0; idx < aList.Count; idx++)
            {
                Console.WriteLine("Value: {0} / Type: {1}",
                    aList[idx], aList[idx].GetType());
            }
           
        }
    }
}
