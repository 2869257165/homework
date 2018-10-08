using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;


namespace homework4_1
{
    public delegate void clock(object sender);
    class Clock
    {
        public event clock Pclock;
        private int H, M, S;
        public Clock(int h,int m,int s)
        {
            H = h;
            M = m;
            S = s;
        }
        public void Time()
        {
           
            if(H==DateTime.Now.Hour&&M==DateTime.Now.Minute&&S==DateTime.Now.Second)
            {
                Pclock(this);
            }
            else
            {
                System.Threading.Thread.Sleep(500);
                Time();
            }
        }
    }
    class Program
    {
        
        static void Arrivetime(object sender)
        {
            Console.WriteLine("Time of arrival");
        }
        static void Main(string[] args)
        {
            Console.WriteLine("输入闹钟的时，分，秒");
            int[] A = new int[3];
            string s = Console.ReadLine();
            string[] pnum = s.Split(' ');
            for(int i=0;i<3;i++)
            {
                A[i] = int.Parse(pnum[i]);
            }
            Clock tclock = new Clock(A[0], A[1], A[2]);
            tclock.Pclock += Arrivetime;
            tclock.Time();
        }
    }
}
