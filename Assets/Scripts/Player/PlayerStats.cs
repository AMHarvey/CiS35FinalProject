using System.Collections;
using System.Collections.Generic;
using System.Linq;
using UnityEngine;

public class PlayerStats : MonoBehaviour {

	private int[] _stats = new int[6];

	private int _lowest = int.MaxValue;

	// Use this for initialization
	void Start () {
		//int[] firstDice = d6(4);
		//int totalDice = removeMin(firstDice);
		stats();
	}

	private void stats() {
		int[] dice = null;
		int total = 0;
		//Debug.Log(removeMin (d6(4)));
		for (int i = 0; i < _stats.Length; i++) {
			dice = d6 (4);
			total = removeMin (dice);
			_stats [i] = total;
			Debug.Log (_stats [i]);
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
}
