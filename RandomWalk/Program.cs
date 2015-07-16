using System;


namespace RandomWalk
{
    class Program
    {
      

        static void Main(string[] args)
        {

            RandomWalk walk = new RandomWalk(35);

            for(int i = 0; i < 1000; i++)
            {
                walk.Step();
            }

          




        }
    }
}
