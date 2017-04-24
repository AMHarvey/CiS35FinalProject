using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerStats : MonoBehaviour {

	private enum statEnum { Str, Dex, Con, Int, Wis, Cha };

	[SerializeField] Stats playerStats;

	//private static int[] _stats = new int[6];
	private int[] _stats;
	private int[] _mods;

	void Awake () {
		_stats = playerStats.getStats ();
		_mods = playerStats.getMods ();
	}

	public int[] getStats() {
		return _stats;
	}

	public int[] getMods() {
		return _mods;
	}

	public void shuffle() {
		playerStats.shuffle ();
	}

	public void setStats(int index, int newVal) {
		_stats [index] = newVal;
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
