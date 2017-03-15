using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class EnemyDetector : MonoBehaviour {
	[SerializeField] GameObject enemy;
	public float maxDistance = 2.0f;

	// Use this for initialization
	void Start () {
		
	}
	
	// Update is called once per frame
	void Update () {
		if (Input.GetKeyDown("w")) {
			Ray ray = new Ray(this.transform.position, this.transform.forward);
			RaycastHit hit;
			if (Physics.Raycast (ray, out hit, maxDistance)) {
				GameObject hitObject = hit.transform.gameObject;
				EnemyActions target = hitObject.GetComponent<EnemyActions> ();
				if (target != null) {
					target.reactToHit ();
				}
			} else {
				Debug.Log ("NOPE");
			}
				
			//Ray ray = player.;
			//RaycastHit hit;
		}
	}
}
