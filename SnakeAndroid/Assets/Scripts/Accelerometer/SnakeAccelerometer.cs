using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class SnakeAccelerometer : MonoBehaviour
{
	Rigidbody2D rb;


	[Range(0.2f, 2f)]
	public float moveSpeedModifier = 0.5f;


	float dirX, dirY;

	static bool moveAllowed;



	void Start()
	{

		moveAllowed = true;

		rb = GetComponent<Rigidbody2D>();

	}

	void Update()
	{


		dirX = Input.acceleration.x * moveSpeedModifier;
		dirY = Input.acceleration.y * moveSpeedModifier;

	}

	void FixedUpdate()
	{
		if (moveAllowed)
			rb.velocity = new Vector2(rb.velocity.x + dirX, rb.velocity.y + dirY);
	}

}

