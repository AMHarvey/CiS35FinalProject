using System.Collections;
using System.Collections.Generic;
using UnityEngine.UI;
using UnityEngine;

public class FloatingText : MonoBehaviour {

	[SerializeField] GameObject origin;
	[SerializeField] Text floatingText;

	private Vector3 _v;
	private Vector2 _originPosition;

	// Use this for initialization
	void Awake () {
		_v = floatingText.transform.position;
		_originPosition = origin.transform.position;
		floatingText.text = "Test";

	}
	
	// Update is called once per frame
	void Update () {
		_v = new Vector3 (_v.x, _v.y + 1, _v.z);
		floatingText.transform.position = _v;
	}
}
