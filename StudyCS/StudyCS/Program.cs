using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace StudyCS
{
    class Program
    {
        static void Main(string[] args)
        {
            string[] stArrayData = Console.ReadLine().Trim().Split(' ');

            int i = int.Parse(stArrayData[0]);
            int j = int.Parse(stArrayData[1]);
            Console.WriteLine(i + j);

        }
    }
}
