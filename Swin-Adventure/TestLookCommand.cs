using NUnit.Framework;
using System;

namespace SwinAdventure
{
	[TestFixture ()]
	public class TestLookCommand
	{
		[Test ()]
		public void TestLookAtMe ()
		{
			LookCommand test = new LookCommand ();
			Player testPlayer = new Player ("Player 1", "a funny wizard");
			Assert.AreEqual (test.Execute(testPlayer, new String[]{"look", "at", "inventory"}),"You are carrying nothing");
		}

		[Test()]
		public void TestLookAtGem(){
			LookCommand test = new LookCommand ();
			Player testPlayer = new Player ("Player 1", "a funny wizard");
			testPlayer.Inventory.Put (new Item( new String[] {"gun", "rifle" }, "a gun", "This is a a long spirally grooved ..." ));
			Assert.AreEqual (test.Execute(testPlayer, new String[]{"look", "at", "gun", "in", "inventory"}),"This is a a long spirally grooved ...");
		}

		[Test()]
		public void TestLookAtUnk(){
			LookCommand test = new LookCommand ();
			Player testPlayer = new Player ("Player 1", "a funny wizard");
			Assert.AreEqual (test.Execute(testPlayer, new String[]{"look", "at", "gun"}),"I cannot find the gun");
		}

		[Test()]
		public void TestLookAtGemInMe(){
			LookCommand test = new LookCommand ();
			Player testPlayer = new Player ("Player 1", "a funny wizard");
			Assert.AreEqual (test.Execute(testPlayer, new String[]{"look", "at", "gun", "in", "inventory"}),"I cannot find the gun");
		}

		[Test()]
		public void TestLookAtGemInBag(){
			LookCommand test = new LookCommand ();
			Player testPlayer = new Player ("Player 1", "a funny wizard");
			Bag testBag = new Bag (new string[]{ "Bag", "Backpack" }, "a bag", "This is a bag for....");
			testBag.Inventory.Put(new Item( new String[] {"shovel", "spade" }, "a shovel", "This is a might fine ..."));
			testPlayer.Inventory.Put (testBag);
			Assert.AreEqual (test.Execute(testPlayer, new String[]{"look", "at", "shovel", "in", "bag"}),"This is a might fine ...");
		}

		[Test()]
		public void TestLookAtGemInNoBag(){
			LookCommand test = new LookCommand ();
			Player testPlayer = new Player ("Player 1", "a funny wizard");
			Assert.AreEqual (test.Execute(testPlayer, new String[]{"look", "at", "shovel", "in", "bag"}),"I cannot find the bag");
		}

		[Test()]
		public void TestLookAtNoGemInBag(){
			LookCommand test = new LookCommand ();
			Player testPlayer = new Player ("Player 1", "a funny wizard");
			Bag testBag = new Bag (new string[]{ "Bag", "Backpack" }, "a bag", "This is a bag for....");
			testPlayer.Inventory.Put (testBag);
			Assert.AreEqual (test.Execute(testPlayer, new String[]{"look", "at", "shovel", "in", "bag"}),"I cannot find the shovel in the bag");
		}

		[Test()]
		public void TestInvalidLook(){
			LookCommand test = new LookCommand ();
			Player testPlayer = new Player ("Player 1", "a funny wizard");
			Assert.AreEqual (test.Execute(testPlayer, new String[]{"look", "around"}),"I don’t know how to look like that");
			Assert.AreEqual (test.Execute(testPlayer, new String[]{"Hello", "man", "there"}),"Error in look input");
			Assert.AreEqual (test.Execute(testPlayer, new String[]{"look", "at", "sth", "about", "me"}),"What do you want to look in?");
			Assert.AreEqual (test.Execute(testPlayer, new String[]{"look", "over", "that"}),"What do you want to look at?");
		}
	}
}

