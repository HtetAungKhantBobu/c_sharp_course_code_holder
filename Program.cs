using System;
using System.IO.Compression;

namespace GGWP{
    class WPGG{
        public static void Main(string[] args){
            // int counter = 11; // initiate the variable for while/do while condition
            Console.WriteLine("Starting Loop ...");
            // while loop
            // while (counter <= 10){
            //     Console.WriteLine($"Current counter value is : {counter}");
            //     counter++;
            // }

            // do while loop 
            // do{
            //     Console.WriteLine($"Current counter value is: {counter}");
            //     counter ++;
            // }while(counter <= 10);

            //for loop
            for(int counter=0;counter<=10;counter++){
                Console.WriteLine($"Current counter is : {counter}");
            }
            Console.WriteLine($"Out of the loop.");
            Console.ReadLine();
        }
        
    }
}