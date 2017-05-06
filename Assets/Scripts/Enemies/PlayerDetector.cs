using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerDetector : MonoBehaviour {
	
	[SerializeField] GameObject player;
	[SerializeField] CombatController cController;

	// Use this for initialization
	void Start () {
		
	}
	
	// Update is called once per frame
	void Update () {
		if (!TurnController.isPlayerTurn()) {
			//TurnController.startPlayerTurn ();
			//Debug.Log (TurnController.isPlayerTurn());
			//rotateTowards ();
			//cController.attack (player);
		}
	}

	private void rotateTowards() {
		Transform hitT = player.transform;
		Vector3 adjustedPos = new Vector3 (hitT.position.x, transform.position.y, hitT.position.z);
		Quaternion targetRot = Quaternion.LookRotation (adjustedPos - transform.position);
		transform.rotation = targetRot;
	}
}
