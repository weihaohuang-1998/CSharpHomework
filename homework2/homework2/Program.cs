using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace homework2
{
    class Program
    {
        static void Main(string[] args)
        {
            string s = "";
            int n = 0;
            Console.WriteLine("请输入一个整数");
            s = Console.ReadLine();
            n = Int32.Parse(s);
            Console.WriteLine("该整数的所有素数因子:");
            for(int i = 2; i <= n;)
            {
                if (n % i == 0)
                {
                    n = n/ i;
                    Console.WriteLine(i + " ");
                    i = 2;
                }
                else
                {
                    i++;
                }
            }
        }
    }
}
