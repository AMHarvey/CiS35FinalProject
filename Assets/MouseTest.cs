using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class MouseTest : MonoBehaviour {
	[SerializeField] GameObject player;
	public float speed = 2.0f;

	// Use this for initialization
	void Start () {
		
	}
	
	// Update is called once per frame
	void Update () {
		if (Input.GetMouseButtonDown(0)) {
			Ray ray = Camera.main.ScreenPointToRay(Input.mousePosition);
			RaycastHit hit;
			if (Physics.Raycast (ray, out hit)) {
				if(!hit.collider.gameObject.Equals(player)) {
					Vector3 pos = hit.collider.gameObject.transform.position;
					pos.y += 0.95f;
					iTween.Stop ();
					iTween.MoveTo (player, pos, speed);
					//player.transform.position = pos;
				}
			}
		}
	}
}



/**
 * Original Movement Code, TBH if going to us.
 * 
 * if (!hit.collider.gameObject.Equals(player) && !Input.GetKey("e")) {
					Vector3 pos = hit.point;
					pos.y += 0.95f;
					////player.transform.position = pos;
					iTween.MoveTo (player, pos, speed);
				}
*/
