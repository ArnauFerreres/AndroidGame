using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using TMPro;

public class TouchControl : MonoBehaviour
{
    public GameObject panel;
    public int tCount;

    void Start()
    {
        tCount = 0;
        panel.SetActive(false);
    }
    void Update()
        {
            
            tCount = Input.touchCount;
        if (tCount == 2)
        {
            Debug.Log("Se para");
            panel.SetActive(true);
            Time.timeScale = 0;
        }

        
    }
    public void Resume()
    {
        panel.SetActive(false);
        Time.timeScale = 1;
    }
}

