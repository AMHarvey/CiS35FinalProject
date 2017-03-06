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
		if (Input.GetMouseButtonDown(0)) {
			Ray ray = Camera.main.ScreenPointToRay(Input.mousePosition);
			RaycastHit hit;
			if (Physics.Raycast (ray, out hit)) {
				if (!hit.collider.gameObject.Equals(player)) {
					Vector3 pos = new Vector3 (hit.point.x, hit.point.y, hit.point.z);
					pos.y += 0.95f;
					player.transform.position = pos;
				}
			}
		}
	}
}
