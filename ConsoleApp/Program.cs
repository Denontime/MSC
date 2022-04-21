using System;
using System.Collections.Generic;

namespace ConsoleInClassApp
{
    class Program
    {
        static void Main(string[] args)
        {
            //Console.Write("请输入第" + (i + 1) + "个人的年龄：");
            //myClass[i] = Convert.ToInt32(Console.ReadLine());

            //int SumGrade = 0;
            //float AvgGrade;
            //Dictionary<string, int> keyValuePairs = new Dictionary<string, int>();
            //keyValuePairs.TryAdd("景珍", 90);
            //keyValuePairs.TryAdd("林惠洋", 65);
            //keyValuePairs.TryAdd("成蓉", 88);
            //keyValuePairs.TryAdd("洪南昌", 70);
            //keyValuePairs.TryAdd("龙玉民", 46);
            //keyValuePairs.TryAdd("单江开", 81);
            //keyValuePairs.TryAdd("田武山", 100);
            //keyValuePairs.TryAdd("王三明", 68);

            //foreach (var Grade in keyValuePairs.Values)
            //{
            //    SumGrade += Grade;
            //}
            //AvgGrade = SumGrade / keyValuePairs.Count;

            //Console.WriteLine($"平均分是{AvgGrade}，高于平均分的有：");

            //foreach (string Name in keyValuePairs.Keys)
            //{
            //    if (keyValuePairs[Name] > AvgGrade)
            //    {
            //        Console.Write($"{Name} ");
            //    }
            //}

            Random ran = new Random();
            int RandNum = ran.Next(0, 50);

            Console.WriteLine("请输入一个0-50之间的数：");
            int Input = Convert.ToInt32(Console.ReadLine());

            while (true)
            {
                if (Input > RandNum)
                {
                    Console.WriteLine($"您猜大了，这个数字比{Input}小：");
                }
                if (Input < RandNum)
                {
                    Console.WriteLine($"您猜小了，这个数字比{Input}大：");
                }
                if (Input == RandNum)
                {
                    Console.WriteLine($"恭喜您猜对了，这个数字为：{Input}");
                    break;
                }
                Input = Convert.ToInt32(Console.ReadLine());
            }

        }
    }
}
