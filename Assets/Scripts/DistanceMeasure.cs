using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class DistanceMeasure : MonoBehaviour {

	[SerializeField] GameObject one;
	[SerializeField] GameObject two;

	// Use this for initialization
	void Start () {
		Debug.Log(distanceFrom(one, two));
	}
	
	private static float distanceFrom(GameObject one, GameObject two) {
		return Vector3.Distance (one.transform.position, two.transform.position);
	}
}
