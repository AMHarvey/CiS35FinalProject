using System.Collections;
using UnityEngine.UI;
using UnityEngine;

public class UIController : MonoBehaviour {
	[SerializeField] private Text[] statDisplay;
	[SerializeField] private Text[] modDisplay;
	[SerializeField] StatUI statui;
	[SerializeField] PlayerStats stats;

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
		stats.shuffle ();
		displayStats ();
		displayMods ();
	}

	public void displayStats() {
		int[] statA = stats.getStats ();
		for (int i = 0; i < 6; i++) {
			statDisplay [i].text = statA [i].ToString ();
		}
	}

	public void displayMods() {
		int[] modA = stats.getMods ();
		for (int i = 0; i < 6; i++) {
			modDisplay [i].text = modA [i].ToString ();
		}
	}
}
