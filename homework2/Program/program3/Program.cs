using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace program3
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("2-100中素数是：");
            int[] numbers = new int[99];
            for(int i=0;i<numbers.Length;i++)
            {
                numbers[i] = i + 2;
            }
            for(int i=2;i<=numbers.Length;i++)//使数组中i的倍数的数等于0
            {
                for(int j=i-1;j<numbers.Length;j++)
                {

                    if(numbers[j]%i==0)
                    {
                        numbers[j] = 0;
                    }
                }
            }
            foreach(int i in numbers)//输出数组中筛选后不为0的数
            {
                if(i!=0)
                    Console.WriteLine(i);
            }
        }
    }
}
