using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class TurnController : MonoBehaviour {

	private static int turnCount;
	private static bool playerTurn;


	// Use this for initialization
	void Start () {
		turnCount = 0;
		startPlayerTurn();
	}
	
	// Update is called once per frame
	void Update () {
		
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

}
