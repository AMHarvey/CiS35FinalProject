using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerStats : MonoBehaviour {

	private enum statEnum { Str, Dex, Con, Int, Wis, Cha };

	private static int[] _stats = new int[6];

	void Awake () {
		stats();
	}

	public static int[] getStats() {
		return _stats;
	}

	public static void setStats(int index, int newVal) {
		_stats [index] = newVal;
	}

	public static void shuffle() {
		stats ();
	}

	private static void stats() {
		//Testing
		//Debug.Log("Dice Working: " + tester ());

		for (int i = 0; i < _stats.Length; i++) {
			_stats [i] = Dice.removeMin(Dice.d6(4));
			//Debug.Log (_stats [i]);
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
