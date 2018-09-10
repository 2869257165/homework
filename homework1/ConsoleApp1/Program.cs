using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp1
{
    class Program
    {
        static void Main(string[] args)
        {
            string s = "";
            double a = 0;
            double b = 0;
            Console.WriteLine("please input first numble");
            s = Console.ReadLine();
            a = Double.Parse(s);
            Console.WriteLine("please input second numble");
            s = Console.ReadLine();
            b = Double.Parse(s);
            Console.WriteLine("The resurt is:" + (a * b) );
        }
    }
}
