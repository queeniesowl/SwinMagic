using System;
using System.Collections.Generic;

namespace SwinAdventure
{
	/// <summary>
	/// Inventory. The item storage.
	/// </summary>
	public class Inventory
	{
		private List<Item> _items = new List<Item>();

		/// <summary>
		/// The Item storage
		/// </summary>
		public Inventory (){
		}

		/// <summary>
		/// Check if a specific item is in the inventory
		/// </summary>
		/// <returns><c>true</c> if this instance has item the specified id; otherwise, <c>false</c>.</returns>
		/// <param name="id">Identifier.</param>
		public bool HasItem(string id){
			bool result = false;
			foreach (Item i in _items) {
				if (i.AreYou (id)) {
					result = true;
					break;
				}
			}
			return result;
		}

		/// <summary>
		/// Put the specified item into the inventory.
		/// </summary>
		/// <param name="item">Item.</param>
		public void Put(Item item){
			_items.Add (item);
		}

		/// <summary>
		/// Take the specified item out of the inventory.
		/// </summary>
		/// <param name="id">Identifier.</param>
		public Item Take(string id){
			Item result= null;
			foreach (Item i in _items) {
				if (i.AreYou (id)) {
					result = i;
					break;
				}
			}
			_items.Remove (result);
			return result;
		}

		/// <summary>
		/// Find the item
		/// </summary>
		/// <param name="id">Identifier.</param>
		public Item Fetch(string id){
			Item result = null;
			foreach (Item i in _items) {
				if (i.AreYou (id)) {
					result = i;
					break;
				}
			}
			return result;
		}

		/// <summary>
		/// Gets the item list.
		/// </summary>
		/// <value>The item list.</value>
		public string ItemList{
			get{ 
				string result = null;
				foreach (Item i in _items) {
					result += (i.ShortDescription+ "\r\n");
				}
				return result;
			}
		}
	}
}

