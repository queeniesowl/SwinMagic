using System;

namespace SwinAdventure
{
	class MainClass
	{
		public static void Main (string[] args)
		{
			string _playerName;
			string _playerDesc;
			LookCommand _lookCommand = new LookCommand ();

			Console.WriteLine ("Welcome to Swin-Adventure");
			Console.WriteLine ("+―++―++―++―++―++―++―+\r\n");
			Console.WriteLine ("Please enter your name:");
			_playerName = Console.ReadLine();
			Console.WriteLine ("Please enter your description:");
			_playerDesc = Console.ReadLine();

			Player _player = new Player (_playerName, _playerDesc);
			_player.Inventory.Put(new Item( new String[] {"map" }, "an incomplete map", "This is an incomplete map of......" ));
			_player.Inventory.Put(new Item( new String[] {"gun", "rifle" }, "a gun", "This is a a long spirally grooved ..." ));
			Bag _bag = new Bag (new string[]{"Bag", "Backpack"}, "a bag", "This is a bag for....");
			Item item1 = new Item( new String[] {"shovel", "spade" }, "a shovel", "This is a might fine ..." );
			_bag.Inventory.Put (item1);
			_player.Inventory.Put (_bag);

			string _command;
			string _output;
			String[] _commandArr;

			do {
				Console.WriteLine ("Enter a command or enter 'exit' to exit the game");
				_command = Console.ReadLine ();
				if (_command.ToLower () == "exit") {
					Console.WriteLine ("Press enter to exit");
					Console.ReadLine ();
					break;
				} else {

					_commandArr = ToStringArray (_command);
					_output = _lookCommand.Execute (_player, _commandArr);
					Console.WriteLine (_output);
				}
			} while (_command.ToLower () != "exit");

		}

		private static string[] ToStringArray(string s){
			string[] strArr = null;
			char[] splitchar = { ' ' };
			strArr = s.Split(splitchar);
			return strArr;
		}
	}
}


