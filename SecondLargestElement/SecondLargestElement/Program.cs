using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Functions;

namespace SecondLargestElement {
	class Program {
		static void Main(string[] args) {
			int[] arr = new int[10];  // 1, 2, 3, 5, 4 ...

			Console.WriteLine("Value kaun dega be: ");

			for(int i = 0; i < arr.Length; i++) {
				arr[i] = ConsoleFunc.GetInt();		
			}

			int max = 0;  // 85
			int secondMax = 0;  // 85

			for (int i = 0; i < arr.Length; i++) {
				if(arr[i] > max) {
					secondMax = max;
					max = arr[i];
				} else if(arr[i] > secondMax && arr[i] != max) {
					secondMax = arr[i];
				}
			}	

			Console.WriteLine("Max value is: " + max + " SecondMax is: " + secondMax);
		}
	}
}
