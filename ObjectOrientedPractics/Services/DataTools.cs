using ObjectOrientedPractics.Model;
using ObjectOrientedPractics.Model.Enums;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ObjectOrientedPractics.Services
{
    public delegate bool Compare(Item item);
    public delegate bool CompareSort(Item item1, Item item2);
    public static class DataTools
    {
        public static bool CostFilter(Item item)
        {
            return item.Cost > 5000;
        }

        public static bool CategoryFilter(Item item)
        {
            return item.Category == Category.Cereals;
        }

        public static List<Item> Filter(List<Item> items, Func<Item, bool> compare)
        {
            List<Item> list = new List<Item>();
            foreach (Item item in items)
            {
                if (compare(item))
                {
                    list.Add(item);
                }
            }
            return list;
        }

        public static bool NameSort(Item item1, Item item2)
        {
            return string.Compare(item1.Name, item2.Name) < 0;
        }

        public static bool CostAscendingSort(Item item1, Item item2)
        {
            return item1.Cost < item2.Cost;
        }

        public static bool CostDiscendingSort(Item item1, Item item2)
        {
            return item1.Cost > item2.Cost;
        }

        public static List<Item> Sort(List<Item> items, CompareSort compare)
        {
            List<Item> list = new List<Item>();
            foreach (Item item in items)
            {
                list.Add(item);
            }
            for (int i = 0; i < list.Count; i++)
            {
                for (int j = 1; j < list.Count; j++)
                {
                    if (compare(list[j], list[j - 1]))
                    {
                        Item temp = list[j];
                        list[j] = list[j - 1];
                        list[j - 1] = temp;
                    }
                }
            }
            return list;
        }
    }
}
