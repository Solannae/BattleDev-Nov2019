using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;

namespace BattleDev.Training.Ex2___Nov2018
{
    public class Solution
    {
        public static void Solve()
        {
            var n = 0;
            var path = @"../../../Training/Ex2 - Nov2018/input5.txt";
            var words = new List<string>();

            using (var stream = new StreamReader(path))
            {
                n = int.Parse(stream.ReadLine());
                for (var i = 0; i < n; ++i)
                {
                    words.Add(stream.ReadLine());
                }
            }

            var vowels = new List<string> {"a", "e", "i", "o", "u", "y"};

            var filteredList = words.Where(u =>
                u.Length >= 5 && u.Length <= 7 && u[1] - u[0] == 1 && vowels.Contains(u[u.Length - 1].ToString()));

            Console.WriteLine(filteredList.Count());
        }
    }
}
