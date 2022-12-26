using System;
using System.Collections.Generic;


namespace ChallengeApp
{
class Program
    {
        static void Main(string[] args)
        {

            var names = new List<string>() {"Jacek", "Radek"};

            var numbers = new List<int>() {1,2,3};

            foreach(var n in names)
            {    
                Console.WriteLine(n);  
                
                foreach(var w in numbers) 
                {
                    Console.WriteLine(w);
                }
            }     
        }
    }  
}