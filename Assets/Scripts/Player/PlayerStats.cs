using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerStats : MonoBehaviour {

	private enum statEnum { Str, Dex, Con, Int, Wis, Cha };

	public int[] _stats = new int[6];

	void Start () {
		stats();
	}

	private void stats() {
		//Testing
		Debug.Log("Dice Working: " + tester ());

		for (int i = 0; i < _stats.Length; i++) {
			_stats [i] = Dice.removeMin(Dice.d6(4));
			Debug.Log ((statEnum)i + ": " + _stats [i]);
		}
	}

	//Testing Purposes. Remove when done.
	private bool tester() {
		int backOut, total;
		backOut = total = 0;
		while (backOut != 10000) {
			total = Dice.removeMin (Dice.d6 (4));
			backOut++;
			if (total == 3) { return true; } 
		} 
		return false; 
	}
}
