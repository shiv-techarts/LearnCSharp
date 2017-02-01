using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Functions;

namespace PrintSteps {

	class Program {

		public static string downSym = "_\n" +
						 " |";

		public static string upSym = " _\n" +
					   "| ";

		public static string planeSym = "__"; 

		static void Main(string[] args) {
			int steps = ConsoleFunc.GetInt();

			int up = steps % 10;
			steps /= 10;
			int plane = steps % 10;
			steps /= 10;
			int down = steps;

			for(int i = 0; i < down; i++) {
				//Console.WriteLine(downSym);
				for(int k = 0; k < i; k++) {
					Console.Write(" ");
				}
				Console.WriteLine(downSym);
			}

			

		}
	}
}
