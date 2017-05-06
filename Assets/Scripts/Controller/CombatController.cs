using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CombatController : MonoBehaviour {

	[SerializeField] Stats stats;

	// Use this for initialization
	void Start () {
		
	}

	// Update is called once per frame
	void Update () {
		
	}

	public void attack(GameObject attacker) {
		if (checkAttack () && TurnController.isPlayerTurn()) { //Make isAttackerTurn();
			isEnemy (attacker);
		} 
	}

	public void isEnemy(GameObject attacker) {
		Ray ray = new Ray (attacker.transform.position, attacker.transform.forward);
		RaycastHit hit;
		if (Physics.Raycast (ray, out hit, 2.0f)) {
			GameObject hitObject = hit.transform.gameObject;
			DeathController target = hitObject.GetComponent<DeathController> ();
			if (target != null) {
				target.reactToHit ();
			}
		}
	}

	private bool checkAttack() {
		
		int dice = Dice.d20 (1) [0]; //DEBUG ONLY, DELETE AFTER
		//dice += stats.getMods()[1];
		Debug.Log (dice);//**
		Debug.Log(stats.getArmorClass());//**

		return dice > stats.getArmorClass ();
	}
}
