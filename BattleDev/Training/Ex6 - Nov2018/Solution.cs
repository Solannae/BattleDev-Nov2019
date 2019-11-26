using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;

namespace BattleDev.Training.Ex6___Nov2018
{
    public class Solution
    {
        public static void Solve()
        {
            const string path = @"../../../Training/Ex6 - Nov2018/input3.txt";

            double n;
            int k;
            int[] functionValues;

            using (var stream = new StreamReader(path))
            {
                n = int.Parse(stream.ReadLine());
                var values = stream.ReadLine();
                k = int.Parse(stream.ReadLine());
                functionValues = values.Split(" ").Select(u => int.Parse(u)).ToArray();
            }

            var recValues = new List<int>(functionValues).ToArray();
            var total = 0;
            var j = 0;
            var target = n / 2;

            do
            {
                if (j > 0)
                {
                    for (var i = 0; i < functionValues.Length; ++i)
                    {
                        recValues[i] = functionValues[recValues[i]];
                    }
                }

                ++j;

            } while (j < k);

            for (var i = 0; i < recValues.Length - 1; ++i)
            {
                if (recValues[i] <= target && recValues[i + 1] > target
                    || recValues[i] >= target && recValues[i + 1] < target)
                {
                    ++total;
                }
            }

            Console.WriteLine(total.ToString());
            Console.ReadKey();
        }
    }
}
