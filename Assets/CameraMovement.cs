using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CameraMovement : MonoBehaviour {

	//[RequireComponent (Camera)]
	[SerializeField] float cameraSpeed = 0.3f;

	// Use this for initialization
	void Start () {
		
	}
	
	// Update is called once per frame
	void Update () {
		float y = Input.mousePosition.y;
		float x = Input.mousePosition.x;
		if (y >= Screen.height - 15.0f) {
			//this.transform.Translate (new Vector3(0.0f, cameraSpeed, 0.0f));
		}

		if (y <= 15.0f) {
			//this.transform.Translate (new Vector3(0.0f, -cameraSpeed, 0.0f));
		}

		if (x >= Screen.width - 15.0f) {
			//this.transform.Translate (new Vector3(cameraSpeed, 0.0f, 0.0f));
		}

		if (x <= 15.0f) {
			//this.transform.Translate (new Vector3(-cameraSpeed, 0.0f, 0.0f));
		}
	}
}
