using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace StringReverse {
	class Program {
		static void Main(string[] args) {

			Console.WriteLine("Apan nam de: ");
			string name = Console.ReadLine();

			char[] arr = name.ToCharArray();	// { 'S', 'D', 'E'} 
			Array.Reverse(arr);                 // { 'E', 'D', 'S'}
			String nameInReverse = new String(arr);	  // 

			Console.WriteLine("Pachu se nam hai: " + nameInReverse);

		}
	}
}
