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
            return birdsPerDay.Any(Days => Days == 0); // Checks if array has elements with value 0, returns true or false
        }

        public int CountForFirstDays(int DaystoSum)
        {
            int sum= 0; //initialises the sum to zero
            {
                for(int i = 0; i < DaystoSum; i++) //loops through the array up to the DaystoSum value passed to the method
                {
                    sum += birdsPerDay[i]; //increments the sum
                }
            }
            return sum;
        }

        public int BusyDays()
        {
            {
                int busydays = 0;

                foreach (int birds in birdsPerDay)
                {
                    if (birds >= 5) //checks if the number of birds visiting is greater or equal to 5
                    {
                        busydays++; //increments the count of the busy days if >=5
                    }
                }
                return busydays;
            }
        }
    }
}

