using System;
using System.Collections;
using System.Collections.Generic;
using TMPro;
using UnityEngine;

public class GoalController : MonoBehaviour
{

    public bool isLeft;
    public int score = 0;
    public TextMeshProUGUI scoreText;

    private void OnTriggerEnter2D(Collider2D collision)
    {
        BallController ballController = collision.gameObject.GetComponent<BallController>();

        if (ballController != null)
        {
            if (isLeft)
            {
                Debug.Log("Opponent scores!");
            }
            else
            {
                Debug.Log("Player scores!");
            }
        }
        
        score++;
        scoreText.text = score.ToString();
        
        BallController.instance.StartGame();
    }
}
