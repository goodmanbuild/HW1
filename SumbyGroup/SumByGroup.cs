using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Collections;

namespace SumbyGroup
{
    public class SumByGroup
    {
        //public void CalculatSum(IEnumerable<int> items, int groupCount, Func<int>)
        //{

        //}

        public List<int> CalculatSum<T>(List<Item> items, int groupCount, Func<Item, int> func)
        {


            var sum = 0;
            var result = new List<int>();
            var collectionCount = items.Count();
            if (items == null || collectionCount == 0)
            {
                throw new ArgumentOutOfRangeException();
            }
            for (int i = 0 ; i < collectionCount ; i++)
            {
                Item item = items[i];

                sum += func(item);

                if ((i + 1) % groupCount == 0 || (i == collectionCount - 1))
                {
                    result.Add(sum);
                    sum = 0;
                }

            }

            return result;
        }
    }

    public class Item
    {
        public int Id { get; set; }
        public int Cost { get; set; }
        public int Revenue { get; set; }
        public int SellPrice { get; set; }
    }
}
