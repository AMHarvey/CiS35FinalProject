using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CombatController : MonoBehaviour {

	[SerializeField] EnemyStatistics stats;

	// Use this for initialization
	void Start () {
		
	}

	// Update is called once per frame
	void Update () {
		
	}

	public void attack(GameObject attacker) {
		Ray ray = Camera.main.ScreenPointToRay(Input.mousePosition);
		RaycastHit hit;
		if (Physics.Raycast (ray, out hit)) {
			if(checkAttack()) {
				isEnemy (attacker);
			}
		}
	}

	public void isEnemy(GameObject attacker) {
		Ray ray = new Ray (attacker.transform.position, attacker.transform.forward);
		RaycastHit hit;
		if (Physics.Raycast (ray, out hit, 1.5f)) {
			//Debug.DrawLine (attacker.transform.position, hit.point, Color.cyan, 60);
			GameObject hitObject = hit.transform.gameObject;
			EnemyActions target = hitObject.GetComponent<EnemyActions> ();
			if (target != null) {
				target.reactToHit ();
			}
		}
	}

	private bool checkAttack() {
		
		int dice = Dice.d20 (1) [0]; //DEBUG ONLY, DELETE AFTER
		Debug.Log (dice);//**

		return dice > stats.getAC ();
	}
}
