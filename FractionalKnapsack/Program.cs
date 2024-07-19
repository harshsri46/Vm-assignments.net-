using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FractionalKnapsack
{
    //This class represents an item with profit and weight
    public class Item
    {
        public int Profit { get; set; }
        public int Weight { get; set; }

        public Item(int profit, int weight)
        {
            Profit = profit;
            Weight = weight;
        }

    }
    //this class contains the logic for knapsack problem
    public class FractionalKnapsack
    {
        public double GetMaxProfit(List<Item> items, int capacity)
        {
            //sort the items by value to weight ratio in descending order

            items.Sort(new SortItemByRatio());

            double totalProfit = 0.0;
            int remainingCapacity = capacity;

            //iterate through the sorted items 
            foreach (Item item in items)
            {
                //if the entire item can be taken take it
                if (item.Weight <= remainingCapacity)
                {
                    totalProfit += item.Profit;
                    remainingCapacity = item.Weight;
                }
                else
                {
                    //if only a fraction of the item can be taken ,take the fraction
                    double fraction = (double)remainingCapacity / item.Weight;
                    totalProfit += item.Profit * fraction;
                    break;//knapsack is full
                }
            }
            return totalProfit;
        }
        internal class Program
        {
            static void Main(string[] args)
            {
                List<Item> list = new List<Item>
            {
                new Item(50,3),
                new Item(40,4),
                new Item(90,6),
                new Item(10,4),
                new Item(5,1),
                new Item(11,2),
                new Item(70,5),
                new Item(15,2)
            };
                //weight capacity of knapsack
                int capacity = 20;

                //Create an instance of Fractional knapsack and find the maximum profit 
                FractionalKnapsack fractionalKnapsack = new FractionalKnapsack();

                double maxProfit = fractionalKnapsack.GetMaxProfit(items,capacity);

                //print the maximum profit 
                Console.WriteLine($"Maximum Profit:{maxProfit}");

            }
        }

        public class SortItemByRatio : IComparer<Item>
        {
            public int Compare(Item x, Item y)
            {
                double ratioX = (double)x.Profit / x.Weight;
                double ratioY = (double)y.Profit / y.Weight;
                return ratioY.CompareTo(ratioX);
            }
        }
    }
}
