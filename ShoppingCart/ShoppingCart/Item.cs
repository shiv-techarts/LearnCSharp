using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ShoppingCart {
	class Item {
		private string itemName { get; set; }
		private double itemPrice { get; set; }
		private int itemQty { get; set; }

		public Item(string item, double price, int qty) {
			itemName = item;
			itemPrice = price;
			itemQty = qty;
		}

		public string getItemName() {
			return itemName;
		}

		public double getItemPrice() {
			return itemPrice;
		}

		public int getItemQty() {
			return itemQty;
		}

		public void setItemQty(int qty) {
			if (itemQty != 0)
				itemQty = qty;
		}

		public void increaseQty() {
			itemQty++;
		}

		public void decreaseQty() {
			if(itemQty != 0)
				itemQty--;
		}
	}
}
