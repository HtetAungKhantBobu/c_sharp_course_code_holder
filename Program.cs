using System;
using System.IO.Compression;

namespace GGWP{
    class WPGG{

        public bool isPrime(int num){
            if (num <= 1){
                return false;
            }
            else if(num % 2 == 0){
                if (num > 2){
                    return false;
                }
            }
            else{
                for(int c=3; c<=num/2; c++){
                    if (num % c == 0){
                        return false;
                    }
                }
            }
            return true;
        }

        public static void Main(string[] args){
            WPGG wpgg_instance_1 = new WPGG();
            Console.WriteLine("Enter a Number");
            int n = Convert.ToInt32(Console.ReadLine());
            bool res = wpgg_instance_1.isPrime(n);
            Console.WriteLine($"{n} is prime? : {res}");
        }
        
    }
}