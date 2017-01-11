﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SumbyGroup
{
    class Program
    {
        static void Main(string[] args)
        {
            var sumByGroup = new SumByGroup();
            var target = new List<Item>();
            target.Add(new Item { Id = 1, Cost = 1, Revenue = 11, SellPrice = 21 });
            target.Add(new Item { Id = 2, Cost = 2, Revenue = 12, SellPrice = 22 });
            target.Add(new Item { Id = 3, Cost = 3, Revenue = 13, SellPrice = 23 });
            target.Add(new Item { Id = 4, Cost = 4, Revenue = 14, SellPrice = 24 });
            target.Add(new Item { Id = 5, Cost = 5, Revenue = 15, SellPrice = 25 });
            target.Add(new Item { Id = 6, Cost = 6, Revenue = 16, SellPrice = 26 });
            target.Add(new Item { Id = 7, Cost = 7, Revenue = 17, SellPrice = 27 });
            target.Add(new Item { Id = 8, Cost = 8, Revenue = 18, SellPrice = 28 });
            target.Add(new Item { Id = 9, Cost = 9, Revenue = 19, SellPrice = 29 });
            target.Add(new Item { Id = 10, Cost = 10, Revenue = 20, SellPrice = 30 });
            target.Add(new Item { Id = 11, Cost = 11, Revenue = 21, SellPrice = 31 });
            var result = sumByGroup.CalculatSum<Item>(target, 3, t => t.Cost);

            Console.ReadKey();
        }
    }
}
