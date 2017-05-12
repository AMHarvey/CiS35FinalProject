using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class HexActions : MonoBehaviour {

	public LayerMask enemy;

	// Use this for initialization
	void Start () {
		
	}

	public bool checkAbove(GameObject target) {
		
		Ray ray = new Ray (target.transform.position, target.transform.up);

		RaycastHit hit;
		if (Physics.Raycast (ray, out hit, enemy)) {
			//if (hit.collider.ToString ().Equals ("Enemy")) {
			Debug.Log (hit.collider.transform.ToString());
				return true;
			//}
		}
		Debug.Log ("FALSE");
		return false;

	}
}
