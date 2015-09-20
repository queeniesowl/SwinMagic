using System;

namespace SwinAdventure
{
	/// <summary>
	/// Command.
	/// </summary>
	public abstract class Command:IdentifiableObject
	{

		/// <summary>
		/// Initializes a new instance of the <see cref="SwinAdventure.Command"/> class.
		/// </summary>
		/// <param name="ids">Identifiers.</param>
		public Command (string[] ids):base(ids)
		{
		}

		public abstract string Execute(Player p, string[] text);
	}
}

