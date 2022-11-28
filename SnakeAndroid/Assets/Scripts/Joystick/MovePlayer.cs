using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class MovePlayer : MonoBehaviour
{
    private Vector2 _direction = Vector2.right;

    public MovementJoystick movementJoystick;
    public float playerSpeed;
    private Rigidbody2D rb;
    public float speedMultiplier = 1f;
    private float nextUpdate;



    //Start is called before the first frame update
    void Start()
    {
        rb = GetComponent<Rigidbody2D>();
    }

    // Update is called once per frame
    void FixedUpdate()
    {
        if (movementJoystick.joystickVec.y != 0)
        {
            rb.velocity = new Vector2(movementJoystick.joystickVec.x * playerSpeed, movementJoystick.joystickVec.y * playerSpeed);
        }
        else
        {
            rb.velocity = Vector2.zero;
        }


        /*this.transform.position = new Vector3(
        Mathf.Round(this.transform.position.x) + _direction.x,
        Mathf.Round(this.transform.position.y) + _direction.y,
            0.0f);
        if (Time.time < nextUpdate)
        {
            return;
        }
        float x = Mathf.Round(transform.position.x) + _direction.x;
        float y = Mathf.Round(transform.position.y) + _direction.y;

        transform.position = new Vector2(x, y);
        nextUpdate = Time.time + (1f / (playerSpeed * speedMultiplier));*/
    }
}
