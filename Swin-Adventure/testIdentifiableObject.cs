using NUnit.Framework;
using System;
using System.Collections.Generic;

namespace SwinAdventure
{
	[TestFixture ()]
	public class testIdentifiableObject
	{
		[Test ()]
		public void TestCreation ()
		{
			IdentifiableObject id =new IdentifiableObject( new string[] { "id1", "id2" } );
			Assert.AreEqual (id.Firstid,"id1");
		}

		[Test ()]
		public void TestAreYou ()
		{
			IdentifiableObject id =new IdentifiableObject( new string[] { "id1", "id2" } );
			Assert.IsTrue(id.AreYou("id1"));
		}

		[Test ()]
		public void TestYouAreNot ()
		{
			IdentifiableObject id =new IdentifiableObject( new string[] { "id1", "id2" } );
			Assert.IsFalse(id.AreYou("id3"));
		}

		[Test ()]
		public void TestCaseSensitive ()
		{
			IdentifiableObject id =new IdentifiableObject( new string[] { "id1", "id2" } );
			Assert.IsTrue(id.AreYou("ID1"));
		}

		[Test ()]
		public void TestFirstID ()
		{
			IdentifiableObject id =new IdentifiableObject( new string[] { "id1", "id2" } );
			Assert.AreEqual(id.Firstid, "id1");
		}

	/*	[Test ()]
		public void TestAddID ()
		{
			IdentifiableObject id =new IdentifiableObject( new string[] { "id1", "id2" } );
			Assert.IsTrue(id.AreYou("id1"));
			Assert.IsTrue(id.AreYou("id2"));
			Assert.IsFalse(id.AreYou("id3"));

			id.AddIdentifier ("id3");
			Assert.IsTrue(id.AreYou("id1"));
			Assert.IsTrue(id.AreYou("id2"));
			Assert.IsTrue(id.AreYou("id3"));
		}*/

	}
}

