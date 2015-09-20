using System;

namespace SwinAdventure
{
	/// <summary>
	/// Item.
	/// </summary>
	public class Item:GameObject
	{
		/// <summary>
		/// Initializes a new instance of the <see cref="SwinAdventure.Item"/> class.
		/// </summary>
		/// <param name="idents">Idents.</param>
		/// <param name="name">Name.</param>
		/// <param name="desc">Desc.</param>
		public Item (string[] idents, string name, string desc):base(idents,name,desc)
		{
		}
	}
}

