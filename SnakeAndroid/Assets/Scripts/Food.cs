using System.Collections;
using System.Collections.Generic;
using TMPro;
using UnityEngine;
using UnityEngine.UI;

public class Food : MonoBehaviour
{
    public BoxCollider2D gridArea;

    public TextMeshProUGUI scoreText;
    private int ScoreNum;

    public GameObject sound;
    private void Start()
    {
        ScoreNum = 0;
        scoreText.text = "Score " + ScoreNum;
        RandomizePosition();
    }
    private void RandomizePosition()
    {
        Bounds bounds = this.gridArea.bounds;

        float x = Random.Range(bounds.min.x, bounds.max.x);
        float y = Random.Range(bounds.min.y, bounds.max.y);

        this.transform.position = new Vector3(Mathf.Round(x), Mathf.Round(y), 0.0f);
    }

    private void OnTriggerEnter2D(Collider2D other)
    {
        if(other.tag == "Player")
        {
            ScoreNum += 10;
            scoreText.text = "Score " + ScoreNum;
            Instantiate(sound, transform.position, transform.rotation);
            RandomizePosition(); 
        }
    }

}

