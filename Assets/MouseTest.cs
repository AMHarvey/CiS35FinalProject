using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class MouseTest : MonoBehaviour {
	[SerializeField] GameObject player;

	// Use this for initialization
	void Start () {
		
	}
	
	// Update is called once per frame
	void Update () {
		//Vector3 v = Input.mousePosition;
		//v.z = 8.2f;

		if (Input.GetMouseButtonDown(0)) {
			Ray ray = Camera.main.ScreenPointToRay(Input.mousePosition);
			RaycastHit hit;
			//Debug.Log(Input.GetAxis("Mouse X"));
			if (Physics.Raycast (ray, out hit)) {
				Debug.Log (hit.point);
				player.transform.position (hit.point);
			}
			//Debug.Log(Camera.main.ScreenToWorldPoint(v));
		}
	}
}
