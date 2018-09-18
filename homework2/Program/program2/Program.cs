using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace program2
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
            for (int i = 0; i < k; i++)
            {
                numbers[i] = int.Parse(pnum[i]);
            }
            Console.WriteLine("最大数是：" + max(numbers));
            Console.WriteLine("最小数是："+mini(numbers));
            Console.WriteLine("和为："+sum(numbers));
            Console.Write("平均值为：" + aver(numbers));
            int max(int [] a)
            {
                int temp=a[0];
                for(int i=0;i<a.Length;i++)
                {
                    if(temp<=a[i])
                    { temp = a[i]; }
                }
                return temp;
            }
            int mini(int [] a)
            {
                int temp = a[0];
                for (int i = 0; i < a.Length; i++)
                {
                    if (temp >= a[i])
                    { temp = a[i]; }
                }
                return temp;
            }
            int sum(int[]a)
            {
                int temp=0;
                for(int i=0;i<a.Length;i++)
                {
                    temp += a[i];
                }
                return temp;
            }
            double aver(int[]a)
            {
                double temp=0;
                for (int i = 0; i < a.Length; i++)
                {
                    temp += a[i];
                }
                return temp / (a.Length);
            }
        }
        
    }
}
