using System;
using System.IO.Compression;

namespace GGWP{
    class WPGG{
        public static void Main(string[] args){
            int counter = 1; // initiate the variable for while condition
            Console.WriteLine("Starting Loop ...");
            while (counter <= 10){
                Console.WriteLine($"Current counter value is : {counter}");
                counter++;
            }
            Console.WriteLine($"Out of the loop. Current counter value is {counter}");
            Console.ReadLine();
        }
        
    }
}