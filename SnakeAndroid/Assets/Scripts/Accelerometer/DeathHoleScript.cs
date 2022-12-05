using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class DeathHoleScript : MonoBehaviour {

	// If ball touches Death holes collider
	// then isDead variable of BallControlScript is set to true
	void OnTriggerEnter2D (Collider2D col)
	{
		BallControlScript.setIsDeadTrue ();
	}
}
