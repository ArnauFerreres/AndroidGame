using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class SnakeAccelerometer : MonoBehaviour
{
	Rigidbody2D rb;

	// Range option so moveSpeedModifier can be modified in Inspector
	// this variable helps to simulate objects acceleration
	[Range(0.2f, 2f)]
	public float moveSpeedModifier = 0.5f;

	// Direction variables that read acceleration input to be added
	// as velocity to Rigidbody2d component
	float dirX, dirY;

	// Variable to allow or disallow movement when ball is alive or dead
	static bool moveAllowed;



	void Start()
	{

		// Movement is allowed at the start
		moveAllowed = true;

		// Getting Rigidbody2D component of the ball game object
		rb = GetComponent<Rigidbody2D>();

	}

	// Update is called once per frame
	void Update()
	{

		// Getting devices accelerometer data in X and Y direction
		// multiplied by move speed modifier
		dirX = Input.acceleration.x * moveSpeedModifier;
		dirY = Input.acceleration.y * moveSpeedModifier;

	}

	void FixedUpdate()
	{
		// Setting a velocity to Rigidbody2D component according to accelerometer data
		if (moveAllowed)
			rb.velocity = new Vector2(rb.velocity.x + dirX, rb.velocity.y + dirY);
	}

}

