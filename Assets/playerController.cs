using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using TMPro;
using UnityEngine.SceneManagement;

public class playerController : MonoBehaviour
{

	public float moveSpeed = 5f; // the player's movement speed
	public float rotationSpeed = 5f;

	public GameObject GameManagerGO;
	private Rigidbody2D rb2d;

	public int maxHealth = 100;
	public int currentHealth;

	public TextMeshProUGUI healthText;

	public float delay = 3;
	float timer;

	private Camera mainCamera;

	// Store the touch IDs for movement and rotation
	private int touchID = -1;

	private float lastFireTime = 0f;
	public float projectileSpeed = 10f;
	public float fireRate = 0.5f;
	public GameObject projectilePrefab;

	public Transform bulletSpawn;

	// Start is called before the first frame update
	void Start()
	{
		mainCamera = Camera.main;

		currentHealth = maxHealth;
		UpdateHealthText();

		rb2d = GetComponent<Rigidbody2D>();
	}

	// Update is called once per frame
	void Update()
	{
		Move();
		Rotate();
		Shoot();
	}

	private void Move()
	{
		if (Input.touchCount > 0)
		{
			foreach (Touch touch in Input.touches)
			{
				if (touch.phase == TouchPhase.Began)
				{
					Vector2 touchPos = mainCamera.ScreenToWorldPoint(touch.position);
					//if (GetComponent<Collider2D>().OverlapPoint(touchPos))
					{
						touchID = touch.fingerId;
					}
				}
				else if (touch.phase == TouchPhase.Moved && touch.fingerId == touchID)
				{
					Vector2 moveDir = (touch.position - touch.deltaPosition) - touch.position;
					rb2d.velocity =  (moveDir.normalized * moveSpeed * Time.deltaTime) * -1;
					Debug.Log("Velocity:" + rb2d.velocity.magnitude);
				}
				else if (touch.phase == TouchPhase.Ended && touch.fingerId == touchID)
				{
					touchID = -1;
					rb2d.velocity = Vector2.zero;
				}
			}
		}
		else
		{
			rb2d.velocity = Vector2.zero;
		}
	}

	private void Rotate()
	{
		if (Input.touchCount > 0)
		{
			foreach (Touch touch in Input.touches)
			{
				if (touch.phase == TouchPhase.Began)
				{
					Vector2 touchPos = mainCamera.ScreenToWorldPoint(touch.position);
					//if (GetComponent<Collider2D>().OverlapPoint(touchPos))
					{
						touchID = touch.fingerId;
					}
				}
				else if (touch.phase == TouchPhase.Moved && touch.fingerId == touchID)
				{
					Vector3 touchPos = mainCamera.ScreenToWorldPoint(touch.position);
					touchPos.z = 0f;

					Vector3 lookDir = touchPos - transform.position;
					float angle = Mathf.Atan2(lookDir.y, lookDir.x) * Mathf.Rad2Deg - 90f;
					Quaternion rotation = Quaternion.AngleAxis(angle, Vector3.forward);
					transform.rotation = Quaternion.Slerp(transform.rotation, rotation, rotationSpeed * Time.deltaTime);
					Debug.Log("Rotation:" + transform.rotation);
				}
				else if (touch.phase == TouchPhase.Ended && touch.fingerId == touchID)
				{
					touchID = -1;
				}
			}
		}
	}

	private void Shoot()
	{
		if (Input.GetMouseButton(0) && Time.time - lastFireTime >= fireRate)
		{
			lastFireTime = Time.time;

			GameObject projectile = Instantiate(projectilePrefab, bulletSpawn.position, Quaternion.identity);
			Rigidbody2D projectileRb = projectile.GetComponent<Rigidbody2D>();
			projectile.transform.rotation = Quaternion.Euler(0f, 0f, transform.rotation.eulerAngles.z);

			Vector2 shootDirection = new Vector2(Mathf.Cos(transform.rotation.eulerAngles.z * Mathf.Deg2Rad),
												 Mathf.Sin(transform.rotation.eulerAngles.z * Mathf.Deg2Rad));

			projectileRb.AddForce(shootDirection * projectileSpeed, ForceMode2D.Impulse);

			StartCoroutine(DestroyProjectile(projectile));
		}
	}

	private IEnumerator DestroyProjectile(GameObject projectile)
	{
		yield return new WaitForSeconds(2f);
		Destroy(projectile);
	}

	void OnCollisionEnter2D(Collision2D col)
	{
		if (col.gameObject.tag == "Enemy")
		{
			TakeDamage(5);
		}
	}
	public void TakeDamage(int damage)
	{
		currentHealth -= damage;
		if (currentHealth <= 0)
		{
			GameManagerGO.GetComponent<GameManager>().RestartScene();
		}
		UpdateHealthText();
	}

	private void UpdateHealthText()
	{
		healthText.text = "Health: " + currentHealth.ToString();
	}
}






