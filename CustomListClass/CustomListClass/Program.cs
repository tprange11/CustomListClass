using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CustomListClass
{
    class Program
    {
        static void Main(string[] args)
        {
            MyList<int> intList = new MyList<int>() { 5, 4, 3, 2, 1 };
 //           intList.SortBonus(intList);

            for (int i = 0; i < intList.Count; i++)
            {
                Console.WriteLine(intList[i]);
            }

            Console.ReadLine();

        }
    }
}
