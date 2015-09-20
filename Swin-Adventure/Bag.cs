using System;

namespace SwinAdventure
{
	/// <summary>
	/// Bag. A item which own a inventory 
	/// </summary>
	public class Bag :Item, IHaveInventory
	{
		private Inventory _inventory = new Inventory();

		/// <summary>
		///  A item which own a inventory 
		/// </summary>
		/// <param name="ids">Identifiers.</param>
		/// <param name="name">Name.</param>
		/// <param name="desc">Desc.</param>
		public Bag (string[] ids, string name, string desc):base(ids, name,desc)
		{
		}

		/// <summary>
		/// Locate the bag itself ot the item in it.
		/// </summary>
		/// <param name="id">Identifier.</param>
		public GameObject Locate(string id){
			if (AreYou (id)) {
				return this;
			} else {
				return _inventory.Fetch (id);
			}
		}

		/// <summary>
		/// Gets the full description.
		/// </summary>
		/// <value>The full description.</value>
		public string FullDescription{
			get{ 
				return "In the " + Name + " you can see:\r\n" + _inventory.ItemList;
			}
		}

		/// <summary>
		/// Gets the inventory.
		/// </summary>
		/// <value>The inventory.</value>
		public Inventory Inventory{
			get{
				return _inventory;
			}
		}
	}
}

