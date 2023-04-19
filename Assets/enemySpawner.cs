using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class enemySpawner : MonoBehaviour
{
	public float spawnTime = 3f;
	public GameObject enemyPrefab;
	public Vector2 arenaSize;

	void Start()
	{
		InvokeRepeating("SpawnEnemy", spawnTime, spawnTime);
	}

	void SpawnEnemy()
	{
		Instantiate(enemyPrefab, Random.insideUnitCircle * arenaSize, Quaternion.identity);
	}
}
