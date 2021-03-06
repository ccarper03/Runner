﻿using UnityEngine;
using System.Collections;

public class Spawn : MonoBehaviour 
{
	public GameObject obstaclePrefab;
	public GameObject powerupPrefab;
	public float spawnCycle = 0.5f;
	private float timeElapsed = 0;
	private bool spawnPowerup = true;

	void Update () 
	{
		spawnCycle *= 0.9996f;
		timeElapsed += Time.deltaTime;
		if (timeElapsed > spawnCycle) 
		{
			GameObject temp;
			if (spawnPowerup) {
				temp = Instantiate (powerupPrefab) as GameObject;
				Vector3 pos = temp.transform.position;
				temp.transform.position = new Vector3 (Random.Range (-3, 4), pos.y, pos.z);
			} 
			else 
			{
				temp = Instantiate (obstaclePrefab) as GameObject;
				Vector3 pos = temp.transform.position;
				temp.transform.position = new Vector3 (Random.Range (-3, 4), pos.y, pos.z);
			}	

			timeElapsed -= spawnCycle;
			spawnPowerup = !spawnPowerup;
		}
	}
}
