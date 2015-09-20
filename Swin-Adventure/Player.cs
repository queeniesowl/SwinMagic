using System;

namespace SwinAdventure
{
	/// <summary>
	/// Player.
	/// </summary>
	public class Player : GameObject, IHaveInventory
	{
		private Inventory _inventory = new Inventory();
		private Locations _location = new Locations("entry", "the entry of....");

		/// <summary>
		/// Initializes a new instance of the <see cref="SwinAdventure.Player"/> class.
		/// </summary>
		/// <param name="name">Name.</param>
		/// <param name="desc">Desc.</param>
		public Player (string name, string desc):base( new string[] { "me", "inventory"} , name, desc)
		{

		}

		/// <summary>
		/// Locate the yourself or a item
		/// </summary>
		/// <param name="id">Identifier.</param>
		public GameObject Locate(string id){
			GameObject control; 
			if (AreYou (id)) {
				return this;
			} else {
				control = _inventory.Fetch (id);
				if (control == null) {
					control = _location.Locate (id);
				}
				return control;
			}
		}

		/// <summary>
		/// Gets the full description.
		/// </summary>
		/// <value>The full description.</value>
		public override string FullDescription {
			get {
				if (_inventory.ItemList == null) {
					return "You are carrying nothing";
				} else {
					return "You are carrying:\r\n" + _inventory.ItemList;
				}
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

		public Locations Location{
			get{
				return _location;
			}set{ 
				 _location = value;
			}
		}
	}
}

