using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class playerController : MonoBehaviour
{

	public float speed = 20f; // the player's movement speed

	private Rigidbody2D rb;

	// Start is called before the first frame update
	void Start()
    {
		rb = GetComponent<Rigidbody2D>();
	}

	// Update is called once per frame
	void Update()
	{
		float xInput = Input.GetAxis("Horizontal");
		float yInput = Input.GetAxis("Vertical");
		rb.velocity = new Vector2(xInput * speed, yInput * speed);


		if (Input.GetMouseButtonDown(0))
		{
			Collider2D[] cols = Physics2D.OverlapCircleAll(transform.position, 1f);
			foreach (Collider2D col in cols)
			{
				if (col != null && col.tag == "Enemy")
				{
					Destroy(col.gameObject);
				}
			}
		}
	}
	
	void OnCollisionEnter2D(Collision2D col)
	{
		if (col.gameObject.tag == "Ground")
			rb.velocity = Vector2.zero;
	}

}
