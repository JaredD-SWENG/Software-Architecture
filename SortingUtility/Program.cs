using System;
using System.Collections.Generic;

namespace Lab04
{
    class Program
    {
        public static void Main(string[] args)
        {
            List<ProductIF> desks = new List<ProductIF>();

            
            //initialize Desk objects
            Desk d1 = new Desk("12312314", "Home", 20.30);
            Desk d2 = new Desk("90873223", "Office", 15.25);
            Desk d3 = new Desk("13804157", "School", 25.13);
            Desk d4 = new Desk("15157631", "Den", 5.85);
            
            //Add Desks to List
            desks.Add(d1);
            desks.Add(d2);
            desks.Add(d3);
            desks.Add(d4);

            //Initialize bubble sort utility object
            Utility<ProductIF> utility = new BubbleSortUtility<ProductIF>();
            Console.WriteLine("Performing Bubble Sort:");
            utility.sort(desks);

            //Initialize utility to be a quicksort object.
            utility = new QuickSortUtility<ProductIF>("quicksort");
            Console.WriteLine("Performing Quick Sort Utility:");

            //reset desk list to sort with new algorithm
            desks.Clear();
            desks.Add(d1);
            desks.Add(d2);
            desks.Add(d3);
            desks.Add(d4);

            //sort using quick sort.
            utility.sort(desks);
  
        }
    }
}
