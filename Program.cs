using System;

namespace test
{
    internal class Program
    {
        static void Main(string[] args)
        {

            int low =int.Parse(Console.ReadLine());
               int high=int.Parse(Console.ReadLine());
            

                Console.WriteLine("print prime numper from x to y");

            while(low <= high)
            {
                Boolean notprime=false;

                for (int i = 2; i <= low / 2; i++)
                {

                    if (low % i == 0)
                    {
                        notprime = true;
                        break;
                    }
                }
                if (!notprime && low != 0 && low != 0)
                    Console.WriteLine(low + "");

                ++low;
                
            }

        }
    }
}
