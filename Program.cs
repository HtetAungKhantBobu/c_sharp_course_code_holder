using System;
using System.IO.Compression;

namespace GGWP{
    class WPGG{
        public static void Main(string[] args){
            // declare int a, and b to operate
            string str;

            Console.WriteLine("Enter a string");

            str = Console.ReadLine(); // "hell" -> str = "hell"
            int len = str.Length; // str -> "hell" -> len = 4
            Console.WriteLine($"String Length: {len}");

            int amount = 1 - len % 2; // len=4-> 1 - 4 % 2-> 1-0-> 1 -> amount=1
            Console.WriteLine($"amount: {amount}");

            string mid_string = str.Substring(len/2-amount, 1+amount);
            // စဖြတ်မယ့်နေရာ/index -> len/2-amount -> 4/2-1 -> 2-1->1 -> index -> 1
            // ဖြတ်မယ့် စာလုံးအရည်အတွက် -> 1+amount -> 1 + 1 -> 2
            // hell -> el
            Console.WriteLine(mid_string);


        }
        
    }
}