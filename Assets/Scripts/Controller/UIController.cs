using System.Collections;
using UnityEngine.UI;
using UnityEngine;

public class UIController : MonoBehaviour {
	[SerializeField] private Text scoreLabel;

	// Use this for initialization
	void Start () {
		int[] stats = PlayerStats.getStats ();
		scoreLabel.text = stats[0].ToString();
	}
	
	// Update is called once per frame
	void Update () {
		//scoreLabel.text = Time.realtimeSinceStartup.ToString ();
	}

	public void OnOpenSettings() {
		Debug.Log ("Working");
	}
}
