using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp1
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("samad agah!");
            while(true)
            { 
                var x = Console.ReadKey();
                if(x.Key == ConsoleKey.NumPad0)
                    break;
            }
        }
    }
}
