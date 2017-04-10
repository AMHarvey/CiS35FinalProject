using System.Collections;
using UnityEngine.UI;
using UnityEngine;

public class UIController : MonoBehaviour {
	[SerializeField] private Text[] statDisplay;
	[SerializeField] StatUI statui;

	private bool isOpen = false;

	// Use this for initialization
	void Start () {
		statui.Close ();
		displayStats ();
	}
	
	// Update is called once per frame
	void Update () {
		//scoreLabel.text = Time.realtimeSinceStartup.ToString ();
	}

	public void OnOpenSettings() {
		if (!isOpen) {
			statui.Open ();
			isOpen = true;
		} else {
			statui.Close ();
			isOpen = false;
		}
	}

	public void Shuffle() {
		PlayerStats.shuffle ();
		displayStats ();
	}

	public void displayStats() {
		int[] stats = PlayerStats.getStats ();
		for (int i = 0; i < statDisplay.Length; i++) {
			statDisplay [i].text = stats[i].ToString ();
		}
	}
}
