using System;
using System.Linq;
namespace Datastructures
{
    public class petrol_price
    {
        public void sellOrBuy()
        {
            int[]  price = new int[] {7, 6, 5, 3, 1, 4, 2};
            string[] day = new string[] {"Sunday", "Monday", "Tuesday", "Wednesday", "Thursday", "Friday", "Saturday"};

            int max = price.Max();     // finding maximum petrol price from the price array
            int min = price.Min();      //  finding minimum petrol price from the price array
            int max_day = price.ToList().IndexOf(max);            // getting the index of the maximum petrol price
            int min_day = price.ToList().IndexOf(min);             // getting the index of the minimum petrol price
            Console.Write("Buy petrol on {0} with best price of  Rs.{1}\n", day[min_day], min);
            Console.Write("Sell petrol on {0} with best price of  Rs.{1}\n", day[max_day], max);
        }
    }
}