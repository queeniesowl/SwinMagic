using System;
using System.Collections.Generic;

namespace SwinAdventure
{
	/// <summary>
	/// Identifiable object.
	/// </summary>
	public class IdentifiableObject
	{
		private List<string> _identifiers = new List<string>();

		/// <summary>
		/// Initializes a new instance of the <see cref="SwinAdventure.IdentifiableObject"/> class.
		/// </summary>
		/// <param name="idents">Idents.</param>
		public IdentifiableObject (String[] idents)
		{
			foreach (string i in idents) {
				_identifiers.Add (i.ToLower());
			}
		}

		/// <summary>
		/// Are you. Check if you are the element.
		/// </summary> 
		/// <returns><c>true</c>, if you was ared, <c>false</c> otherwise.</returns>
		/// <param name="id">Identifier.</param>
		public bool AreYou(string id){
			bool result = false;
			foreach (string i in _identifiers) {
				if (id.ToLower() == i) {
					result = true;
					break;
				}
			}
			return result;
		}

		/// <summary>
		/// Gets the firstid.
		/// </summary>
		/// <value>The firstid.</value>
		public string Firstid{
			get{ 
				return _identifiers [0];
			}
		}

		/// <summary>
		/// Adds the identifier.
		/// </summary>
		/// <param name="id">Identifier.</param>
		//public void AddIdentifier(string id){
		protected void AddIdentifier(string id){
			_identifiers.Add (id.ToLower ());
		}
			
	}
}

