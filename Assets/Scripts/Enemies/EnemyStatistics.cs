using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class EnemyStatistics : MonoBehaviour {
	private int armorClass;

	// Use this for initialization
	void Start () {
		armorClass = 10;
		
	}

	public int getAC() {
		return armorClass;
	}

}
