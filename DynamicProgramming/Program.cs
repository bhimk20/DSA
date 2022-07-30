using System;
using System.Collections.Generic;

namespace DynamicProgramming
{
    class Program
    {
        private static Dictionary<int, int> cache;

        static void Main(string[] args)
        {
            cache = new Dictionary<int, int>();
            Console.WriteLine(MinCostClimbingTree(new int[4] { 20, 15, 30, 5 }));
        }

        public static int MinCostClimbingTree(int[] cost)
        {
            if(cost == null || cost.Length == 0)
            {
                return 0;
            }
            var len = cost.Length;

            return Math.Min(MinCost(len - 1, cost), MinCost(len - 2, cost));
        }

        public static int MinCost(int len, int[] cost)
        {
            if (cache.ContainsKey(len))
            {
                return cache[len];
            }
            if (len < 2)
            {
                return cost[len];
            }

            var _mincost = cost[len] + Math.Min(MinCost(len - 1, cost), MinCost(len - 2, cost));

            cache.Add(len, _mincost);
            return cache[len];
        }
    }
}
