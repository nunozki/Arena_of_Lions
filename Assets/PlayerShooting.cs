using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerShooting : MonoBehaviour
{
	public GameObject projectilePrefab;
	public float projectileSpeed = 10.0f;
	public float fireRate = 10.0f;

	private float fireTimer;

	private void Update()
	{
		fireTimer += Time.deltaTime;

		if (fireTimer >= fireRate)
		{
			fireTimer = 0.0f;

			GameObject projectile = Instantiate(projectilePrefab, transform.position, Quaternion.identity);
			Rigidbody2D projectileRb = projectile.GetComponent<Rigidbody2D>();
			projectileRb.velocity = transform.right * projectileSpeed;
			Destroy(projectile, 2.0f);
		}
	}
}
