using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class EnemyActions : MonoBehaviour {

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
		yield return null;
		Destroy (this.gameObject);
	}
}
