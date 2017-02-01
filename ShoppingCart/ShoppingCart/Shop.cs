using System;
using System.IO;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ShoppingCart {
	class Shop {

		protected static Item[] array;

		public Shop() {
			array = new Item[5];
			insertItems();
		}

		private void insertItems() {
			string[] file = File.ReadAllLines("items.txt");

			for (int i = 0, j = 0; i < 5; i++) {	
				array[i] = new Item(file[j], double.Parse(file[j + 1]), int.Parse(file[j + 2]));
				j += 3;
			}		 		
		}

		public void printItems() {
			for(int i = 0; i < 5; i++) {
				Console.WriteLine((i + 1) + ":" + " ItemName: " + array[i].getItemName() 
								+ " Price: " + array[i].getItemPrice() 
								+ " Qty: " + array[i].getItemQty());
				Console.WriteLine();
			}
		}
	}
}
