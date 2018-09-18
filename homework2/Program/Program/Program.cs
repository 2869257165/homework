using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Program
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("输入数组的长度:");
            int k = int.Parse(Console.ReadLine());
            int[] numbers = new int[k];
            Console.WriteLine("输入元素，以空格间隔:");
            string s = Console.ReadLine();
            string[] pnum = s.Split(' ');
            for (int i=0;i<k;i++)
            {
                numbers[i] = int.Parse(pnum[i]);
            }
            Console.WriteLine("素数是：");
            foreach (int i in numbers)
            {
                bool p = true;//控制是否输出
                for(int j=2;j<i;j++)//筛选是否为素数
                {
                    if(i%j==0)
                    {
                        p=false;
                        break;
                    }
                }
                if (p == true)
                { Console.WriteLine(i); }
            }
        }
    }
}
