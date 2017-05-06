using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Movement : MonoBehaviour {

	public float rotSpeed = 15.0f;

	private Vector3 _targetPos;
	private Vector3 _targetRot;

	// Use this for initialization
	void Start () {
		
	}
	
	// Update is called once per frame
	void Update () {
		//move ();
		//selectedRotate ();
	}
		
	public bool move() {
		if (Input.GetMouseButtonDown(0)) {
			Ray ray = Camera.main.ScreenPointToRay(Input.mousePosition);
			RaycastHit hit;
			if (Physics.Raycast (ray, out hit)) {
				float temp = distanceFrom (hit);
				if(!hit.collider.gameObject.Equals(this.gameObject) && temp < 3.0f && temp > 1.2f) { //Delete Collider, try tags
					rotateTowards(hit);
					_targetPos = hit.transform.position;
					_targetPos.y = 1.1f;
					transform.position = _targetPos;
					return true;
				}
			}
		}
		return false;
	}

	public void selectedRotate() {
		if (Input.GetKeyDown("z")) {
			Ray ray = Camera.main.ScreenPointToRay(Input.mousePosition);
			RaycastHit hit;
			if (Physics.Raycast (ray, out hit)) {
				if (distanceFrom (hit) < 3.0f)
					rotateTowards (hit);
			}
		}
	}

	private void rotateTowards(RaycastHit hit) {
		Transform hitT = hit.transform;
		Vector3 adjustedPos = new Vector3 (hitT.position.x, transform.position.y, hitT.position.z);
		Quaternion targetRot = Quaternion.LookRotation (adjustedPos - transform.position);
		transform.rotation = targetRot;
	}

	private float distanceFrom(RaycastHit hit) {
		return Vector3.Distance (gameObject.transform.position, hit.transform.position);
	}
}
