using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Functions;

namespace Diamond {
	class Program {
		static void Main(string[] args) {
			
			Console.WriteLine("Enter the size: ");

			int size = ConsoleFunc.GetInt();

			for(int i = 0; i < size; i++) {
				for(int k = 0; k < (size - i); k++) {
					Console.Write(" ");
				}
				for(int j = 0; j < i; j++) {
					Console.Write((char)222 + " ");
				}
				Console.WriteLine();
			}

			for (int i = 0; i < size; i++) {		 
				for (int k = 0; k < i; k++) {
					Console.Write(" ");
				}
				for (int j = 0; j < (size - i); j++) {
					Console.Write( (char) 222 + " ");
				}
				Console.WriteLine();
			}

			for (int i = 0; i < size; i++) {
				for (int k = 0; k < (size - 1); k++) {
					Console.Write(" ");
				}
				Console.WriteLine((char)222);
			}
		}
	}
}
