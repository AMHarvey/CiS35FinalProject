using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class EnemyMovement : MonoBehaviour {

	private bool hasMoved;

	// Use this for initialization
	void Start () {
		hasMoved = false;
	}
	
	// Update is called once per frame
	void Update () {
		GameObject targetObject = GameObject.Find ("Hexagon_Mid");
		float temp = distanceFrom (targetObject);
		//Debug.Log ("DistanceFrom " + temp);
		if (temp < 2.5f && temp > 1.0f && !hasMoved) {
			Debug.Log (targetObject.ToString ());
			gameObject.transform.position = targetObject.transform.position;
			hasMoved = true;
		}
	}

	private float distanceFrom(GameObject target) {
		return Vector3.Distance (gameObject.transform.position, target.transform.position);
	}

}
