using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Functions;

namespace Factorial {
	class Program {

		public static long factorial(int number) {
			// Base Case
			if(number == 1) {
				return 1;
			} else {    // Working Case
				return number * factorial(number - 1);
			}
			 
		}

		static void Main(string[] args) {
			// 5 * 4 * 3 * 2 * 1
			// 5 * 4
			// 20 * 3
			// 60 * 2
			// 120 * 1
			int startTime = System.DateTime.Now.Millisecond;


			Console.WriteLine("Enter a number: ");
			int number = ConsoleFunc.GetInt();

			Console.WriteLine("Factorial is: " + factorial(number));

			//long fact = number;

			//for(int i = ( number - 1 ); i >= 1; i--) {
			//	fact = fact * i;	
			//}

			//Console.WriteLine("Factorial : " + fact);

			int endTime = System.DateTime.Now.Millisecond;
			

			Console.WriteLine("Duration is: " + (endTime - startTime) + "ms" );
			
			//Console.WriteLine(TimeSpan.FromMilliseconds(DateTime.Now.Millisecond) + "ms");
		}
	}
}
