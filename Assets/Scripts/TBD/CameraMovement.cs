﻿using System.Collections;
using System.Collections.Generic;
using UnityEngine;

[RequireComponent(typeof(Camera))]
public class CameraMovement : MonoBehaviour {

	[SerializeField] GameObject player;
	public float horizontalSpeed = 0.5f;
	public float verticalSpeed = 0.5f;
	private Vector3 _startingPos;
	//private bool _isMoving;


	// Use this for initialization
	void Start () {
	//	_isMoving = false;
		_startingPos = this.transform.position;
		_startingPos.y -= 0.98f;
	}
	
	// Update is called once per frame
	// Try out third person camera code from the example game.
	void Update () {
		if (Input.GetKey ("r")) {
			float x = horizontalSpeed * Input.GetAxis ("Mouse X");
			float y = verticalSpeed * Input.GetAxis ("Mouse Y");
			float z = 0.5f * Input.GetAxis ("Mouse Z");
			this.transform.Translate (x, y, z);
			this.transform.LookAt (player.transform.position);
			//_isMoving = true;
		}// else if(!Input.GetKey ("r") && _isMoving) {
		//	this.transform.localPosition = _startingPos;
			//_isMoving = false;
		//}
	}
}

//TODO: Seperate camera from player.
