using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class touchLocation {

    public int touchId;
    public GameObject circle;
    public touchLocation(int newTouchId, GameObject newCircle)
    {
        touchId = newTouchId;
        circle = newCircle;
    }

}
