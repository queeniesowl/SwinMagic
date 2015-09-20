using NUnit.Framework;
using System;

namespace SwinAdventure
{
	[TestFixture ()]
	public class TestBag
	{
		[Test ()]
		public void TestBagLocationItems ()
		{
			Bag test = new Bag (new string[]{"Bag", "Backpack"}, "a bag", "This is a bag for....");
			Item item1 = new Item( new String[] {"shovel", "spade" }, "a shovel", "This is a might fine ..." );
			test.Inventory.Put (item1);
			Assert.AreEqual(test.Locate ("shovel"),item1);
		}

		[Test()]
		public void TestBagLocateItself(){
			Bag test = new Bag (new string[]{"Bag", "Backpack"}, "a bag", "This is a bag for....");
			Assert.AreEqual(test.Locate ("Bag"),test);
		}

		[Test()]
		public void TestBagLocateNothing(){
			Bag test = new Bag (new string[]{"Bag", "Backpack"}, "a bag", "This is a bag for....");
			Assert.AreEqual(test.Locate ("Sth"),null);
		}

		[Test()]
		public void TestBagFullDesc(){
			Bag test = new Bag (new string[]{"Bag", "Backpack"}, "bag", "This is a bag for....");
			Item item1 = new Item( new String[] {"shovel", "spade" }, "a shovel", "This is a might fine ..." );
			test.Inventory.Put (item1);
			Assert.AreEqual(test.FullDescription,"In the bag you can see:\r\na shovel (shovel)\r\n");
		}
	}
}

