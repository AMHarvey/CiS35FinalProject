using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerActions : MonoBehaviour {

	[SerializeField] Movement move;
	[SerializeField] CombatController cController;

	private bool hasAttacked;//Move to 
	private bool hasMoved;// TurnController?

	// Use this for initialization
	void Start () {
		hasAttacked = false;
		hasMoved = false;
	}
	
	// Update is called once per frame
	void Update () {
		moveTurn ();
		attackTurn ();
		move.selectedRotate ();
	}

	private void moveTurn() {
		if (TurnController.isPlayerTurn() && !hasMoved) {
			if (move.move ()) hasMoved = true;
		}
	}

	private void attackTurn() {
		if (TurnController.isPlayerTurn() && !hasAttacked) {
			if (Input.GetMouseButtonDown (1) && TurnController.isPlayerTurn ()) {
				cController.attack (this.gameObject);
				hasAttacked = true;
				TurnController.startEnemyTurn ();
			}
		}
	}
}
