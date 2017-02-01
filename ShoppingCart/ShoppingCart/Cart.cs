using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ShoppingCart {
	class Cart : Shop {
		private List<Item> cartList;

		private int count { get; set; }

		public Cart() {
			cartList = new List<Item>();
			count = 0;
		}

		public void addItem(int choice, int qty) {
			Item item = GetRealItem(choice, qty);
			item.setItemQty(qty);
			cartList.Add(item);
		
		}

		private Item GetRealItem(int choice, int qty) {

			Item item = null;

			switch (choice) {
				case 1: item = Shop.array[0]; 
					break;
				case 2:	item = Shop.array[1];
					break;
				case 3:	item = Shop.array[2];
					break;
				case 4:	item = Shop.array[3];
					break;
				case 5:	item = Shop.array[4];
					break;
				default:
					break;
			}

			//item.setItemQty(item.getItemQty() - qty);

			return item;
		}

		public void printCart() {
			for(int i = 0; i < cartList.Count; i++) {
				Console.WriteLine(cartList[i].getItemName() + " " + cartList[i].getItemQty());
			}
		}

	}
}
