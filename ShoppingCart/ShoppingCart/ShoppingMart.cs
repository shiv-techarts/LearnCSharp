using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Functions;

namespace ShoppingCart {
	public class ShoppingMart {
		public ShoppingMart() {
			Shop shop = new Shop();
			Cart cart = new Cart();
			
			bool buyMore = false;

			while(!buyMore) {
				Console.Clear();
				shop.printItems();
				Console.WriteLine("Type the Item No and Qty: ");
				int itemNo = ConsoleFunc.GetInt();
				int itemQty = ConsoleFunc.GetInt();

				cart.addItem(itemNo, itemQty);

				Console.WriteLine("Do you want to Buy More (Yes/No)");
				string choice = Console.ReadLine();

				if(("no").Equals(choice.ToLower())) {
					buyMore = true;
				}

				cart.printCart();
			}
		}
	}
}
