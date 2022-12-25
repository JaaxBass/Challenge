using System;
using System.Collections.Generic;


namespace ChallengeApp
{
class Program
    {
        static void Main(string[] args)
        {

            var numbers = new List<double>() {13.8, 6.3, 10.0};

            var result = 0.0;

            foreach(var n in numbers)
            {
                result += n;   
            }

            result /= numbers.Count;


            Console.WriteLine($"Average is: {result:N4}");
            
        if(args.Length > 0)
        {
            Console.WriteLine("Hello " + args[0]);
        }
        else
        {
            Console.WriteLine("Hello");
        }


        }
    }

   
    
}