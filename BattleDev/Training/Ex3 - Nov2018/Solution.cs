using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;

namespace BattleDev.Training.Ex3___Nov2018
{
    public class Solution
    {
        public static void Solve()
        {
            const string path = @"../../../Training/Ex3 - Nov2018/input5.txt";

            int n;
            int[] functionValues;

            using (var stream = new StreamReader(path))
            {
                n = int.Parse(stream.ReadLine());
                var values = stream.ReadLine();
                functionValues = values.Split(" ").Select(u => int.Parse(u)).ToArray();
            }

            var total = 0;
            var res = "";
            var target = n / (double) 2;

            for (var i = 0; i < functionValues.Length - 1; ++i)
            {
                if (functionValues[i] == functionValues[i + 1] && functionValues[i] == n / 2)
                {
                    res = "INF";
                    break;
                }

                if (functionValues[i] <= target && functionValues[i + 1] > target
                    || functionValues[i] >= target && functionValues[i + 1] < target)
                {
                    ++total;
                }
            }

            if (string.IsNullOrEmpty(res)) res = total.ToString();
            Console.WriteLine(res);
            Console.ReadKey();
        }
    }
}
