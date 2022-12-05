using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Accelerometer : MonoBehaviour
{
    private Rigidbody2D rb;
    private float dx;
    public float moveSpeed = 20f;
    private void Start()
    {
        rb = GetComponent<Rigidbody2D>();
    }





    // Update is called once per frame
    private void Update()
    {
        dx = Input.acceleration.x * moveSpeed;
        //dx = Input.acceleration.y * moveSpeed;

        transform.position = new Vector2(Mathf.Clamp(transform.position.x, -7.5f, 7.5f), transform.position.y);



    }

    private void FixedUpdate()
    {
        rb.velocity = new Vector2(dx, 0f);

    }


}
