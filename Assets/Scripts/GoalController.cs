using System;
using System.Collections;
using System.Collections.Generic;
using TMPro;
using UnityEngine;

public class GoalController : MonoBehaviour
{

    public bool isLeft;
    public BallController ball;
    public GameController game;

    private void OnTriggerEnter2D(Collider2D collision)
    {
        BallController ballController = collision.gameObject.GetComponent<BallController>();

        if (ballController != null)
        {
            if (isLeft)
            {
                Debug.Log("Opponent scores!");
                game.IncreaseOpponentScore();
            }
            else
            {
                Debug.Log("Player scores!");
                game.IncreasePlayerScore();
            }
        }
        
        ball.StartGame();
    }
}
