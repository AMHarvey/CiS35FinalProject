using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class EnemyStatistics : MonoBehaviour {

	[SerializeField] Stats stats;

	private int armorClass;

	// Use this for initialization
	void Awake () {
		armorClass = stats.armorClass;
		
	}

	public int getAC() {
		return armorClass;
	}

}
