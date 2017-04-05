using System.Collections;
using System.Collections.Generic;
using System.Linq;
using UnityEngine;

public class PlayerStats : MonoBehaviour {

	enum statEnum { Str, Dex, Con, Int, Wis, Cha };

	private int[] _stats = new int[6];

	private int _lowest = int.MaxValue;

	// Use this for initialization
	void Start () {
		stats();
	}

	private void stats() {
		//Testing
		//Debug.Log("Dice Working: " + tester ());

		for (int i = 0; i < _stats.Length; i++) {
			_stats [i] = removeMin(d6(4));
			Debug.Log ((statEnum)i + ": " + _stats [i]);
		}
	}


	//TODO Put into diceroller class
	private int[] d6(int diceNum) {
		int[] d6 = new int[diceNum];
		for (int i = 0; i < diceNum; i++) {
			d6 [i] = Random.Range (1, 6 + 1);
		}
		return d6;
	}

	private int removeMin (int[] diceArray) {
		int temp = diceArray.Min ();
		return diceArray.Sum () - temp;
	}

	private bool tester() {
		int backOut = 0;
		int total = 0;
		while (backOut != 10000) {
			total = removeMin (d6 (4));
			backOut++;
			if (total == 3) {
				return true;
			}
		}
		return false;
	}
}
