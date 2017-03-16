using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Movement : MonoBehaviour {

	public float moveSpeed = 6.0f;
	public float rotSpeed = 15.0f;

	private Vector3 _targetPos;
	private float _curSpeed;
	private Vector3 _movement;
	private CharacterController _charController;

	// Use this for initialization
	void Start () {
		_charController = GetComponent<CharacterController>();
	}
	
	// Update is called once per frame
	void Update () {
		getClick ();
		StartCoroutine(move ());
	}

	private IEnumerator move() {
		while (true) {
			this.transform.position = Vector3.Lerp (transform.position, _targetPos, 5.0f * Time.deltaTime);
			if (transform.position == _targetPos) {
				yield break;
			}
			yield return null;
		}
	}



	private void getClick() {
		if (Input.GetMouseButtonDown(0)) {
			Ray ray = Camera.main.ScreenPointToRay(Input.mousePosition);
			RaycastHit hit;
			if (Physics.Raycast (ray, out hit)) {
				if(!hit.collider.gameObject.Equals(this.gameObject)) {
					_targetPos = hit.transform.position;
					_curSpeed = moveSpeed;
					Debug.Log (_targetPos + " " + _curSpeed);
				}
			}
		}
	}
}
