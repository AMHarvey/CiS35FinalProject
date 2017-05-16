using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class DeathController : MonoBehaviour {

	// Use this for initialization
	void Start () {
		
	}
	
	// Update is called once per frame
	void Update () {
		
	}

	public void reactToHit() {
		StartCoroutine (Die ());
	}

	private IEnumerator Die() {
		yield return new WaitForSeconds(1.5f);
		Debug.Log ("WORKING " + this.gameObject.ToString());
		Destroy (this.gameObject);
	}
}
