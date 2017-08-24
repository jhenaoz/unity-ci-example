using UnityEngine;
using UnityEditor;
using UnityEngine.TestTools;
using NUnit.Framework;
using System.Collections;

public class PlayerTest {

	[Test]
	public void PlayerTestSimplePasses() {
		Player player = new Player (12);

		bool isWinner = player.isWinner ();

		Assert.AreEqual (true, isWinner);

	}

	[Test]
	public void PlayerTestSimpleFail() {
		Player player = new Player (10);

		bool isWinner = player.isWinner ();

		Assert.AreEqual (false, isWinner);

	}

	[Test]
	public void PlayerTestCountIncreasePass() {
		Player player = new Player (11);
		player.increaseCountBy (1);

		bool isWinner = player.isWinner ();

		Assert.AreEqual (true, isWinner);

	}
}
