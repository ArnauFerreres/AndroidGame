using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class BallControlScript : MonoBehaviour {

	// Reference to Rigidbody2D component of the ball game object
	Rigidbody2D rb;

	// Range option so moveSpeedModifier can be modified in Inspector
	// this variable helps to simulate objects acceleration
	[Range(0.2f, 2f)]
	public float moveSpeedModifier = 0.5f;

	// Direction variables that read acceleration input to be added
	// as velocity to Rigidbody2d component
	float dirX, dirY;

	// Reference to Balls Animator component to control animaations transition
	Animator anim;

	// Setting bool variable that ball is alive at the beginning
	static bool isDead;

	// Variable to allow or disallow movement when ball is alive or dead
	static bool moveAllowed;

	// Variable to be set to true if you win
	static bool youWin;

	// Reference to WinText game object to control its appearance
	// Text game object can be added in inspector because of [SerializeField] line
	[SerializeField]
	//GameObject winText;

	// Use this for initialization
	void Start () {

		// Turn WinText off at the start
		//winText.gameObject.SetActive(false);

		// You don't win at the start
		youWin = false;

		// Movement is allowed at the start
		moveAllowed = true;

		// Ball is alive at the start
		isDead = false;

		// Getting Rigidbody2D component of the ball game object
		rb = GetComponent<Rigidbody2D> ();

		// Getting Animator component of the ball game object
		anim = GetComponent<Animator> ();

		// Set BallAlive animation
		anim.SetBool ("BallDead", isDead);
	}
	
	// Update is called once per frame
	void Update () {

		// Getting devices accelerometer data in X and Y direction
		// multiplied by move speed modifier
		dirX = Input.acceleration.x * moveSpeedModifier;
		dirY = Input.acceleration.y * moveSpeedModifier;

		// if isDead is true
		if (isDead) {

			// then ball movement is stopped
			rb.velocity = new Vector2 (0, 0);

			// Set Animators BallDead variable to true to switch to 
			anim.SetBool ("BallDead", isDead);

			// Restart scene to play again in 1 seconds
			Invoke ("RestartScene", 1f);
		}

		// If you win
		if (youWin) {

			// then turn YouWin sign on
			//winText.gameObject.SetActive (true);

			// ball movement is not allowed anymore
			moveAllowed = false;

			// switch to Ball Dead Animation so ball falls into exit hole
			anim.SetBool("BallDead", true);

			// Restart scene to play again in 2 seconds
			Invoke ("RestartScene", 2f);
		}

	}

	void FixedUpdate()
	{
		// Setting a velocity to Rigidbody2D component according to accelerometer data
		if (moveAllowed)
		rb.velocity = new Vector2 (rb.velocity.x + dirX, rb.velocity.y + dirY);
	}

	// Method is invoked by DeathHoleScript when ball touches deathHole collider
	public static void setIsDeadTrue()
	{
		// Setting isDead to true
		isDead = true;
	}

	// Method is inviked by exit hole game object when ball thouches its collider
	public static void setYouWinToTrue()
	{
		youWin = true;
	}

	// Method to restart current scene
	void RestartScene()
	{
		SceneManager.LoadScene ("Scene01");
	}
	public void Flip()
    {
		if (dirY > 0)
			transform.localScale = Vector3.one;
		if(dirY < 0)
			transform.localScale= new Vector3(-1,1,1);
    }
}
