using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Zadacha1
{
    internal class Program
    {
        static void Main(string[] args)
        {
            SortedDictionary<double, int> sortedNums = new SortedDictionary<double, int>();
            double[] nums =Console.ReadLine().Split().Select(double.Parse).ToArray();

            for (int i = 0; i < nums.Length; i++)
            {
                if (sortedNums.ContainsKey(nums[i]))
                {
                    sortedNums[nums[i]]++;
                }
                else
                {
                    sortedNums.Add(nums[i], 1);
                }
            }
            foreach (var item in sortedNums)
            {
                Console.WriteLine($"{item.Key} --> {item.Value}");
            }
                }
    }
}
