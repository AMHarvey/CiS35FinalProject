﻿using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CameraControls : MonoBehaviour {
	[SerializeField] private Transform target;

	public float rotSpeed = 1.5f;

	private float _rotY;
	private Vector3 _offset;

	// Use this for initialization
	void Start() {
		_rotY = transform.eulerAngles.y;
		_offset = target.position - transform.position;
	}

	// Update is called once per frame
	void LateUpdate() {
		if (target != null) {
			_rotY -= Input.GetAxis ("Horizontal") * rotSpeed;
			Quaternion rotation = Quaternion.Euler (0.0f, _rotY, 0.0f);
			transform.position = target.position - (rotation * _offset);
			transform.LookAt (target);
		}
	}
}