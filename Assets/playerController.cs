using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using TMPro;
using UnityEngine.SceneManagement;

public class playerController : MonoBehaviour
{

	public float speed = 10f; // the player's movement speed

	public GameObject GameManagerGO;
	private Rigidbody2D rb2d;

	public int maxHealth = 100;
	public int currentHealth;

	public TextMeshProUGUI healthText;

	public float delay = 3;
	float timer;

	// Store the touch IDs for movement and rotation
	private int movementTouchID = -1;
	private int rotationTouchID = -1;

	// Start is called before the first frame update
	void Start()
	{
		currentHealth = maxHealth;
		UpdateHealthText();

		rb2d = GetComponent<Rigidbody2D>();
	}

	// Update is called once per frame
	void Update()
	{
		// Get touch input for movement and rotation
		float xInput = 0f;
		float yInput = 0f;
		Vector3 lookDir = Vector3.zero;
		foreach (Touch touch in Input.touches)
		{
			// Check if touch is for movement
			if (movementTouchID == -1 && touch.phase == TouchPhase.Began)
			{
				Vector2 touchPos = Camera.main.ScreenToWorldPoint(touch.position);
				if (touchPos.x < transform.position.x)
				{
					xInput = -1f;
				}
				else if (touchPos.x > transform.position.x)
				{
					xInput = 1f;
				}
				if (touchPos.y < transform.position.y)
				{
					yInput = -1f;
				}
				else if (touchPos.y > transform.position.y)
				{
					yInput = 1f;
				}
				movementTouchID = touch.fingerId;
			}
			// Check if touch is for rotation
			else if (rotationTouchID == -1 && touch.fingerId != movementTouchID && touch.phase == TouchPhase.Began)
			{
				Vector3 touchPos = Camera.main.ScreenToWorldPoint(touch.position);
				touchPos.z = 10.0f;
				lookDir = touchPos - transform.position;
				float angle = Mathf.Atan2(lookDir.y, lookDir.x) * Mathf.Rad2Deg - 90.0f;
				transform.rotation = Quaternion.Euler(0.0f, 0.0f, angle);
				rotationTouchID = touch.fingerId;
			}
			// Update movement touch
			else if (touch.fingerId == movementTouchID)
			{
				Vector2 touchPos = Camera.main.ScreenToWorldPoint(touch.position);
				if (touchPos.x < transform.position.x)
				{
					xInput = -1f;
				}
				else if (touchPos.x > transform.position.x)
				{
					xInput = 1f;
				}
				if (touchPos.y < transform.position.y)
				{
					yInput = -1f;
				}
				else if (touchPos.y > transform.position.y)
				{
					yInput = 1f;
				}
				if (touch.phase == TouchPhase.Ended || touch.phase == TouchPhase.Canceled)
				{
					movementTouchID = -1;
				}
			}
			// Update rotation touch
			else if (touch.fingerId == rotationTouchID)
			{
				Vector3 touchPos = Camera.main.ScreenToWorldPoint(touch.position);
				touchPos.z = 10.0f;
				lookDir = touchPos - transform.position;
				float angle = Mathf.Atan2(lookDir.y, lookDir.x) * Mathf.Rad2Deg - 90.0f;
				transform.rotation = Quaternion.Euler(0.0f, 0.0f, angle);
				if (touch.phase == TouchPhase.Ended || touch.phase == TouchPhase.Canceled)
				{
					rotationTouchID = -1;
				}
			}
		}
		rb2d.velocity = new Vector2(xInput * speed, yInput * speed);
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






