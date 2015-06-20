using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace SimpleLinqNumberStuff
{
    class Program
    {
        static void Main(string[] args)
        {
            Program Obj = new Program();
            Obj.OddEven(); //Calls OddEven Method
            //Obj.PrimeNum(); //Incomplete

        }
	
	//Determine if value is even or odd
        public void OddEven()
        {
            var numbers =
            from n in Enumerable.Range(100, 50)
            select new { Number = n, OddEven = n % 2 == 1 ? "odd" : "even" };

            foreach (var n in numbers)
            {
                Console.WriteLine("The number {0} is {1}.", n.Number, n.OddEven);
            }
        }

	//Not finished, still need to complete
	//The code  is to determine 
        public void PrimeNum()
        {
            var PrimeNumberAlgor = from num in Enumerable.Range(1, 99)
                                   select new { PNA = num, Algor = (num / num == 1?  "True" : "False")};

            
            foreach (var number in PrimeNumberAlgor)
            {
                int numnum = number.PNA;
            }

            foreach (var pnal in PrimeNumberAlgor)
            {
                Console.WriteLine("The number {0} is prime number? \t{1}.", pnal.PNA, pnal.Algor);
            }
        }
    }
}
