using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading;
namespace RandomWalk
{
    class RandomWalk
    {
        private static Random rand = new Random();
        private int[] walkArray;
        private int currentLocation;
        private int stepNumber;

        public RandomWalk(int size)
        {
            rand = new Random();
            walkArray = new int[size];
            currentLocation = walkArray.Length / 2;
            stepNumber = 1;

            ++walkArray[currentLocation];
        }

        public void Step()
        {
            if (Flip()) currentLocation++;
            else currentLocation--;

            CheckBounds();

            ++walkArray[currentLocation];
            stepNumber++;

            PrintVisits();

        }

        private Boolean Flip()
        {
            
            return rand.Next(2) == 0 ? true : false;
        }

        private void CheckBounds()
        {
            if (currentLocation == -1) currentLocation = walkArray.Length - 1;
            if (currentLocation == walkArray.Length) currentLocation = 0;
        }

        private void PrintVisits()
        {
           Console.Clear();


            for (int i = 0; i < walkArray.Length; i++)
            {
                Console.Write("{0,2}: ", i);

                for (int j = 0; j < walkArray[i]; j++)
                {
                    Console.Write(stepNumber);
                }

                Console.WriteLine();

               // Thread.Sleep(1);
            }

        }

    }
}
