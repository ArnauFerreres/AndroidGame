using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class SnakeMode : MonoBehaviour
{
    public GameObject joystick;
    public GameObject panel;

    // Start is called before the first frame update
    void Start()
    {
        joystick.SetActive(true);
        this.GetComponent<MovePlayer>().enabled = true;
        this.GetComponent<BallControlScript>().enabled = false;
    }

    // Update is called once per frame
    void Update()
    {
        
    }
    public void Accelerometer()
    {
        panel.SetActive(false);
        joystick.SetActive(false);
        Time.timeScale = 1;
        this.GetComponent<BallControlScript>().enabled = true;
        this.GetComponent<MovePlayer>().enabled = false;

    }
    public void Joystick()
    {
        panel.SetActive(false);
        joystick.SetActive(true);
        Time.timeScale = 1;
        this.GetComponent<MovePlayer>().enabled = true;
        this.GetComponent<BallControlScript>().enabled = false;
    }



}
