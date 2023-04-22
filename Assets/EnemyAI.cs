using System.Collections;
using System.Collections.Generic;
using UnityEngine;

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
}
