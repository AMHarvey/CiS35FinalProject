using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class EnemyActions : MonoBehaviour {

	//[SerializeField] Movement move;
	[SerializeField] CombatController cController;
	[SerializeField] Stats enemyStats;

	private bool hasAttacked;//Move to 
	private bool hasMoved;// TurnController?

	// Use this for initialization
	void Start () {
		hasAttacked = false;
		hasMoved = false;

	}

	// Update is called once per frame
	void Update () {
		//moveTurn ();
		//attackTurn ();
		//move.selectedRotate ();
	}

	private void moveTurn() {
		if (!TurnController.isPlayerTurn()) {
			//if (move.move ()) TurnController.takeAction();
		}
	}

	public void attackTurn() {
		if (!TurnController.isPlayerTurn() && !hasAttacked) {
			//hasAttacked = true;
			isEnemy (this.gameObject);
		}
	}

	public void isEnemy(GameObject attacker) {
		GameObject player = GameObject.Find ("player");
		if (player == null)
			return;
		if (distanceFrom (player) < 2.0f) {
			hasAttacked = true;
			TurnController.takeAction ();
			if (TurnController.getActions () < 2) { //REMOVE?
				TurnController.takeAction ();
				hasAttacked = false;
			}
			if (checkAttack (player)) {
				DeathController target = player.GetComponent<DeathController> ();
				player.GetComponent<Stats> ().setHealth (1);
			}
		} else {
			TurnController.takeAction ();//REMOVE
			TurnController.takeAction ();
		}
	}

	private bool checkAttack(GameObject player) {
		Stats stats = player.GetComponent<Stats> ();
		int dice = Dice.d20 (1) [0];
		int mod = enemyStats.getMods()[1];
		return dice + mod > stats.getArmorClass ();
	}

	private float distanceFrom(GameObject player) {
		return Vector3.Distance (gameObject.transform.position, player.transform.position);
	}
}
