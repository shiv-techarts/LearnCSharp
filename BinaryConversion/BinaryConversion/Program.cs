using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BinaryConversion {
	class Program {
		static void Main(string[] args) {
			// Convert To Binary

			Console.WriteLine("Enter a number: ");

			int number = int.Parse(Console.ReadLine());

			string binaryString = null;

			while(number != 0) {
				int temp = number % 2;

				binaryString += temp.ToString();

				number /= 2;
			}

			// Reverse a String

			char[] arr = binaryString.ToCharArray();
			Array.Reverse(arr);
			String finalString = new String(arr);

			Console.WriteLine("Binary is: " + finalString);

		}
	}
}
