using System;

namespace SwinAdventure
{
	/// <summary>
	/// Look command.
	/// </summary>
	public class LookCommand:Command
	{
		/// <summary>
		/// Look Command
		/// </summary>
		public LookCommand ():base(new string[] {"look"})
		{
		}

		/// <summary>
		/// Execute the look command.
		/// </summary>
		/// <param name="p">P.</param>
		/// <param name="text">Text.</param>
		public override string Execute(Player p, string[] text){
			string output = "";
			if (text.Length == 3 || text.Length == 5) {
				if (text [0].ToLower () != "look") {
					output = "Error in look input";
				} else if (text [1].ToLower () != "at") {
					output = "What do you want to look at?";
				} else if (text.Length == 3) {
					output = LookAtIn (p, text [2], "inventory");
				} else if (text.Length == 5) {
					if (text [3].ToLower () != "in") {
						output = "What do you want to look in?";
					} else {
						output= LookAtIn (p, text [2], text [4]);
					}
				}
			}else{
				output= "I don’t know how to look like that";
			}

			return output;
		}

		/// <summary>
		/// Looks at in.
		/// </summary>
		private string LookAtIn(Player p, string thingId, string containerId){
			string output = "";
			GameObject obj= p.Locate (containerId);

			if (obj != null) {
				IHaveInventory container = obj as IHaveInventory;
				if (container.Locate (thingId) != null) {
					output = container.Locate (thingId).FullDescription;
				} else {
					if (containerId == "inventory") {
						output = "I cannot find the " + thingId;
					} else {
						output = "I cannot find the " + thingId + " in the " + containerId;
					}
				}
			} else {
				output = "I cannot find the " + containerId;
			}
			return output;
		}
	}
}

