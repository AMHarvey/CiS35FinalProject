using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerActions : MonoBehaviour {

	[SerializeField] Movement move;
	[SerializeField] CombatController cController;
	[SerializeField] Stats playerStats;

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
		if (TurnController.isPlayerTurn()) {
			//if (move.move ()) hasMoved = true;
			if (move.move ()) TurnController.takeAction();
		}
	}

	private void attackTurn() {
		if (TurnController.isPlayerTurn() && !hasAttacked) {
			if (Input.GetMouseButtonDown (1) && TurnController.isPlayerTurn ()) {
				isEnemy (this.gameObject);

			}
		}
	}

	public void isEnemy(GameObject attacker) {
		Ray ray = new Ray (attacker.transform.position, attacker.transform.forward);
		RaycastHit hit;
		if (Physics.Raycast (ray, out hit, 2.0f)) {
			hasAttacked = true;
			TurnController.takeAction ();
			if (checkAttack (hit)) {
				GameObject hitObject = hit.transform.gameObject;
				DeathController target = hitObject.GetComponent<DeathController> ();
				if (target != null) {
					target.reactToHit ();
				}
			}
		}
	}

	private bool checkAttack(RaycastHit hit) {
		Stats stats = hit.collider.gameObject.GetComponent<Stats> ();
		int dice = Dice.d20 (1) [0]; //DEBUG ONLY, DELETE AFTER
		int mod = playerStats.getMods()[1];
		return dice + mod > stats.getArmorClass ();
	}
}
