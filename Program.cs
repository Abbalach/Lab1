using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lab1
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Really new text" + (new Random()).Next(0,10));
            Console.WriteLine("Develop branch");
            Console.ReadKey();
        }
    }
}
