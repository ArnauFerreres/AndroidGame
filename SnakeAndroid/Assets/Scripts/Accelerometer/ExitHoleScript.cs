using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ExitHoleScript : MonoBehaviour {

	// If ball touches Exit holes collider
	// then youWin variable of BallControlScript is set to true
	void OnTriggerEnter2D (Collider2D col)
	{
		BallControlScript.setYouWinToTrue ();
	}
}
