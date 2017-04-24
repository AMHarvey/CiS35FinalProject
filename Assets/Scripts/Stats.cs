using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Stats : MonoBehaviour {

	public enum Stat { Str, Dex, Con, Int, Wis, Cha }

	private int[] stats;
	private int[] mods;

	public const int statSize = 6;
	public int armorClass;

	void Awake () {
		stats = new int[statSize];
		mods = new int[statSize];
		assignStats ();
		addMods ();


		//statTester ();
	}

	public int[] getStats() {
		return stats;
	}

	public int[] getMods() {
		return mods;
	}

	public void assignStats() {
		for (int i = 0; i < 6; i++) {
			stats [i] = Dice.removeMin(Dice.d6(4));
		}
	}

	public void shuffle() {
		assignStats ();
		addMods ();
	}
		
	public void addMods() {
		for (int i = 0; i < statSize; i++) {
			mods [i] = (stats [i] - 10) / 2; 
		}
	}

	private void statTester() { //Delete
		for (int i = 0; i < statSize; i++) {
			stats [i] = Dice.removeMin(Dice.d6(4));
		}
		addMods ();
		for (int i = 0; i < statSize; i++) {
			//Debug.Log ("Stat: " + stats [i] + " * Mod: " + mods [i]);
		}
	}
}
