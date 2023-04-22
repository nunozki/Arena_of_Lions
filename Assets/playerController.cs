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
		float xInput = Input.GetAxis("Horizontal");
		float yInput = Input.GetAxis("Vertical");
		rb2d.velocity = new Vector2(xInput * speed, yInput * speed);

		Vector3 mousePos = Input.mousePosition;
		mousePos.z = 10.0f;
		Vector3 lookDir = Camera.main.ScreenToWorldPoint(mousePos) - transform.position;
		float angle = Mathf.Atan2(lookDir.y, lookDir.x) * Mathf.Rad2Deg - 90.0f;
		transform.rotation = Quaternion.Euler(0.0f, 0.0f, angle);
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
