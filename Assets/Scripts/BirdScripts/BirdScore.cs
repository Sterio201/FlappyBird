using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class BirdScore : MonoBehaviour
{
    [SerializeField] Text scoreText;
    int score;

    private void Start()
    {
        score = 0;
    }

    private void OnTriggerEnter2D(Collider2D collision)
    {
        if (collision.gameObject.tag == "scorezone")
        {
            score++;
            scoreText.text = "—чет: " + score;
        }
    }
}