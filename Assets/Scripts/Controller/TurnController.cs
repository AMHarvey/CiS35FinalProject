using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class TurnController : MonoBehaviour {

	private const int actionsAllowed = 2;
	private static int turnCount;
	private static int actionsTaken;
	private static bool playerTurn;
	private static bool hasAttacked, hasMoved;// Test, might remove.

	// Use this for initialization
	void Start () {
		turnCount = actionsTaken = 0;
		hasAttacked = hasMoved = false;
		startPlayerTurn();
	}

	void Update() {
		if (actionsTaken == actionsAllowed) {
			if (isPlayerTurn ()) {
				startEnemyTurn ();
				resetTurn ();
			} else {
				startPlayerTurn ();
				resetTurn ();
			}
		}
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

	public static void takeAction() {
		actionsTaken++;
		Debug.Log (actionsTaken);
	}

	/*
	 * Going to try and handle turns here, if it works. Delete if not.
	 * This code exists in PlayerAction, remove while testing.
	 */
	public static void resetTurn() {
		hasAttacked = hasMoved = false;
		actionsTaken = 0;
	}

}
