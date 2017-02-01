using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Functions {
	public class ConsoleFunc {
		public static int GetInt() {
			return int.Parse(Console.ReadLine());
		}

		public static string Reverse(string source) {
			char[] arr = source.ToCharArray();
			Array.Reverse(arr);
			return ( new String(arr) );
		}

		public static int GetIntRand(int range) {
			Random rand = new Random(DateTime.Now.Millisecond);
			return ( rand.Next() % range );
		}

		public static char CharToLower(char ch) {
			return (char)( ch + 32 );
		}

		public static char CharToUpper(char ch) {
			return (char)(ch - 32);
		}
	}
}
