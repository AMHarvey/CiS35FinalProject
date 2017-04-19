using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class EnemyDetector : MonoBehaviour {
	[SerializeField] GameObject enemy;
	[SerializeField] CombatController cController;
	public float maxDistance = 2.0f;

	// Use this for initialization
	void Start () {
		
	}
	
	// Update is called once per frame
	void Update () {
		if (Input.GetMouseButtonDown (1)) {
			cController.attack (this.gameObject);
		}
	}


}
