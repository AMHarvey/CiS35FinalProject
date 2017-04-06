using System.Collections;
using System.Collections.Generic;
using System.Linq;
using UnityEngine;

public class Dice : MonoBehaviour {

	public static int[] d4(int diceNum) {
		int[] diceRolls = new int[diceNum];
		for (int i = 0; i < diceNum; i++) {
			diceRolls [i] = Random.Range (1, 4 + 1);
		}
		return diceRolls;
	}

	public static int[] d6(int diceNum) {
		int[] diceRolls = new int[diceNum];
		for (int i = 0; i < diceNum; i++) {
			diceRolls [i] = Random.Range (1, 6 + 1);
		}
		return diceRolls;
	}

	public static int[] d8(int diceNum) {
		int[] diceRolls = new int[diceNum];
		for (int i = 0; i < diceNum; i++) {
			diceRolls [i] = Random.Range (1, 8 + 1);
		}
		return diceRolls;
	}

	public static int[] d10(int diceNum) {
		int[] diceRolls = new int[diceNum];
		for (int i = 0; i < diceNum; i++) {
			diceRolls [i] = Random.Range (1, 10 + 1);
		}
		return diceRolls;
	}

	public static int[] d12(int diceNum) {
		int[] diceRolls = new int[diceNum];
		for (int i = 0; i < diceNum; i++) {
			diceRolls [i] = Random.Range (1, 12 + 1);
		}
		return diceRolls;
	}

	public static int[] d20(int diceNum) {
		int[] diceRolls = new int[diceNum];
		for (int i = 0; i < diceNum; i++) {
			diceRolls [i] = Random.Range (1, 20 + 1);
		}
		return diceRolls;
	}

	public static int[] d100(int diceNum) {
		int[] diceRolls = new int[diceNum];
		for (int i = 0; i < diceNum; i++) {
			diceRolls [i] = Random.Range (1, 100 + 1);
		}
		return diceRolls;
	}

	public static int[] dCustom(int diceMax, int diceNum) {
		int[] diceRolls = new int[diceNum];
		for (int i = 0; i < diceNum; i++) {
			diceRolls [i] = Random.Range (1, diceMax + 1);
		}
		return diceRolls;
	}

	public static int removeMin (int[] diceArray) {
		return diceArray.Sum () - diceArray.Min ();
	}
}
