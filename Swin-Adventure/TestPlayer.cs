using NUnit.Framework;
using System;

namespace SwinAdventure
{
	[TestFixture ()]
	public class TestPlayer
	{
		[Test ()]
		public void TestIdentifiable ()
		{
			Player test = new Player ("Player 1", "a funny wizard");
			Assert.IsTrue (test.AreYou("me"));
			Assert.IsTrue (test.AreYou("inventory"));
		}

		[Test()]
		public void TestLocatesItem(){
			Player test = new Player ("Player 1", "a funny wizard");
			Item item1 = new Item( new String[] {"shovel", "spade" }, "a shovel", "This is a might fine ..." );
			test.Inventory.Put (item1);
			Assert.AreEqual(test.Locate ("shovel"),item1);
		}

		[Test()]
		public void TestLocatesItself(){
			Player test = new Player ("Player 1", "a funny wizard");
			Assert.AreEqual (test.Locate("me"),test);
		}

		[Test()]
		public void TestLocatesNothing(){
			Player test = new Player ("Player 1", "a funny wizard");
			Assert.AreEqual (test.Locate("123"),null);
		}

		[Test()]
		public void TestFullDescription(){
			Player test = new Player ("Player 1", "a funny wizard");
			Item item1 = new Item( new String[] {"shovel", "spadxze" }, "a shovel", "This is a might fine ..." );
			test.Inventory.Put (item1);
			Assert.AreEqual (test.FullDescription, "You are carrying:\r\na shovel (shovel)\r\n");
		}


	}
}

