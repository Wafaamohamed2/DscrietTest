using System;

namespace Task_2
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Enter your range");
            int number1 =int.Parse(Console.ReadLine());
            int number2=int.Parse(Console.ReadLine());


            Console.WriteLine("Get all perfct numbers in the range");

            for(int i = number1; i <= number2; i++)
            {
                decimal sum = 0;
                for(int j = 1; j < i; j++)
                {
                    if(i%j==0)
                        sum=sum + j;

                }

                if (sum == i)
                    Console.WriteLine(i);

            }


            
        }
    }
}
