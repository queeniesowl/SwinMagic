using NUnit.Framework;
using System;

namespace SwinAdventure
{
	[TestFixture ()]
	public class TestInventory
	{
		[Test ()]
		public void TestFindItem ()
		{
			Inventory test = new Inventory ();
			test.Put(new Item( new String[] {"shovel", "spade" }, "a shovel", "This is a might fine ..." ));
			test.Put(new Item( new String[] {"gun", "rifle" }, "a gun", "This is a a long spirally grooved ..." ));
			Assert.IsTrue (test.HasItem ("shovel"));
			Assert.IsTrue (test.HasItem ("spade"));
			Assert.IsTrue (test.HasItem ("gun"));
			Assert.IsTrue (test.HasItem ("rifle"));
		}

		[Test()]
		public void TestNoItem(){
			Inventory test = new Inventory ();
			Assert.IsFalse (test.HasItem ("gun"));
			Assert.IsFalse (test.HasItem ("rifle"));
		}

		[Test()]
		public void TestFetchItem(){
			Inventory test = new Inventory ();
			Item item1 = new Item( new String[] {"shovel", "spade" }, "a shovel", "This is a might fine ..." );
			test.Put(item1);
			Assert.AreEqual (test.Fetch ("shovel"), item1);
		}

		[Test()]
		public void TestItemList(){
			Inventory test = new Inventory ();
			test.Put (new Item (new String[] { "shovel", "spade" }, "a shovel", "This is a might fine ..."));
			test.Put (new Item (new String[] { "gun", "rifle" }, "a gun", "This is a a long spirally grooved ..."));
			Assert.AreEqual (test.ItemList, "a shovel (shovel)\r\na gun (gun)\r\n");
		}
	}
}

