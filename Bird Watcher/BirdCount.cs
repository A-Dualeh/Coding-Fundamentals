using System;
using System.Linq;

namespace Bird_Watcher
{
    public class BirdCount
    {
        private int[] birdsPerDay;
        public BirdCount(int[] BirdsPerDay)
        {
            this.birdsPerDay = BirdsPerDay;
        }
        public static int[] LastWeek() //static method with array as the return type
        {
            int[] BirdCountLastWeek = { 0, 2, 5, 3, 7, 8, 4 }; //count of birds stored in an array
            return BirdCountLastWeek; //return the full array
        }
        public int Today()
        {
            return birdsPerDay.Last(); //return only the last element in the array
        }
        public void IncrementTodaysCount()
        {
            birdsPerDay[birdsPerDay.Length - 1] += 1; //increment the last element(Today's count) by 1
        }
        public bool HasDayWithoutBirds()
        {
            return birdsPerDay.Contains(0); // Checks if array has elements with value 0, returns true or false
        }
        public int CountForFirstDays(int DaystoSum)
        {
            return birdsPerDay.Take(DaystoSum).Sum(); // Returns the sum of the array up to the given index in DaystoSum
        }
        public int BusyDays()
        {
            return birdsPerDay.Count(day => day >= 5); // Returns the count of elements in the array that are >=5  
        }
    }
}

