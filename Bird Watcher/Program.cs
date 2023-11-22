using System;
using System.Collections.Generic;
using System.Diagnostics.Metrics;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Bird_Watcher
{
    public class Program
    {
        public static void Main(string[] args)
        {
            //1.Check what the counts were last week
            Console.Write("Last Week's Bird Count: ");
            foreach (var count in BirdCount.LastWeek()) //call the LastWeek method and loop through the elements of the array it returns
            {
                Console.Write(count+ ", ");  //print Last Week's Bird Count with comma separation in each loop iteration
            }

            //2. Check how many birds visited today

            int[] birdsPerDay = { 2, 5, 0, 7, 4, 1 };
            var birdCount = new BirdCount(birdsPerDay); //create instance of BirdCount
            
            Console.WriteLine($"\nToday's Bird Count: {birdCount.Today()}"); //call the Today method

            //3. Increment today's count
            birdCount.IncrementTodaysCount(); //call Increment function to update last element in array
            Console.WriteLine($"Incremented Bird Count: {birdCount.Today()}"); //print the updated count using Today method

            //4. Check if there was a day with no visiting birds
            Console.Write("Visting Birds: ");
            Console.WriteLine($"{birdCount.HasDayWithoutBirds()}"); //calls HasDayWithoutBirds method 

            //5. Calculate the number of visiting birds for the first number of days
            Console.WriteLine($"Number of Birds for the past 4 days: {birdCount.CountForFirstDays(4)}"); //calls CountForFirstDays method

            // 6. Calculate the number of busy days
            Console.WriteLine($"Number of busy days: {birdCount.BusyDays()}"); //calls BusyDays method
           
        }



    }
}
