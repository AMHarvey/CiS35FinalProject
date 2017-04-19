using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class EnemyPlacement : MonoBehaviour {
	[SerializeField] HexGrid grid;
	private GameObject _startPlat;

	// Use this for initialization
	void Start () {
		string gridPos = string.Format("Hexagon{0}|{1}", Random.Range (0, grid.gridWidth),
			Random.Range (0, grid.gridHeight));
		_startPlat = GameObject.Find (gridPos);
		Vector3 tempPos = _startPlat.transform.position;
		tempPos.y = 1.0f;
		transform.position = tempPos;
	}
	
	// Update is called once per frame
	void Update () {
		
	}
}
