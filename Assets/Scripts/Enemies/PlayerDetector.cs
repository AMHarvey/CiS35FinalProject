using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerDetector : MonoBehaviour {
	
	[SerializeField] GameObject player;
	[SerializeField] EnemyActions actions;

	// Use this for initialization
	void Start () {
		
	}
	
	// Update is called once per frame
	void Update () {
		if (!TurnController.isPlayerTurn() && player != null) { // Fix Rotation
			if (distanceFrom(player) < 2.0f) 
				rotateTowards ();
			actions.attackTurn ();
		}
	}

	private void rotateTowards() {
		Transform hitT = player.transform;
		Vector3 adjustedPos = new Vector3 (hitT.position.x, transform.position.y, hitT.position.z);
		Quaternion targetRot = Quaternion.LookRotation (adjustedPos - transform.position);
		transform.rotation = targetRot;
	}

	private float distanceFrom(GameObject player) {
		return Vector3.Distance (gameObject.transform.position, player.transform.position);
	}
}
