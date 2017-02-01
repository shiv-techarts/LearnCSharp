using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Initials {
	class Program {
		static void Main(string[] args) {
			// " @   shivam kumar" 
			// SK

			Console.WriteLine("Enter your Name: ");
			string name = Console.ReadLine();
			char[] nameArr = name.ToCharArray(); // {'S', 'H' ......}

			for(int i = 0; i < name.Length; i++) {
				//Console.WriteLine(nameArr[i]);
				char ch = nameArr[i];
				if( ( ch >= 65 && ch <= 90 ) || ( ch >= 97 && ch <= 122 ) ) {
					if(i == 0) {
						Console.Write(Char.ToUpper(ch));
					} else if(nameArr[i - 1] == ' ') {
						Console.Write(Char.ToUpper(ch));
					}
				}

			}
			Console.WriteLine();
		}
	}
}
