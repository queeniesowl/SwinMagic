using NUnit.Framework;
using System;

namespace SwinAdventure
{
	[TestFixture ()]
	public class TestItem
	{
		[Test ()]
		public void TestItemIdentifiable ()
		{
			Item test = new Item( new String[] {"shovel", "spade" }, "a shovel", "This is a might fine ..." );
			Assert.IsTrue (test.AreYou ("shovel"));
			Assert.IsTrue (test.AreYou ("ShOvel"));
			Assert.IsTrue (test.AreYou ("spade"));
			Assert.IsFalse (test.AreYou ("ABC"));
		}

		[Test()]
		public void TestShortDescription(){
			Item test = new Item( new String[] {"shovel", "spade" }, "a shovel", "This is a might fine ..." );
			Assert.AreEqual(test.ShortDescription, "a shovel (shovel)");
		}

		[Test()]
		public void TestFullDescription(){
			Item test = new Item( new String[] {"shovel", "spade" }, "a shovel", "This is a might fine ..." );
			Assert.AreEqual (test.FullDescription, "This is a might fine ...");
		}
	}
}

