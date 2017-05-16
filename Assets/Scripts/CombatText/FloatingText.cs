using System.Collections;
using System.Collections.Generic;
using UnityEngine.UI;
using UnityEngine;

public class FloatingText : MonoBehaviour {
	
	private Camera mainCamera;

	private Vector3 _objectPosition;

	// Use this for initialization
	void Start () {
		mainCamera = Camera.FindObjectOfType<Camera> ();
	}
	
	// Update is called once per frame
	void Update () {
		Vector3 pos = gameObject.transform.position;
		Vector3 temp = new Vector3 (pos.x, pos.y + 0.05f, pos.z);
		gameObject.transform.position = temp;
		gameObject.transform.rotation = mainCamera.transform.rotation;
		if (temp.y > 5.0f)
			Object.Destroy (this.gameObject);
	}
}
