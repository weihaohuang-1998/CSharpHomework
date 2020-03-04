using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace homework2_2
{
    class Program
    {
        static void Main(string[] args)
        {

            int[] arr = new int[10];
            Random rd = new Random();
            
            for (int i = 0; i < arr.Length; i++)
            {
                arr[i] = rd.Next(1, 10);
            }

            //遍历
            for (int i = 0; i < arr.Length; i++)
            {
                Console.Write(arr[i] + "\t");
            }
            Console.WriteLine();
            //求数组元素的最大值
            int maxValue = arr[0];
            for (int i = 1; i < arr.Length; i++)
            {
                if (maxValue < arr[i])
                {
                    maxValue = arr[i];
                }
            }
            Console.WriteLine("最大值为：" + maxValue);
            //求数组元素的最小值
            int minValue = arr[0];
            for (int i = 1; i < arr.Length; i++)
            {
                if (minValue > arr[i])
                {
                    minValue = arr[i];
                }
            }
            Console.WriteLine("最小值为：" + minValue);
            //求数组元素的总和
            int sum = 0;
            for (int i = 0; i < arr.Length; i++)
            {
                sum += arr[i];
            }
            Console.WriteLine("总和为：" + sum);
            //求数组元素的平均数
            int avgValue = sum / arr.Length;
            Console.WriteLine("平均数为：" + avgValue);
        }
        
    }
}
