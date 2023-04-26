using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class enemySpawner : MonoBehaviour
{
	public float spawnTime = 3f;
	public float spawnTime2 = 3f;
	public GameObject enemyPrefab;
	public GameObject enemyPrefab2;
	public Vector2 arenaSize;

	void Start()
	{
		InvokeRepeating("SpawnEnemy", spawnTime, spawnTime);
		InvokeRepeating("SpawnEnemy2", spawnTime2, spawnTime2);
	}

	void SpawnEnemy()
	{
		Instantiate(enemyPrefab, Random.insideUnitCircle * arenaSize, Quaternion.identity);
	}
	void SpawnEnemy2()
	{
		Instantiate(enemyPrefab2, Random.insideUnitCircle * arenaSize, Quaternion.identity);
	}
}
