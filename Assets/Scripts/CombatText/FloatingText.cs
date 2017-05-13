using System.Collections;
using System.Collections.Generic;
using UnityEngine.UI;
using UnityEngine;

public class FloatingText : MonoBehaviour {

	[SerializeField] GameObject origin;
	//[SerializeField] GameObject floatingText;
	[SerializeField] TextMesh text;
	[SerializeField] Camera mainCamera;

	private Vector3 _objectPosition;
	//private float _drift;

	// Use this for initialization
	void Start () {
		_objectPosition = origin.transform.position;
		gameObject.transform.position = _objectPosition;
		//_drift = 0;
		text.text = "";

	}
	
	// Update is called once per frame
	void Update () {
		//if (_drift < 1.0f)
		//	_drift += 0.01;
		//else
		//	Debug.Log ("WORKING");
		Vector3 pos = gameObject.transform.position;
		Vector3 temp = new Vector3 (pos.x, pos.y + 0.05f, pos.z);
		gameObject.transform.position = temp;
		gameObject.transform.rotation = mainCamera.transform.rotation;
		text.text = origin.GetComponent<Stats> ().getHealth ().ToString();
		if (temp.y > _objectPosition.y * 5.0f)
			Object.Destroy (this.gameObject);
	}

	private float textDrift() {
		int min = -1; 
		int max = 1;
		return Random.Range(min, max) * 0.91f;
	}
}
