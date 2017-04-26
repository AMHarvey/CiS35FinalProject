using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class TurnController : MonoBehaviour {

	private static int turnCount;
	private static bool playerTurn;
	private static bool hasAttacked, hasMoved;// Test, might remove.

	// Use this for initialization
	void Start () {
		turnCount = 0;
		hasAttacked = hasMoved = false;
		startPlayerTurn();
	}

	public static void startPlayerTurn() {
		turnCount++;
		playerTurn = true;
	}

	public static void startEnemyTurn() {
		turnCount++;
		playerTurn = false;
	}

	public static bool isPlayerTurn() {
		return playerTurn;
	}

	/*
	 * Going to try and handle turns here, if it works. Delete if not.
	 * This code exists in PlayerAction, remove while testing.
	 */
	public static void resetTurn() {
		hasAttacked = hasMoved = false;
	}

}
