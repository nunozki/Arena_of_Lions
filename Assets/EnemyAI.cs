using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using TMPro;

public class EnemyAI : MonoBehaviour
{
	public Transform player;
	public float moveSpeed = 5.0f;
	public float stoppingDistance = 2.0f;

	private void Update()
	{
		if (player != null)
		{
			float distance = Vector2.Distance(transform.position, player.position);
			if (distance > stoppingDistance)
			{
				transform.position = Vector2.MoveTowards(transform.position, player.position, moveSpeed * Time.deltaTime);
			}
		}
	}

	private void OnCollisionEnter2D(Collision2D collision)
	{
		if (collision.gameObject.CompareTag("Bullet"))
		{

			KillCounter killCounter = FindObjectOfType<KillCounter>();
			if (killCounter != null)
			{
				killCounter.IncrementKills();
			}

			Destroy(collision.gameObject);

			// Destroy the projectile clone
			Destroy(gameObject);
		}
	}
}
