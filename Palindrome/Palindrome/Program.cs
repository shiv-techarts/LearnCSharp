using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Functions;

namespace Palindrome {
	class Program {
		static void Main(string[] args) {
			int number = ConsoleFunc.GetInt();
			int reverse = 0;
			int temp = number;	   // Initiallization

			while(temp != 0) {     // Condition

				reverse = (reverse * 10) + (temp % 10);

				temp /= 10;   // ++/--
			} 

			if(number == reverse) {
				Console.WriteLine("Number is Palindrome");
			} else {
				Console.WriteLine("Number is Not Plaindrome.");
			}	
													 
		}
	}
}
