using System;
using System.Collections.Generic;

namespace SwinAdventure
{
	public class Locations: GameObject, IHaveInventory
	{
		private Inventory _inventory = new Inventory();

		public Locations (string name, string desc):base( new string[] { "Location", "here"} , name, desc)
		{
		}

		public GameObject Locate(string id){
			if (AreYou (id)) {
				return this;
			} else {
				return _inventory.Fetch (id);
			}
		}

		public override string FullDescription{
			get{ 
				return "In" + Name +"you can see:\r\n" + _inventory.ItemList;
			}
		}

		public Inventory Inventory{
			get{
				return _inventory;
			}
		}



	}
}

