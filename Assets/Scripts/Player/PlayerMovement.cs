using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerMovement : MonoBehaviour {
	public float speed = 2.0f;
	private float _yPos;

	// Use this for initialization
	void Start () {
		_yPos = this.transform.position.y;
	}
	
	// Update is called once per frame
	void Update () {
		if (Input.GetMouseButtonDown(0)) {
			Ray ray = Camera.main.ScreenPointToRay(Input.mousePosition);
			RaycastHit hit;
			if (Physics.Raycast (ray, out hit)) {
				if(!hit.collider.gameObject.Equals(this.gameObject)) {
					Vector3 pos = hit.collider.gameObject.transform.position;
					pos.y = _yPos;
					iTween.Stop ();
					iTween.MoveTo (this.gameObject, pos, speed);
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
