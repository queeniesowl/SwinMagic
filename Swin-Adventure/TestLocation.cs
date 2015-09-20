using NUnit.Framework;
using System;

namespace SwinAdventure
{
	[TestFixture ()]
	public class TestLocation
	{
		[Test ()]
		public void TestIdentify ()
		{
			Locations _test = new Locations("entry","the entry of ...");
			Assert.AreEqual (_test.Locate("here"),_test);
		}

		[Test()]
		public void TestLocateItem(){
			Locations _test = new Locations("entry","the entry of ...");
			Item item1 = new Item( new String[] {"shovel", "spade" }, "a shovel", "This is a might fine ..." );
			_test.Inventory.Put (item1);
			Assert.AreEqual (_test.Locate("shovel"),item1);
		}

		[Test()]
		public void TestPlayerLocateinLocation(){
			Player test = new Player ("Player 1", "a funny wizard");
			Locations testLocation = new Locations("park","a nice park which is ...");
			Item item1 = new Item( new String[] {"shovel", "spade" }, "a shovel", "This is a might fine ..." );
			testLocation.Inventory.Put (item1);
			test.Location = testLocation;
			Assert.AreEqual (test.Location,testLocation);
			Assert.AreEqual (test.Locate("shovel"),item1);
		}
	}
}

