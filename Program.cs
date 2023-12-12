using System;
using System.IO.Compression;

namespace GGWP{
    class WPGG{
        public static void Main(string[] args){
            // declare int a, and b to operate
            int a,b;

            //string template to prompt number
            string num_prompt = "Type a number, and then press Enter";
            Console.WriteLine(num_prompt);

            //get a
            a = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine(num_prompt);

            //get b
            b = Convert.ToInt32(Console.ReadLine());

            //prompt operand (+,-,*,/)
            Console.WriteLine("Choose an option from the following list:\n\ta - Add\n\ts - Substract\n\tm - Multiplication\n\td - Division");

            switch(Console.ReadLine()){
                case "a":
                    Console.WriteLine($"Your Result: {a} + {b} = {a+b}");
                    break;
                case "s":
                    Console.WriteLine($"Your Result: {a} - {b} = {a-b}");
                    break;
                case "m":
                    Console.WriteLine($"Your Result: {a} * {b} = {a*b}");
                    break;
                case "d":
                    Console.WriteLine($"Your Result: {a} / {b} = {a/b}");
                    break;
                default:
                    Console.WriteLine("Are you too stupid to read that simple instructions?");
                    break;
            }
        }
        
    }
}